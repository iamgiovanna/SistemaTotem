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
    public partial class Secretaria : Form
    {
        private void CarregarInfo(string nome, string func)
        {
            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemSecretaria>("GACollection_Secretaria");

            var filtro = Builders<ItemSecretaria>.Filter.Eq(item => item.DiaDaSemana, TxtDiaSemana1.Text);

            var itens = collection.Find(filtro).FirstOrDefault();

            if (itens != null)
            {
                TxtDiaSemana1.Text = itens.DiaDaSemana;
                TxtDiaSemana2.Text = itens.DiaDaSemana;
                TxtDiaSemana3.Text = itens.DiaDaSemana;
                TxtDiaSemana4.Text = itens.DiaDaSemana;
                TxtDiaSemana5.Text = itens.DiaDaSemana;
                TxtDiaSemana7.Text = itens.DiaDaSemana;

                TxtHora1.Text = itens.Horario;
                TxtHora2.Text = itens.Horario;
                TxtHora3.Text = itens.Horario;
                TxtHora4.Text = itens.Horario;
                TxtHora5.Text = itens.Horario;
                TxtHora6.Text = itens.Horario;

                Console.WriteLine("Informações carregadas com sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhuma informação encontrada para o evento especificado.");
            }
        }
        public Secretaria()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //EVENTO para voltar a tela inicial
            TelaIncialForm telaIncialForm = new TelaIncialForm();
            telaIncialForm.Show();
            this.Hide();
        }



        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemSecretaria>("GACollection_Secretaria");

            Dictionary<string, string> textBoxData = new Dictionary<string, string>();
            foreach (Control control in BotaoSalvar.Controls) {
                if (control is TextBox textBox) {
                    textBoxData[textBox.Name] = textBox.Text;
                }
            }

            foreach (var item in textBoxData)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            MessageBox.Show("Dados coletados com sucesso!", "Informação");
            /*if ((string.IsNullOrWhiteSpace(TxtDiaSemana1.Text)) || (string.IsNullOrWhiteSpace(TxtDiaSemana2.Text))|| (string.IsNullOrWhiteSpace(TxtDiaSemana3.Text)) || (string.IsNullOrWhiteSpace(TxtDiaSemana4.Text)) || (string.IsNullOrWhiteSpace(TxtHora1.Text)))
            {
                MessageBox.Show("Para prosseguir com a ação é preciso preencher todos os campos!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mongoConnection = new Class1("App_GremioDB", "mongodb://localhost:27017");
            var collection = mongoConnection.GetCollection<ItemSecretaria>("GACollection_Secretaria");

            var novoItem = new ItemSecretaria
            {
                DiaDaSemana = TxtDiaSemana1.Text,
                Horario = TxtHora1.Text
            };*/
        }

    }
}
