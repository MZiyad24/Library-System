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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();

            sign.Enabled = false;

            //--------------------- user won't sign until he choose the type

            user.CheckedChanged+=Check_radios;
            admin_btn.CheckedChanged+=Check_radios;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            
            try{
                if (form1.Input_validation(email_box.Text, password_box.Text))
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";

                    //------------------- check if the email already exists

                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AUTHENTICATION_SYSTEM WHERE E_MAIL = '" + email_box.Text + "'", con);
                    con.Open();
                    int ans = (int)cmd.ExecuteScalar();
                    if (ans == 0)
                    {
                        //------------------  inserting into authentication table

                        SqlCommand cmd2 = new SqlCommand("INSERT INTO AUTHENTICATION_SYSTEM (E_MAIL, PASSWORD) VALUES ('" + email_box.Text + "', '" + password_box.Text + "' )", con);
                        
                        String EMAIL=email_box.Text;  // save the primary key for further use

                        //------------------ username validation

                        if(username.Text.Length>4) 
                        {    
                            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM USERR WHERE USER_NAME = '" + username.Text + "'", con);
                            int val = (int)cmd3.ExecuteScalar();

                            
                            if (val == 0)
                            {
                                //---------------- checking user type

                                String type;
                                String USERNAME=username.Text;

                                if(admin_btn.Checked) 
                                {
                                    type = "admin";
                                }
                                else
                                {
                                    type = "user";
                                }

                                //---------------- updating the user table
                                cmd2.ExecuteNonQuery();   // adding to authentication

                                SqlCommand upd = new SqlCommand("INSERT INTO USERR (E_MAIL, USER_NAME, USER_TYPE, USER_ID) VALUES ('" + EMAIL + "', '" + username.Text + "','"+ type +"','"+user_id_val.Value+"' )", con);
                                upd.ExecuteNonQuery();
                                
                                //------------------ success

                                MessageBox.Show("Welcome to our site ;)");
                                this.Hide();
                                if(type=="admin")
                                {
                                    Admin form = new Admin(USERNAME);
                                    form.Show();
                                }
                                else
                                {
                                    User form = new User(USERNAME); 
                                    form.Show();
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("username is already used!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid username syntax!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("email is used!");
                    }
                    con.Close();

                }
                else
                {
                    MessageBox.Show("invalid input");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Check_radios(object sender, EventArgs e)
        {
            if (user.Checked || admin_btn.Checked) { sign.Enabled = true; }

        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }
    }
}
