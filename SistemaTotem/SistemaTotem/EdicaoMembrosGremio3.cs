using ConexaoBD;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTotem
{
    public partial class EdicaoMembrosGremio3 : Form
    {
        private void CarregarInfo(string nome, string func)
        {
            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemBancoDeDadosChapa>("GACollections_AlunoChapa");

            var filtro = Builders<ItemBancoDeDadosChapa>.Filter.Eq(item => item.NomeAluno, TxtNome.Text);

            var itens = collection.Find(filtro).FirstOrDefault();

            if (itens != null)
            {
                TxtNome.Text = itens.NomeAluno;
                txtFuncao.Text = itens.Funcao;

                Console.WriteLine("Informações carregadas com sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhuma infromação encontrada para o evento especificado.");
            }
        }

        public EdicaoMembrosGremio3()
        {
            InitializeComponent();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemBancoDeDadosChapa>("GACollections_AlunoChapa");

            var filtro = Builders<ItemBancoDeDadosChapa>.Filter.Eq(Item => Item.NomeAluno, TxtNome.Text);
            var result = collection.DeleteOne(filtro);

            if (result.DeletedCount > 0)
            {
                MessageBox.Show("Item excluído com sucesso!");

                TxtNome.Clear();
                txtFuncao.Clear();
            }
            else
            {
                MessageBox.Show("Nenhum Item encontrado com o critério específicado");
            }
        }


        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text) || string.IsNullOrWhiteSpace(txtFuncao.Text))
            {
                MessageBox.Show("Para prosseguir com a ação é preciso preencher todos os campos!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemBancoDeDadosChapa>("GACollections_AlunoChapa");

            var novoItem = new ItemBancoDeDadosChapa
            {
                NomeAluno = TxtNome.Text,
                Funcao = txtFuncao.Text
            };


            collection.InsertOne(novoItem);

            MessageBox.Show("Item salvo com sucesso");

            CarregarInfo(novoItem.NomeAluno, novoItem.Funcao);
        }

        private void FotoPerfil_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                openFileDialog.Title = "Selecione uma imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FotoPerfil.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
