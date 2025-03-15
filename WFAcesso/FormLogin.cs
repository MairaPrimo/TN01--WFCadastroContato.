namespace WFAcesso
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtUsuario.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        return;
                    }
                }

            }

            MessageBox.Show("Usuario Não Autenticado!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario u1 = new Usuario();
            u1.Codigo = 1;
            u1.Login = "admin";
            u1.Senha = "admin";
            u1.DataCadastro = Convert.ToDateTime("01/01/2000");
            //u1.DataCadastro = DateTime.Parse ("01/01/2000");
            
            Usuario.ListaUsuarios.Add(u1);
        }
    }
}
