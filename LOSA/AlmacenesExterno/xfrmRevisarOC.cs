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
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.AlmacenesExterno.Models;
using LOSA.Clases;

namespace LOSA.AlmacenesExterno
{
    public partial class xfrmRevisarOC : DevExpress.XtraEditors.XtraForm
    {
        OrdenCompra_H oc_h = new OrdenCompra_H();

        UserLogin UsuarioLogueado;

        public xfrmRevisarOC(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogueado = pUser;
            ObtenerBodegas();
            LoadPresentaciones();
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAlmacenesExternos.presentacion.Clear();
                adat.Fill(dsAlmacenesExternos.presentacion);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void ObtenerBodegas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    dsAlmacenesExternos.Warehouse.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_almacenes_externos_bodegas", cnx);
                    da.Fill(dsAlmacenesExternos.Warehouse);


                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnOC_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            xfrmSeleccionarOC frm = new xfrmSeleccionarOC();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                oc_h = frm.oc;
                txtProveedor.Text = frm.oc.Proveedor;
                txtDate.EditValue = frm.oc.FechaDocumento;
                txtComment.Text = frm.oc.Comentario;
                btnOC.Text = frm.oc.DocNum.ToString();

                LoadOCDetail(frm.oc.DocNum);
            }
        }

        private void LoadOCDetail(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {

                    cnx.Open();
                    dsAlmacenesExternos.RevisionOC.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_OC_Detail_AlmacenesExternos", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@DocEntry", SqlDbType.Int).Value = id;
                    da.Fill(dsAlmacenesExternos.RevisionOC);
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        SqlTransaction transaction;
        private void btn_Click(object sender, EventArgs e)
        {
            List<Conf_MP_Ingresada> lista = new List<Conf_MP_Ingresada>();

            var gv = (GridView)gcIngreso.FocusedView;

                       
            foreach (var element in dsAlmacenesExternos.RevisionOC)
            {
                if (element.seleccionar == true)
                {
                    if (element.CantidadIngresar == 0)
                    {
                        CajaDialogo.Error("DEBE DE INGRESAR UNA CANTIDAD");
                        return;
                    }

                    if (element.UnidadesIngresar == 0)
                    {
                        CajaDialogo.Error("DEBE DE INGRESAR LAS UNIDADES");
                        return;
                    }

                    if (element.diferencia == 0)
                    {
                        CajaDialogo.Error("YA SE INGRESO LA MISMA CANTIDAD DE LA ORDEN DE COMPRA");
                        return;
                    }


                    if (element.diferencia > 0)
                    {

                        lista.Add(new Conf_MP_Ingresada
                        {
                            ItemCode = element.ItemCode,
                            CantIngresada = element.CantidadIngresar,
                            Descripcion = element.Dscription,
                            UnidadesIngresadas = element.UnidadesIngresar,
                            LineNum = element.LineNum,
                            MPID = element.id_mp,
                            bodega = element.bodega,
                            id_presentacion = element.id_presentacion
                        }) ;

                    }
                }
            }


            //}
            xfrmAlmacenesExternosDefinirLotes frm = new xfrmAlmacenesExternosDefinirLotes(lista,oc_h,UsuarioLogueado );

            if (frm.ShowDialog()== DialogResult.OK)
            {
                this.Close();
            }
            //frm.Show();
        }

        private void gvIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gv = (GridView)gcIngreso.FocusedView;
            var row = (dsAlmacenesExternos.RevisionOCRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (row != null)
            {
                if (row.CantidadIngresar > row.kg)
                {
                    CajaDialogo.Error("LA CANTIDAD INGRESADA ES SUPERIOR A LO QUE DISPONE LA ORDEN DE COMPRA");
                    row.CantidadIngresar = 0;
                    return;
                }

                if (row.diferencia <= 0 )
                {
                    CajaDialogo.Error("YA SE INGRESO LA MISMA CANTIDAD DE LA ORDEN DE COMPRA");
                    row.CantidadIngresar = 0;
                    return;
                }

                if ( row.CantidadIngresar > row.diferencia && row.diferencia > 0)
                {
                    CajaDialogo.Error("DEBE DE INGRESAR UNA CANTIDAD MENOR O IGUAL A " + row.diferencia+ " Para esta MP");
                    row.CantidadIngresar = 0;
                    return;
                }

                if (row.seleccionar == true)
                {
                    if (row.diferencia <= 0)
                    {
                        CajaDialogo.Error("NO PUEDE SELECCIONAR ESTE ITEM PORQUE YA HA SIDO INGRESADO TOTALMENTE");
                        row.seleccionar = false;
                        return;
                    }

                }
            }
        }

        private void ceSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            var gv = (GridView)gcIngreso.FocusedView;
            var row = (dsAlmacenesExternos.RevisionOCRow)gv.GetDataRow(gv.FocusedRowHandle);

            //if (row.seleccionar==true)
            //{
            //    if (row.diferencia<=0)
            //    {
            //        CajaDialogo.Error("NO PUEDE SELECCIONAR ESTE ITEM PORQUE YA HA SIDO INGRESADO TOTALMENTE");
            //        row.seleccionar = false;
            //        return;
            //    }

            //}
        }
    }
}