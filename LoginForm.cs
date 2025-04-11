using System;
using System.Data.SqlClient;
using System.Windows.Forms;  // 📌 Assurez-vous que Windows Forms est référencé


namespace Gestion_Ensegnent_et_Etudient
{
    internal class LoginForm

    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            using (SqlConnection con = new SqlConnection("your_connection_string"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT role FROM Utilisateurs WHERE email=@Email AND mot_de_passe=@Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show("Connexion réussie en tant que " + role);

                        this.Hide();
                        DashboardForm dashboard = new DashboardForm(role);
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email ou mot de passe incorrect !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion : " + ex.Message);
                }
            }
        }
    }
}
