using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercicio_Integrador
{
    public partial class FrmCalculadora : Form
    {
        Operacion calculadora;
        Numeracion primerOperando;
        Numeracion segundoOperando;
        Numeracion resultado;
        ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.operacion.DataSource = new object[] { "",'+','-','/','*'};

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.operacion.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnOperar_Click(object sender, EventArgs e)
        {
            Operacion Op = new Operacion(new Numeracion(txtNumero1.Text, ESistema.Decimal), new Numeracion (txtNumero2.Text, ESistema.Decimal));
            // Cambiar esto 
            if (operacion.Text != null)
            {
                char revalido;

                bool res = char.TryParse(operacion.Text, out revalido);

                Numeracion resFinal = Op.Operar(revalido);

                MessageBox.Show(resFinal.Valor);
            }
        }

    }
}
