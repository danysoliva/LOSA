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
        
        

        DataOperations dp = new DataOperations();
        public frmGenerarTarimas(int Pid_ali)
        {
            InitializeComponent();
            id_alimentacion = Pid_ali;  
            load_presentacion();
            load_data();           

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
            double factor = 0;
            foreach (dsProduccion.bagsRow row in dsProduccion.bags.Rows)
            {
               
                if (row.equi == Convert.ToInt32(grdv_data.EditValue))
                {
                    factor = row.net;
                }             
            }

            peso = Convert.ToDecimal(factor * unidades);
            txtkg.Text = peso.ToString();

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
            if (MessageBox.Show("Desea imprimir solo una hoja de este producto?","Pregunta", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = @"sp_insert_tarima_pt_nuevo";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();


                    SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", cn);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@id", 1);
                    string barcode = cmm.ExecuteScalar().ToString();

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;                               
                    cmd.Parameters.AddWithValue("@date_vencimiento", string.Format("{0:yyyy-MM-dd}", dt_fechaVencimiento.EditValue));
                    cmd.Parameters.AddWithValue("@lote", lote);
                    cmd.Parameters.AddWithValue("@id_presentacion", presentacion);
                    cmd.Parameters.AddWithValue("@id_pt", id_pt);
                    cmd.Parameters.AddWithValue("@date_produccion", string.Format("{0:yyyy-MM-dd}", dt_fechaFabricaion.EditValue));
                    cmd.Parameters.AddWithValue("@cantidad", unidades);
                    cmd.Parameters.AddWithValue("@peso", txtkg.Text.Trim());
                    cmd.Parameters.AddWithValue("@itemcode", Itemcode.Trim());
                    cmd.Parameters.AddWithValue("@id_alimentacion", id_alimentacion);   
                    cmd.Parameters.AddWithValue("@Pcodigo_barra", barcode);

                    int Id_tm = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();

                    rptReporteTarimaPT boleta = new rptReporteTarimaPT(Id_tm);
                    boleta.ShowPrintMarginsWarning = false;
                    ReportPrintTool printtool = new ReportPrintTool(boleta);
                    printtool.Print();
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
                int contador = 25;
                for (int i = 0; i < contador; i++)
                {
                    string query = @"sp_insert_tarima_pt_nuevo";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();


                        SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", cn);
                        cmm.CommandType = CommandType.StoredProcedure;
                        cmm.Parameters.AddWithValue("@id", 1);
                        string barcode = cmm.ExecuteScalar().ToString();

                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@date_vencimiento", string.Format("{0:yyyy-MM-dd}", dt_fechaVencimiento.EditValue));
                        cmd.Parameters.AddWithValue("@lote", lote);
                        cmd.Parameters.AddWithValue("@id_presentacion", presentacion);
                        cmd.Parameters.AddWithValue("@id_pt", id_pt);
                        cmd.Parameters.AddWithValue("@date_produccion", string.Format("{0:yyyy-MM-dd}", dt_fechaFabricaion.EditValue));
                        cmd.Parameters.AddWithValue("@cantidad", unidades);
                        cmd.Parameters.AddWithValue("@peso", txtkg.Text.Trim());
                        cmd.Parameters.AddWithValue("@itemcode", Itemcode.Trim());
                        cmd.Parameters.AddWithValue("@id_alimentacion", id_alimentacion);
                        cmd.Parameters.AddWithValue("@Pcodigo_barra", barcode);
                                                        
                        int Id_tm = Convert.ToInt32(cmd.ExecuteScalar());
                        cn.Close();

                        rptReporteTarimaPT boleta = new rptReporteTarimaPT(Id_tm);
                        boleta.ShowPrintMarginsWarning = false;
                        ReportPrintTool printtool = new ReportPrintTool(boleta);
                        printtool.Print();

                        Thread.Sleep(400);
                    }
                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                    }
                }
                CajaDialogo.Information("Impresion completa.");
                this.Close();
            }
        }
    }
}