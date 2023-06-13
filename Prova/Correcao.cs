using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Correcao : Form
    {
        public Correcao()
        {
            InitializeComponent();
        }
        
        private void bt_verify_Click(object sender, EventArgs e)
        {
            char[] resposta = { Convert.ToChar(textBox1.Text), Convert.ToChar(textBox2.Text), Convert.ToChar(textBox3.Text), Convert.ToChar(textBox4.Text), Convert.ToChar(textBox5.Text), Convert.ToChar(textBox6.Text), Convert.ToChar(textBox7.Text), Convert.ToChar(textBox8.Text), Convert.ToChar(textBox9.Text), Convert.ToChar(textBox10.Text), };
            ProvaCorrecao aluno = new ProvaCorrecao();
            for (int i = 0; i < resposta.Length; i++)
            {
            aluno.RespostaAluno(Convert.ToChar(resposta[i]));
            }

            MessageBox.Show($"{aluno.Correcao()}");
            
            
        }
    }
}
