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
    public partial class Form1 : Form
    {
        public enum urgencia
        {
            Ya = 0,
            Hoy = 1,
            Mañana = 2
        }
        public enum tipo
        {
            Publica = 0,
            Empresa,
            Personal
        }

        public struct Nota
        {
            public string nombre;
            public string destinatario;
            public string nota;
            public tipo tipoTxt;
            public urgencia urgenciaTxt;
        }

        public int[] contraseñas = new int[] { 1234, 1235, 1654, 9862, 1111 };
        public bool acertada = false;
        public bool funcionalidCompleta = false;
        public List<Nota> notas = new List<Nota>();
        public tipo tipoSeleccionado;
        public urgencia urgenciaSeleccionada;
        public int idBorrar = -1;
        public bool cerrar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormPin formPin = new FormPin();
            DialogResult res = DialogResult.Cancel;
            int cont = 0;
            while (cont <= 3 && !acertada)
            {
                cerrar = true;
                if (cont == 3)
                {
                    this.Close();
                }
                try
                {
                    res = formPin.ShowDialog();
                }
                catch (ObjectDisposedException) { }
                switch (res)
                {
                    case DialogResult.OK:
                        formPin.lblError.Text = "";
                        int pin = -1;
                        try
                        {
                            pin = Convert.ToInt32(formPin.txtPin.Text);
                        }
                        catch (FormatException)
                        {
                            formPin.lblError.Text = "Error al introducir el Pin";
                            formPin.lblError.Text = pin + "";
                        }
                        catch (OverflowException)
                        {
                            formPin.lblError.Text = "El pin es demasiado grande";
                        }
                        for (int i = 0; i < contraseñas.Length; i++)
                        {
                            if (!acertada)
                            {
                                if (contraseñas[i] == pin)
                                {
                                    formPin.lblError.Text = contraseñas[i] + "";
                                    acertada = true;
                                }
                            }
                        }
                        if (acertada)
                        {
                            formPin.lblError.Text = "Correcta";
                        }
                        else
                        {
                            formPin.lblError.Text = "El PIN no es correcto";
                        }
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
                cont++;
            }
            funcionalidCompleta = formPin.chkCompleta.Checked;
            gbTipo.Visible = funcionalidCompleta;
            gbUrgencia.Visible = funcionalidCompleta;
            for (int i = 0; i < gbTipo.Controls.Count; i++)
            {
                gbTipo.Controls[i].Text = "&" + (tipo)i;
            }
            for (int i = 0; i < gbUrgencia.Controls.Count; i++)
            {
                gbUrgencia.Controls[i].Text = "&" + (urgencia)Convert.ToInt32(gbUrgencia.Controls[i].Tag);
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = Color.FromName(((TextBox)sender).Tag + "");
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = Color.White;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrar)
            {
                e.Cancel = false;
            }
            else
            {
                if (MessageBox.Show("Seguro que desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlmacenar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            Nota nota;
            nota.nombre = txtNombre.Text;
            nota.destinatario = txtDestinatario.Text;
            nota.nota = txtNota.Text;
            if (funcionalidCompleta)
            {
                nota.tipoTxt = tipoSeleccionado;
                nota.urgenciaTxt = urgenciaSeleccionada;
            }
            else
            {
                nota.tipoTxt = tipo.Publica;
                nota.urgenciaTxt = urgencia.Mañana;
            }
            if (nota.nombre.Length == 0)
            {
                lblError.Text = "Debes poner un nombre valido ";
            }
            if (nota.destinatario.Length == 0)
            {
                lblError.Text += "Debes poner un distinatario valido ";
            }
            if (nota.nota.Length == 0)
            {
                lblError.Text += "Debes poner una nota valida";
            }
            if (lblError.Text.Length == 0)
            {
                notas.Add(nota);
                txtNombre.Text = "";
                txtDestinatario.Text = "";
                txtNota.Text = "";
                lblError.Text = "Añadido";
            }
        }

        private void CheckedChangedUrgencia(object sender, EventArgs e)
        {
            urgenciaSeleccionada = (urgencia)Enum.Parse(typeof(urgencia), ((RadioButton)sender).Text.Substring(1));
        }
        private void CheckedChangedTipo(object sender, EventArgs e)
        {
            tipoSeleccionado = (tipo)Enum.Parse(typeof(tipo), ((RadioButton)sender).Text.Substring(1));
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            txtNota.Clear();
            txtNota.AppendText(String.Format("{0,2} {1,12} {2,12} {3,30} {4,7} {5,7}", "ID", "Nombre", "Destinatario", "Nota", "Tipo", "Urgencia"));
            txtNota.AppendText(Environment.NewLine);
            int cont = 1;
            foreach (Nota nota in notas)
            {
                txtNota.AppendText(String.Format("{0,2} {1,12} {2,12} {3,30} {4,7} {5,7}", cont, nota.nombre, nota.destinatario, nota.nota, nota.tipoTxt, nota.urgenciaTxt));
                txtNota.AppendText(Environment.NewLine);
                for (int i = 0; i < 80; i++)
                {
                    txtNota.AppendText("*");
                }
                txtNota.AppendText(Environment.NewLine);
                cont++;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            PeticionID peticionID = new PeticionID();
            peticionID.ShowDialog(this);
            if (idBorrar < 1 || idBorrar > notas.Count() + 1)
            {
                MessageBox.Show("No existe el ID", "Error");
            }
            else
            {
                notas.RemoveAt(idBorrar - 1);
                txtNota.Clear();
            }
        }

        private void txtNota_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Clear();
        }
    }
}
