using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnChecklis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FlowLayout.BackColor = Color.White;
                FlowLayout.Controls.Clear();
                FlowLayout.Dock = DockStyle.Fill;
                List<ControlCheck> Lista = new List<ControlCheck>();
                int cantidadcheck = int.Parse(txtcantidad.Text);

                for (int i = 0; i < cantidadcheck; i++)
                {
                    ControlCheck objeto = new ControlCheck();
                    objeto.NombreCheck = "Check " + i.ToString();
                    Lista.Add(objeto);
                }
                foreach (var item in Lista)
                {
                    FlowLayout.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }
    }
}
