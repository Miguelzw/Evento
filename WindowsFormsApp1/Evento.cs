﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Evento : Form
    {
        private GerenciadorEvento gerenciadorEvento;
        public Evento()
        {
            gerenciadorEvento = new GerenciadorEvento();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastroPessoas = new Cadastro(gerenciadorEvento.ListaPessoas);
            
            cadastroPessoas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
