using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class MainForm : Form
    {
        private List<UserControl> listOfUserControls;
        
        private EventHandler<(bool,string)> RaiseRichTextInsertNewMessage;
        private EventHandler<List<Status>> RaiseUpdateStatus;
        private EventHandler<List<Store>> RaiseUpdateStore;
        private EventHandler<List<Supervisor>> RaiseUpdateSupervisor;
        private EventHandler<List<User>> RaiseUpdateUser;
        private EventHandler<(User, List<UserPermit>)> RaiseUpdateActiveUser;
        private EventHandler<List<UserRole>> RaiseUpdateUserRoles;
        private EventHandler<List<UserPermit>> RaiseUpdateActiveRole;

        private WebServiceOperation _webserviceOperations;
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

        public MainForm(WebServiceOperation webserviceOperations, User activeUser, List<UserPermit> activePermit,
            List<UserModule> userModuleList, List<UserModuleDetail> userModuleDetailList,
            List<Status> statusList, List<Store> storeList, List<Supervisor> supervisorList, List<User> userList,
            List<UserRole> userRoleList, List<StatusReport> statusReportList)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint, true);

            _webserviceOperations = webserviceOperations;
            _activeUser = activeUser;
            _activePermit = activePermit;
            _userModuleList = userModuleList;
            _userModuleDetailList = userModuleDetailList;
            _userRoleList = userRoleList;
            _statusList = statusList;
            _storeList = storeList;
            _supervisorList = supervisorList;
            _userList = userList;
            _statusReportList = statusReportList;

            InitializeComponent();
            CustomizeDesing();
            WireUpEvents();
            InitUserControls();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        //Esta lista es para el cambio que pidio Jhonny no perder la informacion mientras se cambia de pestaña
        private void InitUserControls()
        {
            listOfUserControls = new List<UserControl>
            {
                new InitUserControl(),
                new ReportStoreUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_TIENDA],
                RaiseRichTextInsertNewMessage),
                new ReportSupervisorUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_SUPERVISOR],
                RaiseRichTextInsertNewMessage),
                new RegisterStoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_TIENDA],
                RaiseRichTextInsertNewMessage),
                new RegisterSupervisorUserControl(_webserviceOperations, _activeUser,
                 _storeList, _supervisorList, _statusReportList,
                 _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_SUPERVISOR],
                 RaiseRichTextInsertNewMessage),
                new StatusUserControl(_webserviceOperations, _activeUser, _statusList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.ESTATUS], 
                RaiseRichTextInsertNewMessage, RaiseUpdateStatus),
                new SupervisorUserControl(_webserviceOperations, _activeUser,
                _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.SUPERVISOR],
                RaiseRichTextInsertNewMessage, RaiseUpdateSupervisor),
                new StoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.TIENDA],
                RaiseRichTextInsertNewMessage, RaiseUpdateStore),
                new UserUserControl(_webserviceOperations, _activeUser, _userList,
                _userRoleList, _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.USUARIO],
                _activePermit, RaiseRichTextInsertNewMessage, RaiseUpdateUser, RaiseUpdateActiveUser),
                new RolesUserControl(_webserviceOperations, _activeUser, _userRoleList,
                _activePermit, _userModuleList, _userModuleDetailList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.ROL],
                RaiseRichTextInsertNewMessage, RaiseUpdateUserRoles, RaiseUpdateActiveRole)
            };
        }

        private void WireUpEvents()
        {
            this.RaiseRichTextInsertNewMessage += UpdateOnRichTextInsertNewMessage;
            this.RaiseUpdateStatus += UpdateOnStatus;
            this.RaiseUpdateSupervisor += UpdateOnSupervisor;
            this.RaiseUpdateStore += UpdateOnStore;
            this.RaiseUpdateUser += UpdateOnUsers;
            this.RaiseUpdateActiveUser += UpdateOnActiveUser;
            this.RaiseUpdateUserRoles += UpdateOnRoles;
            this.RaiseUpdateActiveRole += UpdateOnActiveRole;
        }

        private void UpdateOnStatus(object sender, List<Status> e)
        {
            _statusList = e;

            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REPORT] =
                new ReportStoreUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_TIENDA],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REGISTER] =
                 new RegisterStoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_TIENDA],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STATUS] =
                new StatusUserControl(_webserviceOperations, _activeUser, _statusList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.ESTATUS],
                RaiseRichTextInsertNewMessage, RaiseUpdateStatus);
        }

        private void UpdateOnSupervisor(object sender, List<Supervisor> e)
        {
            _supervisorList = e;

            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REPORT] =
                new ReportSupervisorUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_SUPERVISOR],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REGISTER] =
                new RegisterSupervisorUserControl(_webserviceOperations, _activeUser,
                 _storeList, _supervisorList, _statusReportList,
                 _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_SUPERVISOR],
                 RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR] =
                new SupervisorUserControl(_webserviceOperations, _activeUser,
                _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.SUPERVISOR],
                RaiseRichTextInsertNewMessage, RaiseUpdateSupervisor);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORES] =
                new StoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.TIENDA],
                RaiseRichTextInsertNewMessage, RaiseUpdateStore);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.USERS] =
                new UserUserControl(_webserviceOperations, _activeUser, _userList,
                _userRoleList, _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.USUARIO],
                _activePermit,
                RaiseRichTextInsertNewMessage, RaiseUpdateUser, RaiseUpdateActiveUser);
        }

        private void UpdateOnStore(object sender, List<Store> e)
        {
            _storeList = e;

            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REPORT] =
                new ReportStoreUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_TIENDA],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REGISTER] =
                new RegisterStoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_TIENDA],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REGISTER] =
                new RegisterSupervisorUserControl(_webserviceOperations, _activeUser,
                 _storeList, _supervisorList, _statusReportList,
                 _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_SUPERVISOR],
                 RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORES] =
                new StoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.TIENDA],
                RaiseRichTextInsertNewMessage, RaiseUpdateStore);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.USERS] =
                new UserUserControl(_webserviceOperations, _activeUser, _userList,
                _userRoleList, _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.USUARIO],
                _activePermit,
                RaiseRichTextInsertNewMessage, RaiseUpdateUser, RaiseUpdateActiveUser);
        }

        private void UpdateOnUsers(object sender, List<User> e)
        {
            _userList = e;

            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REGISTER] =
                new UserUserControl(_webserviceOperations, _activeUser, _userList,
                _userRoleList, _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.USUARIO],
                _activePermit, RaiseRichTextInsertNewMessage, RaiseUpdateUser, RaiseUpdateActiveUser);
        }

        private void UpdateOnActiveUser(object sender, (User, List<UserPermit>) e)
        {
            _activeUser = e.Item1;
            _activePermit = e.Item2;

            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REPORT] =
                new ReportStoreUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_TIENDA],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REPORT] =
                new ReportSupervisorUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_SUPERVISOR],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REGISTER] =
                new RegisterStoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_TIENDA],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REGISTER] =
                new RegisterSupervisorUserControl(_webserviceOperations, _activeUser,
                 _storeList, _supervisorList, _statusReportList,
                 _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_SUPERVISOR],
                 RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STATUS] =
                new StatusUserControl(_webserviceOperations, _activeUser, _statusList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.ESTATUS],
                RaiseRichTextInsertNewMessage, RaiseUpdateStatus);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR] =
                new SupervisorUserControl(_webserviceOperations, _activeUser,
                _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.SUPERVISOR],
                RaiseRichTextInsertNewMessage, RaiseUpdateSupervisor);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORES] =
                new StoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.TIENDA],
                RaiseRichTextInsertNewMessage, RaiseUpdateStore);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.USERS] =
                new UserUserControl(_webserviceOperations, _activeUser, _userList,
                _userRoleList, _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.USUARIO],
                _activePermit, RaiseRichTextInsertNewMessage, RaiseUpdateUser, RaiseUpdateActiveUser);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.ROLES] =
                new RolesUserControl(_webserviceOperations, _activeUser, _userRoleList,
                _activePermit, _userModuleList, _userModuleDetailList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.ROL],
                RaiseRichTextInsertNewMessage, RaiseUpdateUserRoles, RaiseUpdateActiveRole);
        }

        private void UpdateOnRoles(object sender, List<UserRole> e)
        {
            _userRoleList = e;

            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.USERS] =
                new UserUserControl(_webserviceOperations, _activeUser, _userList,
                _userRoleList, _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.USUARIO],
                _activePermit, RaiseRichTextInsertNewMessage, RaiseUpdateUser, RaiseUpdateActiveUser);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.ROLES] =
                new RolesUserControl(_webserviceOperations, _activeUser, _userRoleList,
                _activePermit, _userModuleList, _userModuleDetailList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.ROL],
                RaiseRichTextInsertNewMessage, RaiseUpdateUserRoles, RaiseUpdateActiveRole);
        }

        private void UpdateOnActiveRole(object sender, List<UserPermit> e)
        {
            _activePermit = e;

            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REPORT] =
                new ReportStoreUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_TIENDA],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REPORT] =
                new ReportSupervisorUserControl(_webserviceOperations,
                _storeList, _supervisorList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_SUPERVISOR],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REGISTER] =
                new RegisterStoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _statusList, _statusReportList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_TIENDA],
                RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REGISTER] =
                new RegisterSupervisorUserControl(_webserviceOperations, _activeUser,
                 _storeList, _supervisorList, _statusReportList,
                 _activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_SUPERVISOR],
                 RaiseRichTextInsertNewMessage);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STATUS] =
                new StatusUserControl(_webserviceOperations, _activeUser, _statusList,
                _activePermit[(int)MagickInfo.PERMISOS_INDEX.ESTATUS],
                RaiseRichTextInsertNewMessage, RaiseUpdateStatus);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR] =
                new SupervisorUserControl(_webserviceOperations, _activeUser,
                _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.SUPERVISOR],
                RaiseRichTextInsertNewMessage, RaiseUpdateSupervisor);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORES] =
                new StoreUserControl(_webserviceOperations, _activeUser,
                _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.TIENDA],
                RaiseRichTextInsertNewMessage, RaiseUpdateStore);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.USERS] =
                new UserUserControl(_webserviceOperations, _activeUser, _userList,
                _userRoleList, _storeList, _supervisorList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.USUARIO],
                _activePermit, RaiseRichTextInsertNewMessage, RaiseUpdateUser, RaiseUpdateActiveUser);
            listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.ROLES] =
                new RolesUserControl(_webserviceOperations, _activeUser, _userRoleList,
                _activePermit, _userModuleList, _userModuleDetailList, _activePermit[(int)MagickInfo.PERMISOS_INDEX.ROL],
                RaiseRichTextInsertNewMessage, RaiseUpdateUserRoles, RaiseUpdateActiveRole);
        }

        private string GetTime()
        {
            return "Tiempo: " + DateTime.Now.ToString(@"hh\:mm\:ss\:fff") + ". ";
        }

        private void UpdateOnRichTextInsertNewMessage(object sender, (bool, string) e)
        {
            if (e.Item1)
            {
                AppendText(true, e.Item2, Color.Green, true);
            }
            else
            {
                AppendText(false, e.Item2, Color.Red, true);
            }
        }

        private void AppendText(bool status, string text, Color color, bool addNewLine = false)
        {   
            if(status)
            {
                text = text.Insert(0, "EXITOSO: " + GetTime());
            }
            else
            {
                text = text.Insert(0, "ERROR: " + GetTime());
            }
            richTextBoxStatusMessages.SuspendLayout();
            richTextBoxStatusMessages.SelectionColor = color;
            richTextBoxStatusMessages.AppendText(addNewLine
                ? $"{text}{Environment.NewLine}"
                : text);
            richTextBoxStatusMessages.ScrollToCaret();
            richTextBoxStatusMessages.ResumeLayout();
        }

        private void UpdateUserControlsOnChange(object sender, EventArgs e)
        {
            InitUserControls();
        }

        private void CustomizeDesing()
        {
            this.panelReporteSubmenu.Visible = false;
            this.panelRegisterSubmenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (this.panelReporteSubmenu.Visible)
            {
                this.panelReporteSubmenu.Visible = false;
            }
            if (this.panelRegisterSubmenu.Visible)
            {
                this.panelRegisterSubmenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void OpenChildForm(UserControl childForm)
        {
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonReColorMainMenu()
        {
            buttonReports.BackColor = Color.RoyalBlue;
            buttonRegisters.BackColor = Color.RoyalBlue;
            buttonStatus.BackColor = Color.RoyalBlue;
            buttonSupervisor.BackColor = Color.RoyalBlue;
            buttonStore.BackColor = Color.RoyalBlue;
            buttonUser.BackColor = Color.RoyalBlue;
            buttonRoles.BackColor = Color.RoyalBlue;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonReColorSubMenus()
        {
            buttonReportStore.BackColor = Color.CornflowerBlue;
            buttonReportSupervisor.BackColor = Color.CornflowerBlue;
            buttonRegisterStore.BackColor = Color.CornflowerBlue;
            buttonRegisterSupervisor.BackColor = Color.CornflowerBlue;
        }
        private void buttonReport_Click(object sender, EventArgs e)
        {
            ButtonReColorMainMenu();
            buttonReports.BackColor = Color.DarkBlue;
            HideSubmenu();
            ButtonReColorSubMenus();
            ShowSubMenu(this.panelReporteSubmenu);
            OpenChildForm(new InitUserControl());
        }
        private void buttonReportStore_Click(object sender, EventArgs e)
        {
            ButtonReColorSubMenus();
            buttonReportStore.BackColor = Color.DodgerBlue;
            richTextBoxStatusMessages.Text = string.Empty;

            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_TIENDA].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REPORT]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            }
        }

        private void buttonReportSupervisor_Click(object sender, EventArgs e)
        {
            ButtonReColorSubMenus();
            buttonReportSupervisor.BackColor = Color.DodgerBlue;
            richTextBoxStatusMessages.Text = string.Empty;

            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.REPORTE_SUPERVISOR].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REPORT]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            }
        }

        private void buttonRegisters_Click(object sender, EventArgs e)
        {
            ButtonReColorMainMenu();
            buttonRegisters.BackColor = Color.DarkBlue;
            HideSubmenu();
            ButtonReColorSubMenus();
            ShowSubMenu(this.panelRegisterSubmenu);
            OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
        }

        private void buttonRegisterStore_Click(object sender, EventArgs e)
        {
            ButtonReColorSubMenus();
            buttonRegisterStore.BackColor = Color.DodgerBlue;
            richTextBoxStatusMessages.Text = string.Empty;

            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_TIENDA].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORE_REGISTER]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            }
        }

        private void buttonRegisterSupervisor_Click(object sender, EventArgs e)
        {
            ButtonReColorSubMenus();
            buttonRegisterSupervisor.BackColor = Color.DodgerBlue;
            richTextBoxStatusMessages.Text = string.Empty;
            
            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.REGISTRO_SUPERVISOR].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR_REGISTER]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            }
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            ButtonReColorMainMenu();
            ButtonReColorSubMenus();
            buttonStatus.BackColor = Color.DarkBlue;
            HideSubmenu();
            richTextBoxStatusMessages.Text = string.Empty;

            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.ESTATUS].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STATUS]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            }
        }

        private void buttonSupervisor_Click(object sender, EventArgs e)
        {
            ButtonReColorMainMenu();
            ButtonReColorSubMenus();
            buttonSupervisor.BackColor = Color.DarkBlue;
            HideSubmenu();
            richTextBoxStatusMessages.Text = string.Empty;

            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.SUPERVISOR].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.SUPERVISOR]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            } 
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            ButtonReColorMainMenu();
            ButtonReColorSubMenus();
            buttonStore.BackColor = Color.DarkBlue;
            HideSubmenu();
            richTextBoxStatusMessages.Text = string.Empty;
            
            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.TIENDA].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.STORES]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            }

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            ButtonReColorMainMenu();
            ButtonReColorSubMenus();
            buttonUser.BackColor = Color.DarkBlue;
            HideSubmenu();
            richTextBoxStatusMessages.Text = string.Empty;
            
            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.USUARIO].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.USERS]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            }
        }

        private void buttonRoles_Click(object sender, EventArgs e)
        {
            ButtonReColorMainMenu();
            ButtonReColorSubMenus();
            buttonRoles.BackColor = Color.DarkBlue;
            HideSubmenu();
            richTextBoxStatusMessages.Text = string.Empty;
            
            if (_activePermit[(int)MagickInfo.PERMISOS_INDEX.ROL].upm_select == true)
            {
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.ROLES]);
            }
            else
            {
                RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Usuario sin permisos para ver esta seccion."));
                OpenChildForm(listOfUserControls[(int)MagickInfo.USER_CONTROL_LIST_INDEX.INIT]);
            }

        }
    }
}