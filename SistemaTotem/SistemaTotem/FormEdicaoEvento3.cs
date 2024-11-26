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
    public partial class FormEdicaoEvento3 : Form
    {
        private void CarregarInfo(string evento, string desc)
        {
            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemBancoDeDados>("GACollection_Eventos");

            var filtro = Builders<ItemBancoDeDados>.Filter.Eq(item => item.Evento, TxtEventos.Text);

            var itens = collection.Find(filtro).FirstOrDefault();

            if (itens != null)
            {
                TxtEventos.Text = itens.Evento;
                txtDesc.Text = itens.Descricao;

                Console.WriteLine("Informações carregadas com sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhuma infromação encontrada para o evento especificado.");
            }
        }

        public FormEdicaoEvento3()
        {
            InitializeComponent();
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEventos.Text) || string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Para prosseguir com a ação é preciso preencher todos os campos!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemBancoDeDados>("GACollection_Eventos");

            var novoItem = new ItemBancoDeDados
            {
                Evento = TxtEventos.Text,
                Descricao = txtDesc.Text
            };


            collection.InsertOne(novoItem);

            MessageBox.Show("Item salvo com sucesso");

            CarregarInfo(novoItem.Evento, novoItem.Descricao);

        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {

            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemBancoDeDados>("GACollection_Eventos");

            var filtro = Builders<ItemBancoDeDados>.Filter.Eq(Item => Item.Evento, TxtEventos.Text);
            var result = collection.DeleteOne(filtro);

            if (result.DeletedCount > 0)
            {
                MessageBox.Show("Item excluído com sucesso!");

                TxtEventos.Clear();
                txtDesc.Clear();

            }
            else
            {
                MessageBox.Show("Nenhum Item encontrado com o critério específicado");
            }

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
