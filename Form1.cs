using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_en_clase
{
    

    public partial class Contactos : Form 
    {
        
        public Contactos()
        {
            InitializeComponent();
        }

        // AGREGAR 2 VARIABLES Y CREAR EL ARREGLO
        private int CantidadPersona = 0;
        private int Registros = 0;
        private contacto[] arreglo;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Registros < CantidadPersona)
            {
                // MARCAR ERRORES CON ERRORPROVIDER CADA QUE DEJE ALGUNA CASILLA SIN RELLENAR O MAL PUESTA
                if (lblNumC.Text == "")
                {
                    errorProvider1.SetError(lblNumC, "Ingrese un ID para el Contacto");
                    lblNumC.Focus();
                    return;
                }
                errorProvider1.SetError(lblNumC, "");

                if (txtNombre.Text == "")
                {
                    errorProvider1.SetError(txtNombre, "Ingrese un Nombre para el Contacto");
                    txtNombre.Focus();
                    return;
                }
                errorProvider1.SetError(txtNombre, "");

                if (txtTelefono.Text == "")
                {
                    errorProvider1.SetError(txtTelefono, "Ingrese un Telefono para el Contacto");
                    txtTelefono.Focus();
                    return;
                }
                errorProvider1.SetError(txtTelefono, "");

                Regex Regmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.Compiled);

                if (!Regmail.IsMatch(txtCorreo.Text))
                {
                    errorProvider1.SetError(txtCorreo, "Debe Ingresar una Direccion de Correo Valida");
                    txtCorreo.Focus();
                    return;
                }
                errorProvider1.SetError(txtCorreo, "");

                Registros = Registros + 1;


                contacto x;
                x = new contacto();



                x.FechaNacimiento = dtpFechaNacimiento.Value;
                x.Nombre = txtNombre.Text;
                x.Telefono = txtTelefono.Text;


                //CREAR UN INT PARA MANDAR LOS DATOS X A LA TABLA CON EL INT CREADO (N)
                int n = DgvDatos.Rows.Add(x);

                DgvDatos.Rows[n].Cells[0].Value = lblNumC.Text;
                DgvDatos.Rows[n].Cells[1].Value = txtNombre.Text;
                DgvDatos.Rows[n].Cells[2].Value = txtCorreo.Text;
                DgvDatos.Rows[n].Cells[3].Value = txtTelefono.Text;
                DgvDatos.Rows[n].Cells[4].Value = x.Edad;

                //Limpiar Tabla
                txtNombre.Text = "";
                dtpFechaNacimiento.Text = "";
                txtTelefono.Text = "";
                lblNumC.Text = "";
                txtCorreo.Text = "";

                
            }
            else 
            {
                MessageBox.Show("Ya se han Agregado");
                
            }           
            
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtNcontactos.Text);
            CantidadPersona = valor;
            Registros = 0;
            arreglo = new contacto[CantidadPersona + 1];

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {          
            DgvDatos.Rows.Clear();                     
        }
    }
}
