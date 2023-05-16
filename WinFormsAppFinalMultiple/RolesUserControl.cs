using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;
using System.Reflection;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class RolesUserControl : UserControl
    {
        private WebServiceOperation _webserviceOperations;
        private User _activeUser;
        private List<UserRole> _userRolesList;
        private List<UserPermit> _activePermit;
        private List<UserModule> _userModuleList;
        private List<UserModuleDetail> _userModuleDetailList;
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;
        private EventHandler<List<UserRole>> _RaiseUpdateUserRoles;
        private EventHandler<List<UserPermit>> _RaiseUpdateActiveRole;

        private ToolTip buttonUserRoleEditTooltip = new ToolTip();
        private ToolTip buttonUserRoleDeleteTooltip = new ToolTip();
        private ToolTip buttonUserRoleAddTooltip = new ToolTip();
        private ToolTip buttonUserRoleRefreshDataTooltip = new ToolTip();

        public RolesUserControl(WebServiceOperation webserviceOperations,
            User activeUser, List<UserRole> userRolesList, List<UserPermit> activePermit,
            List<UserModule> userModuleList, List<UserModuleDetail> userModuleDetailList,
            UserPermit _activePermissionSection,
            EventHandler<(bool, string)> RaiseRichTextInsertNewMessage,
            EventHandler<List<UserRole>> RaiseUpdateUserRoles,
            EventHandler<List<UserPermit>> RaiseUpdateActiveRole)
        {
            InitializeComponent();
            _webserviceOperations = webserviceOperations;
            _activeUser = activeUser;
            _userRolesList = userRolesList;
            _activePermit = activePermit;
            _userModuleList = userModuleList;
            _userModuleDetailList = userModuleDetailList;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;
            _RaiseUpdateUserRoles = RaiseUpdateUserRoles;
            _RaiseUpdateActiveRole = RaiseUpdateActiveRole;

            ApplyPermissions(_activePermissionSection);
            BindUserRoleEdit();
            LoadDataGridViewUserPermitAdd();

            buttonUserRoleEditTooltip.SetToolTip(buttonUserRoleEdit, "Editar Rol");
            buttonUserRoleDeleteTooltip.SetToolTip(buttonUserRoleDelete, "Eliminar Rol");
            buttonUserRoleAddTooltip.SetToolTip(buttonUserRoleAdd, "Agregar Rol");
            buttonUserRoleRefreshDataTooltip.SetToolTip(buttonUserRoleRefreshData, "Refrescar data del servidor en caso de error.");

            dataGridViewUserRoleAdd.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridViewUserRoleAdd, true, null);
            dataGridViewUserRoleEdit.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridViewUserRoleEdit, true, null);
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
                buttonUserRoleEdit.Hide();
            }

            if (activePermissionSection.upm_delete == false)
            {
                buttonUserRoleDelete.Hide();
            }

            if (activePermissionSection.upm_insert == false)
            {
                buttonUserRoleAdd.Hide();
            }

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Permisos de Usuario aplicados."));
        }

        private void LoadDataGridViewUserPermitAdd()
        {
            dataGridViewUserRoleAdd.DataSource = null;

            List<UserPermitAdd> userPermitAddList = new List<UserPermitAdd>();

            foreach (var item in _userModuleDetailList)
            {
                userPermitAddList.Add(new UserPermitAdd
                {
                    upm_umo_name = _userModuleList.Where(x => x.umo_id == item.umd_umo_id).Select(x => x.umo_name).FirstOrDefault(),
                    upm_umd_id = item.umd_id,
                    upm_umd_name = item.umd_name,
                    upm_select = false,
                    upm_insert = false,
                    upm_update = false,
                    upm_delete = false
                });
            }

            dataGridViewUserRoleAdd.DataSource = userPermitAddList;
            DataGridViewRoleAddStyle();
        }

        private void DataGridViewRoleAddStyle()
        {
            try
            {
                dataGridViewUserRoleAdd.Columns[0].ReadOnly = true;
                dataGridViewUserRoleAdd.Columns[1].ReadOnly = true;
                dataGridViewUserRoleAdd.Columns[1].Visible = false;
                dataGridViewUserRoleAdd.Columns[2].ReadOnly = true;


                dataGridViewUserRoleAdd.Columns[0].HeaderText = "Modulo";
                dataGridViewUserRoleAdd.Columns[1].HeaderText = "Detalle Modulo ID";
                dataGridViewUserRoleAdd.Columns[2].HeaderText = "Detalle Modulo";
                dataGridViewUserRoleAdd.Columns[3].HeaderText = "Ver";
                dataGridViewUserRoleAdd.Columns[4].HeaderText = "Agregar";
                dataGridViewUserRoleAdd.Columns[5].HeaderText = "Editar";
                dataGridViewUserRoleAdd.Columns[6].HeaderText = "Eliminar";

                dataGridViewUserRoleAdd.Columns[0].Width = 160;
                dataGridViewUserRoleAdd.Columns[1].Width = 160;
                dataGridViewUserRoleAdd.Columns[2].Width = 160;
                dataGridViewUserRoleAdd.Columns[3].Width = 160;
                dataGridViewUserRoleAdd.Columns[4].Width = 160;
                dataGridViewUserRoleAdd.Columns[5].Width = 160;
                dataGridViewUserRoleAdd.Columns[6].Width = 160;
            }
            catch
            {
                ;
            }
        }

        private void BindUserRoleEdit()
        {
            comboBoxUserRoleEdit.SelectedIndexChanged -= new System.EventHandler(this.comboBoxStatusEdit_SelectedIndexChanged);
            comboBoxUserRoleEdit.DataSource = null;
            comboBoxUserRoleEdit.DataSource = _userRolesList.Where(x => x.uro_id != (int)MagickInfo.ROLES.STORE_ROL && x.uro_id != (int)MagickInfo.ROLES.SUPERVISOR_ROL).ToList();
            comboBoxUserRoleEdit.ValueMember = "uro_id";
            comboBoxUserRoleEdit.DisplayMember = "uro_name";
            comboBoxUserRoleEdit.SelectedIndex = -1;
            comboBoxUserRoleEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusEdit_SelectedIndexChanged);
        }

        private async void comboBoxStatusEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUserRoleEdit.SelectedIndex != -1)
            {
                var permited = await _webserviceOperations.UserPermitGetByRol(((UserRole)comboBoxUserRoleEdit.SelectedItem).uro_id);

                _RaiseRichTextInsertNewMessage?.Invoke(this, new(permited.Item1, permited.Item2));

                List<UserPermitEdit> userPermitedEdit = new List<UserPermitEdit>();
                foreach (var item in permited.Item3)
                {
                    userPermitedEdit.Add(new UserPermitEdit
                    {
                        upm_id = item.upm_id,
                        upm_uro_name = _userRolesList.Where(x => x.uro_id == item.upm_uro_id).Select(x => x.uro_name).FirstOrDefault(),
                        upm_umo_name = _userModuleList.Where(x => x.umo_id == _userModuleDetailList.Where(s => s.umd_id == item.upm_umd_id).Select(f => f.umd_umo_id).FirstOrDefault()).Select(x => x.umo_name).FirstOrDefault(),
                        upm_umd_name = _userModuleDetailList.Where(x => x.umd_id == item.upm_umd_id).Select(x => x.umd_name).FirstOrDefault(),
                        upm_select = item.upm_select,
                        upm_insert = item.upm_insert,
                        upm_update = item.upm_update,
                        upm_delete = item.upm_delete
                    });
                }
                dataGridViewUserRoleEdit.DataSource = userPermitedEdit;
                DataGridViewRoleEditStyle();
            }
        }

        private void DataGridViewRoleEditStyle()
        {
            try
            {
                dataGridViewUserRoleEdit.Columns[0].Visible = false;
                dataGridViewUserRoleEdit.Columns[0].ReadOnly = true;
                dataGridViewUserRoleEdit.Columns[1].ReadOnly = true;
                dataGridViewUserRoleEdit.Columns[2].ReadOnly = true;
                dataGridViewUserRoleEdit.Columns[3].ReadOnly = true;

                dataGridViewUserRoleEdit.Columns[1].HeaderText = "Rol";
                dataGridViewUserRoleEdit.Columns[2].HeaderText = "Modulo";
                dataGridViewUserRoleEdit.Columns[3].HeaderText = "Detalle Modulo";
                dataGridViewUserRoleEdit.Columns[4].HeaderText = "Ver";
                dataGridViewUserRoleEdit.Columns[5].HeaderText = "Agregar";
                dataGridViewUserRoleEdit.Columns[6].HeaderText = "Editar";
                dataGridViewUserRoleEdit.Columns[7].HeaderText = "Eliminar";

                dataGridViewUserRoleEdit.Columns[1].Width = 160;
                dataGridViewUserRoleEdit.Columns[2].Width = 160;
                dataGridViewUserRoleEdit.Columns[3].Width = 160;
                dataGridViewUserRoleEdit.Columns[4].Width = 160;
                dataGridViewUserRoleEdit.Columns[5].Width = 160;
                dataGridViewUserRoleEdit.Columns[6].Width = 160;
                dataGridViewUserRoleEdit.Columns[7].Width = 160;
            }
            catch
            {
                ;
            }
        }


        private async Task<bool> UpdateUserRoleList()
        {
            var resultGeRoles = await _webserviceOperations.UserRoleGetAll(_activeUser.usr_id);

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGeRoles.Item1, resultGeRoles.Item2));

            if (resultGeRoles.Item1)
            {
                _userRolesList.Clear();
                _userRolesList.AddRange(resultGeRoles.Item3);
                return true;
            }

            return false;
        }



        private async void buttonUserRolesRefreshData_Click(object sender, EventArgs e)
        {
            buttonUserRoleRefreshData.Enabled = false;

            await UpdateUserRoleList();
            BindUserRoleEdit();

            buttonUserRoleRefreshData.Enabled = true;
        }

        private async void buttonUserRoleEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxUserRoleEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error debe seleccionar un rol a editar."));
                return;
            }
            else if (((UserRole)comboBoxUserRoleEdit.SelectedItem).uro_id == (int)MagickInfo.ROLES.ADMIN_PRINCIPAL)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error el rol de Administrador no puede ser editado."));
                return;
            }
            else if (dataGridViewUserRoleEdit.DataSource == null || ((List<UserPermitEdit>)dataGridViewUserRoleEdit.DataSource).Count() < 9)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error permisos no cargados."));
                return;
            }

            comboBoxUserRoleEdit.Enabled = false;
            dataGridViewUserRoleEdit.Enabled = false;
            buttonUserRoleEdit.Enabled = false;
            buttonUserRoleDelete.Enabled = false;
            dataGridViewUserRoleAdd.Enabled = false;
            buttonUserRoleRefreshData.Enabled = false;

            var userPermitedList = (List<UserPermitEdit>)dataGridViewUserRoleEdit.DataSource;

            var resultUpdateBulk = await _webserviceOperations.UserPermitUpdateBulk(
                new UserPermitBulk
                {
                    upm_id_1 = userPermitedList[0].upm_id,
                    upm_select_1 = userPermitedList[0].upm_select,
                    upm_insert_1 = userPermitedList[0].upm_insert,
                    upm_update_1 = userPermitedList[0].upm_update,
                    upm_delete_1 = userPermitedList[0].upm_delete,
                    upm_id_2 = userPermitedList[1].upm_id,
                    upm_select_2 = userPermitedList[1].upm_select,
                    upm_insert_2 = userPermitedList[1].upm_insert,
                    upm_update_2 = userPermitedList[1].upm_update,
                    upm_delete_2 = userPermitedList[1].upm_delete,
                    upm_id_3 = userPermitedList[2].upm_id,
                    upm_select_3 = userPermitedList[2].upm_select,
                    upm_insert_3 = userPermitedList[2].upm_insert,
                    upm_update_3 = userPermitedList[2].upm_update,
                    upm_delete_3 = userPermitedList[2].upm_delete,
                    upm_id_4 = userPermitedList[3].upm_id,
                    upm_select_4 = userPermitedList[3].upm_select,
                    upm_insert_4 = userPermitedList[3].upm_insert,
                    upm_update_4 = userPermitedList[3].upm_update,
                    upm_delete_4 = userPermitedList[3].upm_delete,
                    upm_id_5 = userPermitedList[4].upm_id,
                    upm_select_5 = userPermitedList[4].upm_select,
                    upm_insert_5 = userPermitedList[4].upm_insert,
                    upm_update_5 = userPermitedList[4].upm_update,
                    upm_delete_5 = userPermitedList[4].upm_delete,
                    upm_id_6 = userPermitedList[5].upm_id,
                    upm_select_6 = userPermitedList[5].upm_select,
                    upm_insert_6 = userPermitedList[5].upm_insert,
                    upm_update_6 = userPermitedList[5].upm_update,
                    upm_delete_6 = userPermitedList[5].upm_delete,
                    upm_id_7 = userPermitedList[6].upm_id,
                    upm_select_7 = userPermitedList[6].upm_select,
                    upm_insert_7 = userPermitedList[6].upm_insert,
                    upm_update_7 = userPermitedList[6].upm_update,
                    upm_delete_7 = userPermitedList[6].upm_delete,
                    upm_id_8 = userPermitedList[7].upm_id,
                    upm_select_8 = userPermitedList[7].upm_select,
                    upm_insert_8 = userPermitedList[7].upm_insert,
                    upm_update_8 = userPermitedList[7].upm_update,
                    upm_delete_8 = userPermitedList[7].upm_delete,
                    upm_id_9 = userPermitedList[8].upm_id,
                    upm_select_9 = userPermitedList[8].upm_select,
                    upm_insert_9 = userPermitedList[8].upm_insert,
                    upm_update_9 = userPermitedList[8].upm_update,
                    upm_delete_9 = userPermitedList[8].upm_delete,
                    upm_audit_id = _activeUser.usr_audit,
                    upm_audit_date = DateTime.Now
                });

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultUpdateBulk.Item1, (resultUpdateBulk.Item2)));

            if (resultUpdateBulk.Item1)
            {
                var userRoleSelected = (UserRole)comboBoxUserRoleEdit.SelectedItem;

                var result = await _webserviceOperations.UserRoleGetAll(_activeUser.usr_id);

                _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

                if (result.Item1)
                {
                    _userRolesList.Clear();
                    _userRolesList.AddRange(result.Item3);
                    _RaiseUpdateUserRoles?.Invoke(this, _userRolesList);
                    BindUserRoleEdit();
                    dataGridViewUserRoleEdit.DataSource = null;
                }

                foreach (var item in comboBoxUserRoleEdit.Items)
                {
                    if(((UserRole)item).uro_id == userRoleSelected.uro_id)
                    {
                        comboBoxUserRoleEdit.SelectedItem = item;   
                    }
                }
                   
                //comboBoxStatusEdit_SelectedIndexChanged(null, null);

                    //El rol del usuaio activo actual se modifico el rol actualziar permisos
                if (((UserRole)comboBoxUserRoleEdit.SelectedItem).uro_id == _activeUser.usr_urol_id)
                {
                    var resultGetPermisison = await _webserviceOperations.UserPermitGetByRol(_activeUser.usr_urol_id);

                    if (resultGetPermisison.Item1)
                    {
                        _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGetPermisison.Item1, "Permisos Activos actualizados."));
                    }
                    else
                    {
                        _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGetPermisison.Item1, "Error al actualziar Permisos."));
                    }

                    if (resultGetPermisison.Item1)
                    {
                        _activePermit.Clear();
                        _activePermit.AddRange(resultGetPermisison.Item3);
                        _RaiseUpdateActiveRole?.Invoke(this, resultGetPermisison.Item3);
                    }
                }
            }

            comboBoxUserRoleEdit.Enabled = true;
            dataGridViewUserRoleEdit.Enabled = true;
            buttonUserRoleEdit.Enabled = true;
            buttonUserRoleDelete.Enabled = true;
            dataGridViewUserRoleAdd.Enabled = true;
            buttonUserRoleRefreshData.Enabled = true;
        }

        private async void buttonUserRoleDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxUserRoleEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error debe seleccionar un rol a editar."));
                return;
            }
            else if (((UserRole)comboBoxUserRoleEdit.SelectedItem).uro_id == (int)MagickInfo.ROLES.ADMIN_PRINCIPAL)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error el rol de Administrador no puede ser elimnado."));
                return;
            }
            else if (((UserRole)comboBoxUserRoleEdit.SelectedItem).uro_id == _activeUser.usr_urol_id)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error el rol del usuario actual no puede ser eliminado."));
                return;
            }
            else if (dataGridViewUserRoleEdit.DataSource == null || ((List<UserPermitEdit>)dataGridViewUserRoleEdit.DataSource).Count() < 9)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error permisos no cargados."));
                return;
            }
            else if (MessageBox.Show("¿Esta seguro de querer eliminar este Rol y Permisos?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            comboBoxUserRoleEdit.Enabled = false;
            dataGridViewUserRoleEdit.Enabled = false;
            buttonUserRoleEdit.Enabled = false;
            buttonUserRoleDelete.Enabled = false;
            dataGridViewUserRoleAdd.Enabled = false;
            buttonUserRoleRefreshData.Enabled = false;

            var userPermitedList = (List<UserPermitEdit>)dataGridViewUserRoleEdit.DataSource;

            var resultDeleteBulk = await _webserviceOperations.UserPermitDeleteBulk(
                new UserPermitBulk
                {
                    uro_id = ((UserRole)comboBoxUserRoleEdit.SelectedItem).uro_id,
                    upm_id_1 = userPermitedList[0].upm_id,
                    upm_id_2 = userPermitedList[1].upm_id,
                    upm_id_3 = userPermitedList[2].upm_id,
                    upm_id_4 = userPermitedList[3].upm_id,
                    upm_id_5 = userPermitedList[4].upm_id,
                    upm_id_6 = userPermitedList[5].upm_id,
                    upm_id_7 = userPermitedList[6].upm_id,
                    upm_id_8 = userPermitedList[7].upm_id,
                    upm_id_9 = userPermitedList[8].upm_id,
                    upm_audit_id = _activeUser.usr_id,
                    upm_audit_date = DateTime.Now
                });

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultDeleteBulk.Item1, resultDeleteBulk.Item2));

            if (resultDeleteBulk.Item1)
            {
                var resultGetRoles = await _webserviceOperations.UserRoleGetAll(_activeUser.usr_id);

                _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGetRoles.Item1, resultGetRoles.Item2));

                if (resultGetRoles.Item1)
                {
                    _userRolesList.Clear();
                    _userRolesList.AddRange(resultGetRoles.Item3);
                    _RaiseUpdateUserRoles?.Invoke(this, _userRolesList);
                    BindUserRoleEdit();
                    comboBoxUserRoleEdit.SelectedIndex = -1;
                    dataGridViewUserRoleEdit.DataSource = null;
                }
            }

            comboBoxUserRoleEdit.Enabled = true;
            dataGridViewUserRoleEdit.Enabled = true;
            buttonUserRoleEdit.Enabled = true;
            buttonUserRoleDelete.Enabled = true;
            dataGridViewUserRoleAdd.Enabled = true;
            buttonUserRoleRefreshData.Enabled = true;
        }

        private async void buttonUserRoleAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserRolesNameAdd.Text))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error debe ingresar un nombre de rol valido."));
                return;
            }
            else if (_userRolesList.Any(x => x.uro_name == textBoxUserRolesNameAdd.Text.Trim()))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error el nombre de rol ya existe."));
                return;
            }

            comboBoxUserRoleEdit.Enabled = false;
            dataGridViewUserRoleEdit.Enabled = false;
            buttonUserRoleEdit.Enabled = false;
            buttonUserRoleDelete.Enabled = false;
            dataGridViewUserRoleAdd.Enabled = false;
            buttonUserRoleRefreshData.Enabled = false;
            textBoxUserRolesNameAdd.Enabled = false;

            var userPermitAddList = (List<UserPermitAdd>)dataGridViewUserRoleAdd.DataSource;

            var resultUserPermitInsert = await _webserviceOperations.UserPermitInsertBulk(
                new UserPermitBulk
                {
                    uro_name = textBoxUserRolesNameAdd.Text,
                    upm_umd_1 = userPermitAddList[0].upm_umd_id,
                    upm_select_1 = userPermitAddList[0].upm_select,
                    upm_insert_1 = userPermitAddList[0].upm_insert,
                    upm_update_1 = userPermitAddList[0].upm_update,
                    upm_delete_1 = userPermitAddList[0].upm_delete,
                    upm_umd_2 = userPermitAddList[1].upm_umd_id,
                    upm_select_2 = userPermitAddList[1].upm_select,
                    upm_insert_2 = userPermitAddList[1].upm_insert,
                    upm_update_2 = userPermitAddList[1].upm_update,
                    upm_delete_2 = userPermitAddList[1].upm_delete,
                    upm_umd_3 = userPermitAddList[2].upm_umd_id,
                    upm_select_3 = userPermitAddList[2].upm_select,
                    upm_insert_3 = userPermitAddList[2].upm_insert,
                    upm_update_3 = userPermitAddList[2].upm_update,
                    upm_delete_3 = userPermitAddList[2].upm_delete,
                    upm_umd_4 = userPermitAddList[3].upm_umd_id,
                    upm_select_4 = userPermitAddList[3].upm_select,
                    upm_insert_4 = userPermitAddList[3].upm_insert,
                    upm_update_4 = userPermitAddList[3].upm_update,
                    upm_delete_4 = userPermitAddList[3].upm_delete,
                    upm_umd_5 = userPermitAddList[4].upm_umd_id,
                    upm_select_5 = userPermitAddList[4].upm_select,
                    upm_insert_5 = userPermitAddList[4].upm_insert,
                    upm_update_5 = userPermitAddList[4].upm_update,
                    upm_delete_5 = userPermitAddList[4].upm_delete,
                    upm_umd_6 = userPermitAddList[5].upm_umd_id,
                    upm_select_6 = userPermitAddList[5].upm_select,
                    upm_insert_6 = userPermitAddList[5].upm_insert,
                    upm_update_6 = userPermitAddList[5].upm_update,
                    upm_delete_6 = userPermitAddList[5].upm_delete,
                    upm_umd_7 = userPermitAddList[6].upm_umd_id,
                    upm_select_7 = userPermitAddList[6].upm_select,
                    upm_insert_7 = userPermitAddList[6].upm_insert,
                    upm_update_7 = userPermitAddList[6].upm_update,
                    upm_delete_7 = userPermitAddList[6].upm_delete,
                    upm_umd_8 = userPermitAddList[7].upm_umd_id,
                    upm_select_8 = userPermitAddList[7].upm_select,
                    upm_insert_8 = userPermitAddList[7].upm_insert,
                    upm_update_8 = userPermitAddList[7].upm_update,
                    upm_delete_8 = userPermitAddList[7].upm_delete,
                    upm_umd_9 = userPermitAddList[8].upm_umd_id,
                    upm_select_9 = userPermitAddList[8].upm_select,
                    upm_insert_9 = userPermitAddList[8].upm_insert,
                    upm_update_9 = userPermitAddList[8].upm_update,
                    upm_delete_9 = userPermitAddList[8].upm_delete,
                    upm_audit_id = _activeUser.usr_id,
                    upm_audit_date = DateTime.Now
                });

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultUserPermitInsert.Item1, resultUserPermitInsert.Item2));

            if (resultUserPermitInsert.Item1)
            {
                var resultGetRoles = await _webserviceOperations.UserRoleGetAll(_activeUser.usr_id);

                _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGetRoles.Item1, resultGetRoles.Item2));

                if (resultGetRoles.Item1)
                {
                    _userRolesList.Clear();
                    _userRolesList.AddRange(resultGetRoles.Item3);
                    _RaiseUpdateUserRoles?.Invoke(this, _userRolesList);
                    BindUserRoleEdit();
                    dataGridViewUserRoleEdit.DataSource = null;
                    textBoxUserRolesNameAdd.Text = string.Empty;
                    LoadDataGridViewUserPermitAdd();
                }
            }

            comboBoxUserRoleEdit.Enabled = true;
            dataGridViewUserRoleEdit.Enabled = true;
            buttonUserRoleEdit.Enabled = true;
            buttonUserRoleDelete.Enabled = true;
            dataGridViewUserRoleAdd.Enabled = true;
            buttonUserRoleRefreshData.Enabled = true;
            textBoxUserRolesNameAdd.Enabled = true;
        }

        private async void buttonUserRoleRefreshData_Click(object sender, EventArgs e)
        {
            comboBoxUserRoleEdit.Enabled = false;
            dataGridViewUserRoleEdit.Enabled = false;
            buttonUserRoleEdit.Enabled = false;
            buttonUserRoleDelete.Enabled = false;
            dataGridViewUserRoleAdd.Enabled = false;
            buttonUserRoleRefreshData.Enabled = false;
            textBoxUserRolesNameAdd.Enabled = false;

            var result = await _webserviceOperations.UserRoleGetAll(_activeUser.usr_id);

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                _userRolesList.Clear();
                _userRolesList.AddRange(result.Item3);
                _RaiseUpdateUserRoles?.Invoke(this, _userRolesList);
                BindUserRoleEdit();
                dataGridViewUserRoleEdit.DataSource = null;
            }

            comboBoxUserRoleEdit.Enabled = true;
            dataGridViewUserRoleEdit.Enabled = true;
            buttonUserRoleEdit.Enabled = true;
            buttonUserRoleDelete.Enabled = true;
            dataGridViewUserRoleAdd.Enabled = true;
            buttonUserRoleRefreshData.Enabled = true;
            textBoxUserRolesNameAdd.Enabled = true;
        }

        private class UserPermitEdit
        {
            public int upm_id { get; set; }
            public string upm_uro_name { get; set; }
            public string upm_umo_name { get; set; }
            public string upm_umd_name { get; set; }
            public bool upm_select { get; set; }
            public bool upm_insert { get; set; }
            public bool upm_update { get; set; }
            public bool upm_delete { get; set; }
        }

        private class UserPermitAdd
        {
            public string upm_umo_name { get; set; }
            public int upm_umd_id { get; set; }
            public string upm_umd_name { get; set; }
            public bool upm_select { get; set; }
            public bool upm_insert { get; set; }
            public bool upm_update { get; set; }
            public bool upm_delete { get; set; }
        }
    }
}
