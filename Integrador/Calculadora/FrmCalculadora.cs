using Entidades;
using System;
using System.Windows.Forms;

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
            this.rdbDecimal.Checked = true;
            this.operacion.DataSource = new object[] { "", "+", "-", "/", "*" };
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.operacion.Text = "";
            this.txtResultado.Text = "";

            resultado = null;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Llama tacitamente al evento closing del formulario
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            this.primerOperando = new Numeracion(txtPrimerOperador.Text, ESistema.Decimal);
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            this.segundoOperando = new Numeracion(txtSegundoOperador.Text, ESistema.Decimal);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSegundoOperador.Text) || !String.IsNullOrEmpty(txtSegundoOperador.Text))
            {
                Operacion Op = new Operacion(primerOperando, segundoOperando);

                // Le paso uno infdiferentemente pero podria ser cualquier numero
                if (String.IsNullOrEmpty(operacion.Text))
                {
                    this.resultado = Op.Operar('1');
                }
                else this.resultado = Op.Operar(char.Parse(operacion.Text));

                SetResultado();
            }
            else MessageBox.Show("Por favor, complete todos los campos para poder realizar una operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Decimal;
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Binario;
        }

        // Ver porque carajos no funciona esto El return de la linea 94 no se guarda en ninugn lugar
        private void SetResultado()
        {
            if (this.sistema == ESistema.Binario)
            {
                txtResultado.Text = (this.resultado.ConvertirA(ESistema.Binario).ToString());
            }
            else txtResultado.Text = resultado.Valor;
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
