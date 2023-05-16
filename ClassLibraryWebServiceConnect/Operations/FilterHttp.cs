using ClassLibraryWebServiceConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibraryWebServiceConnect.Operations
{
    internal static class FilterHttp
    {
        internal static async Task<(bool, string, GeneralAnswer<List<StoreReport>>)> StoreReportFiltered(StoreFilter storeFilter, WebServiceParams _params)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = Certificate.ValidateServerCertificate;

                var client = new HttpClient(handler);

                client.Timeout = TimeSpan.FromSeconds(_params._TIMEOUT_WEB_SERVICE);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _params._TOKEN_WEB_SERVICE);

                string json = JsonSerializer.Serialize(storeFilter);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(_params._IP_WEB_SERVICE + $"api/Filter/StoreReportFiltered", data);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return (
                        true,
                        "Respuesta del servidor obtenida con exito.",
                        JsonSerializer.Deserialize<GeneralAnswer<List<StoreReport>>>(result));
                }
                else
                {
                    return (
                        false,
                        "Error al obtener Reportes de Tiendas. Estatus: " + response.StatusCode,
                        null);
                }
            }
            catch (Exception ex)
            {
                return (
                    false,
                    "Error al obtener Reportes de Tiendas, Excepcion: " + ex.Message.ToLower(),
                    new GeneralAnswer<List<StoreReport>>());
            }
        }

        internal static async Task<(bool, string, GeneralAnswer<List<SupervisorReport>>)> SupervisorReportFiltered(SupervisorFilter supervisorFilter, WebServiceParams _params)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = Certificate.ValidateServerCertificate;

                var client = new HttpClient(handler);

                client.Timeout = TimeSpan.FromSeconds(_params._TIMEOUT_WEB_SERVICE);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _params._TOKEN_WEB_SERVICE);

                string json = JsonSerializer.Serialize(supervisorFilter);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(_params._IP_WEB_SERVICE + $"api/Filter/SupervisorReportFiltered", data);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return (
                        true,
                        "Respuesta del servidor obtenida con exito.",
                        JsonSerializer.Deserialize<GeneralAnswer<List<SupervisorReport>>>(result));
                }
                else
                {
                    return (
                        false,
                        "Error al obtener Reportes de Supervisor. Estatus: " + response.StatusCode,
                        null);
                }
            }
            catch (Exception ex)
            {
                return (
                    false,
                    "Error al obtener Reportes de Supervisor, Excepcion: " + ex.Message.ToLower(),
                    new GeneralAnswer<List<SupervisorReport>>());
            }
        }
    }
}
