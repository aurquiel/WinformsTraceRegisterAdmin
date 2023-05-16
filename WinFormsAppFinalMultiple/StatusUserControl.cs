using Accessibility;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class StatusUserControl : UserControl
    {
        private WebServiceOperation _webserviceOperations;
        private User _activeUser;
        private List<Status> _statusList;
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;
        private EventHandler<List<Status>> _RaiseUpdateStatus;

        private ToolTip buttonStatusEditTooltip = new ToolTip();
        private ToolTip buttonStatusDeleteTooltip = new ToolTip();
        private ToolTip buttonStatusAddTooltip = new ToolTip();
        private ToolTip buttonStatusRefreshDataTooltip = new ToolTip();

        public StatusUserControl(WebServiceOperation webserviceOperations,
            User activeUser, List<Status> statusList,
            UserPermit _activePermissionSection, 
            EventHandler<(bool, string)> RaiseRichTextInsertNewMessage,
            EventHandler<List<Status>> RaiseUpdateStatus)
        {
            InitializeComponent();
            _webserviceOperations = webserviceOperations;
            _activeUser = activeUser;
            _statusList = statusList;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;
            _RaiseUpdateStatus = RaiseUpdateStatus;

            ApplyPermissions(_activePermissionSection);
            BindStatusEdit();

            buttonStatusEditTooltip.SetToolTip(buttonStatusEdit, "Editar Estatus");
            buttonStatusDeleteTooltip.SetToolTip(buttonStatusDelete, "Eliminar Estatus");
            buttonStatusAddTooltip.SetToolTip(buttonStatusAdd, "Agregar Estatus");
            buttonStatusRefreshDataTooltip.SetToolTip(buttonStatusRefreshData, "Refrescar data del servidor en caso de error.");
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
                buttonStatusEdit.Hide();
            }

            if (activePermissionSection.upm_delete == false)
            {
                buttonStatusDelete.Hide();
            }

            if (activePermissionSection.upm_insert == false)
            {
                buttonStatusAdd.Hide();
            }

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Permisos de Usuario aplicados."));
        }

        private void BindStatusEdit()
        {
            comboBoxStatusEdit.SelectedIndexChanged -= new System.EventHandler(this.comboBoxStatusEdit_SelectedIndexChanged);
            comboBoxStatusEdit.DataSource = null;
            comboBoxStatusEdit.DataSource = _statusList;
            comboBoxStatusEdit.ValueMember = "sta_id";
            comboBoxStatusEdit.DisplayMember = "sta_description";
            comboBoxStatusEdit.SelectedIndex = -1;
            comboBoxStatusEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusEdit_SelectedIndexChanged);
        }

        private void comboBoxStatusEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatusEdit.SelectedIndex != -1)
            {
                textBoxStatusEditDescription.Text = ((Status)comboBoxStatusEdit.SelectedItem).sta_description;
            }
        }

        private async void buttonStatusEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStatusEditDescription.Text))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error campos invalidos."));
                return;
            }

            buttonStatusEdit.Enabled = false;
            buttonStatusDelete.Enabled = false;
            comboBoxStatusEdit.Enabled = false;
            textBoxStatusEditDescription.Enabled = false;

            var result = await _webserviceOperations.StatusPut(
                new Status
                {
                    sta_id = ((Status)comboBoxStatusEdit.SelectedItem).sta_id,
                    sta_description = textBoxStatusEditDescription.Text,
                    sta_audit_id = _activeUser.usr_id,
                    sta_audit_date = DateTime.Now,
                    sta_audit_delete = false
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (true, result.Item2));

            if (result.Item1)
            {

                await UpdateStatusList();
                BindStatusEdit();
                textBoxStatusEditDescription.Text = string.Empty;
            }

            buttonStatusEdit.Enabled = true;
            buttonStatusDelete.Enabled = true;
            comboBoxStatusEdit.Enabled = true;
            textBoxStatusEditDescription.Enabled = true;
        }

        private async Task<bool> UpdateStatusList()
        {
            var resultGeStatus = await _webserviceOperations.StatusGetAll();

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (resultGeStatus.Item1, resultGeStatus.Item2));

            if (resultGeStatus.Item1)
            {
                _statusList.Clear();
                _statusList.AddRange(resultGeStatus.Item3);
                _RaiseUpdateStatus?.Invoke(this, _statusList);
                return true;
            }
           
            return false;
        }

        private async void buttonStatusDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxStatusEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error debe seleccionar un estatus."));
                return;
            }

            buttonStatusEdit.Enabled = false;
            buttonStatusDelete.Enabled = false;
            comboBoxStatusEdit.Enabled = false;

            var result = await _webserviceOperations.StatusDelete(
                new Status
                {
                    sta_id = ((Status)comboBoxStatusEdit.SelectedItem).sta_id,
                    sta_audit_id = _activeUser.usr_id,
                    sta_audit_date = DateTime.Now
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (result.Item1, result.Item2));

            if (result.Item1)
            {
                await UpdateStatusList();
                BindStatusEdit();
                textBoxStatusEditDescription.Text = string.Empty;
            }

            buttonStatusEdit.Enabled = true;
            buttonStatusDelete.Enabled = true;
            comboBoxStatusEdit.Enabled = true;
        }

        private async void buttonStatusAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStatusAddDescription.Text))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error campos invalidos."));
                return;
            }

            buttonStatusAdd.Enabled = false;
            textBoxStatusAddDescription.Enabled = false;

            var result = await _webserviceOperations.StatusPost(
                new Status
                {
                    sta_description = textBoxStatusAddDescription.Text,
                    sta_audit_id = _activeUser.usr_id,
                    sta_audit_date = DateTime.Now,
                    sta_audit_delete = false
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (true, result.Item2));

            if (result.Item1)
            {
                await UpdateStatusList();
                BindStatusEdit();
                textBoxStatusAddDescription.Text = string.Empty;
            }

            buttonStatusAdd.Enabled = true;
            textBoxStatusAddDescription.Enabled = true;
        }

        private async void buttonStatusRefreshData_Click(object sender, EventArgs e)
        {
            buttonStatusRefreshData.Enabled = false;

            await UpdateStatusList();
            BindStatusEdit();

            buttonStatusRefreshData.Enabled = true;
        }

    }
}
