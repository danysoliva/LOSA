﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.TransaccionesMP
{
    public partial class frmResumenToEntregar : DevExpress.XtraEditors.XtraForm
    {
        public decimal ExistenciaTarimaKg = 0;
        public decimal ExistenciaTarimaUnidades = 0;
        public decimal entregado = 0;
        public decimal Solicitado = 0;
        public decimal RestanteReq = 0;
        public decimal RestanteTm = 0;
        public decimal ExistenciaKg = 0;
        public decimal pesoKg = 0;
        public int id_tm;
        public decimal factor;
        public decimal ud_enviar = 0;
        public decimal kg_enviar = 0;
        public int BasculaID = 0;
        int IsMacroIngrediente;

        DataOperations dp = new DataOperations();

        enum Basculas
        {
            Bascula1 = 1,
            Bascula2 = 2
        }

        //RUTA PRINCIPAL PARA ENTREGA DE MATERIA PRIMA!
        public frmResumenToEntregar(
                                    decimal ExistenciaTarima_kg,//Kg
                                    decimal pExistenciaTarima_Unidades,
                                    decimal PEntregado_Kg,
                                    decimal psolicitado_Kg,
                                    DataTable Tarima,
                                    int Pid_tm,
                                    decimal Pfactor
                                    )
        {

            InitializeComponent();
            vGridControl1.DataSource = Tarima;
            ExistenciaTarimaUnidades = pExistenciaTarima_Unidades;
            this.ExistenciaTarimaKg = ExistenciaTarima_kg;
            ud_enviar = ExistenciaTarimaKg;
            factor = Pfactor;
            ExistenciaKg = ExistenciaTarimaKg * factor;
            lblTotalUd_en_tarima.Text = string.Format("{0:###,##0}", pExistenciaTarima_Unidades) + " Ud";
            entregado = PEntregado_Kg;
            Solicitado = psolicitado_Kg;
            id_tm = Pid_tm;

            Calculo();
            txtEnviados.Text = string.Format("{0:###,##0.00}", entregado);
            txtSolicitados.Text = string.Format("{0:###,##0.00}", Solicitado);
            //txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
            txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
            //txtRestanteTarimasUnidades.Text = string.Format("{0:###,##0}", RestanteTm);
            obtener_factor();

            decimal vPendienteKg = psolicitado_Kg - PEntregado_Kg;
            if (factor > 0)
            {
                ud_enviar = vPendienteKg / factor;
                int ud_enviar_int32 = dp.ValidateNumberInt32(ud_enviar);
                int ud_en_tarima_actual = dp.ValidateNumberInt32( ExistenciaTarimaKg /factor);

                

                if(ud_enviar_int32 == 0)
                {
                    ud_enviar = 1;
                }
                else
                {
                    if (ud_enviar_int32 <= ud_en_tarima_actual)
                        ud_enviar = ud_enviar_int32;
                    else
                        ud_enviar = ud_en_tarima_actual;
                }

                txtRestanteTarimasUnidades.Text = string.Format("{0:###,##0}", pExistenciaTarima_Unidades - ud_enviar);
                txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
                CalcularKg(dp.ValidateNumberInt32(Math.Round(ud_enviar, 0)));
            }



            Tarima tm = new Tarima();
            tm.ValidarSiEsMPBscula(id_tm);
            if (tm.IsMacroIngrediente)
            {
                btnBasc1.Visible = true;
                btnBasc2.Visible = true;
                DisponibilidadDeBascula();
            }

        }

        private void DisponibilidadDeBascula()
        {
            try
            {
                int DisponibleBascula1 = 1;
                int DisponibleBascula2 = 1;

                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_disponibilidad_bascula", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DisponibleBascula1 = dr.GetInt32(0);
                    DisponibleBascula2 = dr.GetInt32(1);
                    
                }
                dr.Close();
                conn.Close();

                if (DisponibleBascula2 == 0)
                {
                    BasculaID = (int)Basculas.Bascula1;
                    btnBasc1.Appearance.BackColor = default(Color);
                    btnBasc2.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
                    simpleButton1.Enabled = true;
                    BasculaID = Convert.ToInt32(Basculas.Bascula2);
                }
                else
                {
                    btnBasc2.Enabled = false;
                }
                

                if (DisponibleBascula1 == 0)
                {
                    BasculaID = (int)Basculas.Bascula1;
                    btnBasc2.Appearance.BackColor = default(Color);
                    btnBasc1.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
                    simpleButton1.Enabled = true;
                    BasculaID = Convert.ToInt32(Basculas.Bascula1);
                }
                else
                {
                    btnBasc1.Enabled = false;
                }
                
                if (DisponibleBascula1 > 0 && DisponibleBascula2 > 0)
                {
                    simpleButton1.Enabled = false;
                    lblErrorBascula.Text = "BASCULAS CON TARIMAS PENDIENTES DE ENTREGA\nSe debe Completar los Pesajes pendientes!";
                    lblErrorBascula.Visible = true;

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public frmResumenToEntregar(int pid_tm, decimal pExistenciaTarimaKg, decimal pExistenciaTarimaUnidades, decimal pEntregadoRequisa, decimal pSolicitadoRequisa)
        {
            InitializeComponent();
            //vGridControl1.DataSource = Tarima;
            ExistenciaTarimaUnidades = pExistenciaTarimaUnidades;
            ExistenciaTarimaKg = pExistenciaTarimaKg;
            ExistenciaKg = ExistenciaTarimaKg;
            lblTotalUd_en_tarima.Text = string.Format("{0:###,##0}", ExistenciaTarimaUnidades) + " Ud";
            entregado = pEntregadoRequisa;
            Solicitado = pSolicitadoRequisa;
            id_tm = pid_tm;
            btnUP.Enabled = false;
            btnDown.Enabled = false;
            
            txtEnviados.Text = string.Format("{0:###,##0.00}", entregado);
            txtSolicitados.Text = string.Format("{0:###,##0.00}", Solicitado);
            
            txtPorEnviar.Text= string.Format("{0:###,##0.00}", ExistenciaTarimaUnidades);
            txtKgAEnviar.Text = string.Format("{0:###,##0.00}", ExistenciaKg);
            txtRestanteTarimasUnidades.Text = string.Format("{0:###,##0.00}", ExistenciaTarimaUnidades);

            txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);

            Tarima tm = new Tarima();
            tm.ValidarSiEsMPBscula(id_tm);
            if (tm.IsMacroIngrediente)
            {
                btnBasc1.Visible = true;
                btnBasc2.Visible = true;
                DisponibilidadDeBascula();
            }

        }

        public void Calculo()
        {
            RestanteReq = Solicitado - entregado;
            if (RestanteReq < 0 )
            {
                RestanteReq = 0;
            }
            else
            {
                decimal aux = 0;
                aux  = RestanteReq - ExistenciaKg;

                if (aux < 0 || aux == 0)
                {
                    RestanteTm = ExistenciaKg - RestanteReq;
                    RestanteReq = 0;
                    //if (factor > 0)
                    //{
                    //    ud_enviar = Convert.ToInt32((ExistenciaKg - RestanteTm) / factor);
                    //    //RestanteTm = Convert.ToInt32(RestanteTm / factor);
                    //}
                    //else
                    //{
                    //    ud_enviar = 0;
                    //}
                }
                else
                {
                    RestanteTm = ExistenciaTarimaKg - ExistenciaKg / factor;
                    RestanteReq = aux;
                    ud_enviar = ExistenciaKg / factor;
                }

            }
        }

        public void obtener_factor() 
        {
            string qeyr = @"sp_obtener_presentacion_of_id_tm";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(qeyr,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", id_tm);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    factor = dr.GetDecimal(0);
                }
                else
                {
                    factor = 1;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
               
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            #region codigo old
            //if (ExistenciaKg + factor > ExistenciaTM * factor)
            //{

            //}
            //else
            //{
            //    ud_enviar = ud_enviar + 1;
            //    ExistenciaKg = ExistenciaKg + factor;
            //    CalculoUD();
            //    txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
            //    txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
            //    textEdit1.Text = string.Format("{0:###,##0.00}", RestanteTm);
            //}
            #endregion
            int ud_enviar = dp.ValidateNumberInt32(txtPorEnviar.Text);
            
            if (ud_enviar == 0)
            {
                if (Solicitado > 0)
                {
                    if (entregado <= Solicitado)
                    {
                        if (this.ExistenciaTarimaKg >= 1)
                        {
                            txtPorEnviar.Text = "1";
                            ud_enviar = 1;
                        }
                    }
                }
            }
            else
            {
                if (ud_enviar == ExistenciaTarimaUnidades)
                {
                    //Si entra aqui, no puede subir mas por que no hay mas unidades en la tarima!
                }
                else
                {
                    if (ud_enviar < this.ExistenciaTarimaKg)
                    {
                        if (kg_enviar + entregado < Solicitado)
                        {
                            ud_enviar++;
                            txtPorEnviar.Text = string.Format("{0:###,##0}", (ud_enviar));
                        }
                    }
                }
            }

            //if (ud_enviar == Convert.ToInt32(lblTotalUd_en_tarima.Text))
            //{
            //    //SI lo enviado es igual a lo que existe en tarima! que no permita sumar mas
            //}

            CalcularKg(ud_enviar);
            this.ud_enviar = ud_enviar;
        }

        private void CalcularKg(int pudAenviar)
        {
            if (pudAenviar > 0)
            {
                if (this.Solicitado < factor)
                    kg_enviar = this.Solicitado;
                else
                    kg_enviar = factor * pudAenviar;
            }
            else
            {
                kg_enviar = 0;
            }

            txtKgAEnviar.Text = string.Format("{0:###,##0.00}", kg_enviar);
            txtRestanteTarimasUnidades.Text = string.Format("{0:###,##0.00}", (ExistenciaTarimaUnidades - pudAenviar));
        }

        public void CalculoUD() 
        {
            ExistenciaKg = ud_enviar * factor;
            RestanteReq = Solicitado - ExistenciaKg - entregado;
            RestanteTm = ExistenciaTarimaKg - ud_enviar;
        } 
        private void btnDown_Click(object sender, EventArgs e)
        {
            int UdEnviar = dp.ValidateNumberInt32(txtPorEnviar.Text);
            if (UdEnviar > 0)
            {
                //if (ExistenciaKg - factor < 0)
                //{

                //}
                //else
                //{
                //    ud_enviar = ud_enviar - 1;
                //    ExistenciaKg = ExistenciaKg - factor;
                //    CalculoUD();
                //    txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
                //    txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
                //    textEdit1.Text = string.Format("{0:###,##0.00}", RestanteTm);
                //}
                UdEnviar--;
                txtPorEnviar.Text = string.Format("{0:###,##0}", (UdEnviar));
            }
            CalcularKg(UdEnviar);

            this.ud_enviar = UdEnviar;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Tarima tm = new Tarima();
            tm.ValidarSiEsMPBscula(id_tm);
            if (tm.IsMacroIngrediente)
            {
                if (BasculaID == 0)
                {
                    Utileria.frmMensaje frm = new Utileria.frmMensaje(Utileria.frmMensaje.TipoMsj.error, "Debe seleccionar una Bascula");
                    frm.ShowDialog();
                    return;
                }
            }

            

            if (ExistenciaKg == 0 )
            {
                Utileria.frmMensaje frm = new Utileria.frmMensaje(Utileria.frmMensaje.TipoMsj.error, "Debe seleccionar aun que sea una unidad");
                frm.ShowDialog();
                return;
            }
            //pesoKg = ud_enviar * factor;
            pesoKg = dp.ValidateNumberDecimal(txtKgAEnviar.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void chConsumirPendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (chConsumirPendientes.Checked)
            {       //Vamos a consumir lo Pendiente
                RestanteReq = Solicitado - entregado; // Aqui tenemos lo restante en KG.
                ExistenciaKg = ExistenciaTarimaKg * factor; //AQui vemos los Kg que nos faltan.
                ud_enviar = 0; // Bueno inicializamos a 0 las enviar.
                decimal Validador = 0; // Es ayuda a llevar la cuenta de los kg que vamos a enviar.
                while (Validador <= RestanteReq && ExistenciaTarimaKg > ud_enviar)
                {
                    ud_enviar = ud_enviar + 1;
                    Validador = Validador + factor;
                }

                CalculoUD();

                txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
                txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
                txtRestanteTarimasUnidades.Text = string.Format("{0:###,##0.00}", ExistenciaTarimaUnidades - ud_enviar);


            }
        }

        private void frmResumenToEntregar_Load(object sender, EventArgs e)
        {
            //chConsumirPendientes.Checked = true;
        }

        private void btnBasc1_Click(object sender, EventArgs e)
        {
            BasculaID = (int)Basculas.Bascula1;
            btnBasc2.Appearance.BackColor = default(Color);
            btnBasc1.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
            simpleButton1.Enabled = true;
        }

        private void btnBasc2_Click(object sender, EventArgs e)
        {
            BasculaID = (int)Basculas.Bascula2;
            btnBasc1.Appearance.BackColor = default(Color);
            btnBasc2.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
            simpleButton1.Enabled = true;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenToEntregar));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSolicitados = new DevExpress.XtraEditors.TextEdit();
            this.txtEnviados = new DevExpress.XtraEditors.TextEdit();
            this.txtPorEnviar = new DevExpress.XtraEditors.TextEdit();
            this.txtRestante = new DevExpress.XtraEditors.TextEdit();
            this.txtRestanteTarimasUnidades = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnUP = new DevExpress.XtraEditors.SimpleButton();
            this.chConsumirPendientes = new DevExpress.XtraEditors.CheckEdit();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowid = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownombreTarima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownombreProveedor = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowfecha_ingreso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownumero_transaccion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowlote_materia_prima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpresentacion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowtipo_tarima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_boleta = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownum = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowIsMicro = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowitemcode = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmp_name = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalUd_en_tarima = new DevExpress.XtraEditors.LabelControl();
            this.txtKgAEnviar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnBasc2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBasc1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblErrorBascula = new DevExpress.XtraEditors.LabelControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnviados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorEnviar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestanteTarimasUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chConsumirPendientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKgAEnviar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(315, 608);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(175, 48);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cancelar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(122, 608);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(175, 48);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Entegar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 225);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(315, 30);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Cant Solicitada en requisa (Kg.):";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(90, 267);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(231, 30);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Cantidad Enviada (Kg.):";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 340);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(306, 30);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Por enviar de esta tarima (Ud.):";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(18, 488);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(303, 30);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Restante por Requisa (kg.):";
            this.labelControl4.Visible = false;
            // 
            // txtSolicitados
            // 
            this.txtSolicitados.Enabled = false;
            this.txtSolicitados.Location = new System.Drawing.Point(327, 222);
            this.txtSolicitados.Name = "txtSolicitados";
            this.txtSolicitados.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSolicitados.Properties.Appearance.Options.UseFont = true;
            this.txtSolicitados.Size = new System.Drawing.Size(237, 36);
            this.txtSolicitados.TabIndex = 14;
            // 
            // txtEnviados
            // 
            this.txtEnviados.Enabled = false;
            this.txtEnviados.Location = new System.Drawing.Point(327, 264);
            this.txtEnviados.Name = "txtEnviados";
            this.txtEnviados.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtEnviados.Properties.Appearance.Options.UseFont = true;
            this.txtEnviados.Size = new System.Drawing.Size(237, 36);
            this.txtEnviados.TabIndex = 15;
            // 
            // txtPorEnviar
            // 
            this.txtPorEnviar.Enabled = false;
            this.txtPorEnviar.Location = new System.Drawing.Point(327, 337);
            this.txtPorEnviar.Name = "txtPorEnviar";
            this.txtPorEnviar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPorEnviar.Properties.Appearance.Options.UseFont = true;
            this.txtPorEnviar.Size = new System.Drawing.Size(59, 36);
            this.txtPorEnviar.TabIndex = 16;
            // 
            // txtRestante
            // 
            this.txtRestante.Enabled = false;
            this.txtRestante.Location = new System.Drawing.Point(327, 482);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtRestante.Properties.Appearance.Options.UseFont = true;
            this.txtRestante.Size = new System.Drawing.Size(237, 36);
            this.txtRestante.TabIndex = 17;
            this.txtRestante.Visible = false;
            // 
            // txtRestanteTarimasUnidades
            // 
            this.txtRestanteTarimasUnidades.Enabled = false;
            this.txtRestanteTarimasUnidades.Location = new System.Drawing.Point(327, 444);
            this.txtRestanteTarimasUnidades.Name = "txtRestanteTarimasUnidades";
            this.txtRestanteTarimasUnidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtRestanteTarimasUnidades.Properties.Appearance.Options.UseFont = true;
            this.txtRestanteTarimasUnidades.Size = new System.Drawing.Size(237, 36);
            this.txtRestanteTarimasUnidades.TabIndex = 109;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(12, 452);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(309, 30);
            this.labelControl6.TabIndex = 108;
            this.labelControl6.Text = "Restante en tarima (Ud.):";
            // 
            // btnDown
            // 
            this.btnDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.ImageOptions.Image")));
            this.btnDown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDown.Location = new System.Drawing.Point(559, 326);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(76, 65);
            this.btnDown.TabIndex = 111;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUP
            // 
            this.btnUP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUP.ImageOptions.Image")));
            this.btnUP.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUP.Location = new System.Drawing.Point(479, 326);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(74, 65);
            this.btnUP.TabIndex = 110;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // chConsumirPendientes
            // 
            this.chConsumirPendientes.Location = new System.Drawing.Point(5, 614);
            this.chConsumirPendientes.Name = "chConsumirPendientes";
            this.chConsumirPendientes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.chConsumirPendientes.Properties.Appearance.Options.UseFont = true;
            this.chConsumirPendientes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.chConsumirPendientes.Properties.Caption = "Consumir lo pendiente de la Requisa";
            this.chConsumirPendientes.Size = new System.Drawing.Size(164, 36);
            this.chConsumirPendientes.TabIndex = 112;
            this.chConsumirPendientes.Visible = false;
            this.chConsumirPendientes.CheckedChanged += new System.EventHandler(this.chConsumirPendientes_CheckedChanged);
            // 
            // vGridControl1
            // 
            this.vGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vGridControl1.Appearance.RecordValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGridControl1.Appearance.RecordValue.Options.UseFont = true;
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.DataMember = null;
            this.vGridControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vGridControl1.Location = new System.Drawing.Point(10, 3);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.vGridControl1.RecordWidth = 453;
            this.vGridControl1.RowHeaderWidth = 130;
            this.vGridControl1.RowHeaderWidthChangeStep = 4;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowid,
            this.rownombreTarima,
            this.rownombreProveedor,
            this.rowfecha_ingreso,
            this.rownumero_transaccion,
            this.rowlote_materia_prima,
            this.rowpresentacion,
            this.rowtipo_tarima,
            this.rowid_boleta,
            this.rownum,
            this.rowIsMicro,
            this.rowitemcode,
            this.rowmp_name});
            this.vGridControl1.Size = new System.Drawing.Size(627, 200);
            this.vGridControl1.TabIndex = 113;
            // 
            // rowid
            // 
            this.rowid.Name = "rowid";
            this.rowid.Properties.Caption = "id";
            this.rowid.Properties.FieldName = "id";
            this.rowid.Properties.ReadOnly = true;
            this.rowid.Visible = false;
            // 
            // rownombreTarima
            // 
            this.rownombreTarima.Name = "rownombreTarima";
            this.rownombreTarima.Properties.Caption = "Código Barra";
            this.rownombreTarima.Properties.FieldName = "nombreTarima";
            this.rownombreTarima.Properties.ReadOnly = true;
            // 
            // rownombreProveedor
            // 
            this.rownombreProveedor.Name = "rownombreProveedor";
            this.rownombreProveedor.Properties.Caption = "Proveedor";
            this.rownombreProveedor.Properties.FieldName = "nombreProveedor";
            this.rownombreProveedor.Properties.ReadOnly = true;
            // 
            // rowfecha_ingreso
            // 
            this.rowfecha_ingreso.Name = "rowfecha_ingreso";
            this.rowfecha_ingreso.Properties.Caption = "Fecha Ingreso";
            this.rowfecha_ingreso.Properties.FieldName = "fecha_ingreso";
            this.rowfecha_ingreso.Properties.ReadOnly = true;
            // 
            // rownumero_transaccion
            // 
            this.rownumero_transaccion.AppearanceCell.Options.UseTextOptions = true;
            this.rownumero_transaccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rownumero_transaccion.Name = "rownumero_transaccion";
            this.rownumero_transaccion.Properties.Caption = "# Ingreso";
            this.rownumero_transaccion.Properties.FieldName = "numero_transaccion";
            this.rownumero_transaccion.Properties.ReadOnly = true;
            // 
            // rowlote_materia_prima
            // 
            this.rowlote_materia_prima.Name = "rowlote_materia_prima";
            this.rowlote_materia_prima.Properties.Caption = "Lote";
            this.rowlote_materia_prima.Properties.FieldName = "lote_materia_prima";
            this.rowlote_materia_prima.Properties.ReadOnly = true;
            // 
            // rowpresentacion
            // 
            this.rowpresentacion.Name = "rowpresentacion";
            this.rowpresentacion.Properties.Caption = "Presentación";
            this.rowpresentacion.Properties.FieldName = "presentacion";
            this.rowpresentacion.Properties.ReadOnly = true;
            // 
            // rowtipo_tarima
            // 
            this.rowtipo_tarima.Name = "rowtipo_tarima";
            this.rowtipo_tarima.Properties.Caption = "tipo_tarima";
            this.rowtipo_tarima.Properties.FieldName = "tipo_tarima";
            this.rowtipo_tarima.Properties.ReadOnly = true;
            this.rowtipo_tarima.Visible = false;
            // 
            // rowid_boleta
            // 
            this.rowid_boleta.Name = "rowid_boleta";
            this.rowid_boleta.Properties.Caption = "id_boleta";
            this.rowid_boleta.Properties.FieldName = "id_boleta";
            this.rowid_boleta.Properties.ReadOnly = true;
            this.rowid_boleta.Visible = false;
            // 
            // rownum
            // 
            this.rownum.Name = "rownum";
            this.rownum.Properties.Caption = "num";
            this.rownum.Properties.FieldName = "num";
            this.rownum.Properties.ReadOnly = true;
            this.rownum.Visible = false;
            // 
            // rowIsMicro
            // 
            this.rowIsMicro.Name = "rowIsMicro";
            this.rowIsMicro.Properties.Caption = "Is Micro";
            this.rowIsMicro.Properties.FieldName = "IsMicro";
            this.rowIsMicro.Properties.ReadOnly = true;
            this.rowIsMicro.Visible = false;
            // 
            // rowitemcode
            // 
            this.rowitemcode.Name = "rowitemcode";
            this.rowitemcode.Properties.Caption = "ItemCode";
            this.rowitemcode.Properties.FieldName = "itemcode";
            this.rowitemcode.Properties.ReadOnly = true;
            // 
            // rowmp_name
            // 
            this.rowmp_name.Name = "rowmp_name";
            this.rowmp_name.Properties.AllowEdit = false;
            this.rowmp_name.Properties.Caption = "Materia Prima";
            this.rowmp_name.Properties.FieldName = "mp_name";
            this.rowmp_name.Properties.ReadOnly = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(388, 340);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(10, 30);
            this.labelControl7.TabIndex = 114;
            this.labelControl7.Text = "/";
            // 
            // lblTotalUd_en_tarima
            // 
            this.lblTotalUd_en_tarima.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUd_en_tarima.Appearance.Options.UseFont = true;
            this.lblTotalUd_en_tarima.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalUd_en_tarima.Location = new System.Drawing.Point(399, 340);
            this.lblTotalUd_en_tarima.Name = "lblTotalUd_en_tarima";
            this.lblTotalUd_en_tarima.Size = new System.Drawing.Size(115, 30);
            this.lblTotalUd_en_tarima.TabIndex = 115;
            this.lblTotalUd_en_tarima.Text = "0 Ud";
            // 
            // txtKgAEnviar
            // 
            this.txtKgAEnviar.Enabled = false;
            this.txtKgAEnviar.Location = new System.Drawing.Point(327, 404);
            this.txtKgAEnviar.Name = "txtKgAEnviar";
            this.txtKgAEnviar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtKgAEnviar.Properties.Appearance.Options.UseFont = true;
            this.txtKgAEnviar.Size = new System.Drawing.Size(237, 36);
            this.txtKgAEnviar.TabIndex = 117;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 407);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(303, 30);
            this.labelControl5.TabIndex = 116;
            this.labelControl5.Text = "Por enviar de esta Tarima (Kg):";
            // 
            // btnBasc2
            // 
            this.btnBasc2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBasc2.Appearance.Options.UseFont = true;
            this.btnBasc2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBasc2.ImageOptions.Image = global::LOSA.Properties.Resources.weighing_machine_32X32;
            this.btnBasc2.Location = new System.Drawing.Point(353, 555);
            this.btnBasc2.Name = "btnBasc2";
            this.btnBasc2.Size = new System.Drawing.Size(112, 49);
            this.btnBasc2.TabIndex = 119;
            this.btnBasc2.Text = "Báscula 2";
            this.btnBasc2.Visible = false;
            this.btnBasc2.Click += new System.EventHandler(this.btnBasc2_Click);
            // 
            // btnBasc1
            // 
            this.btnBasc1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasc1.Appearance.Options.UseFont = true;
            this.btnBasc1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBasc1.ImageOptions.Image = global::LOSA.Properties.Resources.weighing_machine_32X321;
            this.btnBasc1.Location = new System.Drawing.Point(171, 555);
            this.btnBasc1.Name = "btnBasc1";
            this.btnBasc1.Size = new System.Drawing.Size(112, 49);
            this.btnBasc1.TabIndex = 118;
            this.btnBasc1.Text = "Báscula 1";
            this.btnBasc1.Visible = false;
            this.btnBasc1.Click += new System.EventHandler(this.btnBasc1_Click);
            // 
            // lblErrorBascula
            // 
            this.lblErrorBascula.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBascula.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBascula.Appearance.Options.UseFont = true;
            this.lblErrorBascula.Appearance.Options.UseForeColor = true;
            this.lblErrorBascula.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblErrorBascula.Location = new System.Drawing.Point(122, 488);
            this.lblErrorBascula.Name = "lblErrorBascula";
            this.lblErrorBascula.Size = new System.Drawing.Size(400, 48);
            this.lblErrorBascula.TabIndex = 120;
            this.lblErrorBascula.Text = "NO EXISTE BASCULA DISPONIBLE";
            this.lblErrorBascula.Visible = false;
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmResumenToEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 668);
            this.Controls.Add(this.lblErrorBascula);
            this.Controls.Add(this.btnBasc2);
            this.Controls.Add(this.btnBasc1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtKgAEnviar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.lblTotalUd_en_tarima);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.chConsumirPendientes);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtRestanteTarimasUnidades);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtRestante);
            this.Controls.Add(this.txtPorEnviar);
            this.Controls.Add(this.txtEnviados);
            this.Controls.Add(this.txtSolicitados);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmResumenToEntregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen a Entregar";
            this.Load += new System.EventHandler(this.frmResumenToEntregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnviados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorEnviar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestanteTarimasUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chConsumirPendientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKgAEnviar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}