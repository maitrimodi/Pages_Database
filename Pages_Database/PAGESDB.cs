using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Pages_Database
{
    public class PAGESDB
    {
        // these are the credentials for my database
        private static string User { get { return "root"; } }
        private static string Password { get { return " "; } }
        private static string Database { get { return "pages_db"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //ConnectionString is used to connect to a database
        private static string ConnectionString {
            get {
                return "server = "+Server
                    +"; user = "+User
                    +"; database = "+Database
                    +"; port = "+Port
                    +"; password = "+Password;
            }
        }
        //dictionaries work as key value pairs
         public List<Dictionary<String,String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

           //try and catch are used for debugging they will try to execute everything which is inside try part, but if incase try portion 
           // fails to get execute then catch portion will handle the errors
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query "+query);
                //open the db connection
                Connect.Open();
                //query for the connection
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //result set will consists of the output
                MySqlDataReader resultset = cmd.ExecuteReader();

                
                //this statement is for rows in result set
                while (resultset.Read())
                {
                    Dictionary<String,String> Row = new Dictionary<String, String>();
                    //column in rows
                    for(int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));
                        
                    }
                    
                    ResultSet.Add(Row);
                }//end row
                resultset.Close();

                
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());
               
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }

        //this function is used to add page  in database
         public void AddPage(Page new_page)
        {
            string query = "insert into pages (BUSINESSNAME, TAGLINE, TITLE, SUBTITLE, DESCRIPTION) values ('{0}','{1}','{2}','{3}','{4}')";
            query = String.Format(query,new_page.GetBusinessName(), new_page.GetTagline(), new_page.GetTitle(), new_page.GetSubtitle(), new_page.GetDescription());

            //connection for database
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                //open connection
                Connect.Open();
                //query will get executed
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the Add_Page Method");
                Debug.WriteLine(ex.ToString());
            }
            //close connection
            Connect.Close();
        }


        //this function is for deleting the page from database
        public void Delete_Page(int pageid)
        {
            string removepage = "delete from pages where PAGEID = {0}";
            removepage = String.Format(removepage, pageid);
            //database connection
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //database command to execute query
            MySqlCommand cmd_removepage = new MySqlCommand(removepage, Connect);
            try
            {
                //connection open
                Connect.Open();
                //query executed
                cmd_removepage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removepage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the delete page method!");
                Debug.WriteLine(ex.ToString());
            }
            //connection close
            Connect.Close();
        }

        //this function is used for finding a particular page from the database with the help of their page id
        public Page FindPage(int id)
        {
            //database connection
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //object of page
            Page result_page = new Page();

            try
            {
                //query for selecting all rows from table according to the pageid
                string query = "select * from pages where pageid = " + id;
                Debug.WriteLine("Connection Initialized...");

                //connection open
                Connect.Open();

                //command for executing the query
                MySqlCommand cmd = new MySqlCommand(query, Connect);

                MySqlDataReader resultset = cmd.ExecuteReader();

                List<Page> pages = new List<Page>();

                while (resultset.Read())
                {
                    //object of class Page
                    Page currentpage = new Page();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);
                        //switch case 
                        switch (key)
                        {
                            case "BUSINESSNAME":
                                currentpage.SetBusinessName(value);
                                break;
                            case "TAGLINE":
                                currentpage.SetTagline(value);
                                break;
                            case "TITLE":
                                currentpage.SetTitle(value);
                                break;
                            case "SUBTITLE":
                                currentpage.SetSubtitle(value);
                                break;
                            case "DESCRIPTION":
                                currentpage.SetDescription(value);
                                break;
                        }
                    }
                    pages.Add(currentpage);
                }
                result_page = pages[0];
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the find Page method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");
            return result_page;
        }

        //this function is used for deleting a particular page from database
        public void DeletePage(int pageid)
        {
            //query for  deleting the  page
            string removespage = "delete from pages WHERE PAGEID = {0}";
            removespage = String.Format(removespage, pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd_removespage = new MySqlCommand(removespage, Connect);

            try
            {
                Connect.Open();

                cmd_removespage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removespage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the delete page method! ");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
        }

        //this function is  used  to  update  the content of page
        public void Update_Page(int pageid, Page new_page)
        {
            //query for updating the content of table
            string query = "update pages set BUSINESSNAME='{0}', TAGLINE='{1}', TITLE='{2}',  SUBTITLE='{3}', DESCRIPTION='{4}' where PAGEID={5}";
            query = String.Format(query, new_page.GetBusinessName(), new_page.GetTagline(), new_page.GetTitle(), new_page.GetSubtitle(), new_page.GetDescription(), pageid);
            Debug.WriteLine(query);
            //database connection
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                //open connection
                Connect.Open();
                //execution of query
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the update page method");
                Debug.WriteLine(ex.ToString());
            }
            //connection close
            Connect.Close();
        }


    }
}