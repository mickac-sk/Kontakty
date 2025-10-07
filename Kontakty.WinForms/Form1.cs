namespace Kontakty.WinForms
{
    public partial class Form1 : Form
    {
        private readonly string login_name = "admin";
        private readonly string password_name = "Admin1";
        public Form1()
        {
            InitializeComponent();

            titleLable.Text = "Witaj w aplikacji Kontakty";
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text == null || passwordTextbox.Text == null || loginTextbox.Text == "" || passwordTextbox.Text == "")
            {
                MessageBox.Show("Pola nie moga byæ puste");
            }

            if(loginTextbox.Text == login_name &&  passwordTextbox.Text == password_name)
            {
                MessageBox.Show("Logowanie poprawne");
            }
            else
            {
                MessageBox.Show("B³êdny login lub has³o");
                passwordTextbox.Text = "";
            }
        }
    }
}
