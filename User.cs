using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            borrow_btn.Enabled = false;
            return_btn.Enabled = false;
            DataShow();
            Validation();
           // filter_SelectedIndexChanged+=
        }

        public User(string username)
        {
            InitializeComponent();
            this.USERNAME = username;
            borrow_btn.Enabled = false;
            return_btn.Enabled = false;
            Show_Details();
            DataShow();
            Validation();
        }

        private String USERNAME="";

        private int user_id = -1;

        public void Show_Details()
        { 
            user_btn.Text=this.USERNAME;
        }
        private void User_Load(object sender, EventArgs e)
        {
            Show_Details();

        }

        public String comm()   // i will select the the attributes needed form the book and use keys to get the authors,publisher info and check the details
        {
            return "" +
                "SELECT TITLE, AUTHOR.AUTHOR_NAME AS AUTHOR, PUBLISHER.PUBLISHER_NAME AS PUBLISHER, BOOK.BOOK_ID AS ID " +  // selecting attributes
                "FROM BOOK " +  // SELECTING THE ENTITY
                "INNER JOIN AUTHOR ON BOOK.AUTHOR_ID = AUTHOR.AUTHOR_ID " +  // JOIN 1
                "INNER JOIN PUBLISHER ON BOOK.PUBLISHER_ID = PUBLISHER.PUBLISHER_ID " +  // JOIN 2
                "INNER JOIN COPY ON BOOK.BOOK_ID = COPY.BOOK_ID " +  // JOIN 3 (FOR THE VALIDATION CONDITION)
                "WHERE COPY.COPY_NUMBER > 0";  // select books that its status is not borrowed
        }

        private void DataShow()
        {
            try{

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand(comm(), con);
                con.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(comm(),con.ConnectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(data);   // adding data to the grid
                results.DataSource= data;  // showing data
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Validation()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
            con.Open();

            SqlCommand user_id_cmd=new SqlCommand("SELECT USER_ID FROM USERR WHERE USER_NAME = '"+USERNAME+"'", con);  // user id
            int id = (int)user_id_cmd.ExecuteScalar();
            user_id = id;


            SqlCommand cmd = new SqlCommand("SELECT count (*) FROM BORROWING_DETAILS WHERE USER_ID = '"+id+"'", con);
            int ans = (int)cmd.ExecuteScalar();

            if(ans>0)
            {
                return_btn.Enabled = true;
            }
            else
            {
                return_btn.Enabled=false;
            }
            con.Close();
            
        }
            
        private void search_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private DataGridViewCellEventArgs argument;

        private void results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            borrow_btn.Enabled = true;
            argument = e;

        }

        

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
            con.Open();

            //----------------------- getting the data from the grid

            String title = results.Rows[argument.RowIndex].Cells["TITLE"].Value.ToString();
            String author = results.Rows[argument.RowIndex].Cells["AUTHOR"].Value.ToString();
            String publisher = results.Rows[argument.RowIndex].Cells["PUBLISHER"].Value.ToString();
            int ID = (int)results.Rows[argument.RowIndex].Cells["ID"].Value;

            //---------------------- getting the pk of the data to connect to the next database table

            SqlCommand isbn_cmd = new SqlCommand("SELECT ISBN FROM BOOK WHERE BOOK_ID = '"+ID+"'",con);             // book isbn
            int isbn = (int)isbn_cmd.ExecuteScalar();

            SqlCommand cmd = new SqlCommand("SELECT COPY_NUMBER FROM COPY WHERE BOOK_ID='"+ID+"'", con);            // copy number
            int num = (int)cmd.ExecuteScalar();

            SqlCommand copy = new SqlCommand("SELECT COPY_ID FROM COPY WHERE BOOK_ID='" + ID + "'", con);           // copy id
            int cpy_id = (int)copy.ExecuteScalar();

            SqlCommand user = new SqlCommand("SELECT USER_ID FROM USERR WHERE USER_NAME='" + USERNAME + "'", con);  // user id
            int usr_id = (int)user.ExecuteScalar();

            DateTime today = DateTime.Today;                                                                        // borrow date

            DateTime due = DateTime.Today.AddMonths(1);                                                             // due date

            

            SqlCommand check_cmd = new SqlCommand("SELECT COUNT(*) FROM BORROWING_DETAILS WHERE USER_ID='" + usr_id + "' AND ISBN= '" + isbn + "'", con);
            int check =(int)check_cmd.ExecuteScalar();

            int idddd = generate_borrow_id();

            if(check==0)
            {
                if(num == 1 )    // the last copy
                {

                    SqlCommand brw = new SqlCommand(add_book(idddd, usr_id, ID, isbn, today, due, "false"), con);
                    brw.ExecuteNonQuery();

                }
                else
                {
                    //------------- insert into the borrowing details

                    SqlCommand brw = new SqlCommand(add_book(idddd,usr_id,ID,isbn,today,due,"true"), con);
                    brw.ExecuteNonQuery();
                
                }

                //------------- update the copy num
                num -= 1;
                SqlCommand cpy = new SqlCommand("UPDATE COPY SET COPY_NUMBER = '" + num + "' WHERE COPY_ID = '" + cpy_id + "'", con);
                cpy.ExecuteNonQuery();
                MessageBox.Show("Book has been borrowed successfully");
            }
            else
            {
                MessageBox.Show("YOU ALREADY BORROWING THIS BOOK!");
            }

            con.Close();

        }

        private String add_book(int borrow_id, int user_id , int book_id , int isbn , DateTime borrow_date , DateTime due_date , String state)
        {
            return "INSERT INTO BORROWING_DETAILS (BORROWING_ID,USER_ID,BOOK_ID,ISBN,BORROW_DATE,DUE_DATE,STATUS) VALUES ('"+borrow_id+"','"+user_id+"','"+book_id+"','"+isbn+"','"+borrow_date+"','"+due_date+"','"+state+"')";
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Library lib = new Library(user_id,USERNAME);
            lib.Show();

        }

        public int generate_borrow_id()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                con.Open();
                SqlCommand genertae_id_cmd = new SqlCommand("SELECT TOP 1 COALESCE(CAST(BORROWING_ID AS INT), 0) FROM BORROWING_DETAILS ORDER BY BORROW_DATE DESC", con);
                int idddd = (int)genertae_id_cmd.ExecuteScalar();
                idddd++;

                bool flag = true;
                while (flag)     // case of duplicate
                {
                    SqlCommand flag_cmd = new SqlCommand("SELECT COUNT(*) FROM BORROWING_DETAILS WHERE BORROWING_ID='" + idddd + "'", con);
                    int ans = (int)flag_cmd.ExecuteScalar();
                    if (ans > 0)
                    {
                        idddd++;
                    }
                    else
                    {
                        flag = false;

                    }
                }
                con.Close();
                return idddd;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);return -1; }   
        }

        private void browse_Click(object sender, EventArgs e)
        {
            try
            {
                if (search.Text.Length == 0)
                {
                    DataShow();
                }
                else
                {
                    DataView dataview = ((DataTable)results.DataSource).DefaultView; // taking the data in the grid
                    string filterText = search.Text.Trim();

                    
                    string rowFilter = $"AUTHOR LIKE '%{filterText}%' OR PUBLISHER LIKE '%{filterText}%' OR TITLE LIKE '%{filterText}%'";

                    // Log or display the filter string for debugging
                    Console.WriteLine("Applying RowFilter: " + rowFilter); // For console logging
                    // MessageBox.Show("Applying RowFilter: " + rowFilter); 

                    
                    dataview.RowFilter = rowFilter;
                    Console.WriteLine("Filtered Rows Count: " + dataview.Count);
                    MessageBox.Show("Filtered Rows Count: " + dataview.Count);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
