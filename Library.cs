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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
            return_btn.Enabled = false;
            DataShow();
        }
        public Library(int id,String username)
        {
            InitializeComponent();
            return_btn.Enabled=false;
            this.username = username;
            this.id = id;
            DataShow();
        }

        int id = -1;
        String username = null; 
        private void DataShow()
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand(comm(), con);
                con.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);   // adding data to the grid
                results.DataSource = data;  // showing data
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private String comm()
        {
            return "SELECT ISBN, BORROW_DATE AS 'BORROW DATE', DUE_DATE AS 'DUE' " +
                   "FROM BORROWING_DETAILS " +
                   "WHERE USER_ID = '" + id + "' AND RETURN_DATE IS NULL";


        }

        private DataGridViewCellEventArgs arr;

        private void return_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand(comm(), con);
                con.Open();

                //--------------- update borrowing details

                // String title = results.Rows[arr.RowIndex].Cells["TITLE"].Value.ToString();   // getting the title of the chosen book
                int isbn = (int)results.Rows[arr.RowIndex].Cells["ISBN"].Value;             // getting book's isbn
                DateTime brw_date = (DateTime)results.Rows[arr.RowIndex].Cells["BORROW DATE"].Value; // getting the borrow date
                DateTime return_date = DateTime.Today;

                SqlCommand state_cmd = new SqlCommand("SELECT STATUS FROM BORROWING_DETAILS WHERE ISBN='"+isbn+"' AND BORROW_DATE ='"+brw_date+"'", con);
                String state = (String)state_cmd.ExecuteScalar();

                if(state=="false")
                { 
                    SqlCommand update_cmd = new SqlCommand("UPDATE BORROWING_DETAILS SET RETURN_DATE ='" + return_date + "', STATUS='true' WHERE ISBN ='"+isbn+"' AND BORROW_DATE ='"+brw_date+"' ", con); 
                    update_cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand update_cmd = new SqlCommand("UPDATE BORROWING_DETAILS SET RETURN_DATE ='" + return_date + "' WHERE ISBN ='" + isbn + "' AND BORROW_DATE ='" + brw_date + "' ", con);
                    update_cmd.ExecuteNonQuery();
                }

                //--------------- upadate copy details

                SqlCommand cpy_cmd = new SqlCommand("SELECT COPY_NUMBER FROM COPY WHERE ISBN='" + isbn + "'", con);
                int num = (int)cpy_cmd.ExecuteScalar();

                num += 1;

                SqlCommand update_num = new SqlCommand("UPDATE COPY SET COPY_NUMBER ='"+num+ "' WHERE ISBN='" + isbn + "'", con);
                update_num.ExecuteNonQuery();
                MessageBox.Show("Book has been returned successfully");

                con.Close();
                DataShow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            arr = e;
            return_btn.Enabled = true;
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            User user = new User(username);
            this.Hide();
            user.Show();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            user_btn.Text = username;
        }
    }
}
