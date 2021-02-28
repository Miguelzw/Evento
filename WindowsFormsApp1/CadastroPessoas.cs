using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {
        public List<Pessoas> ListaPessoas { get; set; }

        public Cadastro(List<Pessoas> listaPessoas)
        {
            InitializeComponent();

            ListaPessoas = listaPessoas;

            comboEC.Items.Add("Casado(a)");
            comboEC.Items.Add("Solteiro(a)");
            comboEC.Items.Add("Divorciado(a)");
            comboEC.Items.Add("Viúvo(a)");
            comboEC.SelectedIndex = 0;

            Listar();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Pessoas pessoa in ListaPessoas)
            {

                if (pessoa.Nome == txtNome.Text)
                {
                    index = ListaPessoas.IndexOf(pessoa);
                }
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome!.");
                txtNome.Focus();
                return;
            }

            if (txtTelefone.Text == "") 
            {
                MessageBox.Show("Preencha o campo Telefone!.");
                return;
            }

            char sexo;
            if (radioM.Checked)
                sexo = 'M';
            else if (radiof.Checked)
                sexo = 'F';
            else 
                sexo = 'O';

            Pessoas p = new Pessoas
            {
                Nome = txtNome.Text,
                DataNascimento = txtData.Text,
                EstadoCivil = comboEC.SelectedItem.ToString(),
                Telefone = txtTelefone.Text,
                Sexo = sexo
            };

            if (index < 0) 
                ListaPessoas.Add(p);
            else
                ListaPessoas[index] = p;

            btnLimpar_Click(btnLimpar, EventArgs.Empty);
            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtData.Text = "";
            txtTelefone.Text = "";
            comboEC.SelectedIndex = 0;
            radioM.Checked = true;
            radiof.Checked = false;
            radioO.Checked = false;
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = Lista.SelectedIndex;

            if (indice == -1)
                return;

            ListaPessoas.RemoveAt(indice);
            Listar();
        }
        private void Listar()
        {
            Lista.Items.Clear();

            foreach (Pessoas p in ListaPessoas)
                Lista.Items.Add(p.Nome);
        }
    }
}