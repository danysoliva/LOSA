using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Devart.Data.PostgreSql;
using LOSA.Classes;
using ACS.Classes;

namespace LOSA.MigracionACS.SAP
{
    public partial class frmDetallePartida : DevExpress.XtraEditors.XtraForm
    {
        int IdAccountMove;
        int IdMoneda;//44=LPS, 2=USD
        decimal tasaCambio;
        public frmDetallePartida(int pIdMove, int pIdMoneda, decimal ptasaCambio)
        {
            InitializeComponent();
            IdMoneda = pIdMoneda;
            tasaCambio = ptasaCambio;

            IdAccountMove = pIdMove;
            LoadDataCuentas();
            LoadData();
        }

        private void LoadDataCuentas()
        {
            try
            {
                string sql = @"SELECT id, (coalesce(code,'N/D')) AS cuenta_descripcion
	                           FROM public.account_account
	                           where code is not null 
			                         and sql_account_ref_id is not null
	                           order by code asc ";

                DataOperations dp = new DataOperations();
                PgSqlConnection psConnecton = new PgSqlConnection(dp.ConnectionStringODOO5);
                psConnecton.Open();
                PgSqlCommand cmd = new PgSqlCommand(sql, psConnecton);
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                dsDataSetSAP1.cuentas_contables_odoo.Clear();
                adat.Fill(dsDataSetSAP1.cuentas_contables_odoo);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                /*
                string sql = @"select ll.id,
                                       ll.name,
	                                   coalesce((SELECT name
                                                 FROM public.account_analytic_account aa
                                                 where aa.id = ll.analytic_account_id),'')ceco,
                                       coalesce((SELECT aa.code
                                                 FROM public.account_analytic_account aa
                                                 where aa.id = ll.analytic_account_id),'')ceco_code,
                                                           
                                      (SELECT name
                                       FROM public.account_account acc
                                       where acc.id = ll.account_id)as cuenta,
                                       
                                       (SELECT code
                                       FROM public.account_account acc
                                       where acc.id = ll.account_id)as cuenta_code,
                                       
                                       ll.debit,
                                       ll.credit,
                                       coalesce((select cc.name
                                                 FROM public.res_currency cc 
                                                 where cc.id = ll.currency_id),'HNL')as moneda,
                                       ll.ref
                                from public.account_move_line ll
                                where ll.move_id =" + IdAccountMove;*/

                string sql = @"select tab.id,
	                                    tab.name,
                                        tab.ceco,
                                        tab.ceco_code,
                                        tab.cuenta,
                                        tab.cuenta_code,
                                        case when tab.tasa_id = 2 then
       		                                cast((tab.debit/coalesce(tab.tasa,1))as numeric(18,2))
                                        else
       		                                cast(tab.debit as numeric(18,2))
                                        end as debit,
										
                                        case when tab.tasa_id = 2 then
       		                                cast((tab.credit/coalesce(tab.tasa,1)) as numeric(18,2))
                                        else
                                            cast(tab.credit as numeric(18,2))
                                        end as credit,
                                        tab.ref,
                                        tab.moneda,
                                        tab.row_number,
                                        tab.account_id
                                from(

                                select ll.id,
                                        ll.name,
                                        coalesce((SELECT name
                                                    FROM public.account_analytic_account aa
                                                    where aa.id = ll.analytic_account_id),'')ceco,
                                        coalesce((SELECT aa.code
                                                    FROM public.account_analytic_account aa
                                                    where aa.id = ll.analytic_account_id),'')ceco_code,

                                        ll.account_id,

                                        (SELECT name
                                        FROM public.account_account acc
                                        where acc.id = ll.account_id)as cuenta,
                                       
                                        (SELECT code
                                        FROM public.account_account acc
                                        where acc.id = ll.account_id)as cuenta_code,
                                       
                                        ll.debit,
                                        ll.credit
                                        /*coalesce((select cc.id
                                                    FROM public.res_currency cc 
                                                    where cc.id = ll.currency_id),0)as moneda_id,*/
                                        ,( SELECT rr.currency_id
                                                    FROM public.hr_payslip_run rr join
                                                            public.account_move mv on
                                                            rr.id = mv.payslip_run_id
                                                    where mv.id = ll.move_id)as tasa_id
                                        ,( SELECT rr.rate
                                                    FROM public.hr_payslip_run rr join
                                                            public.account_move mv on
                                                            rr.id = mv.payslip_run_id
                                                    where mv.id = ll.move_id)as tasa
                                        , ( SELECT cc.name
                                                    FROM public.res_currency cc JOIN   
                                                            public.hr_payslip_run rr on
                                                            rr.currency_id = cc.id join
                                                            public.account_move mv on
                                                            rr.id = mv.payslip_run_id
                                                    where mv.id = ll.move_id)as moneda 
                                        ,ll.ref
                                        ,ROW_NUMBER () OVER (ORDER BY  ll.id asc) as row_number
                                from public.account_move_line ll
                                where ll.move_id =" + IdAccountMove +" )as tab ";

                DataOperations dp = new DataOperations();
                PgSqlConnection psConnecton = new PgSqlConnection(dp.ConnectionStringODOO5);
                psConnecton.Open();
                PgSqlCommand cmd = new PgSqlCommand(sql, psConnecton);
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                dsDataSetSAP1.detalle.Clear();
                adat.Fill(dsDataSetSAP1.detalle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
                //Impresion().ExportToXlsx(dialog.FileName);
            }
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch(e.Column.FieldName) 
            {
                case "account_id":
                    CuentaContableODOO cuenta1 = new CuentaContableODOO();
                    var row = (dsDataSetSAP.detalleRow)gridView1.GetFocusedDataRow();
                    if (cuenta1.RecuperarRegistro(row.account_id))
                    {
                        row.cuenta = cuenta1.Nombre;
                    }
                    MoveLineODOO move1 = new MoveLineODOO();
                    move1.UpdateAccountMoveLine(row.id, row.account_id);
                    break;
                case "debit":
                    var row1 = (dsDataSetSAP.detalleRow)gridView1.GetFocusedDataRow();
                    MoveLineODOO move2 = new MoveLineODOO();
                    decimal debit_ = (row1.debit * tasaCambio);
                    //move2.UpdateDebitMoveLine(row1.id, row1.debit);
                    move2.UpdateDebitMoveLine(row1.id, debit_);
                    break;
                case "credit":
                    var row2 = (dsDataSetSAP.detalleRow)gridView1.GetFocusedDataRow();
                    MoveLineODOO move3 = new MoveLineODOO();
                    decimal credit = (row2.credit * tasaCambio);
                    //move3.UpdateDebitMoveLine(row2.id, credit);
                    move3.UpdateCreditMoveLine(row2.id, credit);

                    break;
            }
        }
    }
}