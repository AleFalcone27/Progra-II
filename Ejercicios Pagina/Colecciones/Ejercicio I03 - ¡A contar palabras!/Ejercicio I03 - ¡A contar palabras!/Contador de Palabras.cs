using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ejercicio_I03____A_contar_palabras_
{
    public partial class Form1 : Form
    {
        
        Dictionary<string,int> dict = new Dictionary<string,int>();
        List<KeyValuePair<string,int>> list = new List<KeyValuePair<string, int>>();

        public Form1()
        {
            InitializeComponent();
        }

        //Creamos el comparador en este caso como son numericos nos devuelve el mayor de los 2
        private int Comparador(KeyValuePair<string,int> e1, KeyValuePair<string, int> e2)
        {
            return e2.Value - e1.Value;
        }


        private void button_Click(object sender, EventArgs e)
        {
            int cont = 0;

            dict = Contador.getPalabras(richTextBox.Text);

            list = dict.ToList();   

            list.Sort(Comparador);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-Apariciones-");
 
                
            foreach (KeyValuePair<string, int> kvp in list)
            {
                while (cont<3)
                {
                    sb.AppendLine($"{kvp.Key}:{kvp.Value}");
                    cont++;
                    break;
                }
            }
                MessageBox.Show(sb.ToString());
        }
    }
}
