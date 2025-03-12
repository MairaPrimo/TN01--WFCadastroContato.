namespace TN01__WFCadastroContato
{
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            TN01__WFCadastroContato form = new FormCadastro();
            form.ShowDialog();
        }
    }
}
        }
    }
}
