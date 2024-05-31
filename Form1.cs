using cruds2._0.Clases.Conexion;
using cruds2._0.Clases.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cruds2._0
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
          
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Visualizador view= new Visualizador();
            view.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registe= new Registro();
            registe.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsRead read = new ClsRead();
            string loginResult = read.login(Usuario.Text, Contraseña.Text);

            if (loginResult.Contains("error"))
            {
                MessageBox.Show("Login failed: " + loginResult+"");
            }
            else
            {
                MessageBox.Show("Login successful: " + loginResult);
                this.Hide();
                Visualizador view = new Visualizador();
                view.Show();

                if (Recuerdame.Checked == true)
                {
                    Properties.Settings.Default.Username = Usuario.Text;
                    Properties.Settings.Default.Password = Contraseña.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username !=String.Empty)
            { 
                Usuario.Text= Properties.Settings.Default.Username;
                Contraseña.Text =Properties.Settings.Default.Password;   
            }
        }
    }
}
