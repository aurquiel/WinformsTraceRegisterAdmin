using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class StoreUserControl : UserControl
    {
        private WebServiceOperation _webserviceOperations;
        private User _activeUser;
        private List<Store> _storeList;
        private List<Supervisor> _supervisorList;
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;
        private EventHandler<List<Store>> _RaiseUpdateStore;

        private ToolTip buttonStoreEditTooltip = new ToolTip();
        private ToolTip buttonStoreDeleteTooltip = new ToolTip();
        private ToolTip buttonStoreAddTooltip = new ToolTip();
        private ToolTip buttonStoreRefreshDataTooltip = new ToolTip();

        public StoreUserControl(WebServiceOperation webserviceOperations, User activeUser,
            List<Store> storeList, List<Supervisor> supervisorList,
            UserPermit _activePermissionSection,
            EventHandler<(bool, string)> RaiseRichTextInsertNewMessage,
            EventHandler<List<Store>> RaiseUpdateStore)
        {
            InitializeComponent();

            _webserviceOperations = webserviceOperations;
            _activeUser = activeUser;
            _storeList = storeList;
            _supervisorList = supervisorList;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;
            _RaiseUpdateStore = RaiseUpdateStore;

            ApplyPermissions(_activePermissionSection);
            BindStoresEdit();
            BindSupervisorsEdit();
            BindSupervisorsAdd();

            buttonStoreEditTooltip.SetToolTip(buttonStoreEdit, "Editar Tienda");
            buttonStoreDeleteTooltip.SetToolTip(buttonStoreDelete, "Eliminar Tienda");
            buttonStoreAddTooltip.SetToolTip(buttonStoreAdd, "Agregar Tienda");
            buttonStoreRefreshDataTooltip.SetToolTip(buttonStoreRefreshData, "Refrescar data del servidor en caso de error.");
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
                buttonStoreEdit.Hide();
            }

            if (activePermissionSection.upm_delete == false)
            {
                buttonStoreDelete.Hide();
            }

            if (activePermissionSection.upm_insert == false)
            {
                buttonStoreAdd.Hide();
            }

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Permisos de Usuario aplicados."));
        }

        private void BindStoresEdit()
        {
            comboBoxStoreEdit.SelectedIndexChanged -= new System.EventHandler(this.comboBoxStoreEdit_SelectedIndexChanged);
            comboBoxStoreEdit.DataSource = null;
            comboBoxStoreEdit.DataSource = _storeList.Where(x => x.sto_id != (int)MagickInfo.STORE.ZERO).ToList();
            comboBoxStoreEdit.ValueMember = "sto_id";
            comboBoxStoreEdit.DisplayMember = "sto_code";
            comboBoxStoreEdit.SelectedIndex = -1;
            comboBoxStoreEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxStoreEdit_SelectedIndexChanged);
        }

        private void BindSupervisorsEdit()
        {
            comboBoxStoreEditSupervisor.DataSource = null;
            comboBoxStoreEditSupervisor.DataSource = _supervisorList.Where(x => x.sup_id != (int)MagickInfo.SUPERVISOR.ADMINISTRADOR).ToList();
            comboBoxStoreEditSupervisor.ValueMember = "sup_id";
            comboBoxStoreEditSupervisor.DisplayMember = "sup_description";
            comboBoxStoreEditSupervisor.SelectedIndex = -1;
        }

        private void BindSupervisorsAdd()
        {
            comboBoxStoreAddSupervisor.DataSource = null;
            comboBoxStoreAddSupervisor.DataSource = _supervisorList.Where(x => x.sup_id != (int)MagickInfo.SUPERVISOR.ADMINISTRADOR).ToList();
            comboBoxStoreAddSupervisor.ValueMember = "sup_id";
            comboBoxStoreAddSupervisor.DisplayMember = "sup_description";
            comboBoxStoreAddSupervisor.SelectedIndex = -1;
        }

        private void comboBoxStoreEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStoreEdit.SelectedIndex != -1)
            {
                textBoxStoreEditCode.Text = ((Store)comboBoxStoreEdit.SelectedItem).sto_code.ToString();
                foreach (Supervisor item in comboBoxStoreEditSupervisor.Items)
                {
                    if (item.sup_id == ((Store)comboBoxStoreEdit.SelectedItem).sto_sup_id)
                    {
                        comboBoxStoreEditSupervisor.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        private async void buttonStoreEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxStoreEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error debe seleccionar una tienda."));
                return;
            }

            if (string.IsNullOrEmpty(textBoxStoreEditCode.Text) || comboBoxStoreEditSupervisor.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error campos invalidos."));
                return;
            }

            buttonStoreEdit.Enabled = false;
            buttonStoreDelete.Enabled = false;
            comboBoxStoreEdit.Enabled = false;
            comboBoxStoreEditSupervisor.Enabled = false;
            textBoxStoreEditCode.Enabled = false;

            var result = await _webserviceOperations.StorePut(
                new Store
                {
                    sto_id = ((Store)comboBoxStoreEdit.SelectedItem).sto_id,
                    sto_code = Int32.Parse(textBoxStoreEditCode.Text),
                    sto_sup_id = ((Supervisor)comboBoxStoreEditSupervisor.SelectedItem).sup_id,
                    sto_audit_id = _activeUser.usr_id,
                    sto_audit_date = DateTime.Now
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                await UpdateStoreList();
                BindStoresEdit();
                textBoxStoreEditCode.Text = string.Empty;
                comboBoxStoreEditSupervisor.SelectedIndex = -1;
            }

            buttonStoreEdit.Enabled = true;
            buttonStoreDelete.Enabled = true;
            comboBoxStoreEdit.Enabled = true;
            comboBoxStoreEditSupervisor.Enabled = true;
            textBoxStoreEditCode.Enabled = true;
        }

        private async Task<bool> UpdateStoreList()
        {
            var resultGeStores = await _webserviceOperations.StoreGetAll();

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGeStores.Item1, resultGeStores.Item2));

            if (resultGeStores.Item1)
            {
                _storeList.Clear();
                _storeList.AddRange(resultGeStores.Item3);
                _RaiseUpdateStore?.Invoke(this, _storeList);
                return true;
            }

            return false;
        }

        private async void buttonStoreDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxStoreEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error debe seleccionar una tienda."));
                return;
            }

            buttonStoreEdit.Enabled = false;
            buttonStoreDelete.Enabled = false;
            comboBoxStoreEdit.Enabled = false;
            comboBoxStoreEditSupervisor.Enabled = false;
            textBoxStoreEditCode.Enabled = false;

            var result = await _webserviceOperations.StoreDelete(
                new Store
                {
                    sto_id = ((Store)comboBoxStoreEdit.SelectedItem).sto_id,
                    sto_audit_id = _activeUser.usr_id,
                    sto_audit_date = DateTime.Now
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                await UpdateStoreList();
                BindStoresEdit();
                textBoxStoreEditCode.Text = string.Empty;
                comboBoxStoreEditSupervisor.SelectedIndex = -1;
            }

            buttonStoreEdit.Enabled = true;
            buttonStoreDelete.Enabled = true;
            comboBoxStoreEdit.Enabled = true;
            comboBoxStoreEditSupervisor.Enabled = true;
            textBoxStoreEditCode.Enabled = true;
        }

        private async void buttonStoreAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStoreAddCode.Text) || comboBoxStoreAddSupervisor.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error campos invalidos."));
                return;
            }

            buttonStoreAdd.Enabled = false;
            textBoxStoreAddCode.Enabled = false;
            comboBoxStoreAddSupervisor.Enabled = false;

            var result = await _webserviceOperations.StorePost(
                new Store
                {
                    sto_code = Int32.Parse(textBoxStoreAddCode.Text),
                    sto_sup_id = ((Supervisor)comboBoxStoreAddSupervisor.SelectedItem).sup_id,
                    sto_audit_id = _activeUser.usr_id,
                    sto_audit_date = DateTime.Now,
                    sto_audit_delete = false
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                await UpdateStoreList();
                BindStoresEdit();
                textBoxStoreAddCode.Text = string.Empty;
                comboBoxStoreAddSupervisor.SelectedIndex = -1;
            }

            buttonStoreAdd.Enabled = true;
            textBoxStoreAddCode.Enabled = true;
            comboBoxStoreAddSupervisor.Enabled = true;
        }

        private async void buttonStoreRefreshData_Click(object sender, EventArgs e)
        {
            buttonStoreRefreshData.Enabled = false;
            await UpdateStoreList();
            BindStoresEdit();
            buttonStoreRefreshData.Enabled = true;
        }

        private void textBoxStoreEditCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxStoreAddCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
