using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;
using System.Reflection;
using WinFormsAppTrazoRegistrosAdmin.Excel;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class RegisterSupervisorUserControl : UserControl
    {
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;

        private WebServiceOperation _webserviceOperations;
        private User _activeUser;
        private List<Store> _storeList;
        private List<Supervisor> _supervisorList;
        private List<StatusReport> _statusReportList;

        private ToolTip buttonbuttonSupervisorReportAddTooltip = new ToolTip();
        private ToolTip buttonbuttonSupervisorReportAddCleanTooltip = new ToolTip();
        private ToolTip buttonSupervisorReportEditConsultTooltip = new ToolTip();
        private ToolTip buttonSupervisorReportEditTooltip = new ToolTip();
        private ToolTip buttonSupervisorReportDeleteTooltip = new ToolTip();
        private ToolTip buttonSupervisorReportEditCleanTooltip = new ToolTip();
        private ToolTip buttonSupervisorReportEditExcelTooltip = new ToolTip();

        public RegisterSupervisorUserControl(WebServiceOperation webserviceOperations, User activeUser,
            List<Store> storeList, List<Supervisor> supervisorList, List<StatusReport> statusReportList,
            UserPermit _activePermissionSection,
            EventHandler<(bool, string)> RaiseRichTextInsertNewMessage)
        {
            InitializeComponent();
            _webserviceOperations = webserviceOperations;
            _activeUser = activeUser;
            _storeList = storeList;
            _supervisorList = supervisorList;
            _statusReportList = statusReportList;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;

            ApplyPermissions(_activePermissionSection);
            LoadComboBoxSUpervisorReportEdit();
            LoadDataGridViewAddSupervisorReport();

            buttonbuttonSupervisorReportAddTooltip.SetToolTip(buttonSupervisorReportAdd, "Agregar Reporte");
            buttonbuttonSupervisorReportAddCleanTooltip.SetToolTip(buttonbuttonSupervisorReportAddClean, "Limpiar Campos");
            buttonSupervisorReportEditConsultTooltip.SetToolTip(buttonSupervisorReportEditConsult, "Consultar Registros");
            buttonSupervisorReportEditTooltip.SetToolTip(buttonSupervisorReportEdit, "Editar Registros");
            buttonSupervisorReportDeleteTooltip.SetToolTip(buttonSupervisorReportDelete, "Eliminar Registros");
            buttonSupervisorReportEditCleanTooltip.SetToolTip(buttonSupervisorReportEditClean, "Limpiar Registros");
            buttonSupervisorReportEditExcelTooltip.SetToolTip(buttonSupervisorReportEditExcel, "Exportar Registros a Excel");

            dataGridViewSupervisorReportAdd.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridViewSupervisorReportAdd, true, null);
            dataGridViewSupervisorReportEdit.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridViewSupervisorReportEdit, true, null);
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
                buttonSupervisorReportEdit.Hide();
            }

            if (activePermissionSection.upm_delete == false)
            {
                buttonSupervisorReportDelete.Hide();
            }

            if (activePermissionSection.upm_insert == false)
            {
                buttonSupervisorReportAdd.Hide();
            }

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Permisos de Usuario aplicados."));
        }

        private void LoadComboBoxSUpervisorReportEdit()
        {
            comboBoxSupervisorReportEdit.DisplayMember = "sup_description";
            comboBoxSupervisorReportEdit.ValueMember = "sup_id";
            comboBoxSupervisorReportEdit.DataSource = _supervisorList.Where(x => x.sup_id != (int)MagickInfo.SUPERVISOR.ADMINISTRADOR).Select(x => x).ToList();
        }

        private List<ModelAddSupervisorReport> GetdataGridViewSupervisorReportAdd()
        {
            List<ModelAddSupervisorReport> list = new List<ModelAddSupervisorReport>();
            try
            {
                list.Add(new ModelAddSupervisorReport
                {
                    suprep_sup_id = _storeList.Where(x => x.sto_sup_id != (int)MagickInfo.SUPERVISOR.ADMINISTRADOR).ToList()[0].sto_sup_id,
                    suprep_date = DateTime.Now.Date,
                    suprep_sto_id = _storeList[0].sto_id,
                    suprep_in_dollar = 0,
                    suprep_out_dollar = 0,
                    suprep_in_euro = 0,
                    suprep_out_euro = 0,
                    suprep_in_peso = 0,
                    suprep_out_peso = 0,
                    suprep_comments = string.Empty,
                    suprep_starep_id = (int)MagickInfo.STATUS_REPORT.NO_PROCESADO
                });

                return list;
            }
            catch (Exception ex)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Excepcion: " + ex.Message.ToLower() + " .Funcion: GetdataGridViewSupervisorReportAdd()"));
                return new List<ModelAddSupervisorReport>();
            }
        }

        private void LoadDataGridViewAddSupervisorReport()
        {
            var reports = GetdataGridViewSupervisorReportAdd();

            var comboboxSupervisor = (DataGridViewComboBoxColumn)dataGridViewSupervisorReportAdd.Columns["dgvAddSupervisorReportColumnSupervisor"];
            comboboxSupervisor.DisplayMember = "sup_description";
            comboboxSupervisor.ValueMember = "sup_id";
            comboboxSupervisor.DataSource = _supervisorList.Where(x => x.sup_id != (int)MagickInfo.SUPERVISOR.ADMINISTRADOR).ToList();

            var comboboxStore = (DataGridViewComboBoxColumn)dataGridViewSupervisorReportAdd.Columns["dgvAddSupervisorReportColumnStore"];
            comboboxStore.DisplayMember = "sto_code";
            comboboxStore.ValueMember = "sto_id";
            comboboxStore.DataSource = _storeList;

            var comboboxStatusReport = (DataGridViewComboBoxColumn)dataGridViewSupervisorReportAdd.Columns["dgvAddSupervisorReportColumnStatusReport"];
            comboboxStatusReport.DisplayMember = "starep_description";
            comboboxStatusReport.ValueMember = "starep_id";
            comboboxStatusReport.DataSource = _statusReportList;

            dataGridViewSupervisorReportAdd.DataSource = reports;
        }

        private void dataGridViewSupervisorReportAdd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dataGridViewSupervisorReportAdd.DataSource != null && dataGridViewSupervisorReportAdd.Rows.Count > 0)
            {
                int sup_id = ((List<ModelAddSupervisorReport>)dataGridViewSupervisorReportAdd.DataSource)[0].suprep_sup_id;

                foreach (Supervisor item in comboBoxSupervisorReportEdit.Items)
                {
                    if (item.sup_id == sup_id)
                    {
                        comboBoxSupervisorReportEdit.SelectedItem = item;
                    }
                }
            }
        }

        private void dataGridViewSupervisorReportAdd_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewSupervisorReportAdd.IsCurrentCellDirty)
            {
                dataGridViewSupervisorReportAdd.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewSupervisorReportAdd_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
        }

        private async void buttonbuttonSupervisorReportAdd_Click(object sender, EventArgs e)
        {

            if (dataGridViewSupervisorReportAdd.DataSource == null || ((List<ModelAddSupervisorReport>)dataGridViewSupervisorReportAdd.DataSource).Count <= 0)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Data vacia"));
                return;
            }
            else if (!IsStoreAndSupervisorValid())
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Tienda no pertenece al supervisor"));
                return;
            }

            buttonSupervisorReportAdd.Enabled = false;

            List<SupervisorReport> listToAdd = new List<SupervisorReport>();
            List<ModelAddSupervisorReport> item = (List<ModelAddSupervisorReport>)dataGridViewSupervisorReportAdd.DataSource;
            listToAdd.Add(new SupervisorReport
            {
                suprep_sup_id = item[0].suprep_sup_id,
                suprep_date = item[0].suprep_date,
                suprep_sto_id = item[0].suprep_sto_id,
                suprep_in_dollar = item[0].suprep_in_dollar,
                suprep_out_dollar = item[0].suprep_out_dollar,
                suprep_in_euro = item[0].suprep_in_euro,
                suprep_out_euro = item[0].suprep_out_euro,
                suprep_in_peso = item[0].suprep_in_peso,
                suprep_out_peso = item[0].suprep_out_peso,
                suprep_comments = item[0].suprep_comments,
                suprep_starep_id = item[0].suprep_starep_id,
                suprep_audit_id = _activeUser.usr_id,
                suprep_audit_date = DateTime.Now,
                suprep_audit_delete = false
            });

            var resultInsertReport = await _webserviceOperations.SupervisorReportPost(listToAdd);

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultInsertReport.Item1, resultInsertReport.Item2));

            if (resultInsertReport.Item1)
            {
                LoadDataGridViewAddSupervisorReport();
            }

            buttonSupervisorReportAdd.Enabled = true;
        }

        private bool IsStoreAndSupervisorValid()
        {
            if (this._storeList.Any(s => s.sto_id == ((List<ModelAddSupervisorReport>)dataGridViewSupervisorReportAdd.DataSource)[0].suprep_sto_id &&
                    (s.sto_sup_id == ((List<ModelAddSupervisorReport>)dataGridViewSupervisorReportAdd.DataSource)[0].suprep_sup_id)))
            {
                return true;
            }
            else if (((List<ModelAddSupervisorReport>)dataGridViewSupervisorReportAdd.DataSource)[0].suprep_sto_id == (int)MagickInfo.STORE.ZERO)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonbuttonSupervisorReportAddClean_Click(object sender, EventArgs e)
        {
            LoadDataGridViewAddSupervisorReport();
        }

        private async void buttonSupervisorReportEditConsult_Click(object sender, EventArgs e)
        {
            buttonSupervisorReportEditConsult.Enabled = false;
            buttonSupervisorReportEdit.Enabled = false;
            buttonSupervisorReportDelete.Enabled = false;
            buttonSupervisorReportEditClean.Enabled = false;
            buttonSupervisorReportEditExcel.Enabled = false;
            comboBoxSupervisorReportEdit.Enabled = false;
            dateTimePickerSupervisorReportEdit.Enabled = false;

            var result = await _webserviceOperations.SupervisorReportGetByMonth(
                    ((Supervisor)comboBoxSupervisorReportEdit.SelectedItem).sup_id,
                    dateTimePickerSupervisorReportEdit.Value);

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                LoadEditSupervisorReport(result.Item3);
                CalculateTotales();
            }

            buttonSupervisorReportEditConsult.Enabled = true;
            buttonSupervisorReportEdit.Enabled = true;
            buttonSupervisorReportDelete.Enabled = true;
            buttonSupervisorReportEditClean.Enabled = true;
            buttonSupervisorReportEditExcel.Enabled = true;
            comboBoxSupervisorReportEdit.Enabled = true;
            dateTimePickerSupervisorReportEdit.Enabled = true;
        }

        private void LoadEditSupervisorReport(List<SupervisorReport> output)
        {
            var reports = GetEditSupervisorReport(output);

            var comboboxStatus = (DataGridViewComboBoxColumn)dataGridViewSupervisorReportEdit.Columns["dgvEditSupervisorReportColumnStore"];
            comboboxStatus.DisplayMember = "sto_code";
            comboboxStatus.ValueMember = "sto_id";
            comboboxStatus.DataSource = _storeList;

            var comboboxStatusReport = (DataGridViewComboBoxColumn)dataGridViewSupervisorReportEdit.Columns["dgvEditSupervisorReportColumnProcesado"];
            comboboxStatusReport.DisplayMember = "starep_description";
            comboboxStatusReport.ValueMember = "starep_id";
            comboboxStatusReport.DataSource = _statusReportList;

            dataGridViewSupervisorReportEdit.DataSource = reports;
        }

        private List<ModelEditSupervisorReport> GetEditSupervisorReport(List<SupervisorReport> output)
        {
            try
            {
                var list = new List<ModelEditSupervisorReport>();

                foreach (var item in output)
                {
                    list.Add(new ModelEditSupervisorReport
                    {
                        suprep_selection = false,
                        suprep_id = item.suprep_id,
                        suprep_date = item.suprep_date,
                        suprep_sup_description = this._supervisorList.Where(s => s.sup_id == item.suprep_sup_id).Select(d => d.sup_description).FirstOrDefault(),
                        suprep_sto_id = item.suprep_sto_id,
                        suprep_in_dollar = item.suprep_in_dollar,
                        suprep_out_dollar = item.suprep_out_dollar,
                        suprep_in_euro = item.suprep_in_euro,
                        suprep_out_euro = item.suprep_out_euro,
                        suprep_in_peso = item.suprep_in_peso,
                        suprep_out_peso = item.suprep_out_peso,
                        suprep_comments = item.suprep_comments,
                        suprep_starep_id = item.suprep_starep_id
                    });
                }

                return list;
            }
            catch (Exception ex)
            {
                return new List<ModelEditSupervisorReport>();
            }
        }

        private async void buttonSupervisorReportEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupervisorReportEdit.DataSource == null || dataGridViewSupervisorReportEdit.Rows.Count <= 0)
            {
                return;
            }

            buttonSupervisorReportEdit.Enabled = false;
            buttonSupervisorReportDelete.Enabled = false;
            buttonSupervisorReportEditClean.Enabled = false;
            buttonSupervisorReportEditExcel.Enabled = false;
            comboBoxSupervisorReportEdit.Enabled = false;
            dateTimePickerSupervisorReportEdit.Enabled = false;

            List<SupervisorReport> listToEdit = new List<SupervisorReport>();

            foreach (var item in (List<ModelEditSupervisorReport>)dataGridViewSupervisorReportEdit.DataSource)
            {
                if (item.suprep_selection == true)
                {
                    listToEdit.Add(
                        new SupervisorReport
                        {
                            suprep_id = item.suprep_id,
                            suprep_sup_id = _supervisorList.Where(s => s.sup_description == item.suprep_sup_description).Select(d => d.sup_id).FirstOrDefault(),
                            suprep_date = item.suprep_date,
                            suprep_sto_id = item.suprep_sto_id,
                            suprep_in_dollar = item.suprep_in_dollar,
                            suprep_out_dollar = item.suprep_out_dollar,
                            suprep_in_euro = item.suprep_in_euro,
                            suprep_out_euro = item.suprep_out_euro,
                            suprep_in_peso = item.suprep_in_peso,
                            suprep_out_peso = item.suprep_out_peso,
                            suprep_comments = item.suprep_comments,
                            suprep_starep_id = item.suprep_starep_id,
                            suprep_audit_id = _activeUser.usr_id,
                            suprep_audit_date = DateTime.Now,
                            suprep_audit_delete = false
                        });
                }
            }

            var resultUpdateReport = await _webserviceOperations.SupervisorReportPut(listToEdit);
            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultUpdateReport.Item1, resultUpdateReport.Item2));

            buttonSupervisorReportEditConsult_Click(null, null);

            buttonSupervisorReportEdit.Enabled = true;
            buttonSupervisorReportDelete.Enabled = true;
            buttonSupervisorReportEditClean.Enabled = true;
            buttonSupervisorReportEditExcel.Enabled = true;
            comboBoxSupervisorReportEdit.Enabled = true;
            dateTimePickerSupervisorReportEdit.Enabled = true;
        }

        private async void buttonSupervisorReportDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupervisorReportEdit.DataSource == null || dataGridViewSupervisorReportEdit.Rows.Count <= 0)
            {
                return;
            }

            if (MessageBox.Show("Por favor confirme antes de proceder" + "\n" + "¿Esta seguro de eliminar los registros seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            buttonSupervisorReportEdit.Enabled = false;
            buttonSupervisorReportDelete.Enabled = false;
            buttonSupervisorReportEditClean.Enabled = false;
            buttonSupervisorReportEditExcel.Enabled = false;
            comboBoxSupervisorReportEdit.Enabled = false;
            dateTimePickerSupervisorReportEdit.Enabled = false;

            List<SupervisorReport> listToDelete = new List<SupervisorReport>();

            foreach (var item in (List<ModelEditSupervisorReport>)dataGridViewSupervisorReportEdit.DataSource)
            {
                if (item.suprep_selection == true)
                {
                    listToDelete.Add(
                        new SupervisorReport
                        {
                            suprep_id = item.suprep_id,
                            suprep_audit_id = _activeUser.usr_id,
                            suprep_audit_date = DateTime.Now,
                            suprep_audit_delete = true
                        });
                }
            }

            var resultDeleteReport = await _webserviceOperations.SupervisorReportDelete(listToDelete);
            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultDeleteReport.Item1, resultDeleteReport.Item2));

            buttonSupervisorReportEditConsult_Click(null, null);

            buttonSupervisorReportEdit.Enabled = true;
            buttonSupervisorReportDelete.Enabled = true;
            buttonSupervisorReportEditClean.Enabled = true;
            buttonSupervisorReportEditExcel.Enabled = true;
            comboBoxSupervisorReportEdit.Enabled = true;
            dateTimePickerSupervisorReportEdit.Enabled = true;
        }

        private void buttonSupervisorReportEditClean_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupervisorReportEdit.DataSource != null && dataGridViewSupervisorReportEdit.Rows.Count > 0)
            {
                dataGridViewSupervisorReportEdit.DataSource = new List<ModelEditSupervisorReport>();
                dataGridViewSupervisorReportEdit.Refresh();
                CalculateTotales();
            }
        }

        private void CalculateTotales()
        {
            if (dataGridViewSupervisorReportEdit.DataSource == null || dataGridViewSupervisorReportEdit.Rows.Count <= 0)
            {
                labelSupervisorInDolares.Text = "0";
                labelSupervisorOutDolares.Text = "0";
                labelSupervisorDifferenceDolar.Text = "0";

                labelSupervisorInEuros.Text = "0";
                labelSupervisorOutEuros.Text = "0";
                labelSupervisorDifferenceEuros.Text = "0";

                labelSupervisorInPesos.Text = "0";
                labelSupervisorOutPesos.Text = "0";
                labelSupervisorDifferencePesos.Text = "0";

                return;
            }

            decimal inDolar = 0;
            decimal outDolar = 0;
            decimal differenceDolar = 0;

            decimal inEuro = 0;
            decimal outEuro = 0;
            decimal differenceEuro = 0;

            decimal inPeso = 0;
            decimal outPeso = 0;
            decimal differencePeso = 0;

            foreach (var item in (List<ModelEditSupervisorReport>)dataGridViewSupervisorReportEdit.DataSource)
            {
                inDolar += item.suprep_in_dollar;
                outDolar += item.suprep_out_dollar;

                inEuro += item.suprep_in_euro;
                outEuro += item.suprep_out_euro;

                inPeso += item.suprep_in_peso;
                outPeso += item.suprep_out_peso;
            }

            differenceDolar = inDolar - outDolar;
            differenceEuro = inEuro - outEuro;
            differencePeso = inPeso - outPeso;

            labelSupervisorInDolares.Text = inDolar.ToString("N2");
            labelSupervisorOutDolares.Text = outDolar.ToString("N2");
            labelSupervisorDifferenceDolar.Text = differenceDolar.ToString("N2");

            labelSupervisorInEuros.Text = inEuro.ToString("N2");
            labelSupervisorOutEuros.Text = outEuro.ToString();
            labelSupervisorDifferenceEuros.Text = differenceEuro.ToString("N2");

            labelSupervisorInPesos.Text = inPeso.ToString("N2");
            labelSupervisorOutPesos.Text = outPeso.ToString("N2");
            labelSupervisorDifferencePesos.Text = differencePeso.ToString("N2");
        }

        private async void buttonSupervisorReportEditExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupervisorReportEdit.DataSource == null || dataGridViewSupervisorReportEdit.Rows.Count <= 0)
            {
                return;
            }

            buttonSupervisorReportEdit.Enabled = false;
            buttonSupervisorReportDelete.Enabled = false;
            buttonSupervisorReportEditClean.Enabled = false;
            buttonSupervisorReportEditExcel.Enabled = false;
            comboBoxSupervisorReportEdit.Enabled = false;
            dateTimePickerSupervisorReportEdit.Enabled = false;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Title = "Save XLSX File";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "XLSX";
            saveFileDialog.Filter = "XLSX files (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var listExcelDTO = ((List<ModelEditSupervisorReport>)dataGridViewSupervisorReportEdit.DataSource).Select(x => new ExcelReportSupervisorDTO
                {
                    suprep_sup_description = x.suprep_sup_description,
                    suprep_date = x.suprep_date,
                    suprep_sto_code = _storeList.Where(d => d.sto_id == x.suprep_sto_id).Select(h => h.sto_code).FirstOrDefault(),
                    suprep_in_dollar = x.suprep_in_dollar,
                    suprep_out_dollar = x.suprep_out_dollar,
                    suprep_in_euro = x.suprep_in_euro,
                    suprep_out_euro = x.suprep_out_euro,
                    suprep_in_peso = x.suprep_in_peso,
                    suprep_out_peso = x.suprep_out_peso,
                    suprep_comments = x.suprep_comments,
                    suprep_starep_description = _statusReportList.Where(s => s.starep_id == x.suprep_starep_id).Select(d => d.starep_description).FirstOrDefault(),
                }).ToList();

                var result = await ManageExcel.CreateReportSupervisor(listExcelDTO, GetTotalesExcel(listExcelDTO), saveFileDialog.FileName);

                _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            }

            buttonSupervisorReportEdit.Enabled = true;
            buttonSupervisorReportDelete.Enabled = true;
            buttonSupervisorReportEditClean.Enabled = true;
            buttonSupervisorReportEditExcel.Enabled = true;
            comboBoxSupervisorReportEdit.Enabled = true;
            dateTimePickerSupervisorReportEdit.Enabled = true;
        }

        private ExcelReportSupervisorTotalDTO GetTotalesExcel(List<ExcelReportSupervisorDTO> listExcelDTO)
        {
            ExcelReportSupervisorTotalDTO itemTotal = new ExcelReportSupervisorTotalDTO();
            foreach (var item in listExcelDTO)
            {
                itemTotal.total_suprep_in_dollar += item.suprep_in_dollar;
                itemTotal.total_suprep_out_dollar += item.suprep_out_dollar;
                itemTotal.total_suprep_in_euro += item.suprep_in_euro;
                itemTotal.total_suprep_out_euro += item.suprep_out_euro;
                itemTotal.total_suprep_in_peso += item.suprep_in_peso;
                itemTotal.total_suprep_out_peso += item.suprep_out_peso;
            }

            return itemTotal;
        }

        private bool flagCommentSize = false;
        private void dataGridViewSupervisorReportEdit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 11 && flagCommentSize == false)
            {
                dataGridViewSupervisorReportEdit.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                flagCommentSize = true;
            }
            else if (e.ColumnIndex == 11)
            {
                dataGridViewSupervisorReportEdit.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                dataGridViewSupervisorReportEdit.Columns[11].Width = 200;
                flagCommentSize = false;
            }
        }
    }
}
