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
using System.Windows.Forms.VisualStyles;

namespace cruds2._0
{
    public partial class Visualizador : Form
    {
        ClsCreate crear= new ClsCreate();
        ClsRead leer = new ClsRead();
        ClsUpdate actualizar= new ClsUpdate();
        ClsDelete eliminar= new ClsDelete();
        public Visualizador()
        {
            InitializeComponent();
            leer.tablitas(tablero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(crear.carrospeli(Vin.Text, Modelo.Text, Carro.Text, Año.Text, Conductor.Text, tablero));
        }

        private void tablero_MouseClick(object sender, MouseEventArgs e)
        {
            Vin.Text = tablero.CurrentRow.Cells[1].Value.ToString();
            Carro.Text= tablero.CurrentRow.Cells[2].Value.ToString();
            Modelo.Text= tablero.CurrentRow.Cells[3].Value.ToString();
            Año.Text= tablero.CurrentRow.Cells[4].Value.ToString();
            Conductor.Text= tablero.CurrentRow.Cells[5].Value.ToString();
            Id.Text = tablero.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(actualizar.Update(Vin.Text, Carro.Text, Modelo.Text, Año.Text, Conductor.Text, Int16.Parse(Id.Text),tablero));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(eliminar.Delete(Int16.Parse(Id.Text),tablero));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vin.Text = "";
            Carro.Text = "";
            Modelo.Text = "";
            Año.Text = "";
            Conductor.Text = "";
            Id.Text = "";
        }
    }
}
