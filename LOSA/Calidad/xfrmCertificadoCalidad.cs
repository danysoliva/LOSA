using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Calidad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOSA.Calidad.xfrm_formula_FFIF_New;

namespace LOSA.Calidad
{
    public partial class xfrmCertificadoCalidad : DevExpress.XtraEditors.XtraForm
    {
        public xfrmCertificadoCalidad()
        {
            InitializeComponent();
            loadFFIF_H();
            loadFormulas();
        }

        private void loadFFIF_H()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_Formula_FFIF_H", cnx);

                    dsMantenimientoC.FFIF_H.Clear();
                    da.Fill(dsMantenimientoC.FFIF_H);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            xfrm_formula_FFIF_New frm = new xfrm_formula_FFIF_New((int)Transaccion.Nuevo, null);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadFFIF_H();
            }
        }


        private void loadFFIF_D(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_load_formula_FFIF_d", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h;
                    //da.SelectCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;

                    dsMantenimientoC.FFIF_D.Clear();
                    da.Fill(dsMantenimientoC.FFIF_D);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        int id_h_active = 0;
        private void gvFFIF_H_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gvFFIF_D_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                var row = (dsMantenimientoC.FFIF_DRow)gvFFIF_D.GetFocusedDataRow();
                DataOperations dp = new DataOperations();

                if (id_h_active == 0)
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN CERTIFICADO");
                    return;
                }

                row.date_posted = DateTime.Now;


                if (row != null)
                {
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("dbo.sp_insert_update_Formula_FFIF_d", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h_active;
                        cmd.Parameters.Add("@id_formula", SqlDbType.Int).Value = row.id_formula;
                        cmd.Parameters.Add("@version_foranea", SqlDbType.Int).Value = row.version_foranea;
                        cmd.Parameters.Add("@date_posted", SqlDbType.DateTime).Value = row.date_posted;
                        cmd.Parameters.Add("@FFIF", SqlDbType.Decimal).Value = row.FFIF;

                        cmd.ExecuteNonQuery();

                        cnx.Close();

                        loadFFIF_D(id_h_active);

                    }

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void loadFormulas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.get_formulas", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h;

                    dsMantenimientoC.Formula.Clear();
                    da.Fill(dsMantenimientoC.Formula);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvFFIF_D_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //try
            //{

            //    var row = (dsMantenimientoC.FFIF_DRow)gvFFIF_D.GetFocusedDataRow();
            //    DataOperations dp = new DataOperations();

            //    if (row != null)
            //    {
            //        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
            //        {
            //            cnx.Open();

            //            SqlCommand cmd = new SqlCommand("dbo.sp_insert_update_Formula_FFIF_d", cnx);
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
            //            cmd.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h_active;
            //            cmd.Parameters.Add("@id_formula", SqlDbType.Int).Value = row.id_formula;
            //            cmd.Parameters.Add("@version_foranea", SqlDbType.Int).Value = row.version_foranea;
            //            cmd.Parameters.Add("@date_posted", SqlDbType.DateTime).Value = row.date_posted;
            //            cmd.Parameters.Add("@FFIF", SqlDbType.Decimal).Value = row.FFIF;

            //            cmd.ExecuteNonQuery();

            //            cnx.Close();

            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void gvFFIF_H_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                id_h_active = 0;

                var row = (dsMantenimientoC.FFIF_HRow)gvFFIF_H.GetFocusedDataRow();

                if (row != null)
                {
                    id_h_active = row.id;

                    loadFFIF_D(id_h_active);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimientoC.FFIF_HRow)gvFFIF_H.GetFocusedDataRow();
                FFIF_H item = new FFIF_H();

                xfrm_formula_FFIF_New frm;

                if (row != null)
                {
                    item.ID = row.id;
                    item.Comentario = row.comentario;
                    item.FechaInicial = row.dt_inicial;
                    item.FechaFinal = row.dt_final;
                    item.Mes = row.mes;
                    item.Anio = row.anio;

                    frm = new xfrm_formula_FFIF_New((int)Transaccion.Editar, item);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        loadFFIF_H();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "CONFIRMACIÓN", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection connectionBD = new SqlConnection(dp.ConnectionStringLOSA);
                    var row = (dsMantenimientoC.FFIF_HRow)gvFFIF_H.GetFocusedDataRow();

                    string query = @"UPDATE dbo.LOSA_FFIF_formula_h
                                        SET enable=0 
                                        WHERE id=" + row.id;

                    using (SqlCommand command = new SqlCommand(query, connectionBD))
                    {
                        connectionBD.Open();
                        //command.CommandType = CommandType.StoredProcedure;

                        command.ExecuteNonQuery();
                        connectionBD.Close();

                        loadFFIF_H();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnDelete2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "CONFIRMACIÓN", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection connectionBD = new SqlConnection(dp.ConnectionStringLOSA);
                    var row = (dsMantenimientoC.FFIF_DRow)gvFFIF_D.GetFocusedDataRow();

                    string query = @"UPDATE dbo.LOSA_FFIF_formula_d
                                        SET enable=0 
                                        WHERE id=" + row.id;

                    using (SqlCommand command = new SqlCommand(query, connectionBD))
                    {
                        connectionBD.Open();
                        //command.CommandType = CommandType.StoredProcedure;

                        command.ExecuteNonQuery();
                        connectionBD.Close();

                        loadFFIF_D(id_h_active);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validar_FFIF_D(id_h_active) > 0)
                {
                    CajaDialogo.Error("YA EXISTE UN FFIF");
                    return;
                }

                else
                {

                    FFIF_D item = new FFIF_D();

                    item.ID_H = id_h_active;

                    xfrmCertificadoCalidadCRUD frm = new xfrmCertificadoCalidadCRUD((int)Transaccion.Nuevo, item);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        loadFFIF_D(id_h_active);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public int Validar_FFIF_D(int id_h)
        {
            try
            {

                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("sp_validate_FFIF_Formula_d_by_id_h", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h;

                    int valor = (int)cmd.ExecuteScalar();

                    cnx.Close();

                    return valor;

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return 0;
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimientoC.FFIF_DRow)gvFFIF_D.GetFocusedDataRow();

                FFIF_D item = new FFIF_D();

                item.ID = row.id;
                item.FFIF = row.FFIF;
                item.FormulaID = row.id_formula;
                item.VersionForanea = row.version_foranea;

                xfrmCertificadoCalidadCRUD frm = new xfrmCertificadoCalidadCRUD((int)Transaccion.Editar,item);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    loadFFIF_D(id_h_active);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}