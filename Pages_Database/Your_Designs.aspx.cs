using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages_Database
{
    public partial class Your_Designs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pages_result.InnerHtml = "";
            
            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = page_search.Text;
            }
            string query = "select * from pages";

            if (searchkey != "")
            {
                query += " WHERE BUSINESSNAME like '%"+searchkey+"%' ";
                query += " or TITLE like '%"+searchkey+"%' ";
            }
            sql_debugger_design.InnerHtml = query;

            var db = new PAGESDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            { 
                //displaying in the list
                pages_result.InnerHtml += "<div class=\"listitem\">";

                string pageid = row["PAGEID"];

                string businessname = row["BUSINESSNAME"];
                pages_result.InnerHtml += "<div class=\"col6\"><a href=\"Show_Page.aspx?pageid="+pageid+"\">" + businessname + "</a></div>";

                string tagline = row["TAGLINE"];
                pages_result.InnerHtml += "<div class=\"col6\">" + tagline + "</div>";

                string title = row["TITLE"];
                pages_result.InnerHtml += "<div class=\"col6\">" + title + "</div>";

                string subtitle = row["SUBTITLE"];
                pages_result.InnerHtml += "<div class=\"col6\">" + subtitle + "</div>";

                string description = row["DESCRIPTION"];
                pages_result.InnerHtml += "<div class=\"col6\">" + description + "</div>";
            
                pages_result.InnerHtml += "<div class=\"col6last\"><a href=\"Update_Page.aspx?pageid=" + pageid + "\"><img class=\"icons\" src=\"edit-regular.svg\"/></a></div>";


                pages_result.InnerHtml += "</div>";
            }
        }
    }
}