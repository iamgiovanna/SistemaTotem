﻿using ConexaoBD;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaTotem
{
    public partial class FormEdicaoEvento2 : Form
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
        public FormEdicaoEvento2()
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

            if(result.DeletedCount > 0)
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


    }
}
