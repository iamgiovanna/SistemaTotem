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

    public int GerarId(IMongoCollection<Class1> collection)
    {
        var ultimoItem = collection.Find(_ => true)
            .SortByDescending(i => i.Id)
            .FirstOrDeafult();

        return (ultimoItem.Id ?? 0) + 1;
    }

    public partial class FormEdicaoEvento1 : Form
    {
        public FormEdicaoEvento1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void InfoEvento_Click(object sender, EventArgs e)
        {

        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            try{ 
            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemBancoDeDados>("GACollection_Eventos");


            int novoId = GerarId(collection);
            var novoItem = new ItemBancoDeDados
            {
                Id = GerarId,
                Evento = txtEventos.Text,
                Descricao = txtDesc.Text
            };

            collection.InsertOne(novoItem);

            Console.WriteLine("Item salvo com sucesso");

            }catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message }");

            }


        }
    }
}
