using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void connect(String command)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool Input_validation(String mail,String pass) 
        {
            if((mail.Length > 10) && (pass.Length > 7) && (mail.Contains("@gmail") || mail.Contains("@mail") || mail.Contains("@yahoo")) && (mail.EndsWith(".com")) )
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (Input_validation(email_box.Text,password_box.Text))
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AUTHENTICATION_SYSTEM WHERE E_MAIL = '" + email_box.Text + "' AND PASSWORD ='" + password_box.Text + "'", con);
                    con.Open();
                    int ans = (int)cmd.ExecuteScalar();
                    if (ans > 0)
                    {
                        
                        SqlCommand typ = new SqlCommand("SELECT [USER_TYPE] FROM USERR WHERE E_MAIL = '" + email_box.Text + "'", con);
                        String user_type =(String)typ.ExecuteScalar();

                        SqlCommand name_cmd = new SqlCommand("SELECT [USER_NAME] FROM USERR WHERE E_MAIL = '" + email_box.Text + "'", con);
                        String user_name = (String)name_cmd.ExecuteScalar();
                        if (user_type.Length > 0)
                        {
                            
                            if (user_type.Trim().ToLower()=="admin")
                            {
                                MessageBox.Show("successful login!");
                                this.Hide();
                                Admin form2 = new Admin(user_name);
                                 form2.Show();
                            }
                            else
                            {
                                MessageBox.Show("successful login!");
                                this.Hide();
                                User user = new User(user_name);
                                user.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("error with this account information please sign up with a new one");
                            Sign_up form = new Sign_up();
                            this.Hide();
                            form.Show();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("information entered is not found!");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid or too short!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Sign_up form = new Sign_up();
            this.Hide();
            form.Show();
        }
    }
}
