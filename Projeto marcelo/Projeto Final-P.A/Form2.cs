using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_P.A
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cadCntEstado.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult Fechar;
            Fechar = MessageBox.Show("Deseja Fechar a Matrix?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Fechar.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 TelaInicial = new Form1();
                TelaInicial.ShowDialog();
                this.Close();
            } 
        }

        private void cadCntLimpar_Click(object sender, EventArgs e)
        {
            cadCntBairro.Clear();
            cadCntCEP.Clear();
            cadCntCidade.Clear();
            cadCntConfSenha.Clear();
            cadCntCPF.Clear();
            cadCntEmail.Clear();
            cadCntEstado.SelectedIndex = 0;
            cadCntFem.Checked = false;;
            cadCntMasc.Checked = false;
            cadCntNome.Clear();
            cadCntNumero.Clear();
            cadCntOutros.Checked = false;
            cadCntRG.Clear();
            cadCntRua.Clear();
            cadCntSenha.Clear();
        }

        private void cadCntEnviar_Click(object sender, EventArgs e)
        {
            string nome, email, rg, cpf, rua, bairro, cidade, cep, numero, estado, senha, confsenha, Sexo = "";
            nome = cadCntNome.Text;
            email = cadCntEmail.Text;
            rg = cadCntRG.Text;
            cpf = cadCntCPF.Text;
            rua = cadCntRua.Text;
            bairro = cadCntBairro.Text;
            cidade = cadCntCidade.Text;
            cep = cadCntCEP.Text;
            numero = cadCntNumero.Text;
            estado = cadCntEstado.Text;
            senha = cadCntSenha.Text;
            confsenha = cadCntConfSenha.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(nome))
                {
                    throw new Exception("Campo Nome Vazio");
                }
                if (string.IsNullOrWhiteSpace(email))
                {
                    throw new Exception("Campo Email Vazio");
                }
                if (string.IsNullOrWhiteSpace(rg))
                {
                    throw new Exception("Campo RG Vazio");
                }
                if (rg.Length != 9)
                {
                    throw new Exception("Formato de RG invalido");
                }
                if (string.IsNullOrWhiteSpace(cpf))
                {
                    throw new Exception("Campo CPF Vazio");
                }
                if (cpf.Length != 11)
                {
                    throw new Exception("Formato de CPF invalido");
                }
                if (string.IsNullOrWhiteSpace(rua))
                {
                    throw new Exception("Campo Rua Vazio");
                }
                if (string.IsNullOrWhiteSpace(bairro))
                {
                    throw new Exception("Campo Bairro Vazio");
                }
                if (string.IsNullOrWhiteSpace(cidade))
                {
                    throw new Exception("Campo Cidade Vazio");
                }
                if (string.IsNullOrWhiteSpace(cep))
                {
                    throw new Exception("Campo CEP Vazio");
                }
                try
                {
                    Int64.Parse(cep);
                }
                catch
                {
                    throw new Exception("Formato de CEP invalido");
                }
                if (cep.Length != 8)
                {
                    throw new Exception("CEP deve conter 8 digitos");
                }
                if (string.IsNullOrWhiteSpace(numero))
                {
                    throw new Exception("Campo Número Vazio");
                }
                try
                {
                    int.Parse(numero);
                }
                catch
                {
                    throw new Exception("Formato de Número invalido");
                }
                if (string.IsNullOrWhiteSpace(estado) || estado == "Nenhum")
                {
                    throw new Exception("Campo Estado Vazio");
                }
                if (cadCntMasc.Checked == true)
                {
                    Sexo = cadCntMasc.Text;
                }
                if (cadCntFem.Checked == true)
                {
                    Sexo = cadCntFem.Text;
                }
                if (cadCntOutros.Checked == true)
                {
                    Sexo = cadCntOutros.Text;
                }
                if (Sexo == "")
                {
                    throw new Exception("Selecione o Sexo");
                }
                if (string.IsNullOrWhiteSpace(senha))
                {
                    throw new Exception("Campo Senha Vazio");
                }
                if (string.IsNullOrWhiteSpace(confsenha))
                {
                    throw new Exception("Campo Confirmar Senha Vazio");
                }
                if (senha.Length != 8)
                {
                    throw new Exception("Senha Deve conter 8 Algarismos");
                }
                if (senha != confsenha)
                {
                    throw new Exception("Senha Não Corresponde");
                }

                MessageBox.Show("O Cadastro foi Realizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cadCntBairro.Clear();
                cadCntCEP.Clear();
                cadCntCidade.Clear();
                cadCntConfSenha.Clear();
                cadCntCPF.Clear();
                cadCntEmail.Clear();
                cadCntEstado.SelectedIndex = 0;
                cadCntFem.Checked = false; ;
                cadCntMasc.Checked = false;
                cadCntNome.Clear();
                cadCntNumero.Clear();
                cadCntOutros.Checked = false;
                cadCntRG.Clear();
                cadCntRua.Clear();
                cadCntSenha.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Encontrei um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
