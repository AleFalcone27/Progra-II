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

        private void SetResultado() 
        {
            //tengo que pasarle el sistema de esta clase raro que rompa
            //Numeracion.ConvertirA(this.sistema);
            MessageBox.Show(this.resultado.Valor, "Resultado", MessageBoxButtons.OK);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.operacion.Text = "";

            resultado = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                Operacion Op = new Operacion(primerOperando,segundoOperando);

                // Esta re villero esto
                if (String.IsNullOrEmpty(operacion.Text))
                {
                    this.resultado = (Op.Operar(char.Parse(" ")));
                }
                else this.resultado = (Op.Operar(char.Parse(operacion.Text)));

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
    }
}
