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
    public partial class ControlCheck : UserControl
    {
        public ControlCheck()
        {
            InitializeComponent();
        }
        [Category("Custom Props")]
        public int Id { get; set; }
        private string nombre;



        [Category("Custom Props")]
        public string NombreCheck
        {
            get { return nombre; }
            set { nombre = value; chec.Text = value; }
        }


        private void ControlCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
