using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Projeto_Agropuro.Telas.PaginaClientes;

namespace Projeto_Agropuro.Telas
{
    public partial class PaginaInicial : Form
    {
        Thread t1;
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e) //Perfil
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e) //Botão Aparecer
        {
            guna2Panel2.Show();
            guna2ImageButton1.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e) //Botão Esconder
        {
            guna2Panel2.Hide();
            guna2ImageButton1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e) //Pagina Inicial
        {
            this.Close();
            t1 = new Thread(abrirjanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void abrirjanela(object obj)
        {
            Application.Run(new PaginaInicial());
        }

        private void guna2TileButton5_Click(object sender, EventArgs e) //Produtos
        {

        }

        private void guna2TileButton4_Click(object sender, EventArgs e) //Grafico
        {

        }

        private void guna2TileButton3_Click(object sender, EventArgs e) //Fornecedore
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e) //Funcionario
        {

        }

        private void guna2TileButton1_Click(object sender, EventArgs e) //Cliente
        {
            this.Close();
            t1 = new Thread(abrirCliente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void abrirCliente(object obj)
        {
            Application.Run(new ClienteInicial());
        }

        private void PaginaInicial_Load_1(object sender, EventArgs e)
        {

        }
    }
}
