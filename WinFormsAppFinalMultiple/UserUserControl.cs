using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;
using System.Data;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class UserUserControl : UserControl
    {
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;
        private EventHandler<List<User>> _RaiseUpdateUser;
        private EventHandler<(User, List<UserPermit>)> _RaiseUpdateActiveUser;

        private WebServiceOperation _webserviceOperations;
        private User _activeUser;
        private List<Store> _storeList;
        private List<Supervisor> _supervisorList;
        private List<User> _userList;
        private List<UserRole> _userRoleList;
        private List<UserPermit> _activePermit;

        private ToolTip buttonUserEditEditTooltip = new ToolTip();
        private ToolTip buttonUsertEditDeleteTooltip = new ToolTip();
        private ToolTip buttonUsertAddTooltip = new ToolTip();
        private ToolTip buttonUsertRefreshTooltip = new ToolTip();

        public UserUserControl(WebServiceOperation webserviceOperations, User activeUser,
             List<User> userList, List<UserRole> userRoleList, List<Store> storeList, List<Supervisor> supervisorList,
             UserPermit _activePermissionSection, List<UserPermit> activePermit,
             EventHandler<(bool, string)> RaiseRichTextInsertNewMessage,
             EventHandler<List<User>> RaiseUpdateUser,
             EventHandler<(User, List<UserPermit>)> RaiseUpdateActiveUser)
        {
            InitializeComponent();

            _webserviceOperations = webserviceOperations;
            _activeUser = activeUser;
            _userList = userList;
            _userRoleList = userRoleList;
            _storeList = storeList;
            _supervisorList = supervisorList;
            _activePermit = activePermit;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;
            _RaiseUpdateUser = RaiseUpdateUser;
            _RaiseUpdateActiveUser = RaiseUpdateActiveUser;

            ApplyPermissions(_activePermissionSection);

            BindUserEdit();
            comboBoxUserEditStore.Enabled = false;
            comboBoxUserAddStore.Enabled = false;
            comboBoxUserEditSupervisor.Enabled = false;
            comboBoxUserAddSupervisor.Enabled = false;

            buttonUserEditEditTooltip.SetToolTip(buttonUserEdit, "Editar Usuario");
            buttonUsertEditDeleteTooltip.SetToolTip(buttonUserEditDelete, "Eliminar Usuario");
            buttonUsertAddTooltip.SetToolTip(buttonUserAdd, "Agregar Usuario");
            buttonUsertRefreshTooltip.SetToolTip(buttonUserRefreshData, "Refrescar data del servidor en caso de error.");
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
        //        return parms;
        //    }
        //}

        private void ApplyPermissions(UserPermit activePermissionSection)
        {
            if (activePermissionSection.upm_update == false)
            {
                buttonUserEdit.Hide();
            }

            if (activePermissionSection.upm_delete == false)
            {
                buttonUserEditDelete.Hide();
            }

            if (activePermissionSection.upm_insert == false)
            {
                buttonUserAdd.Hide();
            }

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Permisos de Usuario aplicados."));
        }

        private void BindUserEdit()
        {
            this.comboBoxUserEdit.SelectedIndexChanged -= new System.EventHandler(comboBoxUserEdit_SelectedIndexChanged);
            comboBoxUserEdit.DataSource = null;
            comboBoxUserEdit.DataSource = _userList;
            comboBoxUserEdit.ValueMember = "usr_id";
            comboBoxUserEdit.DisplayMember = "usr_alias";
            comboBoxUserEdit.SelectedIndex = -1;
            this.comboBoxUserEdit.SelectedIndexChanged += new System.EventHandler(comboBoxUserEdit_SelectedIndexChanged);

            comboBoxUserEditAdminRole.DataSource = null;
            comboBoxUserEditAdminRole.DataSource = _userRoleList.Where(x => x.uro_id != (int)MagickInfo.ROLES.STORE_ROL && x.uro_id != (int)MagickInfo.ROLES.SUPERVISOR_ROL).ToList();
            comboBoxUserEditAdminRole.ValueMember = "uro_id";
            comboBoxUserEditAdminRole.DisplayMember = "uro_name";

            comboBoxUserAddAdminRole.DataSource = null;
            comboBoxUserAddAdminRole.DataSource = _userRoleList.Where(x => x.uro_id != (int)MagickInfo.ROLES.STORE_ROL && x.uro_id != (int)MagickInfo.ROLES.SUPERVISOR_ROL).ToList();
            comboBoxUserAddAdminRole.ValueMember = "uro_id";
            comboBoxUserAddAdminRole.DisplayMember = "uro_name";

            comboBoxUserEditStore.DataSource = null;
            comboBoxUserEditStore.DataSource = _storeList.Where(x => x.sto_id != (int)MagickInfo.STORE.ZERO).ToList();
            comboBoxUserEditStore.ValueMember = "sto_id";
            comboBoxUserEditStore.DisplayMember = "sto_code";

            comboBoxUserAddStore.DataSource = null;
            comboBoxUserAddStore.DataSource = _storeList.Where(x => x.sto_id != (int)MagickInfo.STORE.ZERO).ToList();
            comboBoxUserAddStore.ValueMember = "sto_id";
            comboBoxUserAddStore.DisplayMember = "sto_code";

            comboBoxUserEditSupervisor.DataSource = null;
            comboBoxUserEditSupervisor.DataSource = _supervisorList.Where(x => x.sup_id != (int)MagickInfo.SUPERVISOR.ADMINISTRADOR).ToList();
            comboBoxUserEditSupervisor.ValueMember = "sup_id";
            comboBoxUserEditSupervisor.DisplayMember = "sup_description";

            comboBoxUserAddSupervisor.DataSource = null;
            comboBoxUserAddSupervisor.DataSource = _supervisorList.Where(x => x.sup_id != (int)MagickInfo.SUPERVISOR.ADMINISTRADOR).ToList();
            comboBoxUserAddSupervisor.ValueMember = "sup_id";
            comboBoxUserAddSupervisor.DisplayMember = "sup_description";
        }

        private void comboBoxUserEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUserEdit.SelectedIndex == -1)
            {
                return;
            }

            foreach (var item in _userList)
            {
                if (item.usr_id == (int)comboBoxUserEdit.SelectedValue)
                {
                    textBoxUserEditAlias.Text = item.usr_alias;
                    textBoxUserEditName.Text = item.usr_firstname;
                    textBoxUserEditSurname.Text = item.usr_lastname;
                    textBoxUserEditMail.Text = item.usr_email;

                    
                    if (item.usr_urol_id == (int)MagickInfo.ROLES.STORE_ROL)
                    {
                        radioButtonUserEditStore.Checked = true;
                        foreach (Store itemCombo in comboBoxUserEditStore.Items)
                        {
                            if (itemCombo.sto_id == item.usr_manage_id)
                            {
                                comboBoxUserEditStore.SelectedItem = itemCombo;
                                break;
                            }
                        }
                    }
                    else if (item.usr_urol_id == (int)MagickInfo.ROLES.SUPERVISOR_ROL)
                    {
                        radioButtonUserEditSupervisor.Checked = true;
                        foreach (Supervisor itemCombo in comboBoxUserEditSupervisor.Items)
                        {
                            if (itemCombo.sup_id == item.usr_manage_id)
                            {
                                comboBoxUserEditSupervisor.SelectedItem = itemCombo;
                                break;
                            }
                        }
                    }
                    else
                    {
                        radioButtonUserEditAdministrator.Checked = true;
                        foreach (UserRole itemCombo in comboBoxUserEditAdminRole.Items)
                        {
                            if (itemCombo.uro_id == item.usr_urol_id)
                            {
                                comboBoxUserEditAdminRole.SelectedItem = itemCombo;
                                break;
                            }
                        }
                    }
                    
                    break;
                }
            }
        }

        private void radioButtonEditUserAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUserEditAdministrator.Checked)
            {
                comboBoxUserEditAdminRole.Enabled = true;
                comboBoxUserEditStore.Enabled = false;
                comboBoxUserEditSupervisor.Enabled = false;
            }
        }

        private void radioButtonEditUserStore_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUserEditStore.Checked)
            {
                comboBoxUserEditAdminRole.Enabled = false;
                comboBoxUserEditStore.Enabled = true;
                comboBoxUserEditSupervisor.Enabled = false;
            }
        }

        private void radioButtonEditUserSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUserEditSupervisor.Checked)
            {
                comboBoxUserEditAdminRole.Enabled = false;
                comboBoxUserEditStore.Enabled = false;
                comboBoxUserEditSupervisor.Enabled = true;
            }
        }

        private async Task<bool> UpdateUserList()
        {
            var resultGetUsers = await _webserviceOperations.UserGetAll(_activeUser.usr_id);

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (resultGetUsers.Item1, resultGetUsers.Item2));

            if (resultGetUsers.Item1)
            {
                _userList.Clear();
                _userList.AddRange(resultGetUsers.Item3);
                _RaiseUpdateUser?.Invoke(this, _userList);
                BindUserEdit();
                return true;
            }

            return false;
        }

        private async void buttonUserEditEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxUserEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error debe seleccionar un usuario."));
                return;
            }

            if (string.IsNullOrEmpty(textBoxUserEditAlias.Text) || string.IsNullOrEmpty(textBoxUserEditPassword.Text) ||
                   string.IsNullOrEmpty(textBoxUserEditName.Text) || string.IsNullOrEmpty(textBoxUserEditSurname.Text) ||
                   string.IsNullOrEmpty(textBoxUserEditMail.Text))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error campos invalidos."));
                return;
            }

            buttonUserEdit.Enabled = false;
            buttonUserEditDelete.Enabled = false;
            comboBoxUserEdit.Enabled = false;
            textBoxUserEditAlias.Enabled = false;
            textBoxUserEditPassword.Enabled = false;
            textBoxUserEditName.Enabled = false;
            textBoxUserEditSurname.Enabled = false;
            textBoxUserEditMail.Enabled = false;
            radioButtonUserEditAdministrator.Enabled = false;
            comboBoxUserEditAdminRole.Enabled = false;
            radioButtonUserEditStore.Enabled = false;
            comboBoxUserEditStore.Enabled = false;
            radioButtonUserEditSupervisor.Enabled = false;
            comboBoxUserEditSupervisor.Enabled = false;

            int usr_manage_id = 0;
            int usr_rol_id = 0;

            if (radioButtonUserEditAdministrator.Checked)
            {
                usr_manage_id = 0;
                usr_rol_id = ((UserRole)(comboBoxUserEditAdminRole.SelectedItem)).uro_id;
            }
            else if (radioButtonUserEditStore.Checked)
            {
                usr_manage_id = ((Store)comboBoxUserEditStore.SelectedItem).sto_id;
                usr_rol_id = (int)MagickInfo.ROLES.STORE_ROL;
            }
            else
            {
                usr_manage_id = ((Supervisor)comboBoxUserEditSupervisor.SelectedItem).sup_id;
                usr_rol_id = (int)MagickInfo.ROLES.SUPERVISOR_ROL;
            }

            var result = await _webserviceOperations.UserPut(
                    new User
                    {
                        usr_id = ((User)comboBoxUserEdit.SelectedItem).usr_id,
                        usr_alias = textBoxUserEditAlias.Text,
                        usr_password = textBoxUserEditPassword.Text,
                        usr_firstname = textBoxUserEditName.Text,
                        usr_lastname = textBoxUserEditSurname.Text,
                        usr_email = textBoxUserEditMail.Text,
                        usr_manage_id = usr_manage_id,
                        usr_audit = _activeUser.usr_id,
                        usr_urol_id = usr_rol_id,
                        usr_audit_date = DateTime.Now,
                        usr_deleted = false
                    }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (result.Item1, result.Item2));

            if (result.Item1)
            {
                //Si el usuario activo se modifico
                if(_activeUser.usr_id == ((User)comboBoxUserEdit.SelectedItem).usr_id)     
                { 
                    var resultGetUserById = await _webserviceOperations.UserGetById(_activeUser.usr_id);

                    _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGetUserById.Item1, resultGetUserById.Item2));

                    if (resultGetUserById.Item1)
                    {
                        _activeUser.usr_id = resultGetUserById.Item3.usr_id;
                        _activeUser.usr_alias = resultGetUserById.Item3.usr_alias;
                        _activeUser.usr_firstname = resultGetUserById.Item3.usr_firstname;
                        _activeUser.usr_lastname =   resultGetUserById.Item3.usr_lastname;
                        _activeUser.usr_email = resultGetUserById.Item3.usr_email;
                        _activeUser.usr_manage_id = resultGetUserById.Item3.usr_manage_id;
                        _activeUser.usr_urol_id = resultGetUserById.Item3.usr_urol_id;
                        _activeUser.usr_audit = resultGetUserById.Item3.usr_audit;
                        _activeUser.usr_audit_date = resultGetUserById.Item3.usr_audit_date;

                        var resultGetPermissions = await _webserviceOperations.UserPermitGetByRol(_activeUser.usr_urol_id);
                        _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGetPermissions.Item1, resultGetPermissions.Item2));

                        if (resultGetPermissions.Item1)
                        {
                            _activePermit = resultGetPermissions.Item3;
                            _RaiseUpdateActiveUser?.Invoke(this, new(_activeUser, resultGetPermissions.Item3));
                        }
                    } 
                }

                textBoxUserEditAlias.Text = string.Empty;
                textBoxUserEditPassword.Text = string.Empty;
                textBoxUserEditName.Text = string.Empty;
                textBoxUserEditSurname.Text = string.Empty;
                textBoxUserEditMail.Text = string.Empty;
                radioButtonUserEditAdministrator.Checked = true;
                comboBoxUserEditStore.SelectedIndex = -1;
                comboBoxUserEditSupervisor.SelectedIndex = -1;
                comboBoxUserEditAdminRole.SelectedIndex = -1;

                await UpdateUserList();
            }

            buttonUserEdit.Enabled = true;
            buttonUserEditDelete.Enabled = true;
            comboBoxUserEdit.Enabled = true;
            textBoxUserEditAlias.Enabled = true;
            textBoxUserEditPassword.Enabled = true;
            textBoxUserEditName.Enabled = true;
            textBoxUserEditSurname.Enabled = true;
            textBoxUserEditMail.Enabled = true;
            radioButtonUserEditAdministrator.Enabled = true;
            comboBoxUserEditAdminRole.Enabled = true;
            radioButtonUserEditStore.Enabled = true;
            comboBoxUserEditStore.Enabled = true;
            radioButtonUserEditSupervisor.Enabled = true;
            comboBoxUserEditSupervisor.Enabled = true;
        }

        private async void buttonUserEditDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxUserEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error debe seleccionar un usuario."));
                return;
            }

            if (MessageBox.Show("Por favor confirme antes de proceder" + "\n" + "¿Está seguro de querer eliminar el usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (_activeUser.usr_id == ((User)comboBoxUserEdit.SelectedItem).usr_id)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error no se puede elimnar el usuario en uso."));
                return;
            }

            buttonUserEdit.Enabled = false;
            buttonUserEditDelete.Enabled = false;
            comboBoxUserEdit.Enabled = false;

            var result = await _webserviceOperations.UserDelete(
                new User
                {
                        usr_id = ((User)comboBoxUserEdit.SelectedItem).usr_id,
                        usr_audit = _activeUser.usr_id,
                        usr_audit_date = DateTime.Now,
                        usr_deleted = true
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (result.Item1, result.Item2));

            if (result.Item1)
            {
                textBoxUserEditAlias.Text = string.Empty;
                textBoxUserEditPassword.Text = string.Empty;
                textBoxUserEditName.Text = string.Empty;
                textBoxUserEditSurname.Text = string.Empty;
                textBoxUserEditMail.Text = string.Empty;
                radioButtonUserEditAdministrator.Checked = true;
                comboBoxUserEditStore.SelectedIndex = -1;
                comboBoxUserEditSupervisor.SelectedIndex = -1;
                comboBoxUserEditAdminRole.SelectedIndex = -1;

                await UpdateUserList();
            }

            buttonUserEdit.Enabled = true;
            buttonUserEditDelete.Enabled = true;
            comboBoxUserEdit.Enabled = true;
        }

        private void radioButtonUserAddAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUserAddAdministrator.Checked)
            {
                comboBoxUserAddAdminRole.Enabled = true;
                comboBoxUserAddStore.Enabled = false;
                comboBoxUserAddSupervisor.Enabled = false;
            }
        }

        private void radioButtonUserAddStore_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUserAddStore.Checked)
            {
                comboBoxUserAddAdminRole.Enabled = false;
                comboBoxUserAddStore.Enabled = true;
                comboBoxUserAddSupervisor.Enabled = false;
            }
        }

        private void radioButtonUserAddSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUserAddSupervisor.Checked)
            {
                comboBoxUserAddAdminRole.Enabled = false;
                comboBoxUserAddStore.Enabled = false;
                comboBoxUserAddSupervisor.Enabled = true;
            }
        }

        private async void buttonUserAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserAddAlias.Text) || string.IsNullOrEmpty(textBoxUserAddPassword.Text) ||
                   string.IsNullOrEmpty(textBoxUserAddName.Text) || string.IsNullOrEmpty(textBoxUserAddSurname.Text) ||
                   string.IsNullOrEmpty(textBoxUserAddMail.Text))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error campos invalidos."));
                return;
            }

            buttonUserAdd.Enabled = false;
            textBoxUserAddAlias.Enabled = false;
            textBoxUserAddPassword.Enabled = false;
            textBoxUserAddName.Enabled = false;
            textBoxUserAddSurname.Enabled = false;
            textBoxUserAddMail.Enabled = false;
            radioButtonUserAddAdministrator.Enabled = false;
            radioButtonUserAddStore.Enabled = false;
            comboBoxUserAddStore.Enabled = false;
            radioButtonUserAddSupervisor.Enabled = false;
            comboBoxUserAddSupervisor.Enabled = false;

            int usr_manage_id = 0;
            int usr_rol_id = 0;

            if (radioButtonUserAddAdministrator.Checked)
            {
                usr_manage_id = 0;
                usr_rol_id = ((UserRole)(comboBoxUserAddAdminRole.SelectedItem)).uro_id;
            }
            else if (radioButtonUserAddStore.Checked)
            {
                usr_manage_id = ((Store)comboBoxUserAddStore.SelectedItem).sto_id;
                usr_rol_id = (int)MagickInfo.ROLES.STORE_ROL;
            }
            else
            {
                usr_manage_id = ((Supervisor)comboBoxUserAddSupervisor.SelectedItem).sup_id;
                usr_rol_id = (int)MagickInfo.ROLES.SUPERVISOR_ROL;
            }

            var result = await _webserviceOperations.UserPost(
                    new User
                    {
                        usr_alias = textBoxUserAddAlias.Text,
                        usr_password = textBoxUserAddPassword.Text,
                        usr_firstname = textBoxUserAddName.Text,
                        usr_lastname = textBoxUserAddSurname.Text,
                        usr_email = textBoxUserAddMail.Text,
                        usr_manage_id = usr_manage_id,
                        usr_audit = _activeUser.usr_id,
                        usr_urol_id = usr_rol_id,
                        usr_audit_date = DateTime.Now,
                        usr_deleted = false
                    }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (result.Item1, result.Item2));

            if (result.Item1)
            {
                textBoxUserAddAlias.Text = string.Empty;
                textBoxUserAddPassword.Text = string.Empty;
                textBoxUserAddName.Text = string.Empty;
                textBoxUserAddSurname.Text = string.Empty;
                textBoxUserAddMail.Text = string.Empty;

                await UpdateUserList();
            }

            buttonUserAdd.Enabled = true;
            textBoxUserAddAlias.Enabled = true;
            textBoxUserAddPassword.Enabled = true;
            textBoxUserAddName.Enabled = true;
            textBoxUserAddSurname.Enabled = true;
            textBoxUserAddMail.Enabled = true;
            radioButtonUserAddAdministrator.Enabled = true;
            radioButtonUserAddStore.Enabled = true;
            comboBoxUserAddStore.Enabled = true;
            radioButtonUserAddSupervisor.Enabled = true;
            comboBoxUserAddSupervisor.Enabled = true;
        }

        private async void buttonUserRefreshData_Click(object sender, EventArgs e)
        {
            buttonUserRefreshData.Enabled = false;

            await UpdateUserList();

            buttonUserRefreshData.Enabled = true;
        }
    }
}
