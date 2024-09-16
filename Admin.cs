using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBaseProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Add_btn.Enabled = false;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;
            change();
            

            //--------- event handlers
            bOOK_IDTextBox.LostFocus += bOOK_IDTextBox_LostFocus;
            cATEGORYTextBox.LostFocus += cATEGORYTextBox_LostFocus;
            tITLETextBox.LostFocus += tITLETextBox_LostFocus;
            aUTHOR_IDTextBox.LostFocus += aUTHOR_IDTextBox_LostFocus;
            iSBNTextBox.LostFocus += iSBNTextBox_LostFocus;
            pUBLISHER_IDTextBox.LostFocus += pUBLISHER_IDTextBox_LostFocus;
            cOPY_NUMBERTextBox.LostFocus += cOPY_NUMBERTextBox_LostFocus;
            aUTHOR_NAMETextBox.LostFocus += aUTHOR_NAMETextBox_LostFocus;
            pUBLISHER_NAMETextBox.LostFocus += pUBLISHER_NAMETextBox_LostFocus;
        }
        public Admin(string name)
        {
            InitializeComponent();
            this.name = name;
            Add_btn.Enabled = false;
            update_btn.Enabled = false;
            delete_btn.Enabled= false;
            change();
            

            bOOK_IDTextBox.LostFocus += bOOK_IDTextBox_LostFocus;
            cATEGORYTextBox.LostFocus += cATEGORYTextBox_LostFocus;
            tITLETextBox.LostFocus += tITLETextBox_LostFocus;
            aUTHOR_IDTextBox.LostFocus += aUTHOR_IDTextBox_LostFocus;
            iSBNTextBox.LostFocus += iSBNTextBox_LostFocus;
            pUBLISHER_IDTextBox.LostFocus += pUBLISHER_IDTextBox_LostFocus;
            cOPY_NUMBERTextBox.LostFocus += cOPY_NUMBERTextBox_LostFocus;
            aUTHOR_NAMETextBox.LostFocus += aUTHOR_NAMETextBox_LostFocus;
            pUBLISHER_NAMETextBox.LostFocus += pUBLISHER_NAMETextBox_LostFocus;

            

        }


        //----------------------- attributes 

        private String name="admin";
        private int book_check=0;   // max 7 
        private int pub_check=0;    // max 1
        private int auth_check=0;   // max 1

        private int book_id=0;
        private int isbn=0;
        private int pub_id=0;
        private int auth_id=0;
        private int copy_num=0;

        private String title=null;
        private String publisher=null;
        private String author=null;
        private String category=null;

        DataGridViewCellEventArgs ev;

        private void change()
        {
            user_btn.Text = name;
        }

        private String comm()
        {
            return "SELECT CAST(BOOK.BOOK_ID AS VARCHAR) AS 'BOOK_ID', CAST(BOOK.ISBN AS VARCHAR) AS 'ISBN', PUBLISHER.PUBLISHER_NAME AS PUBLISHER, AUTHOR.AUTHOR_NAME AS AUTHOR, BOOK.CATEGORY, BOOK.TITLE, COPY.COPY_NUMBER AS AVAILABLE " +
                  "FROM BOOK " +
                  "INNER JOIN PUBLISHER ON PUBLISHER.PUBLISHER_ID = BOOK.PUBLISHER_ID " +
                  "INNER JOIN AUTHOR ON AUTHOR.AUTHOR_ID = BOOK.AUTHOR_ID " +
                  "INNER JOIN COPY ON COPY.BOOK_ID = BOOK.BOOK_ID";

        }

        private String filter_data(System.Windows.Forms.TextBox Tbox, String column)
        {
            try
            {

                // Ensure the column name is properly escaped
                // string columnName = column.Replace("'", "''");
                // Ensure the text value is properly escaped
                // string textValue = Tbox.Text.Trim().Replace("'", "''");
                String like = "'" + column + "' LIKE '" + Tbox.Text.Trim() + "'";
                return like;
                // return string.Format("{0} LIKE '%{1}%'", column, Tbox.Text.Trim());
            }
            catch (Exception e) { MessageBox.Show(e.Message); return ""; }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand(comm(), con);
                con.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(comm(), con.ConnectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(data);   // adding data to the grid
                results.DataSource = data;  // showing data
                con.Close();

                reset_text();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private System.Windows.Forms.TextBox box;

        private String col;

        public DataTable Data(String fn)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True"))
                {
                    con.Open();

                    // Debugging output to see the actual SQL command string
                     // MessageBox.Show($"Executing SQL Command: {fn}");

                    using (SqlCommand cmd = new SqlCommand(fn, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Output the exception message for debugging
                MessageBox.Show($"Error: {ex.Message}");
            }
            return dt;
        }

        private void reset_text()
        {
            bOOK_IDTextBox.Text = "";
            cATEGORYTextBox.Text = "";
            tITLETextBox.Text = "";
            aUTHOR_IDTextBox.Text = "";
            iSBNTextBox.Text = "";
            pUBLISHER_IDTextBox.Text = "";
            cOPY_NUMBERTextBox.Text = "";
            aUTHOR_NAMETextBox.Text = "";
            pUBLISHER_NAMETextBox.Text = "";
        }

        private void book_valid()
        {
            if(book_check >=7)
            {
                Add_btn.Enabled = true;
                update_btn.Enabled = true;
            }
            if(bOOK_IDTextBox.Text.Length > 0) 
            { 
                if(iSBNTextBox.Text.Length > 0) 
                { 
                    delete_btn.Enabled = true;
                }
            }
        }
        private void auth_valid()
        {
            if(auth_check >=2)
            {
                Add_btn.Enabled = true;
                update_btn.Enabled = true;
            }
            if(aUTHOR_IDTextBox.Text.Length > 0)
            {
                delete_btn.Enabled = true;
            }
        }
        private void pub_valid()
        {
            if(pub_check >=2)
            {
                Add_btn.Enabled = true;
                update_btn.Enabled = true;
            }
            if(pUBLISHER_IDTextBox.Text.Length > 0)
            {
                delete_btn.Enabled = true;
            }
        }
        private void results_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                ev = e;
            }

        
        
        private void user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void filter(String col, System.Windows.Forms.TextBox name)                               //  we can make the grid changes on each table once ? 
         {
            try
            {

                DataView dataview = ((DataTable)results.DataSource).DefaultView; // taking the data in the grid
                String filterText = name.Text.Trim();

                string rowFilter = $"{col} LIKE '%{filterText}%'";

                // Log or display the filter string for debugging
                Console.WriteLine("Applying RowFilter: " + rowFilter); // For console logging

                dataview.RowFilter = rowFilter;
                Console.WriteLine("Filtered Rows Count: " + dataview.Count);
                MessageBox.Show("Filtered Rows Count: " + dataview.Count);

                book_valid();
                pub_valid();
                auth_valid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //-----------------------typing filtering grid  

        
        private void bOOK_IDTextBox_LostFocus(object sender, EventArgs e)
        {
            if(bOOK_IDTextBox.Text.Length > 0)
            {
                book_check++;book_id = int.Parse(bOOK_IDTextBox.Text);
                box = bOOK_IDTextBox;
                col = "BOOK_ID";
                filter(col,box);
                
            }
            
            
        }
        
        private void iSBNTextBox_LostFocus(object sender, EventArgs e)
        {
            if (iSBNTextBox.Text.Length > 0)
            {
                book_check++;isbn = int.Parse(iSBNTextBox.Text);
                box = iSBNTextBox;
                col = "ISBN";
                filter(col, box);
                
            }
            
        }

        private void pUBLISHER_IDTextBox_LostFocus(object sender, EventArgs e)
        {
            if (pUBLISHER_IDTextBox.Text.Length > 0)
            {
                book_check++;
                pub_check++;
                pub_id = int.Parse(pUBLISHER_IDTextBox.Text);
                pub_valid();

            }
           
        }
        
        private void aUTHOR_IDTextBox_LostFocus(object sender, EventArgs e)
        {
            if (aUTHOR_IDTextBox.Text.Length > 0)
            {
                book_check++;
                auth_check++;
                auth_id = int.Parse(aUTHOR_IDTextBox.Text);
                auth_valid();
            }
            
        }

        private void cATEGORYTextBox_LostFocus(object sender, EventArgs e)
        {
            if (cATEGORYTextBox.Text.Length > 0)
            {
                book_check++;
                category = cATEGORYTextBox.Text;
                box = cATEGORYTextBox;
                col = "CATEGORY";
                filter(col, box);
            }
            
            
        }

        private void tITLETextBox_LostFocus(object sender, EventArgs e)
        {
            if (tITLETextBox.Text.Length > 0)
            {
                book_check++;
                title = tITLETextBox.Text;
                box = tITLETextBox;
                col = "TITLE";
                filter(col, box);
                
            }
            
           
        }

        private void cOPY_NUMBERTextBox_LostFocus(object sender, EventArgs e)
        {
            if (cOPY_NUMBERTextBox.Text.Length > 0)
            {
                book_check++;
                copy_num = int.Parse(cOPY_NUMBERTextBox.Text);
                box = cOPY_NUMBERTextBox;
                col = "AVAILABLE";
                filter(col, box);
                

            }
            
        }

        private void aUTHOR_NAMETextBox_LostFocus(object sender, EventArgs e)
        {
            if (aUTHOR_NAMETextBox.Text.Length > 0)
            {
                auth_check++;
                author = aUTHOR_NAMETextBox.Text;
                box = aUTHOR_NAMETextBox;
                col = "AUTHOR";
                filter(col, box);
                

            }
            
            
        }

        private void pUBLISHER_NAMETextBox_LostFocus(object sender, EventArgs e)
        {
            if (pUBLISHER_NAMETextBox.Text.Length > 0)
            {
                pub_check++;
                publisher = pUBLISHER_NAMETextBox.Text;
                box =pUBLISHER_NAMETextBox;
                col = "PUBLISHER";
                filter(col, box);
                

            }
            
            
        }


        //-------------------------- buttons 
        
        //--------------------  add
        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (auth_check >= 2)
                {
                    if (auth_info_validation())
                    {
                        add_author();
                    }
                    else
                    {
                        MessageBox.Show("author already exists\n the book will be added to the existed author");
                    }
                }

                if (pub_check >= 2)
                {
                    if(pub_info_validation())
                    {
                        add_publisher();
                    }
                    else
                    {
                        MessageBox.Show("publisher already exists\n the book will be added to the existed publisher");
                    }
                }

                if (book_check >= 7)
                {
                    if (book_info_validation())
                    {
                        add_book();
                    }
                    else
                    {
                        MessageBox.Show("book already exists\ntry changing id or isbn");
                    }
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        //------------------- update
        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                con.Open();
                if (!category_info_validation()) 
                {
                    if(!pub_info_validation() )
                    {
                        update_publisher();

                        if (!auth_info_validation()) 
                        {
                            update_author();

                            if (!book_info_validation()) 
                            {
                                update_book();
                                MessageBox.Show("Successful update");
                            }
                            else
                            {
                                MessageBox.Show("There is no such book\ncheck book id and isbn");
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no such author");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no such publisher");
                    }
                }
                else 
                {
                    MessageBox.Show("There is no such category\n the category will be added");
                    add_category();
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        //-------------------- delete
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (iSBNTextBox.Text.Length > 0 && bOOK_IDTextBox.Text.Length > 0)
                {
                    delete_book();
                }
                else
                {
                    if (cATEGORYTextBox.Text.Length > 0)
                    {
                        delete_category();
                    }
                    if (pUBLISHER_IDTextBox.Text.Length > 0)
                    {
                        delete_publisher();

                    }
                    if (aUTHOR_IDTextBox.Text.Length > 0)
                    {
                        delete_author();
                        
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }



        //-------------------- data integrity validation

        private bool book_info_validation()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM BOOK WHERE (BOOK_ID = '"+book_id+"') AND (ISBN = '"+isbn+"') ", con);
                con.Open();
                int ans = (int)cmd.ExecuteScalar();
                if(ans>0)
                {
                    con.Close();
                    return false;
                }
                else 
                {
                    con.Close();
                    return true;
                }
                    
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
            
        }
        
        private bool auth_info_validation()
        {

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AUTHOR WHERE (AUTHOR_ID = '" + auth_id + "') ", con);
                con.Open();
                int ans = (int)cmd.ExecuteScalar();
                if (ans > 0)
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        
        private bool pub_info_validation()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PUBLISHER WHERE (PUBLISHER_ID = '" + pub_id + "') ", con);
                con.Open();
                int ans = (int)cmd.ExecuteScalar();
                if (ans > 0)
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        private bool category_info_validation()
        {
            try 
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cat_check_cmd = new SqlCommand("SELECT COUNT(*) FROM CATEGORIES WHERE CATEGORY = '" + category + "'", con);
                con.Open();
                int cat_check = (int)cat_check_cmd.ExecuteScalar();
                if (cat_check > 0)
                {
                    con.Close() ;
                    return false;
                }
                else
                { con.Close(); return true; }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        //-------------------- adding functions

        private void add_book ()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                if (category_info_validation())
                {
                    add_category();
                    
                }
                else
                {
                    MessageBox.Show("Category already exists\n adding will be done to the existed one category");
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO BOOK(BOOK_ID, AUTHOR_ID, PUBLISHER_ID, ISBN, TITLE, CATEGORY) VALUES('" + book_id + "', '" + auth_id + "', '" + pub_id + "', '" + isbn + "', '" + title + "', '" + category + "')", con);
                SqlCommand copy_cmd = new SqlCommand("INSERT INTO COPY(COPY_ID, BOOK_ID, ISBN, COPY_NUMBER) VALUES('" + book_id + "', '" + book_id + "', '" + isbn + "', '" + copy_num + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                copy_cmd.ExecuteNonQuery();
                MessageBox.Show("Book added successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void add_author()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("INSERT INTO AUTHOR(AUTHOR_ID , AUTHOR_NAME) VALUES('" + auth_id + "','"+author+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Author added successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void add_publisher()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("INSERT INTO PUBLISHER(PUBLISHER_ID , PUBLISHER_NAME) VALUES('" + pub_id + "','" + publisher + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Publisher added successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void add_category()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
            SqlCommand category_cmd = new SqlCommand("INSERT INTO CATEGORIES(CATEGORY) VALUES('" + category + "')", con);
            con.Open();
            if(category_info_validation())
            {
                category_cmd.ExecuteNonQuery();
            }
            
            con.Close() ;
            
        }
        
        //-------------------- updating functions

        private void update_book() 
        {
            try
            {
                Form1 form = new Form1();
                String command = "UPDATE BOOK SET CATEGORY = '"+category+"', TITLE = '"+title+"' WHERE BOOK_ID='"+book_id+"' AND ISBN= '"+isbn+"'";
                form.connect(command);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True";
                SqlCommand cpy_update = new SqlCommand("UPDATE COPY SET COPY_NUMBER = '"+copy_num+"' WHERE BOOK_ID = '"+book_id+"'", con);
                con.Open() ;
                cpy_update.ExecuteNonQuery();
                con.Close() ;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void update_publisher() 
        {
            try
            {
                Form1 form = new Form1();
                String command = "UPDATE PUBLISHER SET PUBLISHER_NAME = '"+publisher+ "' WHERE PUBLISHER_ID='"+pub_id+"'";
                form.connect(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void update_author() 
        {
            try
            {
                Form1 form = new Form1();
                String command = "UPDATE AUTHOR SET AUTHOR_NAME = '"+author+ "' WHERE AUTHOR_ID='"+auth_id+"'";
                form.connect(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        //-------------------- deleting functions

        private void delete_book()
        {
            if (!book_info_validation()) {
                Form1 form = new Form1();
                String command = "DELETE FROM BOOK WHERE BOOK_ID = '" + book_id + "' AND ISBN = '" + isbn + "'";
                form.connect(command);
                MessageBox.Show("Delete is done successfully");
            }
            else
            {
                MessageBox.Show("There is no such book");
            }
        }

        private void delete_publisher()
        {
            if(!pub_info_validation())
            {
                
                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True");
                SqlCommand bok_cmd = new SqlCommand("SELECT COUNT(*) FROM BOOK WHERE PUBLISH_ID = '" + pub_id + "'", con);
                con.Open();
                int bok = (int)bok_cmd.ExecuteScalar();
                con.Close();
                Form1 form = new Form1();
                if (bok > 0)
                { String del_book = "DELETE FROM BOOK WHERE PUBLISHER_ID = '" + pub_id + "'";form.connect(del_book); }
                String command = "DELETE FROM PUBLISHER WHERE PUBLISHER_ID = '" + pub_id + "'";
                form.connect(command);
                MessageBox.Show("publisher has been deleted successfully");
            }
            else
            {
                MessageBox.Show("There is no such publisher");
            }
        }

        private void delete_author() 
        {
            if(!auth_info_validation())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-941KU7U;Initial Catalog=project;Integrated Security=True");
                SqlCommand bok_cmd = new SqlCommand("SELECT COUNT(*) FROM BOOK WHERE AUTHOR_ID = '"+auth_id+"'", con);
                con.Open();
                int bok = (int)bok_cmd.ExecuteScalar();
                con.Close();
                Form1 form = new Form1();
                if(bok>0)
                { String del_book = "DELETE FROM BOOK WHERE AUTHOR_ID = '" + auth_id + "'"; form.connect(del_book); }
                String command = "DELETE FROM AUTHOR WHERE AUTHOR_ID = '" + auth_id + "'";
               
                form.connect(command);
                MessageBox.Show("Author has been deleted successfully");
            }
            else
            {
                MessageBox.Show("There is no such author");
            }
        }

        private void delete_category() 
        {
            Form1 form = new Form1();
            String updateBook = "UPDATE BOOK SET CATEGORY = NULL WHERE CATEGORY = '" + category + "'";
            form.connect(updateBook);
            String command = "DELETE FROM CATEGORIES WHERE CATEGORY = '" + category + "'";
            form.connect(command);
            MessageBox.Show("category has been deleted successfully");
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();    
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
