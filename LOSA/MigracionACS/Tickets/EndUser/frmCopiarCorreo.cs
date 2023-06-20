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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.Tickets.Models;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class frmCopiarCorreo : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public DataTable Dt;
        public DataTable Result;
        public frmCopiarCorreo(DataTable DestinoConfig)
        {
            InitializeComponent();
            load_data();
            Dt = DestinoConfig;
            //Inicializar_grid();
        }
        public void Inicializar_grid()
        {
            try
            {
            //    foreach (var item in dsTickets.userCorreos)
            //    {
            //        if (list.Where(x=> x.ID==item.id).ToList().Count()>0)
            //        {
            //            item.seleccionado = true;
            //        }

            //    }



                //foreach (DataRow row1 in Dt.Rows)
                //{
                //    foreach (ACS.Tickets.EndUser.dsTickets.userCorreosRow row in dsTickets.userCorreos.Rows)
                //    {
                //        if (row1["id"].ToString() == row.id.ToString())
                //        {
                //            row.seleccionado = true;
                //            if (Convert.ToBoolean(row1["CC"]))
                //            {
                //                row.CC = true;
                //            }

                //            dsTickets.userCorreos.AcceptChanges();
                //            break;

                //        }    
                //    }
                //}

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
            
        }
        public void load_data()
        {
            string Query = @"sp_tk_obtener_user_and_mail";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsTickets.userCorreos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTickets.userCorreos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public List<CopiaCorreo> list = new List<CopiaCorreo>();
        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Result = dsTickets.userCorreos;


            try
            {
                var gv = (GridView)grd_data.FocusedView;



                foreach (var item in dsTickets.userCorreos)
                {
                    if (list.Where(x => x.ID == item.id).ToList().Count() == 0)
                    {
                        CopiaCorreo copiaCorreo = new CopiaCorreo();

                        if (item.seleccionado == true)
                        {
                            copiaCorreo.ID = item.id;
                            copiaCorreo.Correo = item.corro;
                            copiaCorreo.User = item.user;
                            copiaCorreo.CC = item.CC;

                            list.Add(copiaCorreo);
                        }
                    }
                }



                //for (int i = 0; i < gv.RowCount; i++)
                //{
                //    var row = (dsTickets.userCorreosRow)grdv_data.GetDataRow(i);
                //    CopiaCorreo copiaCorreo = new CopiaCorreo();
                //    if (row.seleccionado == true)
                //    {
                //        copiaCorreo.ID = row.id;
                //        copiaCorreo.Correo = row.corro;
                //        copiaCorreo.User = row.user;
                //        copiaCorreo.CC = row.CC;
                //        list.Add(copiaCorreo);
                //    }
                //}

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }






            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{      	   
            //    var gridView = (GridView)grd_data.FocusedView;
	           // var row = (dsTickets.userCorreosRow)gridView.GetFocusedDataRow();
            //    int IdUser = row.id;
            //    if (e.Column.Name == "colselecionado")
            //    {
            //        foreach (ACS.Tickets.EndUser.dsTickets.userCorreosRow Data in dsTickets.userCorreos.Rows)
            //        {

            //            if (IdUser == row.id)
            //            {
            //                row.selecionado = Convert.ToBoolean(e.Value);
            //            }
            //        }
            //    }
            //    if (e.Column.Name == "colCC")
            //    {
            //        foreach (ACS.Tickets.EndUser.dsTickets.userCorreosRow Data in dsTickets.userCorreos.Rows)
            //        {

            //            if (IdUser == row.id)
            //            {
            //                row.CC = Convert.ToBoolean(e.Value);
            //            }
            //        }
            //    }


            //}
            //catch (Exception ex)
            //{

                
            //}
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var gv = (GridView)grd_data.FocusedView;
                var row = (dsTickets.userCorreosRow)grdv_data.GetDataRow(gv.FocusedRowHandle);


                if (list.Where(x=> x.ID==row.id).ToList().Count()==0)
                {
                    CopiaCorreo copiaCorreo = new CopiaCorreo();

                    //if (row.seleccionado == true)
                    //{
                        copiaCorreo.ID = row.id;
                        copiaCorreo.Correo = row.corro;
                        copiaCorreo.User = row.user;
                        copiaCorreo.CC = row.CC;

                        list.Add(copiaCorreo);
                    //}

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            grdv_data.PostEditor();

        }
    }
    
}