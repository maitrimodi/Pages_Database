using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages_Database
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pages_home_result.InnerHtml = "";
           
            //list is hidden
            home_listitem.Style.Add("display", "none");

            string searchkey = "";
            if (Page.IsPostBack)
            {
                //if the search button is clicked  then and then only the list will be displayed
                home_listitem.Style.Add("display", "block");
                searchkey = search_page.Text;

                // query to get all rows of table if user  clicks  search  button  without typing anything in searchbar
                string query = "select * from pages";
                if (searchkey != "")
                {
                    //if user types somthing in the search  bar then it will search according to the typed text
                    query += " WHERE BUSINESSNAME like '%" + searchkey + "%'";
                    query += " or TITLE like '%" + searchkey + "%'";
                }
                
                var db = new PAGESDB();
                List<Dictionary<String, String>> rs = db.List_Query(query);
                foreach (Dictionary<String, String> row in rs)
                {
                    //for displaying  in the  list
                    pages_home_result.InnerHtml += "<div class=\"listitem\">";

                    string pageid = row["PAGEID"];
                    
                    string businessname = row["BUSINESSNAME"];
                    pages_home_result.InnerHtml += "<div class=\"col6\"><a href=\"Show_Page.aspx?pageid=" + pageid + "\">" + businessname + "</a></div>";

                    string tagline = row["TAGLINE"];
                    pages_home_result.InnerHtml += "<div class=\"col6\">" + tagline + "</div>";

                    string title = row["TITLE"];
                    pages_home_result.InnerHtml += "<div class=\"col6\">" + title + "</div>";

                    string subtitle = row["SUBTITLE"];
                    pages_home_result.InnerHtml += "<div class=\"col6\">" + subtitle + "</div>";

                    string description = row["DESCRIPTION"];
                    pages_home_result.InnerHtml += "<div class=\"col6\">" + description + "</div>";

                    pages_home_result.InnerHtml += "<div class=\"col6last\"><a href=\"Update_Page.aspx?pageid=" + pageid + "\"><img class=\"icons\" src=\"edit-regular.svg\"/></a></div>";

                    pages_home_result.InnerHtml += "</div>";
                }
            }

           
        }

       
    }
}