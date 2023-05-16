using ClassLibraryWebServiceConnect.Models;

namespace ClassLibraryWebServiceConnect.Operations
{
    public class WebServiceOperation
    {
        private WebServiceParams _params;

        public WebServiceOperation(string IP_WEB_SERVICE, int TIMEOUT_WEB_SERVICE)
        {
            _params = new WebServiceParams(IP_WEB_SERVICE, TIMEOUT_WEB_SERVICE);
        }
        public void SetToken(string token)
        {
            _params.SetToken(token);
        }

        #region User

        public async Task<(bool, string, UserAccess)> UserAccess(string alias, string password)
        {
            var result = await UserHttp.UserAccessPost(alias, password, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, User)> UserGetById(int usr_id)
        {
            var result = await UserHttp.UserGetByIdGet(usr_id, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, List<User>)> UserGetAll(int usr_id)
        {
            var result = await UserHttp.UserGetAllGet(usr_id, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> UserPost(User user)
        {
            var result = await UserHttp.UserPost(user, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> UserPut(User user)
        {
            var result = await UserHttp.UserPut(user, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> UserDelete(User user)
        {
            var result = await UserHttp.UserDelete(user, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion User

        #region Role

        public async Task<(bool, string, List<UserRole>)> UserRoleGetAll(int usr_id)
        {
            var result = await RoleHttp.UserRoleGetAllGet(usr_id, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, List<UserModule>)> UserModuleGetAll(int usr_id)
        {
            var result = await RoleHttp.UserModuleGetAll(usr_id, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, List<UserModuleDetail>)> UserModuleDetailGetAll(int usr_id)
        {
            var result = await RoleHttp.UserModuleDetailGetAll(usr_id, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, List<UserPermit>)> UserPermitGetByRol(int usr_uro_id)
        {
            var result = await RoleHttp.UserPermitGetByRol(usr_uro_id, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> UserPermitInsertBulk(UserPermitBulk userPermitBulk)
        {
            var result = await RoleHttp.UserPermitBulkPost(userPermitBulk, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> UserPermitUpdateBulk(UserPermitBulk userPermitBulk)
        {
            var result = await RoleHttp.UserPermitBulkPut(userPermitBulk, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> UserPermitDeleteBulk(UserPermitBulk userPermitBulk)
        {
            var result = await RoleHttp.UserPermitBulkDelete(userPermitBulk, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion Role

        #region Status

        public async Task<(bool, string, List<Status>)> StatusGetAll()
        {
            var result = await StatusHttp.StatusGetAllGet(_params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StatusPost(Status status)
        {
            var result = await StatusHttp.StatusPost(status, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StatusPut(Status status)
        {
            var result = await StatusHttp.StatusPut(status, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StatusDelete(Status status)
        {
            var result = await StatusHttp.StatusDelete(status, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion Status

        #region Supervisor

        public async Task<(bool, string, List<Supervisor>)> SupervisorGetAll()
        {
            var result = await SupervisorHttp.SupervisorGetAllGet(_params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> SupervisorPost(Supervisor supervisor)
        {
            var result = await SupervisorHttp.SupervisorPost(supervisor, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> SupervisorPut(Supervisor supervisor)
        {
            var result = await SupervisorHttp.SupervisorPut(supervisor, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> SupervisorDelete(Supervisor supervisor)
        {
            var result = await SupervisorHttp.SupervisorDelete(supervisor, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion Supervisor

        #region Store

        public async Task<(bool, string, List<Store>)> StoreGetAll()
        {
            var result = await StoreHttp.StoreGetAllGet(_params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StorePost(Store store)
        {
            var result = await StoreHttp.StorePost(store, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StorePut(Store store)
        {
            var result = await StoreHttp.StorePut(store, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StoreDelete(Store store)
        {
            var result = await StoreHttp.StoreDelete(store, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion Store

        #region StatusReport

        public async Task<(bool, string, List<StatusReport>)> StatusReportGetAll()
        {
            var result = await StatusReportHttp.StatusReportGetAllGet(_params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion StatusReport

        #region StoreReport

        public async Task<(bool, string, List<StoreReport>)> StoreReportGetByMonth(int storep_sto_id, DateTime storep_date)
        {
            var result = await StoreReportHttp.StoreReportGetByMonth(storep_sto_id, storep_date, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, StoreReportExist)> StoreReportExist(int storep_sto_id, DateTime storep_date)
        {
            var result = await StoreReportHttp.StoreReportExist(storep_sto_id, storep_date, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StoreReportPost(List<StoreReport> storeReports)
        {
            var result = await StoreReportHttp.StoreReportPost(storeReports, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StoreReportPut(List<StoreReport> storeReports)
        {
            var result = await StoreReportHttp.StoreReportPut(storeReports, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> StoreReportDelete(List<StoreReport> storeReports)
        {
            var result = await StoreReportHttp.StoreReportDelete(storeReports, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion StoreReport

        #region SupervisorReport

        public async Task<(bool, string, List<SupervisorReport>)> SupervisorReportGetByMonth(int suprep_sup_id, DateTime suprep_date)
        {
            var result = await SupervisorReportHttp.SupervisorReportGetByMonth(suprep_sup_id, suprep_date, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> SupervisorReportPost(List<SupervisorReport> supervisorReports)
        {
            var result = await SupervisorReportHttp.SupervisorReportPost(supervisorReports, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> SupervisorReportPut(List<SupervisorReport> supervisorReports)
        {
            var result = await SupervisorReportHttp.SupervisorReportPut(supervisorReports, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, object)> SupervisorReportDelete(List<SupervisorReport> supervisorReports)
        {
            var result = await SupervisorReportHttp.SupervisorReportDelete(supervisorReports, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion SupervisorReport

        #region Filters

        public async Task<(bool, string, List<StoreReport>)> StoreReportFiltered(StoreFilter storeFilter)
        {
            var result = await FilterHttp.StoreReportFiltered(storeFilter, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        public async Task<(bool, string, List<SupervisorReport>)> SupervisorReportFiltered(SupervisorFilter supervisorFilter)
        {
            var result = await FilterHttp.SupervisorReportFiltered(supervisorFilter, _params);

            if (result.Item1) //Obtenido del servidor
            {
                return (result.Item3.status, result.Item3.statusMessage, result.Item3.data);
            }
            else// No Obtenido del servidor
            {
                return (result.Item1, result.Item2, null);
            }
        }

        #endregion Filters

    }
}
