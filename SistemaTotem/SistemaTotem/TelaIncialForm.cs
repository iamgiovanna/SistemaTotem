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
    public partial class TelaIncialForm : Form
    {
        public TelaIncialForm()
        {
            InitializeComponent();
        }

        private void TelaIncialForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnGremio_Click(object sender, EventArgs e)
        {
            //evento gremio
            GremioForm formGremio = new GremioForm();
            formGremio.Show();
            this.Hide();

        }

        private void BtnSecretaria_Click(object sender, EventArgs e)
        {
            //evento secretária
                Secretaria formSecretaria = new Secretaria();
                formSecretaria.Show();
                this.Hide();
        }

        private void BtnMapa_Click(object sender, EventArgs e)
        {
            //evento mapa
            MapaForm formMapa = new MapaForm();
            formMapa.Show();
            this.Hide();
        }

        private void btnDenuncia_Click(object sender, EventArgs e)
        {
            //evento denuncia
            DenunciaForm formDenuncia = new DenunciaForm();
            formDenuncia.Show();    
            this.Hide();
        }

        private void BtnVestibular_Click(object sender, EventArgs e)
        {
            //evento vestibular
            VestibularesForm formVest = new VestibularesForm();
            formVest.Show();
            this.Hide();
        }

        private void BtnEventos_Click(object sender, EventArgs e)
        {
            //eventos eventos ksks
            EventosForm formEventos = new EventosForm();
            formEventos.Show();
            this.Hide();
        }
    }
}
