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
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace LOSA.Calidad
{
    public partial class frmcausasRechazo : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int Tipo_tarima;//1=Materia Prima
                        //2=Producto Terminado
        public enum Tipo_Reten
        {
                 Lote = 1,
                 Ingreso = 2
        }
        //Tipo_Reten TipoOp;
        ArrayList ListaTarimas;

        public frmcausasRechazo(UserLogin Puser
                                  , ArrayList pListaTarimas
                                  , int tipos_tm)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            //txtitemcode.Text = codigoP;
            //txtnombre.Text = producto;
            //txtlote.Text = lote;
            //txtingreso.Text = Ingreso.ToString();
            //TipoOp = POp;
            //Lote = lote;
            //id_mp = Id_mp;
            //ingreso = Ingreso;
            Tipo_tarima = tipos_tm;
            ListaTarimas = pListaTarimas;
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSelectCausaRechazo frm = new frmSelectCausaRechazo(Tipo_tarima);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int id = frm.id;
                foreach (DataRow Ite in dsCalidad.causaadd.Rows)
                {
                    if (Ite["id"].ToString() == id.ToString())
                    {
                        CajaDialogo.Error("Ya se ha registradio esta causa de retencion, por favor revisar las causas");
                        return;
                    }
                }
                DataRow Row = dsCalidad.causaadd.NewRow();
                Row["id"] = frm.id;
                Row["descripcion"] = frm.producto;
                Row["comentario"] = frm.comentario;
                dsCalidad.causaadd.Rows.Add(Row);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //string Query = @"sp_load_idtm_from_lote";//cargar las tarimas, sea por lote o por ingreso.
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                //int bit_is_por_ingreso = 0;
                //if (TipoOp == Tipo_Reten.Lote)//0=Si es por lote.     1=por ingreso
                //    bit_is_por_ingreso = 1;
                //else
                //    bit_is_por_ingreso = 0;
                //SqlCommand cmd = new SqlCommand(Query, cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@lote", Lote);
                ////cmd.Parameters.AddWithValue("@bitloi", bit_is_por_ingreso);
                //cmd.Parameters.AddWithValue("@id_mp", id_mp);
                ////cmd.Parameters.AddWithValue("@ingreso" , ingreso);
                //cmd.Parameters.AddWithValue("@tipo_tm", Tipo_tarima);
                //dsCalidad.Tarimas.Clear();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.Fill(dsCalidad.Tarimas);

                //foreach (dsCalidad.TarimasRow row in dsCalidad.Tarimas.Rows)//recorremos las tarimas encontradas con el query anterior
                if (ListaTarimas != null)
                {
                    foreach (int idTm in ListaTarimas)
                    {
                        string Query = "";
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);//Actualizar el estado de calidad.
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_estado", 4);//Rechazado
                        cmd.Parameters.AddWithValue("@id", idTm);
                        cmd.ExecuteNonQuery();

                        foreach (dsCalidad.causaaddRow row2 in dsCalidad.causaadd.Rows)//Guardar las causas del rechazo
                        {
                            cmd = new SqlCommand("sp_insert_into_calidad_tarimas", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idtarima", idTm);
                            cmd.Parameters.AddWithValue("@id_causa", row2.id);
                            cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@comentario", row2.comentario);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                cn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }



        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_causa.FocusedView;
                var row = (dsCalidad.causaaddRow)gridview.GetFocusedDataRow();
                foreach (DataRow item in dsCalidad.causaadd.Rows)
                {
                    if (Convert.ToInt32(item["id"]) == row.id)
                    {
                        item.Delete();
                    }
                }
                dsCalidad.causaadd.AcceptChanges();
            }
            catch (Exception ex)
            {
            }
        }
    }
}