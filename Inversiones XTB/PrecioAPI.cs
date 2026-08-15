using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Inversiones_XTB
{
    public static class PrecioAPI
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<double> ObtenerPrecioActual(string ticker)
        {
            try
            {
                // 1. LA LLAVE MAESTRA: Forzar conexión con Seguridad Moderna (TLS 1.2)
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // 2. Disfraz de navegador web
                if (!client.DefaultRequestHeaders.Contains("User-Agent"))
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36");
                }

                string url = $"https://query1.finance.yahoo.com/v8/finance/chart/{ticker}?region=US&lang=en-US&includePrePost=false&interval=1m&useYfid=true&range=1d";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                // 3. Extraer el precio
                double precio = (double)json["chart"]["result"][0]["meta"]["regularMarketPrice"];
                return precio;
            }
            catch (Exception ex)
            {
                // MODO DEPURACIÓN: En lugar de esconder el error, ¡te lo mostramos en pantalla!
                MessageBox.Show($"Error al descargar datos de {ticker}:\n{ex.Message}", "Depuración de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0.0;
            }
        }
    }
}