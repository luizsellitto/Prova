﻿using System;
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

            ProvaCorrecao aluno = new ProvaCorrecao();
            try { 
            for (int i = 0; i < 10; i++)
            {
            aluno.RespostaAluno(Convert.ToChar(textBox1.Text), Convert.ToChar(textBox2.Text), Convert.ToChar(textBox3.Text), Convert.ToChar(textBox4.Text), Convert.ToChar(textBox5.Text), Convert.ToChar(textBox6.Text), Convert.ToChar(textBox7.Text), Convert.ToChar(textBox8.Text), Convert.ToChar(textBox9.Text), Convert.ToChar(textBox10.Text));
            }
            
                label1.Text = ($"O número de acertos foi de: {aluno.Correcao()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Está dando erro!");
            }
            
            
            
        }
    }
}
