using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDeMenu
{
    public partial class Menu : Form
    {

        TelaCadastro cad;
        TelaAtualizar atu;
        TelaConsultar con;
        TelaExcluir exc;
        public Menu()
        {
            InitializeComponent();
            cad = new TelaCadastro();
            atu = new TelaAtualizar();
            con = new TelaConsultar();
            exc = new TelaExcluir();

        } // fim do construtor

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            cad.ShowDialog(); //mostrar a tela ao ser chamada 
            Visible = true;

        }//fim do botão cadastrar

        private void consultar_Click(object sender, EventArgs e)
        {
            Visible = false;
            con.ShowDialog(); //mostrar a tela ao ser chamada 
            Visible = true;

        }//fim do botão consultar

        private void atualizar_Click(object sender, EventArgs e)
        {
            Visible = false;
            atu.ShowDialog(); //mostrar a tela ao ser chamada 
            Visible = true;

        }// fim do botão atualizar

        private void excluir_Click(object sender, EventArgs e)
        {
            Visible = false;
            exc.ShowDialog(); //mostrar a tela ao ser chamada 
            Visible = true;

        }//Fim do botão excluir




    }//Fim da classe
}//Fim do projeto
