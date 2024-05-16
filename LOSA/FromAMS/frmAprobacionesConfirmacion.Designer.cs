
namespace LOSA.FromAMS
{
    partial class frmAprobacionesConfirmacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAprobacionesConfirmacion));
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAplicar = new System.Windows.Forms.Button();
            this.cmdRechazar = new System.Windows.Forms.Button();
            this.cmdAprobar = new System.Windows.Forms.Button();
            this.txtCommentsAprobador = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDecisionCase = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTipoOrden = new System.Windows.Forms.TextBox();
            this.txtFechaDocumento = new System.Windows.Forms.TextBox();
            this.txtRutaAprobacion = new System.Windows.Forms.TextBox();
            this.txtUsuarioSolicita = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnVerDetalle.Image")));
            this.btnVerDetalle.Location = new System.Drawing.Point(200, 128);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(25, 25);
            this.btnVerDetalle.TabIndex = 68;
            this.btnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(396, 380);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(125, 56);
            this.cmdCancel.TabIndex = 63;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Image = global::LOSA.Properties.Resources.tick;
            this.cmdAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAplicar.Location = new System.Drawing.Point(236, 380);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(127, 56);
            this.cmdAplicar.TabIndex = 62;
            this.cmdAplicar.Text = "Guardar y \r\nCerrar";
            this.cmdAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAplicar.UseVisualStyleBackColor = true;
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // cmdRechazar
            // 
            this.cmdRechazar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRechazar.Image = ((System.Drawing.Image)(resources.GetObject("cmdRechazar.Image")));
            this.cmdRechazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRechazar.Location = new System.Drawing.Point(658, 263);
            this.cmdRechazar.Name = "cmdRechazar";
            this.cmdRechazar.Size = new System.Drawing.Size(125, 56);
            this.cmdRechazar.TabIndex = 61;
            this.cmdRechazar.Text = "Rechazar";
            this.cmdRechazar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRechazar.UseVisualStyleBackColor = true;
            this.cmdRechazar.Click += new System.EventHandler(this.cmdRechazar_Click);
            // 
            // cmdAprobar
            // 
            this.cmdAprobar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAprobar.Image = global::LOSA.Properties.Resources.check32;
            this.cmdAprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAprobar.Location = new System.Drawing.Point(527, 263);
            this.cmdAprobar.Name = "cmdAprobar";
            this.cmdAprobar.Size = new System.Drawing.Size(125, 56);
            this.cmdAprobar.TabIndex = 60;
            this.cmdAprobar.Text = "Aprobar";
            this.cmdAprobar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAprobar.UseVisualStyleBackColor = true;
            this.cmdAprobar.Click += new System.EventHandler(this.cmdAprobar_Click);
            // 
            // txtCommentsAprobador
            // 
            this.txtCommentsAprobador.BackColor = System.Drawing.Color.LightGray;
            this.txtCommentsAprobador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommentsAprobador.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCommentsAprobador.Location = new System.Drawing.Point(200, 293);
            this.txtCommentsAprobador.Multiline = true;
            this.txtCommentsAprobador.Name = "txtCommentsAprobador";
            this.txtCommentsAprobador.Size = new System.Drawing.Size(321, 69);
            this.txtCommentsAprobador.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 17);
            this.label11.TabIndex = 58;
            this.label11.Text = "Comentarios                                       ";
            // 
            // txtDecisionCase
            // 
            this.txtDecisionCase.BackColor = System.Drawing.Color.LightGray;
            this.txtDecisionCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecisionCase.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDecisionCase.Location = new System.Drawing.Point(200, 262);
            this.txtDecisionCase.Name = "txtDecisionCase";
            this.txtDecisionCase.Size = new System.Drawing.Size(321, 25);
            this.txtDecisionCase.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Decisión                                       ";
            // 
            // txtTipoOrden
            // 
            this.txtTipoOrden.BackColor = System.Drawing.Color.LightGray;
            this.txtTipoOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoOrden.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTipoOrden.Location = new System.Drawing.Point(572, 127);
            this.txtTipoOrden.Name = "txtTipoOrden";
            this.txtTipoOrden.ReadOnly = true;
            this.txtTipoOrden.Size = new System.Drawing.Size(211, 25);
            this.txtTipoOrden.TabIndex = 55;
            // 
            // txtFechaDocumento
            // 
            this.txtFechaDocumento.BackColor = System.Drawing.Color.LightGray;
            this.txtFechaDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFechaDocumento.Location = new System.Drawing.Point(572, 97);
            this.txtFechaDocumento.Name = "txtFechaDocumento";
            this.txtFechaDocumento.ReadOnly = true;
            this.txtFechaDocumento.Size = new System.Drawing.Size(211, 25);
            this.txtFechaDocumento.TabIndex = 54;
            this.txtFechaDocumento.Text = " ";
            // 
            // txtRutaAprobacion
            // 
            this.txtRutaAprobacion.BackColor = System.Drawing.Color.LightGray;
            this.txtRutaAprobacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaAprobacion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRutaAprobacion.Location = new System.Drawing.Point(572, 67);
            this.txtRutaAprobacion.Name = "txtRutaAprobacion";
            this.txtRutaAprobacion.ReadOnly = true;
            this.txtRutaAprobacion.Size = new System.Drawing.Size(211, 25);
            this.txtRutaAprobacion.TabIndex = 53;
            // 
            // txtUsuarioSolicita
            // 
            this.txtUsuarioSolicita.BackColor = System.Drawing.Color.LightGray;
            this.txtUsuarioSolicita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioSolicita.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtUsuarioSolicita.Location = new System.Drawing.Point(200, 67);
            this.txtUsuarioSolicita.Name = "txtUsuarioSolicita";
            this.txtUsuarioSolicita.ReadOnly = true;
            this.txtUsuarioSolicita.Size = new System.Drawing.Size(211, 25);
            this.txtUsuarioSolicita.TabIndex = 52;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.LightGray;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEstado.Location = new System.Drawing.Point(200, 97);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(211, 25);
            this.txtEstado.TabIndex = 51;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.BackColor = System.Drawing.Color.LightGray;
            this.txtNumDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNumDoc.Location = new System.Drawing.Point(227, 128);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.ReadOnly = true;
            this.txtNumDoc.Size = new System.Drawing.Size(184, 25);
            this.txtNumDoc.TabIndex = 50;
            // 
            // txtComentarios
            // 
            this.txtComentarios.BackColor = System.Drawing.Color.LightGray;
            this.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentarios.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtComentarios.Location = new System.Drawing.Point(200, 159);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ReadOnly = true;
            this.txtComentarios.Size = new System.Drawing.Size(583, 46);
            this.txtComentarios.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.Location = new System.Drawing.Point(20, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 48;
            this.label10.Text = "Respuesta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Comentarios                                    ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(439, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tipo de Salida                                          ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Fecha Documento           ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ruta de Aprobación               ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Número de documento base      ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Estado                                       ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Solicitados por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Información Detallada de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Se necesita la aprobación para generar una Salida de Mercancia";
            // 
            // frmAprobacionesConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 448);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.cmdRechazar);
            this.Controls.Add(this.cmdAprobar);
            this.Controls.Add(this.txtCommentsAprobador);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDecisionCase);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTipoOrden);
            this.Controls.Add(this.txtFechaDocumento);
            this.Controls.Add(this.txtRutaAprobacion);
            this.Controls.Add(this.txtUsuarioSolicita);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAprobacionesConfirmacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAplicar;
        private System.Windows.Forms.Button cmdRechazar;
        private System.Windows.Forms.Button cmdAprobar;
        public System.Windows.Forms.TextBox txtCommentsAprobador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDecisionCase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTipoOrden;
        private System.Windows.Forms.TextBox txtFechaDocumento;
        private System.Windows.Forms.TextBox txtRutaAprobacion;
        private System.Windows.Forms.TextBox txtUsuarioSolicita;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}