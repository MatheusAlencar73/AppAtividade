using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAtividade.View
{
    public partial class Atividade_Silvio : Form
    {
        public Atividade_Silvio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt16(txb_num1.Text);
            int valor2 = Convert.ToInt16(txb_num2.Text);
            int soma=  valor1 + valor2;

            label3.Text =  soma.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
