using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Libreria de conexion a SQL

namespace Proyecto5
{
    public partial class Form1 : Form
    {
        //DAtos de conexion a MySQL (XAMPP)
        string conexionSQL = "Server=localhost;Port=3306;Database=programacionavanzada;Uid=root;Pwd=";
         
        public Form1()
        {
            InitializeComponent();

            //Agregar controladores de eventos TextChanged a los campos
            txtEdad.TextChanged += ValidarEdad;
            txtApellido.TextChanged += ValidarApellido;
            txtEstatura.TextChanged += ValidarEstatura;
            txtNombre.TextChanged += ValidarNombre;
            txtTelefono.TextChanged += ValidarTelefono;

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

            //validar que los campos tengan el formato correcto
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telefono) && EsTextoValido(nombres)
                && EsTextoValido(apellidos))
            {
                //Cadena con datos
                string datos = $"Nombre:{nombres}\r\nApellidos:{apellidos}\r\nTelefono:{telefono}\r\nEstatura: {estatura}\r\nEdad:{edad} años\r\nGenero:{genero}";

                //guardar datos en un archivo de texto
                string rutaArchivo = "C:/Users/dinog/OneDrive/Documentos/Textos PA/datos2.txt";

                bool archivoExiste = File.Exists(rutaArchivo);

                if (archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivo, datos);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {
                        if (archivoExiste)
                        {
                            writer.WriteLine();
                            writer.WriteLine(datos);
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos ingresados correctamente.");
                        }
                        else
                        {
                            writer.WriteLine(datos);
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos ingresados correctamente.");
                        }
                        
                    }
                }
                //Mostrar mensajes
                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void InsertarRegistro(string nombres, string apellidos, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection conection =new MySqlConnection(conexionSQL))
            {
                conection.Open();
                string insertQuery = "INSERT INTO resgistros (Nombres, Apellidos, Telefono, Edad, Estatura, Genero)" +
                                       "VALUES (@Nombres, @Apellidos, @Telefono, @Edad, @Estatura, @Genero)"; 

                using(MySqlCommand command= new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombres", nombres);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();
                }
                conection.Close();
            }
        }

        private bool EsEnteroValido(string valor)
        { 
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string input)
        {
            if (input.Length != 10)
            {
                return false;
            }
            if (!input.All(char.IsDigit))
            {
                return false;
            }
            return true;
            //long resultado;
            //return long.TryParse(valor, out resultado) && valor.Length == 10;
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"[a-zA-Z\s]+$");   //Solo letras y espacios
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una estatura valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            if (input.Length < 10)
            {
                return;
            }
            if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor ingrese un numero de telefono valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
            //if (input.Length>10)
            //{
            //    if (!EsEnteroValidoDe10Digitos(input))
            //    {
            //        MessageBox.Show("Por favor ingrese un numero de telefono valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        textBox.Clear();
            //    }
            //}
            //else if (!EsEnteroValidoDe10Digitos(input))
            //{
            //    MessageBox.Show("Por favor ingrese un numero de telefono valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre valido (solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void ValidarApellido(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese apellidos validos (solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
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








