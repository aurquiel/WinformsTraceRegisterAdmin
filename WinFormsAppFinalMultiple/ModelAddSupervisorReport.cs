﻿namespace WinFormsAppTrazoRegistrosAdmin
{
    internal class ModelAddSupervisorReport
    {
        public int suprep_sup_id { get; set; }
        public DateTime suprep_date { get; set; }
        public int suprep_sto_id { get; set; }
        public decimal suprep_in_dollar { get; set; }
        public decimal suprep_out_dollar { get; set; }
        public decimal suprep_in_euro { get; set; }
        public decimal suprep_out_euro { get; set; }
        public decimal suprep_in_peso { get; set; }
        public decimal suprep_out_peso { get; set; }
        public string suprep_comments { get; set; }
        public int suprep_starep_id { get; set; }
    }
}
