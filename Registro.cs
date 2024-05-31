using cruds2._0.Clases.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cruds2._0
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsCreate registrar= new ClsCreate();
            String format = Nacimiento.Text;
           
           
            if (registrar.Register(Usuario.Text, Nombre.Text, Nacimiento.Value, Contraseña.Text) != "error")
            {
                MessageBox.Show(registrar.Register(Usuario.Text, Nombre.Text, Nacimiento.Value, Contraseña.Text));
                Form1 form = new Form1();
                form.Show();
                this.Close(); 
            }

            else {
                MessageBox.Show(registrar.Register(Usuario.Text, Nombre.Text, Nacimiento.Value, Contraseña.Text));
            }
        }
    }
}
