using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace LOSA.MigracionACS.Tickets.Reportes
{
    public partial class rpt_Ticket_TI : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_Ticket_TI(int id_ticket)
        {
            InitializeComponent();
            sqlDataSource1.Queries[0].Parameters[0].Value = id_ticket;

        }

    }
}
