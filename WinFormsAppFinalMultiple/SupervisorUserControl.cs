using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class SupervisorUserControl : UserControl
    {
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;
        private EventHandler<List<Supervisor>> _RaiseUpdateSupervisor;

        private WebServiceOperation _webserviceOperations;
        private User _activeUser;
        private List<Supervisor> _supervisorList;

        private ToolTip buttonSupervisorEditTooltip = new ToolTip();
        private ToolTip buttonSupervisorDeleteTooltip = new ToolTip();
        private ToolTip buttonSupervisorAddTooltip = new ToolTip();
        private ToolTip buttonSupervisorRefreshDataTooltip = new ToolTip();

        public SupervisorUserControl(WebServiceOperation webserviceOperations, User activeUser,
            List<Supervisor> supervisorList, UserPermit _activePermissionSection,
            EventHandler<(bool, string)> RaiseRichTextInsertNewMessage,
            EventHandler<List<Supervisor>> RaiseUpdateSupervisor)
        {
            InitializeComponent();
            _webserviceOperations= webserviceOperations;
            _activeUser= activeUser;
            _supervisorList = supervisorList;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;
            _RaiseUpdateSupervisor = RaiseUpdateSupervisor;

            ApplyPermissions(_activePermissionSection);
            BindSupervisorEdit();

            buttonSupervisorEditTooltip.SetToolTip(buttonSupervisorEdit, "Editar Supervisor");
            buttonSupervisorDeleteTooltip.SetToolTip(buttonSupervisorDelete, "Eliminar Supervisor");
            buttonSupervisorAddTooltip.SetToolTip(buttonSupervisorAdd, "Agregar Supervisor");
            buttonSupervisorRefreshDataTooltip.SetToolTip(buttonSupervisorRefreshData, "Refrescar data del servidor en caso de error.");
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
                buttonSupervisorEdit.Hide();
            }

            if (activePermissionSection.upm_delete == false)
            {
                buttonSupervisorDelete.Hide();
            }

            if (activePermissionSection.upm_insert == false)
            {
                buttonSupervisorAdd.Hide();
            }

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Permisos de Usuario aplicados."));
        }

        private void BindSupervisorEdit()
        {
            comboBoxSupervisorEdit.SelectedIndexChanged -= new System.EventHandler(this.comboBoxSupervisorEdit_SelectedIndexChanged);
            comboBoxSupervisorEdit.DataSource = null;
            comboBoxSupervisorEdit.DataSource = _supervisorList.Where(x => x.sup_id != (int)MagickInfo.SUPERVISOR.ADMINISTRADOR).ToList();
            comboBoxSupervisorEdit.ValueMember = "sup_id";
            comboBoxSupervisorEdit.DisplayMember = "sup_description";
            comboBoxSupervisorEdit.SelectedIndex = -1;
            comboBoxSupervisorEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupervisorEdit_SelectedIndexChanged);
        }

        private void comboBoxSupervisorEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSupervisorEdit.SelectedIndex != -1)
            {
                textBoxSupervisorEditDescription.Text = ((Supervisor)comboBoxSupervisorEdit.SelectedItem).sup_description;
            }
        }
        private async void buttonSupervisorEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxSupervisorEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error debe seleccionar un estatus."));
                return;
            }

            if (string.IsNullOrEmpty(textBoxSupervisorEditDescription.Text))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error campos invalidos."));
                return;
            }

            buttonSupervisorEdit.Enabled = false;
            buttonSupervisorDelete.Enabled = false;
            comboBoxSupervisorEdit.Enabled = false;

            var result = await _webserviceOperations.SupervisorPut(
                new Supervisor
                {
                    sup_id = ((Supervisor)comboBoxSupervisorEdit.SelectedItem).sup_id,
                    sup_description = textBoxSupervisorEditDescription.Text,
                    sup_audit_id = _activeUser.usr_id,
                    sup_audit_date = DateTime.Now
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                await UpdateSupervisorList();
                BindSupervisorEdit();
                textBoxSupervisorEditDescription.Text = string.Empty;
            }

            buttonSupervisorEdit.Enabled = true;
            buttonSupervisorDelete.Enabled = true;
            comboBoxSupervisorEdit.Enabled = true;
        }
        private async Task<bool> UpdateSupervisorList()
        {
            var resultGeSupervisors = await _webserviceOperations.SupervisorGetAll();

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultGeSupervisors.Item1, resultGeSupervisors.Item2));

            if (resultGeSupervisors.Item1)
            {
                _supervisorList.Clear();
                _supervisorList.AddRange(resultGeSupervisors.Item3);
                _RaiseUpdateSupervisor?.Invoke(this, _supervisorList);
            }

            return true;
        }
        private async void buttonSupervisorDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxSupervisorEdit.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error debe seleccionar un estatus."));
                return;
            }

            buttonSupervisorEdit.Enabled = false;
            buttonSupervisorDelete.Enabled = false;
            comboBoxSupervisorEdit.Enabled = false;

            var result = await _webserviceOperations.SupervisorDelete(
                new Supervisor
                {
                    sup_id = ((Supervisor)comboBoxSupervisorEdit.SelectedItem).sup_id,
                    sup_audit_id = _activeUser.usr_id,
                    sup_audit_date = DateTime.Now,
                    sup_audit_delete = true
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (result.Item1, result.Item2));

            if (result.Item1)
            {
                await UpdateSupervisorList();
                BindSupervisorEdit();
                textBoxSupervisorEditDescription.Text = string.Empty;
            }

            buttonSupervisorEdit.Enabled = true;
            buttonSupervisorDelete.Enabled = true;
            comboBoxSupervisorEdit.Enabled = true;
        }
        private async void buttonSupervisorAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSupervisorAddDescription.Text))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new (false, "Error campos invalidos."));
                return;
            }

            buttonSupervisorAdd.Enabled = false;

            var result = await _webserviceOperations.SupervisorPost(
                new Supervisor
                {
                    sup_description = textBoxSupervisorAddDescription.Text,
                    sup_audit_id = _activeUser.usr_id,
                    sup_audit_date = DateTime.Now,
                    sup_audit_delete = false
                }
            );

            _RaiseRichTextInsertNewMessage?.Invoke(this, new (result.Item1, result.Item2));

            if (result.Item1)
            {
                
                await UpdateSupervisorList();
                BindSupervisorEdit();
                textBoxSupervisorAddDescription.Text = string.Empty;
            }

            buttonSupervisorAdd.Enabled = true;
        }
        private async void buttonSupervisorRefreshData_Click(object sender, EventArgs e)
        {
            buttonSupervisorRefreshData.Enabled = false;

            await UpdateSupervisorList();
            BindSupervisorEdit();

            buttonSupervisorRefreshData.Enabled = true;
        }

    }
}
