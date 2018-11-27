using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExamen
{
    public partial class PeticionID : Form
    {
        public PeticionID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                Form1 form = (Form1)Owner;
                try
                {
                    form.idBorrar=(Convert.ToInt32(txtId.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("No existe el ID", "Error");
                }
                this.Close();
            }
        }
    }
}
