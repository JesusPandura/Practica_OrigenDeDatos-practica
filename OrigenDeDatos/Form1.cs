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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           this.usuariosTableAdapter.Fill(this.clasetopicosDataSet1.usuarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                Form4 f4 = new Form4();
              
                f4.id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                f4.us.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f4.c.Text =  dataGridView1.CurrentRow.Cells[2].Value.ToString();
                f4.Show();
               
            }
        }
    }
}
