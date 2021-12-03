using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frmMP_Granel : Form
    {
        UserLogin UsuarioLogeado;
        ArrayList list = new ArrayList();
        ArrayList listMP = new ArrayList();
        public frmMP_Granel(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadData();
            LoadBarcos();
            LoadUbicaciones();
        }

        private void LoadUbicaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"sp_get_lista_ubicaciones_granel";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_barra", "");
                dsRecepcionMPx1.ubicaciones_granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.ubicaciones_granel);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void LoadBarcos()
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ships_active_for_losa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx1.barcos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.barcos);

                con.Close();
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
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ingresos_granel_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx1.granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.granel);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdPasarAlosy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Registrar en ALOSY

        }

        private void cmdLoteActivo_Click(object sender, EventArgs e)
        {
            frmLoteActvoGranel frm = new frmLoteActvoGranel(UsuarioLogeado);
            frm.Show();
        }

        private void checkBoxSeleccionarTodas_CheckedChanged(object sender, EventArgs e)
        {
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                row.seleccionar = checkBoxSeleccionarTodas.Checked;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Generar ingreso de granel
            int Total = 0;
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                if (row.seleccionar)
                {
                    Total++;
                }
            }
            if(Total == 0)
            {
                CajaDialogo.Error("¡Es necesario seleccionar al menos una boleta!");
                return;
            }

            //Agregamos las boletas seleccionadas
            list = new ArrayList();
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                if (row.seleccionar)
                {
                    AddItemCode(row.itemcode, row.Producto);
                }
            }

            frmMP_Granel_Selec_Lote frm = new frmMP_Granel_Selec_Lote(list);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                ArrayList ListaRes = frm.ListaResultados;
                foreach(ItemMP_Lote Item in ListaRes)
                {
                    //hacer la lista de boletas.
                    ArrayList ListaBoletas = new ArrayList();
                    foreach(dsRecepcionMPx.granelRow row_granel in dsRecepcionMPx1.granel.Rows)
                    {
                        if (row_granel.seleccionar)
                        {
                            if(row_granel.itemcode == Item.ItemCode)
                            {
                                ListaBoletas.Add(row_granel);
                            }
                        }
                    }

                    frmIngresoGranelAlosy frm1 = new frmIngresoGranelAlosy(this.UsuarioLogeado, ListaBoletas, Item);
                    if(frm1.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }

            //frmIngresoGranelAlosy frm = new frmIngresoGranelAlosy(this.UsuarioLogeado,list);
            //frm.Show();
        }

        private void AddItemCode(string itemcode, string pName)
        {
            if(list.Count == 0)
            {
                //Lo agregamos por que es el primero
                ItemMP_Lote Item = new ItemMP_Lote();
                Item.ItemCode = itemcode;
                Item.Card_Name = pName;
                list.Add(Item);
            }
            else
            {
                //Vamos a verificar si el codigo esta en lista
                bool Exist = false;
                foreach (ItemMP_Lote vItemCode in list)
                {
                    if(itemcode == vItemCode.ItemCode)
                    {
                        Exist = true;
                    }
                }

                //Si el codigo no esta en lista lo vamos agregar
                if (!Exist)
                {
                    ItemMP_Lote Item = new ItemMP_Lote
                    {
                        ItemCode = itemcode,
                        Card_Name = pName
                    };
                    list.Add(Item);
                }

            }
        }

        private void AddItemCodeMP(string itemcode, string pName)
        {
            if (listMP == null)
                listMP = new ArrayList();
        
            if (listMP.Count == 0)
            {
                //Lo agregamos por que es el primero
                MateriaPrima Item = new MateriaPrima();
                Item.CodeMP_SAP = itemcode;
                Item.Name = pName;
                listMP.Add(Item);
            }
            else
            {
                //Vamos a verificar si el codigo esta en lista
                bool Exist = false;
                foreach (MateriaPrima vItemCode in listMP)
                {
                    if (itemcode == vItemCode.CodeMP_SAP)
                        Exist = true;
                }

                //Si el codigo no esta en lista lo vamos agregar
                if (!Exist)
                {
                    MateriaPrima Item = new MateriaPrima
                    {
                        CodeMP_SAP = itemcode,
                        Name = pName
                    };
                    listMP.Add(Item);
                }

            }
        }

        private void cmdChangeRM_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //dsRecepcionMPx1
            //granel
            var gridView = (GridView)gcMP.FocusedView;
            var row = (dsRecepcionMPx.granelRow)gridView.GetFocusedDataRow();

            if(row.itemcode.Trim() == "MP00003" || row.itemcode.Trim() == "MP00004")
            {
                int Total = 0;
                foreach (dsRecepcionMPx.granelRow row_i in dsRecepcionMPx1.granel.Rows)
                {
                    if (row_i.seleccionar)
                    {
                        Total++;
                    }
                }
                if (Total == 0)
                {
                    CajaDialogo.Error("¡Es necesario seleccionar al menos una boleta!");
                    return;
                }

                //Agregamos las boletas seleccionadas
                listMP = new ArrayList();
                foreach (dsRecepcionMPx.granelRow row_i in dsRecepcionMPx1.granel.Rows)
                {
                    if (row_i.seleccionar)
                    {
                        AddItemCodeMP(row_i.itemcode, row_i.Producto);
                    }
                }

                frmMP_Granel_Selec_MP frm = new frmMP_Granel_Selec_MP(listMP);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ArrayList ListaRes = frm.ListaResultados;
                    foreach (MateriaPrima Item in ListaRes)
                    {
                        //hacer la lista de boletas.
                        ArrayList ListaBoletas = new ArrayList(); 
                        foreach (dsRecepcionMPx.granelRow row_granel in dsRecepcionMPx1.granel.Rows)
                        {
                            if (row_granel.seleccionar)
                            {
                                if (row_granel.itemcode == Item.CodeMP_SAP)
                                {
                                    ListaBoletas.Add(row_granel);
                                }
                            }
                        }

                        //frmIngresoGranelAlosy frm1 = new frmIngresoGranelAlosy(this.UsuarioLogeado, ListaBoletas, Item);
                        //if (frm1.ShowDialog() == DialogResult.OK)
                        //{
                        //    LoadData();
                        //}
                    }
                }


            }
            else
            {
                CajaDialogo.Information("¡Solo se Permite el cambio en Harinas de Soya!");
            }

        }
    }
}
