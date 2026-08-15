using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SQLite;
using MaterialSkin;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Inversiones_XTB
{
    public partial class Form1 : MaterialForm
    {
        // Declaramos el gráfico a nivel de la clase
        private Chart chtDiversificacion;

        public Form1()
        {
            InitializeComponent();

            // 1. Inicializamos Base de datos y Tema Premium
            DatabaseHelper.InicializarBaseDeDatos();


            // 2. Dibujamos el cuadro del gráfico en la pantalla
            DibujarGraficoDesdeCodigo();

            // 3. Cargamos los datos iniciales
            CargarTransacciones();
            CargarResumenPortafolio();

            // 4. Llenamos los elementos visuales
            ActualizarGrafico();
            CalcularMetricasDashboard();
            ConfigurarTablaWatchlist();
            ConfigurarTablaWatchlist();
            CargarWatchlist();
            tmrMercado.Tick += tmrMercado_Tick;
            tmrMercado.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AplicarTemaPremium()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.Teal400,
                TextShade.WHITE
            );
        }

        // ==========================================
        // BOTÓN GUARDAR (UNIFICADO Y CORREGIDO)
        // ==========================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Nota: Asegúrate de que tu ComboBox en el diseño se llame cmbTipo
            if (string.IsNullOrWhiteSpace(txtTicker.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ticker = txtTicker.Text.ToUpper();
                string tipo = cmbTipo.SelectedItem.ToString();

                // Manejo seguro de decimales (reemplaza puntos por comas según tu configuración regional)
                double cantidad = Convert.ToDouble(txtCantidad.Text.Replace(".", ","));
                double precio = Convert.ToDouble(txtPrecio.Text.Replace(".", ","));
                // --- NUEVA VALIDACIÓN: PREVENIR NÚMEROS NEGATIVOS O CERO ---
                if (cantidad <= 0 || precio <= 0)
                {
                    MessageBox.Show("Operación inválida. La cantidad de acciones y el precio deben ser mayores a cero.", "Aviso de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Esto detiene la ejecución para que no se guarde en la base de datos
                }
                // -------------------------------------------------------------
                string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Transacciones (Ticker, Tipo, Cantidad, Precio, Fecha) 
                                           VALUES (@Ticker, @Tipo, @Cantidad, @Precio, @Fecha)";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Ticker", ticker);
                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Transacción guardada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                txtTicker.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
                cmbTipo.SelectedIndex = -1;
                txtTicker.Focus();

                // Actualizar toda la interfaz
                CargarTransacciones();
                CargarResumenPortafolio();
                CalcularMetricasDashboard();
                ActualizarGrafico();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrate de ingresar números válidos en Cantidad y Precio.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // BOTÓN ELIMINAR (UNIFICADO - POR SELECCIÓN DE FILA)
        // ==========================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransacciones.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona toda la fila de la tabla que deseas eliminar (haz clic en el margen izquierdo de la fila).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas eliminar esta transacción de tu portafolio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvTransacciones.SelectedRows[0].Cells["Id"].Value);
                    string query = "DELETE FROM Transacciones WHERE Id = @Id";

                    using (var conexion = DatabaseHelper.GetConnection())
                    {
                        conexion.Open();
                        using (var comando = new SQLiteCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id", id);
                            int filasAfectadas = comando.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Transacción eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Actualizar toda la interfaz
                                CargarTransacciones();
                                CargarResumenPortafolio();
                                CalcularMetricasDashboard();
                                ActualizarGrafico();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // MÉTODOS DE CARGA Y CÁLCULO
        // ==========================================
        private void CargarTransacciones()
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Transacciones ORDER BY Id DESC";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(command))
                        {
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adapter.Fill(tabla);
                            dgvTransacciones.DataSource = tabla;

                            if (dgvTransacciones.Columns["Precio"] != null)
                                dgvTransacciones.Columns["Precio"].DefaultCellStyle.Format = "C2";

                            dgvTransacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            foreach (DataGridViewRow fila in dgvTransacciones.Rows)
                            {
                                if (fila.Cells["Tipo"].Value != DBNull.Value && fila.Cells["Tipo"].Value != null)
                                {
                                    string tipo = fila.Cells["Tipo"].Value.ToString();
                                    if (tipo == "Compra")
                                        fila.DefaultCellStyle.BackColor = Color.LightGreen;
                                    else if (tipo == "Venta")
                                        fila.DefaultCellStyle.BackColor = Color.LightCoral;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las transacciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarResumenPortafolio()
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string selectQuery = @"
                SELECT 
                    Ticker,
                    SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad ELSE -Cantidad END) AS Cantidad_Total,
                    ROUND(SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad * Precio ELSE 0 END) / 
                    NULLIF(SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad ELSE 0 END), 0), 2) AS Precio_Medio
                FROM Transacciones
                GROUP BY Ticker
                HAVING Cantidad_Total > 0";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(command))
                        {
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adapter.Fill(tabla);
                            dgvResumen.DataSource = tabla;

                            if (dgvResumen.Columns["Precio_Medio"] != null)
                                dgvResumen.Columns["Precio_Medio"].DefaultCellStyle.Format = "C2";

                            dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el resumen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void CalcularMetricasDashboard()
        {
            try
            {
                double capitalInvertido = 0;
                double valorActual = 0;

                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // 1. Calcular el Capital Invertido (El dinero que gastaste originalmente)
                    string queryCapital = @"
                SELECT SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad * Precio ELSE -(Cantidad * Precio) END) 
                FROM Transacciones";

                    using (var command = new SQLiteCommand(queryCapital, connection))
                    {
                        object resultado = command.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            capitalInvertido = Convert.ToDouble(resultado);
                        }
                    }

                    // 2. Calcular el Valor Actual (Consultando a Wall Street en vivo)
                    string queryPortafolio = @"
                SELECT Ticker, SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad ELSE -Cantidad END) AS Cantidad_Total
                FROM Transacciones
                GROUP BY Ticker
                HAVING Cantidad_Total > 0";

                    using (var command = new SQLiteCommand(queryPortafolio, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ticker = reader["Ticker"].ToString();
                                double cantidad = Convert.ToDouble(reader["Cantidad_Total"]);

                                // Mandamos al ayudante a buscar el precio actual a internet
                                double precioEnVivo = await PrecioAPI.ObtenerPrecioActual(ticker);

                                // Sumamos al gran total
                                valorActual += (cantidad * precioEnVivo);
                            }
                        }
                    }
                }

                // 3. Fórmulas Financieras
                double gananciaNeta = valorActual - capitalInvertido;
                double rentabilidad = 0;

                if (capitalInvertido > 0)
                {
                    rentabilidad = (gananciaNeta / capitalInvertido);
                }

                // 4. Mostrar en las tarjetas del Dashboard
                lblCapitalInvertido.Text = capitalInvertido.ToString("C2"); // Formato Moneda
                lblValorActual.Text = valorActual.ToString("C2");
                lblGananciaNeta.Text = gananciaNeta.ToString("C2");
                lblRentabilidad.Text = rentabilidad.ToString("P2"); // Formato Porcentaje con 2 decimales

                // 5. Toque Visual: Verde si ganamos dinero, Rojo si perdemos
                if (gananciaNeta >= 0)
                {
                    lblGananciaNeta.ForeColor = Color.ForestGreen;
                    lblRentabilidad.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblGananciaNeta.ForeColor = Color.Red;
                    lblRentabilidad.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular las métricas del portafolio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // MÉTODOS DEL GRÁFICO
        // ==========================================
        private void DibujarGraficoDesdeCodigo()
        {
            chtDiversificacion = new Chart();
            chtDiversificacion.Size = new System.Drawing.Size(350, 250);
            chtDiversificacion.Location = new System.Drawing.Point(500, 50);

            ChartArea area = new ChartArea("AreaPrincipal");
            chtDiversificacion.ChartAreas.Add(area);
            this.Controls.Add(chtDiversificacion);
        }

        private void ActualizarGrafico()
        {
            try
            {
                chtDiversificacion.Series.Clear();
                chtDiversificacion.Titles.Clear();
                chtDiversificacion.Titles.Add("Diversificación de Inversión ($)");

                Series serie = new Series("Portafolio");
                serie.ChartType = SeriesChartType.Pie;
                serie.IsValueShownAsLabel = true;
                serie.Label = "#VALX: #PERCENT{P0}";

                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string selectQuery = @"
                        SELECT 
                            Ticker,
                            (SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad ELSE -Cantidad END) * 
                             (ROUND(SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad * Precio ELSE 0 END) / 
                              NULLIF(SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad ELSE 0 END), 0), 2))) AS DineroInvertido
                        FROM Transacciones
                        GROUP BY Ticker
                        HAVING SUM(CASE WHEN Tipo = 'Compra' THEN Cantidad ELSE -Cantidad END) > 0";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ticker = reader["Ticker"].ToString();
                                double valorInvertido = Convert.ToDouble(reader["DineroInvertido"]);
                                serie.Points.AddXY(ticker, valorInvertido);
                            }
                        }
                    }
                }

                chtDiversificacion.Series.Add(serie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos vacíos que Visual Studio crea al hacer doble clic sin querer
        private void txtPrecio_TextChanged(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }


        private void ConfigurarTablaWatchlist()
        {
            // Preparamos las columnas visualmente
            dgvWatchlist.Columns.Clear();
            dgvWatchlist.Columns.Add("Ticker", "Activo");
            dgvWatchlist.Columns.Add("Precio", "Precio Actual");

            dgvWatchlist.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dgvWatchlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWatchlist.RowHeadersVisible = false;
            dgvWatchlist.AllowUserToAddRows = false;
            dgvWatchlist.ReadOnly = true;
            MejorarDisenoWatchlist();
        }
        private void MejorarDisenoWatchlist()
        {
            // 1. Fondo blanco brillante y bordes limpios
            dgvWatchlist.BackgroundColor = Color.White;
            dgvWatchlist.BorderStyle = BorderStyle.None;
            dgvWatchlist.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvWatchlist.GridColor = Color.FromArgb(230, 230, 230); // Líneas divisorias en gris muy clarito
            dgvWatchlist.EnableHeadersVisualStyles = false;

            // 2. Diseño de la cabecera (Estilo minimalista)
            dgvWatchlist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvWatchlist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // Gris perlado elegante
            dgvWatchlist.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64); // Texto gris oscuro
            dgvWatchlist.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvWatchlist.ColumnHeadersHeight = 35;

            // 3. Diseño de las filas (Los datos)
            dgvWatchlist.DefaultCellStyle.BackColor = Color.White;
            dgvWatchlist.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40); // Texto principal casi negro
            dgvWatchlist.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 242, 255); // Azul pastel al seleccionar una fila
            dgvWatchlist.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);

            // 4. Toques financieros específicos para las columnas
            if (dgvWatchlist.Columns["Precio"] != null)
            {
                // Los números siempre van alineados a la derecha
                dgvWatchlist.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Usamos ForestGreen: resalta que es positivo, pero contrasta perfecto en el fondo blanco
                dgvWatchlist.Columns["Precio"].DefaultCellStyle.ForeColor = Color.ForestGreen;
                dgvWatchlist.Columns["Precio"].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }

            if (dgvWatchlist.Columns["Ticker"] != null)
            {
                // Los nombres de las empresas en un azul corporativo
                dgvWatchlist.Columns["Ticker"].DefaultCellStyle.ForeColor = Color.MidnightBlue;
                dgvWatchlist.Columns["Ticker"].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }

        private async void CargarWatchlist()
        {
            // Nuestra selección de activos en auge (Tecnología e Infraestructura)
            string[] tickersEnAuge = { "NVDA", "MSFT", "GOOG", "CAT", "VMC" };

            dgvWatchlist.Rows.Clear();

            foreach (string ticker in tickersEnAuge)
            {
                // Agregamos la fila temporalmente con un mensaje de carga
                int rowIndex = dgvWatchlist.Rows.Add(ticker, 0.0);

                // Mandamos a nuestro ayudante a buscar el precio en internet
                double precio = await PrecioAPI.ObtenerPrecioActual(ticker);

                // Actualizamos la celda en tiempo real
                if (precio > 0)
                {
                    dgvWatchlist.Rows[rowIndex].Cells["Precio"].Value = precio;
                }
            }
        }

        // El evento que ejecuta el reloj cada 15 segundos
        private void tmrMercado_Tick(object sender, EventArgs e)
        {
            // 1. PAUSAMOS EL RELOJ para que no se dispare otra vez mientras descargamos
            tmrMercado.Stop();

            try
            {
                // 2. Ejecutamos las descargas de internet
                CargarWatchlist();
                CalcularMetricasDashboard();
            }
            finally
            {
                // 3. Pase lo que pase (haya éxito o falle el internet), VOLVEMOS A ENCENDER el reloj
                tmrMercado.Start();
            }
        }
    }
}

    


