using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;
using System.Reflection;
using WinFormsAppTrazoRegistrosAdmin.Excel;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class RegisterStoreUserControl : UserControl
    {
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;

        private WebServiceOperation _webserviceOperations;
        private User _activeUser;
        private List<Store> _storeList;
        private List<Supervisor> _supervisorList;
        private List<User> _userList;
        private List<Status> _statusList;
        private List<StatusReport> _statusReportList;

        private ToolTip buttonbuttonStoreReportAddTooltip = new ToolTip();
        private ToolTip buttonbuttonStoreReportAddCleanTooltip = new ToolTip();
        private ToolTip buttonStoreReportEditConsultTooltip = new ToolTip();
        private ToolTip buttonStoreReportEditTooltip = new ToolTip();
        private ToolTip buttonStoreReportDeleteTooltip = new ToolTip();
        private ToolTip buttonStoreReportEditCloseMonthTooltip = new ToolTip();
        private ToolTip buttonStoreReportEditCleanTooltip = new ToolTip();
        private ToolTip buttonStoreReportEditExcelTooltip = new ToolTip();

        public RegisterStoreUserControl(WebServiceOperation webserviceOperations, User activeUser,
            List<Store> storeList, List<Supervisor> supervisorList, List<Status> statusList,
            List<StatusReport> statusReportList, UserPermit _activePermissionSection,
            EventHandler<(bool, string)> RaiseRichTextInsertNewMessage)
        {
            InitializeComponent();

            _webserviceOperations = webserviceOperations;
            _activeUser = activeUser;
            _storeList = storeList;
            _supervisorList = supervisorList;
            _statusList = statusList;
            _statusReportList = statusReportList;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;

            ApplyPermissions(_activePermissionSection);
            LoadComboBoxStoreReportEdit();
            LoadDataGridViewAddStoreReport();

            buttonbuttonStoreReportAddTooltip.SetToolTip(buttonbuttonStoreReportAdd, "Agregar Reporte");
            buttonbuttonStoreReportAddCleanTooltip.SetToolTip(buttonbuttonStoreReportAddClean, "Limpiar Campos");
            buttonStoreReportEditConsultTooltip.SetToolTip(buttonStoreReportEditConsult, "Consultar Registros");
            buttonStoreReportEditTooltip.SetToolTip(buttonStoreReportEdit, "Editar Registros");
            buttonStoreReportDeleteTooltip.SetToolTip(buttonStoreReportDelete, "Eliminar Registros");
            buttonStoreReportEditCloseMonthTooltip.SetToolTip(buttonStoreReportEditCloseMonth, "Cerrar Mes");
            buttonStoreReportEditCleanTooltip.SetToolTip(buttonStoreReportEditClean, "Limpiar Registros");
            buttonStoreReportEditExcelTooltip.SetToolTip(buttonStoreReportEditExcel, "Exportar Registros a Excel");

            dataGridViewStoreReportAdd.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridViewStoreReportAdd, true, null);
            dataGridViewStoreReportEdit.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridViewStoreReportEdit, true, null);

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
                buttonStoreReportEdit.Hide();
                buttonStoreReportEditCloseMonth.Hide();
            }

            if (activePermissionSection.upm_delete == false)
            {
                buttonStoreReportDelete.Hide();
            }

            if (activePermissionSection.upm_insert == false)
            {
                buttonbuttonStoreReportAdd.Hide();
            }

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Permisos de Usuario aplicados."));
        }

        private void LoadComboBoxStoreReportEdit()
        {
            comboBoxStoreReportEdit.DisplayMember = "sto_code";
            comboBoxStoreReportEdit.ValueMember = "sto_id";
            comboBoxStoreReportEdit.DataSource = _storeList.Where(x => x.sto_id != (int)MagickInfo.STORE.ZERO).Select(x => x).ToList();
        }

        private List<ModelAddStoreReport> GetDataGridViewStoreReportAdd()
        {
            List<ModelAddStoreReport> list = new List<ModelAddStoreReport>();
            try
            {
                list.Add(new ModelAddStoreReport
                {
                    storep_sto_id = _storeList.Where(x => x.sto_id != (int)MagickInfo.STORE.ZERO).Select(x => x.sto_id).FirstOrDefault(),
                    storep_date = DateTime.Now.Date,
                    storep_total_bs = 0,
                    storep_change_bs = 0,
                    storep_rate = 1,
                    storep_equivalent_dollar = 0,
                    storep_payed_zelle = 0,
                    storep_payed_dollar = 0,
                    storep_expended_dollar = 0,
                    storep_total_dollar = 0,
                    storep_sta_id = _statusList.Select(x => x.sta_id).FirstOrDefault(),
                    storep_supervisor = _supervisorList.Where(x => x.sup_id == _storeList.Where(a => a.sto_sup_id == x.sup_id).Select(s => s.sto_sup_id).FirstOrDefault()).Select(t => t.sup_description).FirstOrDefault(),
                    storep_comments = string.Empty,
                    storep_starep_id = _statusReportList.Select(x => x.starep_id).FirstOrDefault(),
                });

                return list;
            }
            catch (Exception ex)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Excepcion: " + ex.Message.ToLower() + " .Funcion: GetDataGridViewStoreReportAdd()"));
                return new List<ModelAddStoreReport>();
            }
        }

        private void LoadDataGridViewAddStoreReport()
        {
            this.dataGridViewStoreReportAdd.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStoreReportAdd_CellValueChanged);

            var reports = GetDataGridViewStoreReportAdd();

            var comboboxStore = (DataGridViewComboBoxColumn)dataGridViewStoreReportAdd.Columns["dgvAddStoreReportColumnStoreCode"];
            comboboxStore.DisplayMember = "sto_code";
            comboboxStore.ValueMember = "sto_id";
            comboboxStore.DataSource = _storeList.Where(x => x.sto_id != (int)MagickInfo.STORE.ZERO).Select(x => x).ToList();

            var comboboxStatus = (DataGridViewComboBoxColumn)dataGridViewStoreReportAdd.Columns["dgvAddStoreReportColumnStatus"];
            comboboxStatus.DisplayMember = "sta_description";
            comboboxStatus.ValueMember = "sta_id";
            comboboxStatus.DataSource = _statusList;

            var comboboxStatusReport = (DataGridViewComboBoxColumn)dataGridViewStoreReportAdd.Columns["dgvAddStoreReportColumnStatusReport"];
            comboboxStatusReport.DisplayMember = "starep_description";
            comboboxStatusReport.ValueMember = "starep_id";
            comboboxStatusReport.DataSource = _statusReportList;

            dataGridViewStoreReportAdd.DataSource = reports;

            this.dataGridViewStoreReportAdd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStoreReportAdd_CellValueChanged);
            dataGridViewStoreReportAdd_CellValueChanged(dataGridViewStoreReportAdd, new DataGridViewCellEventArgs(0, 0));
        }

        private void dataGridViewStoreReportAdd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dataGridViewStoreReportAdd.DataSource != null)
            {
                int sto_id = ((List<ModelAddStoreReport>)dataGridViewStoreReportAdd.DataSource)[0].storep_sto_id;
                int sup_id = _storeList.Where(s => s.sto_id == sto_id).Select(d => d.sto_sup_id).FirstOrDefault();
                ((List<ModelAddStoreReport>)dataGridViewStoreReportAdd.DataSource)[0].storep_supervisor = this._supervisorList.Where(s => s.sup_id == sup_id).Select(d => d.sup_description).FirstOrDefault();
                dataGridViewStoreReportAdd.Refresh();

                foreach (Store item in comboBoxStoreReportEdit.Items)
                {
                    if (item.sto_id == sto_id)
                    {
                        comboBoxStoreReportEdit.SelectedItem = item;
                    }
                }
            }
            else if ((e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 9) && dataGridViewStoreReportAdd.DataSource != null)
            {
                decimal totalFacturado = Decimal.Parse(dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[2].Value.ToString());
                decimal cambioBs = Decimal.Parse(dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[3].Value.ToString());
                decimal tasa = Decimal.Parse(dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[4].Value.ToString());
                decimal euros = Decimal.Parse(dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[6].Value.ToString());
                decimal zelle = Decimal.Parse(dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[7].Value.ToString());
                decimal gastos = Decimal.Parse(dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[9].Value.ToString());
                decimal equivalente = 0;
                decimal dolares = 0;

                if (totalFacturado != 0 && tasa != 0)
                {
                    equivalente = totalFacturado / tasa;
                    dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[5].Value = decimal.Round(equivalente, 2, MidpointRounding.AwayFromZero); //Equivalente Bs
                }

                if (cambioBs != 0 && tasa != 0)
                {
                    equivalente = cambioBs / tasa;
                    dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[5].Value = decimal.Round(equivalente, 2, MidpointRounding.AwayFromZero); //Equivalente Bs
                }

                try
                {
                    dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[8].Value = dolares = decimal.Round(equivalente - euros - zelle, 2, MidpointRounding.AwayFromZero); //Dolar
                    dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[10].Value = decimal.Round(euros + dolares - gastos, 2, MidpointRounding.AwayFromZero); //Resta Efectivo
                }
                catch
                {
                    dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[8].Value = decimal.Round(0 - euros, 2, MidpointRounding.AwayFromZero); //Dolar
                    dataGridViewStoreReportAdd.Rows[e.RowIndex].Cells[10].Value = decimal.Round(0 - gastos, 2, MidpointRounding.AwayFromZero); //Resta Efectivo
                }
                dataGridViewStoreReportAdd.Refresh();
            }
        }

        private void dataGridViewStoreReportAdd_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewStoreReportAdd.IsCurrentCellDirty)
            {
                dataGridViewStoreReportAdd.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewStoreReportAdd_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
        }

        private async void buttonbuttonStoreReportAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewStoreReportAdd.DataSource == null || ((List<ModelAddStoreReport>)dataGridViewStoreReportAdd.DataSource).Count <= 0)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Data Invalida"));
                return;
            }

            buttonbuttonStoreReportAdd.Enabled = false;

            List<ModelAddStoreReport> item = (List<ModelAddStoreReport>)dataGridViewStoreReportAdd.DataSource;

            var result = await _webserviceOperations.StoreReportPost(
                new List<StoreReport>{
                    new StoreReport
                    {
                        storep_sto_id = item[0].storep_sto_id,
                        storep_date = item[0].storep_date,
                        storep_total_bs = item[0].storep_total_bs,
                        storep_change_bs = item[0].storep_change_bs,
                        storep_rate = item[0].storep_rate,
                        storep_equivalent_dollar = item[0].storep_equivalent_dollar,
                        storep_payed_euro = item[0].storep_payed_euro,
                        storep_payed_zelle = item[0].storep_payed_zelle,
                        storep_payed_dollar = item[0].storep_payed_dollar,
                        storep_expended_dollar = item[0].storep_expended_dollar,
                        storep_total_dollar = item[0].storep_total_dollar,
                        storep_sta_id = item[0].storep_sta_id,
                        storep_sup_id = this._supervisorList.Where(s => s.sup_description == item[0].storep_supervisor).Select(g => g.sup_id).FirstOrDefault(),
                        storep_comments = item[0].storep_comments == null ? string.Empty : item[0].storep_comments,
                        storep_starep_id = item[0].storep_starep_id,
                        storep_audit_id = this._activeUser.usr_id,
                        storep_audit_date = DateTime.Now,
                        storep_audit_delete = false
                    }
                });

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                LoadDataGridViewAddStoreReport();
            }

            buttonbuttonStoreReportAdd.Enabled = true;
        }

        private void buttonbuttonStoreReportAddClean_Click(object sender, EventArgs e)
        {
            LoadDataGridViewAddStoreReport();
        }

        private async void buttonStoreReportEditConsult_Click(object sender, EventArgs e)
        {
            buttonStoreReportEditConsult.Enabled = false;
            buttonStoreReportEdit.Enabled = false;
            buttonStoreReportDelete.Enabled = false;
            buttonStoreReportEditCloseMonth.Enabled = false;
            buttonStoreReportEditClean.Enabled = false;
            buttonStoreReportEditExcel.Enabled = false;
            comboBoxStoreReportEdit.Enabled = false;
            dateTimePickerStoreReportEdit.Enabled = false;

            var result = await _webserviceOperations.StoreReportGetByMonth(
                ((Store)comboBoxStoreReportEdit.SelectedItem).sto_id,
                dateTimePickerStoreReportEdit.Value);

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                LoadEditStoreReport(result.Item3);
                CalculateTotales();

            }
            buttonStoreReportEditConsult.Enabled = true;
            buttonStoreReportEdit.Enabled = true;
            buttonStoreReportDelete.Enabled = true;
            buttonStoreReportEditCloseMonth.Enabled = true;
            buttonStoreReportEditClean.Enabled = true;
            buttonStoreReportEditExcel.Enabled = true;
            comboBoxStoreReportEdit.Enabled = true;
            dateTimePickerStoreReportEdit.Enabled = true;
        }

        private void LoadEditStoreReport(List<StoreReport> output)
        {
            var reports = GetEditStoreReport(output);

            var comboboxStatus = (DataGridViewComboBoxColumn)dataGridViewStoreReportEdit.Columns["dgvEditStoreReportColumnStatus"];
            comboboxStatus.DisplayMember = "sta_description";
            comboboxStatus.ValueMember = "sta_id";
            comboboxStatus.DataSource = _statusList;

            var comboboxStatusReport = (DataGridViewComboBoxColumn)dataGridViewStoreReportEdit.Columns["dgvEditStoreReportColumnEstatusProcesado"];
            comboboxStatusReport.DisplayMember = "starep_description";
            comboboxStatusReport.ValueMember = "starep_id";
            comboboxStatusReport.DataSource = _statusReportList;

            dataGridViewStoreReportEdit.DataSource = reports;
        }

        private List<ModelEditStoreReport> GetEditStoreReport(List<StoreReport> output)
        {
            try
            {
                var list = new List<ModelEditStoreReport>();

                foreach (var item in output)
                {
                    list.Add(new ModelEditStoreReport
                    {
                        storep_selection = false,
                        storep_id = item.storep_id,
                        storep_code = _storeList.Where(x => x.sto_id == item.storep_sto_id).Select(x => x.sto_code).FirstOrDefault(),
                        storep_date = item.storep_date.Date,
                        storep_total_bs = item.storep_total_bs,
                        storep_change_bs = item.storep_change_bs,
                        storep_rate = item.storep_rate,
                        storep_equivalent_dollar = item.storep_equivalent_dollar,
                        storep_payed_euro = item.storep_payed_euro,
                        storep_payed_zelle = item.storep_payed_zelle,
                        storep_payed_dollar = item.storep_payed_dollar,
                        storep_expended_dollar = item.storep_expended_dollar,
                        storep_total_dollar = item.storep_total_dollar,
                        storep_sta_id = item.storep_sta_id,
                        storep_supervisor = this._supervisorList.Where(s => s.sup_id == item.storep_sup_id).Select(g => g.sup_description).FirstOrDefault(),
                        storep_comments = item.storep_comments == null ? string.Empty : item.storep_comments,
                        storep_starep_id = item.storep_starep_id
                    });
                }

                return list;
            }
            catch (Exception ex)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Excepcion: " + ex.Message.ToLower() + " .Funcion: GetEditStoreReport()"));
                return new List<ModelEditStoreReport>();
            }
        }

        private void CalculateTotales()
        {
            if (dataGridViewStoreReportEdit.DataSource == null || dataGridViewStoreReportEdit.Rows.Count <= 0)
            {
                labelStoreTotalFacturado.Text = "0";
                labelStoreCambioBs.Text = "0";
                labelStoreEquivalente.Text = "0";
                labelStoreEuros.Text = "0";
                labelStoreZelle.Text = "0";
                labelStoreDolares.Text = "0";
                labelStoreGastos.Text = "0";
                labelStoreRestaEfectivo.Text = "0";

                return;
            }

            decimal totalFacturado = 0;
            decimal cambioBs = 0;
            decimal equivalente = 0;
            decimal euros = 0;
            decimal zelle = 0;
            decimal dolares = 0;
            decimal gastos = 0;
            decimal restaEfectivo = 0;

            foreach (var item in (List<ModelEditStoreReport>)dataGridViewStoreReportEdit.DataSource)
            {
                totalFacturado += item.storep_total_bs;
                cambioBs += item.storep_change_bs;
                equivalente += item.storep_equivalent_dollar;
                euros += item.storep_payed_euro;
                zelle += item.storep_payed_zelle;
                dolares += item.storep_payed_dollar;
                gastos += item.storep_expended_dollar;
                restaEfectivo += item.storep_total_dollar;
            }

            labelStoreTotalFacturado.Text = totalFacturado.ToString("N2");
            labelStoreCambioBs.Text = cambioBs.ToString("N2");
            labelStoreEquivalente.Text = equivalente.ToString("N2");
            labelStoreEuros.Text = euros.ToString("N2");
            labelStoreZelle.Text = zelle.ToString("N2");
            labelStoreDolares.Text = dolares.ToString("N2");
            labelStoreGastos.Text = gastos.ToString("N2");
            labelStoreRestaEfectivo.Text = restaEfectivo.ToString("N2");
        }

        private void dataGridViewStoreReportEdit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 11) && dataGridViewStoreReportEdit.DataSource != null)
            {
                decimal totalFacturado = Decimal.Parse(dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[4].Value.ToString());
                decimal cambioBs = Decimal.Parse(dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[5].Value.ToString());
                decimal tasa = Decimal.Parse(dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[6].Value.ToString());
                decimal euros = Decimal.Parse(dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[8].Value.ToString());
                decimal zelle = Decimal.Parse(dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[9].Value.ToString());
                decimal gastos = Decimal.Parse(dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[11].Value.ToString());
                decimal equivalente = 0;
                decimal dolares = 0;

                if (totalFacturado != 0 && tasa != 0)
                {
                    equivalente = totalFacturado / tasa;
                    dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[7].Value = decimal.Round(equivalente, 2, MidpointRounding.AwayFromZero); //Equivalente Bs
                }

                if (cambioBs != 0 && tasa != 0)
                {
                    equivalente = cambioBs / tasa;
                    dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[7].Value = decimal.Round(equivalente, 2, MidpointRounding.AwayFromZero); //Equivalente Bs
                }

                try
                {
                    dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[10].Value = dolares = decimal.Round(equivalente - euros - zelle, 2, MidpointRounding.AwayFromZero); //Dolar
                    dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[12].Value = decimal.Round(euros + dolares - gastos, 2, MidpointRounding.AwayFromZero); //Resta Efectivo
                }
                catch
                {
                    dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[10].Value = decimal.Round(0 - euros, 2, MidpointRounding.AwayFromZero); //Dolar
                    dataGridViewStoreReportEdit.Rows[e.RowIndex].Cells[12].Value = decimal.Round(0 - gastos, 2, MidpointRounding.AwayFromZero); //Resta Efectivo
                }

                dataGridViewStoreReportEdit.Refresh();
            }
        }

        private void dataGridViewStoreReportEdit_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
        }

        private void dataGridViewStoreReportEdit_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewStoreReportEdit.IsCurrentCellDirty)
            {
                dataGridViewStoreReportEdit.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private async void buttonStoreReportEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStoreReportEdit.DataSource == null || dataGridViewStoreReportEdit.Rows.Count <= 0)
            {
                return;
            }

            buttonStoreReportEdit.Enabled = false;
            buttonStoreReportDelete.Enabled = false;
            buttonStoreReportEditCloseMonth.Enabled = false;
            buttonStoreReportEditClean.Enabled = false;
            buttonStoreReportEditExcel.Enabled = false;
            comboBoxStoreReportEdit.Enabled = false;
            dateTimePickerStoreReportEdit.Enabled = false;

            List<StoreReport> listToEdit = new List<StoreReport>();

            foreach (var item in (List<ModelEditStoreReport>)dataGridViewStoreReportEdit.DataSource)
            {
                if (item.storep_selection == true)
                {
                    listToEdit.Add(new StoreReport
                    {
                        storep_id = item.storep_id,
                        storep_sto_id = this._storeList.Where(s => s.sto_code == item.storep_code).Select(d => d.sto_id).FirstOrDefault(),
                        storep_date = item.storep_date,
                        storep_total_bs = item.storep_total_bs,
                        storep_change_bs = item.storep_change_bs,
                        storep_rate = item.storep_rate,
                        storep_equivalent_dollar = item.storep_equivalent_dollar,
                        storep_payed_euro = item.storep_payed_euro,
                        storep_payed_zelle = item.storep_payed_zelle,
                        storep_payed_dollar = item.storep_payed_dollar,
                        storep_expended_dollar = item.storep_expended_dollar,
                        storep_total_dollar = item.storep_total_dollar,
                        storep_sta_id = item.storep_sta_id,
                        storep_sup_id = this._supervisorList.Where(s => s.sup_description == item.storep_supervisor).Select(g => g.sup_id).FirstOrDefault(),
                        storep_comments = item.storep_comments == null ? string.Empty : item.storep_comments,
                        storep_starep_id = item.storep_starep_id,
                        storep_audit_id = _activeUser.usr_id,
                        storep_audit_date = DateTime.Now,
                        storep_audit_delete = false
                    });
                }
            }

            var resultUpdateReport = await _webserviceOperations.StoreReportPut(listToEdit);

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultUpdateReport.Item1, resultUpdateReport.Item2));

            buttonStoreReportEditConsult_Click(null, null);

            buttonStoreReportEdit.Enabled = true;
            buttonStoreReportDelete.Enabled = true;
            buttonStoreReportEditCloseMonth.Enabled = true;
            buttonStoreReportEditClean.Enabled = true;
            buttonStoreReportEditExcel.Enabled = true;
            comboBoxStoreReportEdit.Enabled = true;
            dateTimePickerStoreReportEdit.Enabled = true;
        }

        private async void buttonStoreReportDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStoreReportEdit.DataSource == null || dataGridViewStoreReportEdit.Rows.Count <= 0)
            {
                return;
            }

            if (MessageBox.Show("Por favor confirme antes de proceder" + "\n" + "¿Esta seguro de eliminar los registros seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            buttonStoreReportEdit.Enabled = false;
            buttonStoreReportDelete.Enabled = false;
            buttonStoreReportEditCloseMonth.Enabled = false;
            buttonStoreReportEditClean.Enabled = false;
            buttonStoreReportEditExcel.Enabled = false;
            comboBoxStoreReportEdit.Enabled = false;
            dateTimePickerStoreReportEdit.Enabled = false;

            List<StoreReport> listToDelete = new List<StoreReport>();

            foreach (var item in (List<ModelEditStoreReport>)dataGridViewStoreReportEdit.DataSource)
            {
                if (item.storep_selection == true)
                {
                    listToDelete.Add(
                        new StoreReport
                        {
                            storep_id = item.storep_id,
                            storep_audit_id = _activeUser.usr_id,
                            storep_audit_date = DateTime.Now,
                            storep_audit_delete = true

                        }
                    );
                }
            }

            var resultDeleteReport = await _webserviceOperations.StoreReportDelete(listToDelete);
            _RaiseRichTextInsertNewMessage?.Invoke(this, new(resultDeleteReport.Item1, resultDeleteReport.Item2));

            buttonStoreReportEditConsult_Click(null, null);

            buttonStoreReportEdit.Enabled = true;
            buttonStoreReportDelete.Enabled = true;
            buttonStoreReportEditCloseMonth.Enabled = true;
            buttonStoreReportEditClean.Enabled = true;
            buttonStoreReportEditExcel.Enabled = true;
            comboBoxStoreReportEdit.Enabled = true;
            dateTimePickerStoreReportEdit.Enabled = true;
        }

        private async void buttonStoreReportEditCloseMonth_Click(object sender, EventArgs e)
        {
            if (dataGridViewStoreReportEdit.DataSource == null || dataGridViewStoreReportEdit.Rows.Count <= 0)
            {
                return;
            }

            if (((List<ModelEditStoreReport>)dataGridViewStoreReportEdit.DataSource).Any(r => r.storep_starep_id == (int)MagickInfo.STATUS_REPORT.NO_PROCESADO))
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Este mes posee registros no procesados."));
                return;
            }

            decimal sumMonth = Decimal.Round(((List<ModelEditStoreReport>)dataGridViewStoreReportEdit.DataSource).Sum(r => r.storep_total_dollar), 2, MidpointRounding.AwayFromZero);

            if (MessageBox.Show("Por favor confirme antes de proceder" + "\n" + "El resto del mes es: " + sumMonth + "\n" +
                "¿Esta seguro de cerrar el mes?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            buttonStoreReportEdit.Enabled = false;
            buttonStoreReportDelete.Enabled = false;
            buttonStoreReportEditCloseMonth.Enabled = false;
            buttonStoreReportEditClean.Enabled = false;
            buttonStoreReportEditExcel.Enabled = false;
            comboBoxStoreReportEdit.Enabled = false;
            dateTimePickerStoreReportEdit.Enabled = false;

            List<ModelEditStoreReport> aux = ((List<ModelEditStoreReport>)dataGridViewStoreReportEdit.DataSource);
            aux[0].storep_date = aux[0].storep_date.AddMonths(1);
            DateTime auxTime = new DateTime(aux[0].storep_date.Year, aux[0].storep_date.Month, 1);

            List<StoreReport> listToInsert = new List<StoreReport>();

            listToInsert.Add(new StoreReport
            {
                storep_sto_id = this._storeList.Where(s => s.sto_code == aux[0].storep_code).Select(d => d.sto_id).FirstOrDefault(),
                storep_date = auxTime,
                storep_total_bs = 0,
                storep_change_bs = 0,
                storep_rate = 0,
                storep_equivalent_dollar = 0,
                storep_payed_euro = 0,
                storep_payed_zelle = 0,
                storep_payed_dollar = 0,
                storep_expended_dollar = 0,
                storep_total_dollar = sumMonth,
                storep_sta_id = (int)MagickInfo.STATUS.CIERRE_DE_MES,
                storep_sup_id = _supervisorList.Where(s => s.sup_description == aux[0].storep_supervisor).Select(g => g.sup_id).FirstOrDefault(),
                storep_comments = "Viene de " + auxTime.Date.AddMonths(-1).ToString("MMMM-yyyy"),
                storep_starep_id = (int)MagickInfo.STATUS_REPORT.PROCESADO,
                storep_audit_id = _activeUser.usr_id,
                storep_audit_date = DateTime.Now,
                storep_audit_delete = false
            });

            var resultInsertStoreReport = await _webserviceOperations.StoreReportPost(listToInsert);

            if (resultInsertStoreReport.Item1)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Mes cerrado con exito. " + resultInsertStoreReport.Item2));
            }
            else
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Error cerrado de mes. " + resultInsertStoreReport.Item2));
            }

            buttonStoreReportEdit.Enabled = true;
            buttonStoreReportDelete.Enabled = true;
            buttonStoreReportEditCloseMonth.Enabled = true;
            buttonStoreReportEditClean.Enabled = true;
            buttonStoreReportEditExcel.Enabled = true;
            comboBoxStoreReportEdit.Enabled = true;
            dateTimePickerStoreReportEdit.Enabled = true;
        }

        private void StoreReportEditClean_Click(object sender, EventArgs e)
        {
            if (dataGridViewStoreReportEdit.DataSource != null && dataGridViewStoreReportEdit.Rows.Count > 0)
            {
                dataGridViewStoreReportEdit.DataSource = new List<ModelEditStoreReport>();
                dataGridViewStoreReportEdit.Refresh();
                CalculateTotales();
            }
        }

        private async void buttonStoreReportEditExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewStoreReportEdit.DataSource == null || dataGridViewStoreReportEdit.Rows.Count <= 0)
            {
                return;
            }

            buttonStoreReportEdit.Enabled = false;
            buttonStoreReportDelete.Enabled = false;
            buttonStoreReportEditCloseMonth.Enabled = false;
            buttonStoreReportEditClean.Enabled = false;
            buttonStoreReportEditExcel.Enabled = false;
            comboBoxStoreReportEdit.Enabled = false;
            dateTimePickerStoreReportEdit.Enabled = false;

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
                var listExcelDTO = ((List<ModelEditStoreReport>)dataGridViewStoreReportEdit.DataSource).Select(x => new ExcelReportStoreDTO
                {
                    storep_code = x.storep_code,
                    storep_date = x.storep_date,
                    storep_total_bs = x.storep_total_bs,
                    storep_change_bs = x.storep_change_bs,
                    storep_rate = x.storep_rate,
                    storep_equivalent_dollar = x.storep_equivalent_dollar,
                    storep_payed_euro = x.storep_payed_euro,
                    storep_payed_zelle = x.storep_payed_zelle,
                    storep_payed_dollar = x.storep_payed_dollar,
                    storep_expended_dollar = x.storep_expended_dollar,
                    storep_total_dollar = x.storep_total_dollar,
                    storep_sta_description = _statusList.Where(s => s.sta_id == x.storep_sta_id).Select(d => d.sta_description).FirstOrDefault(),
                    storep_supervisor = x.storep_supervisor,
                    storep_comments = x.storep_comments == null ? string.Empty : x.storep_comments,
                    storep_starep_description = _statusReportList.Where(s => s.starep_id == x.storep_starep_id).Select(d => d.starep_description).FirstOrDefault(),
                }).ToList();

                var result = await ManageExcel.CreateReportStore(listExcelDTO, GetTotalesExcel(listExcelDTO), saveFileDialog.FileName);

                _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));

            }

            buttonStoreReportEdit.Enabled = true;
            buttonStoreReportDelete.Enabled = true;
            buttonStoreReportEditCloseMonth.Enabled = true;
            buttonStoreReportEditClean.Enabled = true;
            buttonStoreReportEditExcel.Enabled = true;
            comboBoxStoreReportEdit.Enabled = true;
            dateTimePickerStoreReportEdit.Enabled = true;
        }

        private ExcelReportStoreTotalDTO GetTotalesExcel(List<ExcelReportStoreDTO> listExcelDTO)
        {
            ExcelReportStoreTotalDTO itemTotal = new ExcelReportStoreTotalDTO();
            foreach (var item in listExcelDTO)
            {
                itemTotal.total_storep_total_bs += item.storep_total_bs;
                itemTotal.total_storep_change_bs += item.storep_change_bs;
                itemTotal.total_storep_equivalent_dollar += item.storep_equivalent_dollar;
                itemTotal.total_storep_payed_euro += item.storep_payed_euro;
                itemTotal.total_storep_payed_zelle += item.storep_payed_zelle;
                itemTotal.total_storep_payed_dollar += item.storep_payed_dollar;
                itemTotal.total_storep_expended_dollar += item.storep_expended_dollar;
                itemTotal.total_storep_total_dollar += item.storep_total_dollar;
            }

            return itemTotal;
        }

        private bool flagCommentSize = false;
        private void dataGridViewStoreReportEdit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 15 && flagCommentSize == false)
            {
                dataGridViewStoreReportEdit.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                flagCommentSize = true;
            }
            else if (e.ColumnIndex == 15)
            {
                dataGridViewStoreReportEdit.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                dataGridViewStoreReportEdit.Columns[15].Width = 200;
                flagCommentSize = false;
            }
        }

    }
}
