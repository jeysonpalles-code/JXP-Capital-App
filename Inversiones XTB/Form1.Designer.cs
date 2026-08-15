namespace Inversiones_XTB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            txtFecha = new MaterialSkin.Controls.MaterialTextBox2();
            txtAccion = new MaterialSkin.Controls.MaterialTextBox2();
            txtCant = new MaterialSkin.Controls.MaterialTextBox2();
            txtPre = new MaterialSkin.Controls.MaterialTextBox2();
            txtIDelim = new MaterialSkin.Controls.MaterialTextBox2();
            txtTracker = new MaterialSkin.Controls.MaterialTextBox2();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            txtId = new TextBox();
            dgvTransacciones = new DataGridView();
            dtpFecha = new DateTimePicker();
            cmbTipo = new ComboBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtTicker = new TextBox();
            tabPage2 = new TabPage();
            dgvWatchlist = new DataGridView();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblGananciaNeta = new Label();
            lblGananciaNeta1 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lblValorActual = new Label();
            lblValorActual1 = new Label();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            lblCapitalInvertido = new Label();
            label2 = new Label();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            lblRentabilidad = new Label();
            lblRentabilidad1 = new Label();
            dgvResumen = new DataGridView();
            tmrMercado = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWatchlist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1410, 745);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(txtFecha);
            tabPage1.Controls.Add(txtAccion);
            tabPage1.Controls.Add(txtCant);
            tabPage1.Controls.Add(txtPre);
            tabPage1.Controls.Add(txtIDelim);
            tabPage1.Controls.Add(txtTracker);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(btnGuardar);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(dgvTransacciones);
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(cmbTipo);
            tabPage1.Controls.Add(txtPrecio);
            tabPage1.Controls.Add(txtCantidad);
            tabPage1.Controls.Add(txtTicker);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1402, 712);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Operaciones";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1102, 627);
            label10.Name = "label10";
            label10.Size = new Size(202, 20);
            label10.TabIndex = 40;
            label10.Text = "Ingeniería de Software - UTN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1102, 666);
            label9.Name = "label9";
            label9.Size = new Size(237, 20);
            label9.TabIndex = 39;
            label9.Text = "Versión 1.0 | Dashboard Financiero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1102, 594);
            label6.Name = "label6";
            label6.Size = new Size(274, 20);
            label6.TabIndex = 36;
            label6.Text = "Developed by: Jeyson Ariel Palles Castro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.JXP_Capital;
            pictureBox1.Location = new Point(929, 594);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // txtFecha
            // 
            txtFecha.AnimateReadOnly = false;
            txtFecha.BackgroundImageLayout = ImageLayout.None;
            txtFecha.CharacterCasing = CharacterCasing.Normal;
            txtFecha.Depth = 0;
            txtFecha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFecha.HideSelection = true;
            txtFecha.LeadingIcon = null;
            txtFecha.Location = new Point(379, 78);
            txtFecha.MaxLength = 32767;
            txtFecha.MouseState = MaterialSkin.MouseState.OUT;
            txtFecha.Name = "txtFecha";
            txtFecha.PasswordChar = '\0';
            txtFecha.PrefixSuffixText = null;
            txtFecha.ReadOnly = false;
            txtFecha.RightToLeft = RightToLeft.No;
            txtFecha.SelectedText = "";
            txtFecha.SelectionLength = 0;
            txtFecha.SelectionStart = 0;
            txtFecha.ShortcutsEnabled = true;
            txtFecha.Size = new Size(204, 48);
            txtFecha.TabIndex = 34;
            txtFecha.TabStop = false;
            txtFecha.Text = "Fecha de transaccion";
            txtFecha.TextAlign = HorizontalAlignment.Left;
            txtFecha.TrailingIcon = null;
            txtFecha.UseSystemPasswordChar = false;
            // 
            // txtAccion
            // 
            txtAccion.AnimateReadOnly = false;
            txtAccion.BackgroundImageLayout = ImageLayout.None;
            txtAccion.CharacterCasing = CharacterCasing.Normal;
            txtAccion.Depth = 0;
            txtAccion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAccion.HideSelection = true;
            txtAccion.LeadingIcon = null;
            txtAccion.Location = new Point(47, 277);
            txtAccion.MaxLength = 32767;
            txtAccion.MouseState = MaterialSkin.MouseState.OUT;
            txtAccion.Name = "txtAccion";
            txtAccion.PasswordChar = '\0';
            txtAccion.PrefixSuffixText = null;
            txtAccion.ReadOnly = false;
            txtAccion.RightToLeft = RightToLeft.No;
            txtAccion.SelectedText = "";
            txtAccion.SelectionLength = 0;
            txtAccion.SelectionStart = 0;
            txtAccion.ShortcutsEnabled = true;
            txtAccion.Size = new Size(131, 48);
            txtAccion.TabIndex = 33;
            txtAccion.TabStop = false;
            txtAccion.Text = "Accion";
            txtAccion.TextAlign = HorizontalAlignment.Left;
            txtAccion.TrailingIcon = null;
            txtAccion.UseSystemPasswordChar = false;
            // 
            // txtCant
            // 
            txtCant.AnimateReadOnly = false;
            txtCant.BackgroundImageLayout = ImageLayout.None;
            txtCant.CharacterCasing = CharacterCasing.Normal;
            txtCant.Depth = 0;
            txtCant.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCant.HideSelection = true;
            txtCant.LeadingIcon = null;
            txtCant.Location = new Point(47, 138);
            txtCant.MaxLength = 32767;
            txtCant.MouseState = MaterialSkin.MouseState.OUT;
            txtCant.Name = "txtCant";
            txtCant.PasswordChar = '\0';
            txtCant.PrefixSuffixText = null;
            txtCant.ReadOnly = false;
            txtCant.RightToLeft = RightToLeft.No;
            txtCant.SelectedText = "";
            txtCant.SelectionLength = 0;
            txtCant.SelectionStart = 0;
            txtCant.ShortcutsEnabled = true;
            txtCant.Size = new Size(114, 48);
            txtCant.TabIndex = 32;
            txtCant.TabStop = false;
            txtCant.Text = "Cantidad";
            txtCant.TextAlign = HorizontalAlignment.Left;
            txtCant.TrailingIcon = null;
            txtCant.UseSystemPasswordChar = false;
            // 
            // txtPre
            // 
            txtPre.AnimateReadOnly = false;
            txtPre.BackgroundImageLayout = ImageLayout.None;
            txtPre.CharacterCasing = CharacterCasing.Normal;
            txtPre.Depth = 0;
            txtPre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPre.HideSelection = true;
            txtPre.LeadingIcon = null;
            txtPre.Location = new Point(47, 206);
            txtPre.MaxLength = 32767;
            txtPre.MouseState = MaterialSkin.MouseState.OUT;
            txtPre.Name = "txtPre";
            txtPre.PasswordChar = '\0';
            txtPre.PrefixSuffixText = null;
            txtPre.ReadOnly = false;
            txtPre.RightToLeft = RightToLeft.No;
            txtPre.SelectedText = "";
            txtPre.SelectionLength = 0;
            txtPre.SelectionStart = 0;
            txtPre.ShortcutsEnabled = true;
            txtPre.Size = new Size(121, 48);
            txtPre.TabIndex = 31;
            txtPre.TabStop = false;
            txtPre.Text = "Precio";
            txtPre.TextAlign = HorizontalAlignment.Left;
            txtPre.TrailingIcon = null;
            txtPre.UseSystemPasswordChar = false;
            // 
            // txtIDelim
            // 
            txtIDelim.AnimateReadOnly = false;
            txtIDelim.BackgroundImageLayout = ImageLayout.None;
            txtIDelim.CharacterCasing = CharacterCasing.Normal;
            txtIDelim.Depth = 0;
            txtIDelim.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIDelim.HideSelection = true;
            txtIDelim.LeadingIcon = null;
            txtIDelim.Location = new Point(636, 22);
            txtIDelim.MaxLength = 32767;
            txtIDelim.MouseState = MaterialSkin.MouseState.OUT;
            txtIDelim.Name = "txtIDelim";
            txtIDelim.PasswordChar = '\0';
            txtIDelim.PrefixSuffixText = null;
            txtIDelim.ReadOnly = false;
            txtIDelim.RightToLeft = RightToLeft.No;
            txtIDelim.SelectedText = "";
            txtIDelim.SelectionLength = 0;
            txtIDelim.SelectionStart = 0;
            txtIDelim.ShortcutsEnabled = true;
            txtIDelim.Size = new Size(184, 48);
            txtIDelim.TabIndex = 30;
            txtIDelim.TabStop = false;
            txtIDelim.Text = "Id a Eliminar";
            txtIDelim.TextAlign = HorizontalAlignment.Left;
            txtIDelim.TrailingIcon = null;
            txtIDelim.UseSystemPasswordChar = false;
            // 
            // txtTracker
            // 
            txtTracker.AnimateReadOnly = false;
            txtTracker.BackgroundImageLayout = ImageLayout.None;
            txtTracker.CharacterCasing = CharacterCasing.Normal;
            txtTracker.Depth = 0;
            txtTracker.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTracker.HideSelection = true;
            txtTracker.LeadingIcon = null;
            txtTracker.Location = new Point(47, 69);
            txtTracker.MaxLength = 32767;
            txtTracker.MouseState = MaterialSkin.MouseState.OUT;
            txtTracker.Name = "txtTracker";
            txtTracker.PasswordChar = '\0';
            txtTracker.PrefixSuffixText = null;
            txtTracker.ReadOnly = false;
            txtTracker.RightToLeft = RightToLeft.No;
            txtTracker.SelectedText = "";
            txtTracker.SelectionLength = 0;
            txtTracker.SelectionStart = 0;
            txtTracker.ShortcutsEnabled = true;
            txtTracker.Size = new Size(114, 48);
            txtTracker.TabIndex = 29;
            txtTracker.TabStop = false;
            txtTracker.Text = "Ticker";
            txtTracker.TextAlign = HorizontalAlignment.Left;
            txtTracker.TrailingIcon = null;
            txtTracker.UseSystemPasswordChar = false;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(1215, 34);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(88, 36);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(268, 360);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(849, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 27);
            txtId.TabIndex = 24;
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.BackgroundColor = Color.LightGray;
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.GridColor = SystemColors.Desktop;
            dgvTransacciones.Location = new Point(636, 90);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(667, 464);
            dgvTransacciones.TabIndex = 20;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(399, 138);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(155, 27);
            dtpFecha.TabIndex = 18;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Compra", "Venta" });
            cmbTipo.Location = new Point(205, 297);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 17;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(205, 227);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 16;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(205, 159);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 15;
            // 
            // txtTicker
            // 
            txtTicker.Location = new Point(205, 90);
            txtTicker.Name = "txtTicker";
            txtTicker.Size = new Size(125, 27);
            txtTicker.TabIndex = 14;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvWatchlist);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(materialCard1);
            tabPage2.Controls.Add(materialCard2);
            tabPage2.Controls.Add(materialCard3);
            tabPage2.Controls.Add(materialCard4);
            tabPage2.Controls.Add(dgvResumen);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1402, 712);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dashboard";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvWatchlist
            // 
            dgvWatchlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWatchlist.Location = new Point(889, 252);
            dgvWatchlist.Name = "dgvWatchlist";
            dgvWatchlist.RowHeadersWidth = 51;
            dgvWatchlist.Size = new Size(429, 196);
            dgvWatchlist.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1116, 672);
            label11.Name = "label11";
            label11.Size = new Size(237, 20);
            label11.TabIndex = 23;
            label11.Text = "Versión 1.0 | Dashboard Financiero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1116, 638);
            label8.Name = "label8";
            label8.Size = new Size(202, 20);
            label8.TabIndex = 22;
            label8.Text = "Ingeniería de Software - UTN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1116, 606);
            label7.Name = "label7";
            label7.Size = new Size(274, 20);
            label7.TabIndex = 21;
            label7.Text = "Developed by: Jeyson Ariel Palles Castro";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.JXP_Capital;
            pictureBox2.Location = new Point(924, 595);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblGananciaNeta);
            materialCard1.Controls.Add(lblGananciaNeta1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(498, 63);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(167, 97);
            materialCard1.TabIndex = 19;
            // 
            // lblGananciaNeta
            // 
            lblGananciaNeta.AutoSize = true;
            lblGananciaNeta.Location = new Point(49, 52);
            lblGananciaNeta.Name = "lblGananciaNeta";
            lblGananciaNeta.Size = new Size(44, 20);
            lblGananciaNeta.TabIndex = 18;
            lblGananciaNeta.Text = "$0.00";
            // 
            // lblGananciaNeta1
            // 
            lblGananciaNeta1.AutoSize = true;
            lblGananciaNeta1.Location = new Point(31, 14);
            lblGananciaNeta1.Name = "lblGananciaNeta1";
            lblGananciaNeta1.Size = new Size(106, 20);
            lblGananciaNeta1.TabIndex = 13;
            lblGananciaNeta1.Text = "Ganancia Neta";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblValorActual);
            materialCard2.Controls.Add(lblValorActual1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(290, 63);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(167, 97);
            materialCard2.TabIndex = 19;
            // 
            // lblValorActual
            // 
            lblValorActual.AutoSize = true;
            lblValorActual.Location = new Point(47, 52);
            lblValorActual.Name = "lblValorActual";
            lblValorActual.Size = new Size(44, 20);
            lblValorActual.TabIndex = 19;
            lblValorActual.Text = "$0.00";
            // 
            // lblValorActual1
            // 
            lblValorActual1.AutoSize = true;
            lblValorActual1.Location = new Point(32, 14);
            lblValorActual1.Name = "lblValorActual1";
            lblValorActual1.Size = new Size(89, 20);
            lblValorActual1.TabIndex = 12;
            lblValorActual1.Text = "Valor Actual";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(label1);
            materialCard3.Controls.Add(lblCapitalInvertido);
            materialCard3.Controls.Add(label2);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(95, 63);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(167, 97);
            materialCard3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 16;
            label1.Text = "Capital Invertido";
            // 
            // lblCapitalInvertido
            // 
            lblCapitalInvertido.AutoSize = true;
            lblCapitalInvertido.Location = new Point(51, 52);
            lblCapitalInvertido.Name = "lblCapitalInvertido";
            lblCapitalInvertido.Size = new Size(44, 20);
            lblCapitalInvertido.TabIndex = 10;
            lblCapitalInvertido.Text = "$0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 15;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(lblRentabilidad);
            materialCard4.Controls.Add(lblRentabilidad1);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(686, 63);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(167, 97);
            materialCard4.TabIndex = 18;
            // 
            // lblRentabilidad
            // 
            lblRentabilidad.AutoSize = true;
            lblRentabilidad.Location = new Point(55, 52);
            lblRentabilidad.Name = "lblRentabilidad";
            lblRentabilidad.Size = new Size(44, 20);
            lblRentabilidad.TabIndex = 17;
            lblRentabilidad.Text = "$0.00";
            // 
            // lblRentabilidad1
            // 
            lblRentabilidad1.AutoSize = true;
            lblRentabilidad1.Location = new Point(39, 14);
            lblRentabilidad1.Name = "lblRentabilidad1";
            lblRentabilidad1.Size = new Size(85, 20);
            lblRentabilidad1.TabIndex = 14;
            lblRentabilidad1.Text = "Rentabiliad";
            // 
            // dgvResumen
            // 
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(183, 221);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.RowHeadersWidth = 51;
            dgvResumen.Size = new Size(584, 405);
            dgvResumen.TabIndex = 8;
            // 
            // tmrMercado
            // 
            tmrMercado.Interval = 15000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1853, 741);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWatchlist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtId;
        private DataGridView dgvTransacciones;
        private DateTimePicker dtpFecha;
        private ComboBox cmbTipo;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtTicker;
        private DataGridView dgvResumen;
        private Label lblCapitalInvertido;
        private Label lblRentabilidad1;
        private Label lblGananciaNeta1;
        private Label lblValorActual1;
        private MaterialSkin.Controls.MaterialTextBox2 txtCant;
        private MaterialSkin.Controls.MaterialTextBox2 txtPre;
        private MaterialSkin.Controls.MaterialTextBox2 txtIDelim;
        private MaterialSkin.Controls.MaterialTextBox2 txtTracker;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 txtFecha;
        private MaterialSkin.Controls.MaterialTextBox2 txtAccion;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Label label2;
        private Label lblGananciaNeta;
        private Label lblValorActual;
        private Label label1;
        private Label lblRentabilidad;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label9;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label8;
        private Label label7;
        private DataGridView dgvWatchlist;
        private System.Windows.Forms.Timer tmrMercado;
    }
}
