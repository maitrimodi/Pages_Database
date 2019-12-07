using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages_Database
{
    public partial class New_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Page(object sender, EventArgs e)
        {   //object of class PAGESDB is created
            PAGESDB db = new PAGESDB();

            //object of class Page is created
            Page new_page = new Page();

            //By using object new_page we are assigning the user input value to the database
            new_page.SetBusinessName(business_name.Text);
            new_page.SetTagline(tag_line.Text);
            new_page.SetTitle(page_title.Text);
            new_page.SetSubtitle(page_subtitle.Text);
            new_page.SetDescription(page_description.Text);

            //with the help of Page object we are inserting data into database by using function AddPage of class PAGESDB
            db.AddPage(new_page);

            //this will redirect the page to Your_Designs
            Response.Redirect("Your_Designs.aspx");
        }
    }
}