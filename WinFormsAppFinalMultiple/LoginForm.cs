using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;
using System.Configuration;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class LoginForm : Form
    {
        private readonly string _IP_WEB_SERVICE;
        private readonly int _TIMEOUT_WEB_SERVICE;
        private WebServiceOperation _webServiceOperations;
        private User _activeUser;
        private List<UserPermit> _activePermit;
        private List<UserModule> _userModuleList;
        private List<UserModuleDetail> _userModuleDetailList;
        private List<Status> _statusList;
        private List<Store> _storeList;
        private List<Supervisor> _supervisorList;
        private List<User> _userList;
        private List<UserRole> _userRoleList;
        private List<StatusReport> _statusReportList;

        public LoginForm()
        {
            InitializeComponent();
            try
            {
                _IP_WEB_SERVICE = ConfigurationManager.AppSettings["IP_WEB_SERVICE"].ToString();
            }
            catch
            {
                _IP_WEB_SERVICE = "https://192.168.0.203:9097/";
            }
            try
            {
                _TIMEOUT_WEB_SERVICE = Int32.Parse(ConfigurationManager.AppSettings["TIMEOUT_WEB_SERVICE"].ToString());
            }
            catch
            {
                _TIMEOUT_WEB_SERVICE = 30;
            }

            _webServiceOperations = new WebServiceOperation(_IP_WEB_SERVICE, _TIMEOUT_WEB_SERVICE);
        }

        private void UpdateUiFromLoadStore(Tuple<bool, string> result)
        {
            if (result.Item1)
            {
                TextBoxStatusUpdate(result.Item2, Color.Green);
            }
            else
            {
                TextBoxStatusUpdate(result.Item2, Color.Red);
            }
        }

        private void TextBoxStatusUpdate(string text, Color colorBrush)
        {
            this.textBoxStatus.Text = text;
            this.textBoxStatus.ForeColor = colorBrush;
            this.textBoxStatus.BackColor = this.textBoxStatus.BackColor;
        }

        private Tuple<bool, string> ValidateInputUser()
        {
            if (string.IsNullOrWhiteSpace(textBoxUserAlias.Text))
            {
                return new Tuple<bool, string>(false, "Error campo de usuario vacio.");
            }
            else if (string.IsNullOrWhiteSpace(textBoxUserPassword.Text))
            {
                return new Tuple<bool, string>(false, "Error campo de contraseña de usuario vacio.");
            }
            else
            {
                return new Tuple<bool, string>(true, "Entrada de datos de usuarios validados.");
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
            UpdateUiFromLoadStore(new Tuple<bool, string>(true, "Obteniendo data del servidor..."));

            var resultValidateUser = ValidateInputUser();

            if (resultValidateUser.Item1 == false)
            {
                UpdateUiFromLoadStore(resultValidateUser);
                buttonLogin.Enabled = true;
                return;
            }

            var resultAccessUser = await _webServiceOperations.UserAccess(textBoxUserAlias.Text, textBoxUserPassword.Text);
            if (resultAccessUser.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultAccessUser.Item1, resultAccessUser.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _activeUser = resultAccessUser.Item3.user;
            _webServiceOperations.SetToken(resultAccessUser.Item3.token);

            var resultValidateRol = ValidateRolUser(_activeUser);
            if (resultValidateRol.Item1 == false)
            {
                UpdateUiFromLoadStore(resultValidateRol);
                buttonLogin.Enabled = true;
                return;
            }

            var resultGetPermit = await _webServiceOperations.UserPermitGetByRol(_activeUser.usr_urol_id);
            if (resultGetPermit.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultGetPermit.Item1, resultGetPermit.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _activePermit = resultGetPermit.Item3;

            var resultGetUserRoles = await _webServiceOperations.UserRoleGetAll(_activeUser.usr_id);
            if (resultGetUserRoles.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultGetUserRoles.Item1, resultGetUserRoles.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _userRoleList = resultGetUserRoles.Item3;

            var resultGetUserModule = await _webServiceOperations.UserModuleGetAll(_activeUser.usr_id);
            if (resultGetUserModule.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultGetUserModule.Item1, resultGetUserModule.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _userModuleList = resultGetUserModule.Item3;

            var resultGetUserModuleDetail = await _webServiceOperations.UserModuleDetailGetAll(_activeUser.usr_id);
            if (resultGetUserModuleDetail.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultGetUserModuleDetail.Item1, resultGetUserModuleDetail.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _userModuleDetailList = resultGetUserModuleDetail.Item3;

            var resultGetStatus = await _webServiceOperations.StatusGetAll();
            if (resultGetStatus.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultGetStatus.Item1, resultGetStatus.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _statusList = resultGetStatus.Item3;

            var resultGetSupervisors = await _webServiceOperations.SupervisorGetAll();
            if (resultGetSupervisors.Item1 == false)
            {
                UpdateUiFromLoadStore(new Tuple<bool, string>(resultGetSupervisors.Item1, resultGetSupervisors.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _supervisorList = resultGetSupervisors.Item3;

            var resultGetStores = await _webServiceOperations.StoreGetAll();
            if (resultGetStores.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultGetStores.Item1, resultGetStores.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _storeList = resultGetStores.Item3;

            var resultGetUsers = await _webServiceOperations.UserGetAll(_activeUser.usr_id);
            if (resultGetUsers.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultGetUsers.Item1, resultGetUsers.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _userList = resultGetUsers.Item3;

            var resultGetStatusReport = await _webServiceOperations.StatusReportGetAll();
            if (resultGetStatusReport.Item1 == false)
            {
                UpdateUiFromLoadStore(new(resultGetStatusReport.Item1, resultGetStatusReport.Item2));
                buttonLogin.Enabled = true;
                return;
            }

            _statusReportList = resultGetStatusReport.Item3;

            LaunchMainWindows();

            buttonLogin.Enabled = true;
            textBoxStatus.Text = string.Empty;
            textBoxUserAlias.Text = string.Empty;
            textBoxUserPassword.Text = string.Empty;
        }

        private Tuple<bool, string> ValidateRolUser(User user)
        {
            if (user.usr_urol_id != (int)MagickInfo.ROLES.STORE_ROL && user.usr_urol_id != (int)MagickInfo.ROLES.SUPERVISOR_ROL)
            {
                return new Tuple<bool, string>(true, "Rol de usuario valido.");
            }
            else
            {
                return new Tuple<bool, string>(false, "Rol de usuario sin permisos necesarios.");
            }
        }

        private void LaunchMainWindows()
        {
            this.Hide();
            MainForm mainForm = new MainForm(_webServiceOperations, _activeUser,
                                                _activePermit, _userModuleList, _userModuleDetailList,
                                                _statusList, _storeList,
                                                _supervisorList, _userList, _userRoleList,
                                                _statusReportList);
            mainForm.Closed += (s, args) => this.Show();
            mainForm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
