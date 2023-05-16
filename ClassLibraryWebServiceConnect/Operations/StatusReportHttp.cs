using ClassLibraryWebServiceConnect.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ClassLibraryWebServiceConnect.Operations
{
    internal static class StatusReportHttp
    {
        internal static async Task<(bool, string, GeneralAnswer<List<StatusReport>>)> StatusReportGetAllGet(WebServiceParams _params)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = Certificate.ValidateServerCertificate;

                var client = new HttpClient(handler);

                client.Timeout = TimeSpan.FromSeconds(_params._TIMEOUT_WEB_SERVICE);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _params._TOKEN_WEB_SERVICE);

                var response = await client.GetAsync(_params._IP_WEB_SERVICE + $"api/StatusReport/StatusReportGetAll");

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return (
                    true,
                    "Respuesta del servidor obtenida con exito.",
                    JsonSerializer.Deserialize<GeneralAnswer<List<StatusReport>>>(result));
                }
                else
                {
                    return (
                        false,
                        "Error al obtener Estatus. Estatus: " + response.StatusCode,
                        null);
                }
            }
            catch (Exception ex)
            {
                return (
                    false,
                    "Error, Excepcion: " + ex.Message.ToLower(),
                    new GeneralAnswer<List<StatusReport>>());
            }
        }
    }
}
