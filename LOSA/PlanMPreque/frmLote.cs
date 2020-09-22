using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.TransaccionesMP;
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

namespace LOSA.PlanMPreque
{
    public partial class frmLote : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int IdRequisicionDetalle;
        MateriaPrima MP;
        decimal CantidadPendiente;
        int id_unidad;
        public frmLote(UserLogin pUsuarioLogeado, int pIdRequisicionDetalle, int IdRM, decimal pCantidad, int pIdUnidad, string pUnidadName)
        {
            InitializeComponent();
            MP = new MateriaPrima();
            UsuarioLogeado = pUsuarioLogeado;
            IdRequisicionDetalle = pIdRequisicionDetalle;
            CantidadPendiente = pCantidad;
            txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente);
            txtSolicitada.Text = string.Format("{0:###,##0.00}", CantidadPendiente);
            id_unidad = pIdUnidad;
            lblUnidad.Text = pUnidadName;

            if (MP.RecuperarRegistroFromID_RM(IdRM))
            {
                txtCodigoMP.Text = MP.Codigo;
                txtMP_Name.Text = MP.Name;
            }

            LoadDetalleLotes();
        }

        private void LoadDetalleLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_mp_plan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", MP.IdMP_ACS);
                cmd.Parameters.AddWithValue("@id_detalle_req", IdRequisicionDetalle);

                dsTransaccionesMP1.detalle_lote_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.detalle_lote_mp);

                con.Close();
                InicializarData();
                //CalculoTotales();
                seterror();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void InicializarData()
        {
            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;
            decimal cantidad_conseguida = 0;
            foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
            {
                if (row.seleccionado)
                {
                    cantidad_conseguida = cantidad_conseguida + row.cants;
                }
                txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
            }
            

        }
        private void seterror()
        {
            decimal val = 0;
            try
            {
                val = Convert.ToDecimal(txtCantidadPendiente.Text);
            }
            catch { }

            if (val != 0)
            {
                errorProvider1.SetError(txtCantidadPendiente, "Hay materia prima pendiente de asignar lote!!");
                //dxErrorProvider1.SetError(txtCantidadPendiente, 
                //                          "Hay materia prima pendiente de asignar lote!!", 
                //                          DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            }
            else
            {
                //dxErrorProvider1.ClearErrors();
                errorProvider1.Clear();
            }
        }
        private void CalculoTotales()
        {
            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;
            decimal cantidad_conseguida = 0;
            foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
            {
                if (row.peso_total == cantidaPendiente)
                {
                    row.seleccionado = true;
                    cantidaPendiente = 0;
                    row.cants = row.peso_total;
                    break;
                }
                if (row.peso_total > cantidaPendiente && cantidaPendiente > 0)
                {
                    if (row.peso_total > cantidaPendiente)
                        row.cants = cantidaPendiente;
                    else
                        row.cants = total_solicitado - cantidaPendiente;

                    row.cants = row.peso_total - cantidaPendiente;
                    cantidaPendiente -= row.cants;
                    //Calculo de totales.
                    if (row.seleccionado)
                    {
                        cantidad_conseguida += row.cants;

                        txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                        txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                    }
                    row.seleccionado = true;
                    break;
                }
                else
                {
                    //en el row tenemos un valor menor que el solicitado
                    //Necesitaremos mas de un row para satisfaser la cantidad requerida.
                    if (row.peso_total < cantidaPendiente && cantidaPendiente > 0)
                    {
                        //seleccionamos la cantidad total del row para acumular el valor solictado.
                        row.cants = row.peso_total;

                        //Restamos la cantidad conseguida o asignada.
                        cantidaPendiente -= row.cants;

                        //Marcamos el row seleccionado porque se utilizaria dicho lote para la requisicion.
                        row.seleccionado = true;
                    }
                }
                //Calculo de totales.
                if (row.seleccionado)
                    cantidad_conseguida += row.cants;

                txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                //end block foreach
            }
        
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int Seleccionados = 0;
            foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
            {
                if (row.seleccionado)
                {
                    Seleccionados++;
                    break;
                }
            }

            if (Seleccionados <= 0)
            {
                DialogResult r = CajaDialogo.Pregunta("No ha seleccionado ningun lote, si guarda la informacion se eliminara la configuracion! \nDesea continuar con el guardado??");
                
                if (r != DialogResult.Yes)
                    return;
            }

            decimal pendiente = 0;
            if (Convert.ToDecimal(txtCantidadPendiente.Text) > 0)
            {
                DialogResult r = CajaDialogo.Pregunta("Las cantidades seleccionadas no abastecen el total requerido!!\nDesea Guardar el avance seleccionado?");
                if (r != DialogResult.Yes)
                    return;
            }
            else
            {
                if (Convert.ToDecimal(txtCantidadPendiente.Text)<0)
                {
                    DialogResult r = CajaDialogo.Pregunta("Las cantidades seleccionadas sobre pasa el total requerido!!\nDesea Guardar el avance seleccionado?");
                    if (r != DialogResult.Yes)
                        return;
                }
            }


            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd1 = new SqlCommand("sp_set_delete_seleccion_lote_plan", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_detalle_req", IdRequisicionDetalle);
                cmd1.ExecuteNonQuery();

                foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
                {
                    if (row.seleccionado)
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_insert_lotes_req_plan_mp", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote_mp", row.lote_mp);
                        cmd.Parameters.AddWithValue("@id_detalle_req", IdRequisicionDetalle);
                        cmd.Parameters.AddWithValue("@cantidad", row.cants);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        cmd.Parameters.AddWithValue("@idmp", MP.IdMP_ACS);
                        cmd.Parameters.AddWithValue("@n_ingreso", row.numero_transaccion);
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void chkAutoSelect_CheckedChanged(object sender, EventArgs e)
        {
            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;
            decimal cantidad_conseguida = 0;
            if (chkAutoSelect.Checked)
            {
                //var gridView = (GridView)grRequisicoinesMP.FocusedView;
                //var row = (dsTransaccionesMP.detalle_lote_mpRow)gridView.GetFocusedDataRow();

                foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
                {
                    if (row.peso_total == cantidaPendiente)
                    {
                        row.seleccionado = true;
                        cantidaPendiente = 0;
                        row.cants = row.peso_total;
                        break;
                    }
                    if (row.peso_total > cantidaPendiente && cantidaPendiente > 0)
                    {
                        if (row.peso_total > cantidaPendiente)
                            row.cants = cantidaPendiente;
                        else
                            row.cants = total_solicitado - cantidaPendiente;

                        //row.cants = row.peso_total - cantidaPendiente;
                        cantidaPendiente -= row.cants;
                        row.seleccionado = true;
                     
                        
                    }
                    else
                    {
                        //en el row tenemos un valor menor que el solicitado
                        //Necesitaremos mas de un row para satisfaser la cantidad requerida.
                        if (row.peso_total < cantidaPendiente && cantidaPendiente > 0)
                        {
                            if (row.peso_total > 0)
                            {
                                //seleccionamos la cantidad total del row para acumular el valor solictado.
                                row.cants = row.peso_total;

                                //Restamos la cantidad conseguida o asignada.
                                cantidaPendiente -= row.cants;

                                //Marcamos el row seleccionado porque se utilizaria dicho lote para la requisicion.
                                row.seleccionado = true;
                            }
                        }
                    }

                    //Calculo de totales.
                    if (row.seleccionado)
                        cantidad_conseguida += row.cants;

                    txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                    txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                    //end block foreach
                }
            }
            else
            {
                foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
                {
                    row.seleccionado = false;
                    row.cants = 0;
                   
                }
                txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente);
                txtAsignada.Text = string.Format("{0:###,##0.00}", 0);
            }
        }

        private void gvTarimas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "colcants":
                    var gridView = (GridView)grRequisicoinesMP.FocusedView;
                    var row = (dsTransaccionesMP.detalle_lote_mpRow)gridView.GetFocusedDataRow();

                    if (row.peso_total <= 0)
                    {
                        CajaDialogo.Error("No se puede asignar lotes que tienen cantidad menor que cero!");
                        row.cants = 0;
                        row.seleccionado = false;
                    }
                    else
                    {
                        row.seleccionado = true;
                        decimal cantidad_conseguida = 0;
                        decimal cantidad_solicitada = CantidadPendiente;
                        decimal cantidad_pendiente = Convert.ToDecimal(txtCantidadPendiente.Text);
                        decimal trans = 0;
                        if (row.cants >= cantidad_pendiente)
                        {
                            row.cants = cantidad_pendiente;
                        }
                        foreach (dsTransaccionesMP.detalle_lote_mpRow row2 in dsTransaccionesMP1.detalle_lote_mp.Rows)
                        {
                            if (row2.seleccionado)
                            {
                                cantidad_conseguida = cantidad_conseguida + row2.cants;
                            }
                        }

                        txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                        txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                    }

                    if (row.cants == 0)
                    {
                        row.seleccionado = false;
                    }

                    break;
                default:
                    break;
            }
            seterror();


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}