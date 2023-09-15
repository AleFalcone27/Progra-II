using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I02___Registrate
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            this.Masculino.Checked = true;
            

        }


        private void button1_Click(object sender, EventArgs e)
        {

            string[] genero = new string[3];

            if (GeneroInput != null)
            {
                foreach (Control control in GeneroInput.Controls)
                {
                    if(control is RadioButton radioButton && radioButton.Checked)
                    {
                        genero = control.ToString().Split(',');
                    }
                }
            }



            Ingresante usuario = new Ingresante
                (
                 genero,
                 DireccionInput.Text,
                 (int)EdadInput.Value,
                 GeneroInput.Text,
                 NombreInput.Text,
                 inputGenero.Text);
            MessageBox.Show( usuario.Mostrar());
        }

    }
}
