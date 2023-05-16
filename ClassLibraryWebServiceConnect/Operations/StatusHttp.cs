using ClassLibraryWebServiceConnect.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ClassLibraryWebServiceConnect.Operations
{
    internal static class StatusHttp
    {
        internal static async Task<(bool, string, GeneralAnswer<List<Status>>)> StatusGetAllGet(WebServiceParams _params)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = Certificate.ValidateServerCertificate;

                var client = new HttpClient(handler);

                client.Timeout = TimeSpan.FromSeconds(_params._TIMEOUT_WEB_SERVICE);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _params._TOKEN_WEB_SERVICE);

                var response = await client.GetAsync(_params._IP_WEB_SERVICE + $"api/Status/StatusGetAll");

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return (
                    true,
                    "Respuesta del servidor obtenida con exito.",
                    JsonSerializer.Deserialize<GeneralAnswer<List<Status>>>(result));
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
                    new GeneralAnswer<List<Status>>());
            }
        }

        internal static async Task<(bool, string, GeneralAnswer<object>)> StatusPost(Status status, WebServiceParams _params)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = Certificate.ValidateServerCertificate;

                var client = new HttpClient(handler);

                client.Timeout = TimeSpan.FromSeconds(_params._TIMEOUT_WEB_SERVICE);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _params._TOKEN_WEB_SERVICE);

                string json = JsonSerializer.Serialize(status);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(_params._IP_WEB_SERVICE + $"api/Status/StatusInsert", data);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return (
                        true,
                        "Respuesta del servidor obtenida con exito.",
                        JsonSerializer.Deserialize<GeneralAnswer<object>>(result));
                }
                else
                {
                    return (
                        false,
                        "Error al crear Estatus. Estatus: " + response.StatusCode,
                        null);
                }
            }
            catch (Exception ex)
            {
                return (
                    false,
                    "Error, Excepcion: " + ex.Message.ToLower(),
                    new GeneralAnswer<object>());
            }
        }

        internal static async Task<(bool, string, GeneralAnswer<object>)> StatusPut(Status status, WebServiceParams _params)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = Certificate.ValidateServerCertificate;

                var client = new HttpClient(handler);

                client.Timeout = TimeSpan.FromSeconds(_params._TIMEOUT_WEB_SERVICE);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _params._TOKEN_WEB_SERVICE);

                string json = JsonSerializer.Serialize(status);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync(_params._IP_WEB_SERVICE + $"api/Status/StatusUpdate", data);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return (
                        true,
                        "Respuesta del servidor obtenida con exito.",
                        JsonSerializer.Deserialize<GeneralAnswer<object>>(result));
                }
                else
                {
                    return (
                        false,
                        "Error al actualizar Estatus. Estatus: " + response.StatusCode,
                        null);
                }
                
            }
            catch (Exception ex)
            {
                return (
                    false,
                    "Error, Excepcion: " + ex.Message.ToLower(),
                    new GeneralAnswer<object>());
            }
        }

        internal static async Task<(bool, string, GeneralAnswer<object>)> StatusDelete(Status status, WebServiceParams _params)
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(_params._IP_WEB_SERVICE + $"api/Status/StatusDelete"),
                    Content = new StringContent(JsonSerializer.Serialize(status), Encoding.UTF8, "application/json")
                };

                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = Certificate.ValidateServerCertificate;

                var client = new HttpClient(handler);

                client.Timeout = TimeSpan.FromSeconds(_params._TIMEOUT_WEB_SERVICE);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _params._TOKEN_WEB_SERVICE);

                var response = await client.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return (
                        true,
                        "Respuesta del servidor obtenida con exito.",
                        JsonSerializer.Deserialize<GeneralAnswer<object>>(result));
                }
                else
                {
                    return (
                        false,
                        "Error al eliminar Estatus. Estatus: " + response.StatusCode,
                        null);
                }
            }
            catch (Exception ex)
            {
                return (
                    false,
                    "Error, Excepcion: " + ex.Message.ToLower(),
                    new GeneralAnswer<object>());
            }
        }
    }
}
