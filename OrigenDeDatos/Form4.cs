using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrigenDeDatos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.actualizar(Int32.Parse(id.Text), us.Text, c.Text);
            MessageBox.Show(mensaje);

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
