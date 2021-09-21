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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using LOSA.RecepcionMP;
using DevExpress.XtraReports.UI;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Produccion
{
    public partial class frmGenerarTarimas : DevExpress.XtraEditors.XtraForm
    {

        int id_alimentacion;
        int unidades;
        int presentacion;
        decimal peso;
        DateTime F_vencimiento;
        DateTime f_produccion;
        DateTime F_Ingreso;
        int id_pt;
        string Itemcode;
        int lote;
        int id_usuario;
        int id_turno;
        int ud_tarimas;
        int ControlSelected;
        int centinela_print_multi;
        int PsiguienteSa = 0;
        int tipoprinte = 0;


DataOperations dp = new DataOperations();
        public frmGenerarTarimas(int Pid_ali, int NextPrint)
        {
            InitializeComponent();
            id_alimentacion = Pid_ali;
            PsiguienteSa = NextPrint;
            txtdesde.Text = PsiguienteSa.ToString();
            load_presentacion();
            load_data();
            load_turno();
            txthasta.Text = ((PsiguienteSa - 1) + Convert.ToInt32(txt_unidades.Text)).ToString();
            load_tarimas();

        }

        public void load_tarimas() 
        {
            string Query = @"sp_load_tarimas_ingreso_pt";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_alimentacion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProduccion.listaTmPrinted.Clear();
                da.Fill(dsProduccion.listaTmPrinted);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_tarimas_todas()
        {
            string Query = @"sp_load_tarimas_ingreso_pt_todas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_alimentacion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProduccion.listaTmPrinted.Clear();
                da.Fill(dsProduccion.listaTmPrinted);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        public void load_turno()
        {
            string query = @"sp_losa_load_turno";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion.turno.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProduccion.turno);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_presentacion()
        {
            string query = @"sp_load_pt_bags_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion.bags.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProduccion.bags);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        public void load_data()
        {
            string query = @"sp_load_informacion_envasado";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id_env", id_alimentacion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id_pt = dr.GetInt32(1);
                    Itemcode = dr.GetString(2);
                    txt_producto.Text = dr.GetString(3);
                    peso = dr.GetDecimal(4);
                    presentacion = dr.GetInt32(5);
                    lote = dr.GetInt32(6);
                    unidades = dr.GetInt32(8);
                    f_produccion = dr.GetDateTime(11);
                    F_vencimiento = dr.GetDateTime(12);
                }
                dr.Close();
                cn.Close();                      
                txtkg.Text = peso.ToString();
                txt_unidades.Text = unidades.ToString();
                txtlote.Text = lote.ToString();
                dt_fechaFabricaion.EditValue = f_produccion;
                dt_fechaVencimiento.EditValue = F_vencimiento;
                grdv_data.EditValue = presentacion;

                Calcular_peso();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                   
        private void btn_udup_Click(object sender, EventArgs e)
        {
            if (unidades > 0)
            {
                unidades++;
            }

            txt_unidades.Text = unidades.ToString(); 
            Calcular_peso();
        }
         public void Calcular_peso()
        {
            try
            {
               
                double factor = 0;
                foreach (dsProduccion.bagsRow row in dsProduccion.bags.Rows)
                {

                    if (row.equi == Convert.ToInt32(grdv_data.EditValue))
                    {
                        factor = row.net;
                        presentacion = row.equi;

                    }
                }

                peso = Convert.ToDecimal(factor * unidades);
                txtkg.Text = peso.ToString();
            }
            catch (Exception e)
            {

                
            }

        }
        private void btn_uddown_Click(object sender, EventArgs e)
        {
            if (unidades > 1)
            {
                unidades = unidades - 1;
            }

            txt_unidades.Text = unidades.ToString();
            Calcular_peso();
        }

        private void grdv_data_EditValueChanged(object sender, EventArgs e)
        {

            Calcular_peso();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (grdturno.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar el turno");
                return;
            }
            if (txtdesde.Text == "")
            {
                CajaDialogo.Error("Debe especificar el saco inicial de la tarima.");
                return;
            }

            if (grdv_data.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar la presentacion");
                return;
            }
            if (txthasta.Text == "")
            {
                CajaDialogo.Error("Debe especificar el saco final de la tarima.");
                return;
            }
            if (MessageBox.Show("Desea imprimir solo una hoja de este producto?","Pregunta", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = @"sp_insert_tarima_pt_nuevo_v3";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    int desde = Convert.ToInt32(txtdesde.Text);
                    int hasta = Convert.ToInt32(txthasta.Text); 

                    SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", cn);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@id", 1);
                    string barcode = cmm.ExecuteScalar().ToString();

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;                               
                    cmd.Parameters.AddWithValue("@date_vencimiento", string.Format("{0:yyyy-MM-dd}", dt_fechaVencimiento.EditValue));
                    cmd.Parameters.AddWithValue("@lote", lote);
                    cmd.Parameters.AddWithValue("@id_presentacion", grdv_data.EditValue);
                    cmd.Parameters.AddWithValue("@id_pt", id_pt);
                    cmd.Parameters.AddWithValue("@date_produccion", string.Format("{0:yyyy-MM-dd}", dt_fechaFabricaion.EditValue));
                    cmd.Parameters.AddWithValue("@cantidad", unidades);
                    cmd.Parameters.AddWithValue("@peso", txtkg.Text.Trim());
                    cmd.Parameters.AddWithValue("@itemcode", Itemcode.Trim());
                    cmd.Parameters.AddWithValue("@id_alimentacion", id_alimentacion);   
                    cmd.Parameters.AddWithValue("@Pcodigo_barra", barcode);
                    cmd.Parameters.AddWithValue("@id_turno", grdturno.EditValue);
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);

                    int Id_tm = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();
                    tipoprinte = 0;
                    rptReporteTarimaPT boleta = new rptReporteTarimaPT(Id_tm);
                    boleta.ShowPrintMarginsWarning = false;
                    ReportPrintTool printtool = new ReportPrintTool(boleta);
                    printtool.Print();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void btn_print25_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea imprimir 25 tarimas de este producto?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (grdturno.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar el turno");
                    return;
                }
                if (grdv_data.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar la presentacion");
                    return;
                }
                if (txtdesde.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el saco inicial de la tarima.");
                    return;
                }
                if (txthasta.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el saco final de la tarima.");
                    return;
                }
                //int contador = 25;
                //for (int i = 0; i < contador; i++)
                //{
                //    string query = @"sp_insert_tarima_pt_nuevo";
                //    try
                //    {
                //        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                //        cn.Open();


                //        SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", cn);
                //        cmm.CommandType = CommandType.StoredProcedure;
                //        cmm.Parameters.AddWithValue("@id", 1);
                //        string barcode = cmm.ExecuteScalar().ToString();

                //        SqlCommand cmd = new SqlCommand(query, cn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@date_vencimiento", string.Format("{0:yyyy-MM-dd}", dt_fechaVencimiento.EditValue));
                //        cmd.Parameters.AddWithValue("@lote", lote);
                //        cmd.Parameters.AddWithValue("@id_presentacion", presentacion);
                //        cmd.Parameters.AddWithValue("@id_pt", id_pt);
                //        cmd.Parameters.AddWithValue("@date_produccion", string.Format("{0:yyyy-MM-dd}", dt_fechaFabricaion.EditValue));
                //        cmd.Parameters.AddWithValue("@cantidad", unidades);
                //        cmd.Parameters.AddWithValue("@peso", txtkg.Text.Trim());
                //        cmd.Parameters.AddWithValue("@itemcode", Itemcode.Trim());
                //        cmd.Parameters.AddWithValue("@id_alimentacion", id_alimentacion);
                //        cmd.Parameters.AddWithValue("@Pcodigo_barra", barcode);

                //        int Id_tm = Convert.ToInt32(cmd.ExecuteScalar());
                //        cn.Close();

                //        rptReporteTarimaPT boleta = new rptReporteTarimaPT(Id_tm);
                //        boleta.ShowPrintMarginsWarning = false;
                //        ReportPrintTool printtool = new ReportPrintTool(boleta);
                //        printtool.Print();

                //        Thread.Sleep(400);
                //    }
                //    catch (Exception ex)
                //    {

                //        CajaDialogo.Error(ex.Message);
                //    }
                //}
                //CajaDialogo.Information("Impresion completa.");
                //this.Close();
                timerPrintMulti.Enabled = true;
                tipoprinte = 0;
                centinela_print_multi = 25;
                timerPrintMulti.Start();
            }
        }

        private void timerPrintMulti_Tick(object sender, EventArgs e)
        {


            if (tipoprinte ==  0)
            {
                if (centinela_print_multi > 0)
                {
                    string query = @"sp_insert_tarima_pt_nuevo_v3";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();

                        int desde = Convert.ToInt32(txtdesde.Text);
                        int hasta = Convert.ToInt32(txthasta.Text);
                        int aux = 0;
                        SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", cn);
                        cmm.CommandType = CommandType.StoredProcedure;
                        cmm.Parameters.AddWithValue("@id", 1);
                        string barcode = cmm.ExecuteScalar().ToString();

                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@date_vencimiento", string.Format("{0:yyyy-MM-dd}", dt_fechaVencimiento.EditValue));
                        cmd.Parameters.AddWithValue("@lote", lote);
                        cmd.Parameters.AddWithValue("@id_presentacion", grdv_data.EditValue);
                        cmd.Parameters.AddWithValue("@id_pt", id_pt);
                        cmd.Parameters.AddWithValue("@date_produccion", string.Format("{0:yyyy-MM-dd}", dt_fechaFabricaion.EditValue));
                        cmd.Parameters.AddWithValue("@cantidad", unidades);
                        cmd.Parameters.AddWithValue("@peso", txtkg.Text.Trim());
                        cmd.Parameters.AddWithValue("@itemcode", Itemcode.Trim());
                        cmd.Parameters.AddWithValue("@id_alimentacion", id_alimentacion);
                        cmd.Parameters.AddWithValue("@Pcodigo_barra", barcode);
                        cmd.Parameters.AddWithValue("@id_turno", grdturno.EditValue);
                        cmd.Parameters.AddWithValue("@desde", desde);
                        cmd.Parameters.AddWithValue("@hasta", hasta);

                        int Id_tm = Convert.ToInt32(cmd.ExecuteScalar());
                        aux = hasta;
                        desde = hasta + 1;
                        hasta = aux + unidades;

                        cn.Close();
                        centinela_print_multi--;

                        rptReporteTarimaPT boleta = new rptReporteTarimaPT(Id_tm);
                        boleta.ShowPrintMarginsWarning = false;
                        ReportPrintTool printtool = new ReportPrintTool(boleta);
                        printtool.Print();


                        //Thread.Sleep(400);
                    }
                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                    }
                }
                else
                {
                    timerPrintMulti.Stop();
                    timerPrintMulti.Enabled = false;
                    CajaDialogo.Information("Impresion completa.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                if (centinela_print_multi < 0)
                {
                    foreach (dsProduccion.listaTmPrintedRow row in dsProduccion.listaTmPrinted.Rows)
                    {
                        if (row.selectedd)
                        {
                            rptReporteTarimaPT boleta = new rptReporteTarimaPT(row.id);
                            boleta.ShowPrintMarginsWarning = false;
                            ReportPrintTool printtool = new ReportPrintTool(boleta);
                            printtool.Print();
                            centinela_print_multi--;
                        }
                    }
                }
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea imprimir 3 tarimas de este producto?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (grdturno.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar el turno");
                    return;
                }


                if (grdv_data.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar la presentacion");
                    return;
                }
                if (txtdesde.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el saco inicial de la tarima.");
                    return;
                }
                if (txthasta.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el saco final de la tarima.");
                    return;
                }

                timerPrintMulti.Enabled = true;
                tipoprinte = 0;
                centinela_print_multi = 3;
                timerPrintMulti.Start();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea imprimir 5 tarimas de este producto?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (grdturno.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar el turno");
                    return;
                }

                if (grdv_data.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar la presentacion");
                    return;
                }

                if (txtdesde.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el saco inicial de la tarima.");
                    return;
                }
                if (txthasta.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el saco final de la tarima.");
                    return;
                }

                timerPrintMulti.Enabled = true;
                tipoprinte = 0;
                centinela_print_multi = 5;
                timerPrintMulti.Start();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "1");

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "4");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "5");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "6");
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "7");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "8");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "9");
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "--");
        }

       
        private void simpleButton10_Click(object sender, EventArgs e)
        {
            MoverNumero(ControlSelected, "0");
        }

        public void MoverNumero(int Id_Control, string Numero)
        {
            try
            {
                switch (Id_Control)
                {
                    case 1:
                        if (Numero == "--")
                        {
                            txtdesde.Text = txtdesde.Text.Remove(txtdesde.Text.Length - 1);

                            txtdesde.Select(txtdesde.Text.Length, 0);
                            break;
                        }
                        txtdesde.Text = txtdesde.Text + Numero;
                        txtdesde.Focus();
                        //txtdesde.Select(txtdesde.Text.Length - 1, txtdesde.Text.Length - 1);
                        txtdesde.Select(txtdesde.Text.Length, 0);
                        break;
                    case 2:
                        if (Numero == "--")
                        {
                            txthasta.Text = txthasta.Text.Remove(txthasta.Text.Length - 1);

                            txthasta.Select(txthasta.Text.Length, 0);

                            break;
                        }
                        txthasta.Text = txthasta.Text + Numero;
                        txthasta.Focus();
                        //txtdesde.Select(txtdesde.Text.Length - 1, txtdesde.Text.Length - 1);
                        txthasta.Select(txthasta.Text.Length, 0);
                        break;
                    case 3:
                        if (Numero == "--")
                        {
                            txt_unidades.Text = txt_unidades.Text.Remove(txt_unidades.Text.Length - 1);

                            txt_unidades.Select(txt_unidades.Text.Length, 0);
                            break;
                        }

                        txt_unidades.Text = txt_unidades.Text + Numero;
                        txt_unidades.Focus();
                        //txtdesde.Select(txtdesde.Text.Length - 1, txtdesde.Text.Length - 1);
                        txt_unidades.Select(txt_unidades.Text.Length, 0);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void txt_unidades_Click(object sender, EventArgs e)
        {
            ControlSelected = 3;
        }

        private void txtdesde_Click(object sender, EventArgs e)
        {
            ControlSelected = 1;
        }

        private void txthasta_Click(object sender, EventArgs e)
        {
            ControlSelected = 2;
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {     // tarimas ya activadas

                load_tarimas();
            }
            else
            {
                load_tarimas_todas();
            }
        }

        private void txt_unidades_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_unidades.Text != "" )
            {
                txthasta.Text = ( Convert.ToInt32(txtdesde.Text) + Convert.ToInt32(txt_unidades.Text)).ToString();
                unidades = Convert.ToInt32(txt_unidades.Text);
                Calcular_peso();
            }
        }

        private void bbtnreprint_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsProduccion.listaTmPrintedRow)gridView.GetFocusedDataRow();
                rptReporteTarimaPT boleta = new rptReporteTarimaPT(row.id);
                boleta.ShowPrintMarginsWarning = false;
                ReportPrintTool printtool = new ReportPrintTool(boleta);
                printtool.Print();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtdesde_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                int count_selected = 0;
                    foreach (dsProduccion.listaTmPrintedRow row in dsProduccion.listaTmPrinted.Rows)
                    {
                        if (row.selectedd)
                        {
                         count_selected = count_selected + 1;
                        }
                    }

                centinela_print_multi = count_selected;
                timerPrintMulti.Enabled = true;
                tipoprinte = 1;
                centinela_print_multi = 25;
                timerPrintMulti.Start();
            }
            catch (Exception ex)
            {

                
            }
        }

        private void chSeleccionarTodas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chSeleccionarTodas.Checked)
                {
                    foreach (dsProduccion.listaTmPrintedRow row in dsProduccion.listaTmPrinted.Rows)
                    {
                        row.selectedd = true;
                    }
                }
                else
                {
                    foreach (dsProduccion.listaTmPrintedRow row in dsProduccion.listaTmPrinted.Rows)
                    {
                        row.selectedd = false;
                    }
                }
            }
            catch (Exception ex)
            {

                
            }
        }

        private void gridv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colselectedd")
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsProduccion.listaTmPrintedRow)gridView.GetFocusedDataRow();

                    row.selectedd = Convert.ToBoolean(e.Value);

                    row.AcceptChanges();
                }
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}