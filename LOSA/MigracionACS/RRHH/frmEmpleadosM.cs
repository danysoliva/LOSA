using ACS.Classes;
using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.RRHH
{
    public partial class frmEmpleadosM : Form
    {
        PgSqlConnection psConnection;
        DataOperations dp;
        int Id_Empleado;
        string Pin;
        Boolean appli;
        int IdGrupo;
        bool TarjetaDisponible;

        public frmEmpleadosM()
        {
            InitializeComponent();
            dp = new DataOperations();
            psConnection = new PgSqlConnection(dp.ConnectionStringODOO5);
            try
            {
                psConnection.Open();
                load();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
           
        }
        public void load()
        {
            string query;
            query = @"SELECT 
                          id,
                          descripcion
                        FROM 
                          admon.hr_journal 
                          where enable = true
                          Union all
                          Select 0, 'No definido'";
            PgSqlCommand cmd = new PgSqlCommand(query, psConnection);
            PgSqlDataAdapter da = new PgSqlDataAdapter(cmd);
            dSrrhh.typeday.Clear();
            da.Fill(dSrrhh.typeday);
            
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            LookEmpleado();
        }

        private void LookEmpleado()
        {
            frmEmpleadosLista frm = new frmEmpleadosLista(psConnection);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Id_Empleado = frm.IdEmpleado;
                Pin = frm.Pin;
                txtNombreEmpleado.Text = frm.NombreEmpleado;
                txtCodigo.Text = frm.CodigoEmpleado;
                toolStripStatusLabelCodigoEmpleado.Text = "id=" + Id_Empleado + ", Codigo Aqf=" + frm.CodigoEmpleado + ", Tabla PG=public.hr_employee";


                //Load Image
                try
                {
                    if (Id_Empleado > 0)
                    {
                        recive_query(@"SELECT x_image, 
                                              x_hour_in, 
                                              x_hour_out,
                                              x_conf_aplic,
                                              id_grupo, 
                                              Coalesce(x_id_journal,0), 
                                              x_code_card
                                        FROM public.hr_employee ee 
                                        where ee.pin = :id;");
                    }
                    else
                    {
                        recive_query("Select x_image, x_hour_in, x_hour_out,x_conf_aplic,id_grupo, Coalesce(id_journal,0),x_code_card FROM admon.hr_foreign_emp ee where ee.id = :id");
                    }
                }
                catch (Exception ec )
                {
                    //pictureBoxProfile.Image = pictureBoxBackup.Image;
                    //CajaDialogo.Error(ec.Message);

                    Thread.Sleep(1000);
                    if (Id_Empleado > 0)
                    {
                        toolStripStatusLabelCodigoEmpleado.Text = "id=" + Id_Empleado + ", Codigo Aqf=" + frm.CodigoEmpleado + ", Tabla PG=public.hr_employee";
                    }
                    else
                    {
                        toolStripStatusLabelCodigoEmpleado.Text = "id=" + Id_Empleado + ", Codigo Aqf=" + frm.CodigoEmpleado + ", Tabla PG=admon.hr_foreign_emp";
                    }
                }
            }
        }
        public void recive_query(string query)
        {
            string sql = query;
            PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
            cmd.Parameters.Add("id", PgSqlType.VarChar).Value = Pin;
            toolStripStatusLabelCodigoEmpleado.Text = "Error al cargar la imagen.";
            PgSqlDataReader dr = cmd.ExecuteReader();
            toolStripStatusLabelCodigoEmpleado.Text = "NONE";
            if (dr.Read())
            {
                byte[] fotoBytes = (byte[])dr[0];
                //foto = ToImage(fotoBytes);
                if (fotoBytes != null)
                {
                    //using (MemoryStream productImageStream = new System.IO.MemoryStream())
                    //{
                    //    System.Drawing.ImageConverter imageConverter = new System.Drawing.ImageConverter();
                    //    pictureBoxFoto.Image = imageConverter.ConvertFrom(fotoBytes) as System.Drawing.Image;
                    //}
                    pictureBoxProfile.Image = ToImage(fotoBytes);

                    //pictureBoxFoto.Image = emp.ByteArrayToImage(fotoBytes);
                    //BinaryToImage
                    //MemoryStream ms = new MemoryStream(fotoBytes, 0, fotoBytes.Length);
                    //ms.Position = 0; // this is important
                    //pictureBoxProfile.Image = Image.FromStream(ms, true);

                }
                if (dr[1].ToString() != null)
                {
                    dtin.Text = String.Format("{0:HH:mm:ss}", dr[1].ToString());
                }
                if (dr[2].ToString() != null)
                {
                    dtout.Text = String.Format("{0:HH:mm:ss}", dr[2].ToString());
                }
                if (dr[3].ToString() != null)
                {
                    checkEdit1.Checked = Convert.ToBoolean(dr[3].ToString());
                }
                if (dr[4].ToString() != null)
                {
                    if (Convert.ToInt32(dr[4]) == 1)
                        tggTipoHorario.IsOn = false;
                    else
                        tggTipoHorario.IsOn = true;
                    
                }

                grdturno.EditValue = dr[5];
                txtCodigoTarjeta.Text = dr.GetString(6);
            }
            else
            {
                //pictureBoxProfile.Image = pictureBoxBackup.Image;
            }
        }


        private Image ToImage(byte[] arreglo)
        {
            Image img = null;
            if (arreglo != null)
            {
                try
                {
                    ImageConverter ic = new ImageConverter();
                    img = (Image)ic.ConvertFrom(arreglo);
                    //Bitmap bitmap1 = new Bitmap(img);
                    return img;
                }
                catch
                {
                    //Bitmap bitmap1 = new Bitmap(img);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //Guardar
            if (Id_Empleado == 0)
            {
                CajaDialogo.Error("Es necesario seleccionar un empleado!");
                cmdSearch.Focus();
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Desea guardar esta imagen para el empleado?");
            if(r!= DialogResult.Yes)
            {
                return;
            }

            if (!string.IsNullOrEmpty(txtCodigoTarjeta.Text))
            {
                try
                {
                    string sql = @"select * from public.ft_get_disponibilidad_tarjeta (:p_card_number, :p_id_employ);";
                    PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                    cmd.Parameters.Add("p_card_number", PgSqlType.VarChar).Value = txtCodigoTarjeta.Text;
                    cmd.Parameters.Add("p_id_employ", PgSqlType.Int).Value = Id_Empleado;
                    TarjetaDisponible = Convert.ToBoolean(cmd.ExecuteScalar());
                    if (!TarjetaDisponible)
                    {
                        CajaDialogo.Error(@"No se puede guardar los datos, la tarjeta seleccionada esta asociada a otro empleado. " +
                                           "Retire del empleado anterior para asginar a otra persona");
                        return;
                    }
                }
                catch (Exception ec)
                {
                    TarjetaDisponible = false;
                    CajaDialogo.Error("Error en la verficacion de disponibilidad de tarjeta! Error: " + ec.Message);
                }
            }

            try
            {
                if (Id_Empleado > 0)
                {
                    update(@"update public.hr_employee ee 
                                    set x_image = :image ,
                                       x_hour_in = :in ,
                                       x_hour_out = :out,
                                        x_conf_aplic = :aplii,
                                        id_grupo    =:id_grupo,
                                        x_id_journal = :jour,
                                        x_code_card = :card_code
                               where ee.id = :id;");

                }
                //else
                //{
                //     update(@"update admon.hr_foreign_emp ee 
                //                    set x_image = :image ,
                //                       x_hour_in = :in ,
                //                       x_hour_out = :out,
                //                        x_conf_aplic = :aplii,
                //                        id_grupo    =:applis
                //                        id_journal = :jour,
                //                        x_code_card = :card_code
                //               where ee.id = :id;");
                //}
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        public void update(string query)
        {
            string sql = query;
            PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
            cmd.Parameters.Add("image", PgSqlType.ByteA).Value = ImageToByte(pictureBoxProfile.Image);
            cmd.Parameters.Add("id", PgSqlType.ByteA).Value = Id_Empleado;
            cmd.Parameters.Add("in", PgSqlType.Time).Value = Convert.ToDateTime(String.Format("{0:HH:mm:ss}", dtin.Text));
            cmd.Parameters.Add("out", PgSqlType.Time).Value = Convert.ToDateTime(String.Format("{0:HH:mm:ss}", dtout.Text));
            cmd.Parameters.Add("aplii", PgSqlType.Boolean).Value = checkEdit1.Checked;
            cmd.Parameters.Add("id_grupo", PgSqlType.Int).Value = IdGrupo;
            cmd.Parameters.Add("jour", PgSqlType.Int).Value = Convert.ToInt32(grdturno.EditValue);
            cmd.Parameters.Add("card_code", PgSqlType.VarChar).Value = txtCodigoTarjeta.Text;
            cmd.ExecuteNonQuery();
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        public byte[] ImageToByte(Image img)
        {
            if (img != null)
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(img, typeof(byte[]));
            }
            else
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(pictureBoxProfile.Image, typeof(byte[]));
            }
        }



        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            //Buscar la Imagen.
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Seleccionar imagen";
            //BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = this.textBox1.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                //this.textBox1.Text = BuscarImagen.FileName;
                String Direccion = BuscarImagen.FileName;
                this.pictureBoxProfile.ImageLocation = Direccion;
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                //this.pictureBox1.ImageLocation = textBox1.Text;
            }
        }

        private void checkEdit1_Properties_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(checkEdit1.EditValue) == true)
            {
                checkEdit1.Text = "Aplica para marca";
                appli = true;
            }
            else
            {
                checkEdit1.Text = "No aplica para marca";
                appli = false;
            }
        }

        private void checkEdit2_Properties_CheckedChanged(object sender, EventArgs e)
        {
            if (tggTipoHorario.IsOn)
            {
                //checkEdit2.Text = "Administracion: ";
                IdGrupo = 2;
            }
            else
            {
                //checkEdit2.Text = "Turno: ";
                IdGrupo = 1;
            }

        }

        private void txtCodigoTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (Id_Empleado > 0)
                {
                    //Validar disponibilidad
                    try
                    {
                        string sql = @"select * from public.ft_get_disponibilidad_tarjeta (:p_card_number, :p_id_employ);";
                        PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                        cmd.Parameters.Add("p_card_number", PgSqlType.VarChar).Value = txtCodigoTarjeta.Text;
                        cmd.Parameters.Add("p_id_employ", PgSqlType.Int).Value = Id_Empleado;
                        TarjetaDisponible = Convert.ToBoolean(cmd.ExecuteScalar());
                    }
                    catch (Exception ec)
                    {
                        TarjetaDisponible = false;
                        CajaDialogo.Error("Error en la verficacion de disponibilidad de tarjeta! Error: " + ec.Message);
                    }
                }
                else
                {
                    CajaDialogo.Error("No hay un empleado seleccionado para poder validar la tarjeta!");
                }
            }
        }

        private void tggTipoHorario_Toggled(object sender, EventArgs e)
        {
            if (tggTipoHorario.IsOn)
            {
                IdGrupo = 2;
            }
            else
            {
                IdGrupo = 1;
            }
        }
    }
}
