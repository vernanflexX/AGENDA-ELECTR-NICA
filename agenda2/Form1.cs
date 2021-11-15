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

namespace agenda2
{
    public partial class AGENDA : Form
    {
        public AGENDA()
        {
            InitializeComponent();
        }

        SqlConnection conectar = new SqlConnection("SERVER=DESKTOP-3MD6P1K\\SQLEXPRESS;DATABASE=agenda;Integrated security=true");
        

        private void agregar_Click(object sender, EventArgs e)
        {
            conectar.Open();
            string consulta = "insert into persona values("+textID.Text+",'"+textNombre.Text+"','"+textApellido.Text+"','"+textFecha.Text+"','"+textDireccion.Text+"','"+textGenero.Text+"','"+textEstadoc.Text+"','"+textMovil.Text+"','"+textTelefono.Text+"','"+textCorreo.Text+"')";
            SqlCommand comando = new SqlCommand(consulta,conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro agregado.");

            conectar.Close();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            conectar.Open();

            string consulta = "delete from persona where Id=" + textID.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conectar);
            comando.ExecuteNonQuery();
            MessageBox.Show("El registro fue eliminado.");

            conectar.Close();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            conectar.Open();
            string consulta = "update persona set Id=" + textID.Text + ",nombre='" + textNombre.Text + "',apellido='" + textApellido.Text + "',fecha_de_nacimiento='" + textFecha.Text + "',direccion='" + textDireccion.Text + "',genero='" + textGenero.Text + "',estado_civil='" +textEstadoc.Text+ "',movil='" +textMovil.Text+ "',telefono='" +textTelefono.Text + "',correo_electronico='" + textCorreo.Text + "' where Id=" +textID.Text+ " ";
            SqlCommand comando = new SqlCommand(consulta, conectar);
            int cant;
            cant = comando.ExecuteNonQuery();
            if(cant> 0)
            {
                MessageBox.Show("El registro fue modificado.");
            }
            else
            {
                MessageBox.Show("Hubo un error.");
            }

            conectar.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            conectar.Open();

            string consulta = "select * from persona where Id=" + textBuscar.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conectar);
            SqlDataReader datos;
            datos = comando.ExecuteReader();
            if (datos.Read())
            {
                textID.Text = datos["Id"].ToString();
                textNombre.Text = datos["nombre"].ToString();
                textApellido.Text = datos["apellido"].ToString();
                textFecha.Text = datos["fecha_de_nacimiento"].ToString();
                textDireccion.Text = datos["direccion"].ToString();
                textGenero.Text = datos["genero"].ToString();
                textEstadoc.Text = datos["estado_civil"].ToString();
                textMovil.Text = datos["movil"].ToString();
                textTelefono.Text = datos["telefono"].ToString();
                textCorreo.Text = datos["correo_electronico"].ToString();

            }
            conectar.Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textFecha.Text = "";
            textDireccion.Text = "";

            for (int i = 0; i < textGenero.Items.Count; i++)
            {
                textGenero.SetItemChecked(i, false);
            }

            for (int i = 0; i < textEstadoc.Items.Count; i++)
            {
                textEstadoc.SetItemChecked(i, false);
            }

            textMovil.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";
            textBuscar.Text = "";
        }
    }
}
