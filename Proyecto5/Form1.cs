using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string edad = txtEdad.Text;
            string estatura = txtEstatura.Text;
            string telefono = txtTelefono.Text;

            //Obtener el genero

            string genero = "";

            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }

            //Cadena con datos

            string datos = $"Nombre:{nombres}\r\nApellidos:{apellidos}\r\nTelefono:{telefono}\r\nEstatura: {estatura}\r\nEdad:{edad} años\r\nGenero:{genero}";

            //guardar datos en un archivo de texto

            string rutaArchivo = "C:/Users/dinog/OneDrive/Documentos/Textos PA/datos1.txt";
            File.WriteAllText(rutaArchivo, datos);

            //Mostrar mensajes

            MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEstatura.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}
