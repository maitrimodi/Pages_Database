using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
namespace Pages_Database
{
    public partial class Update_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PAGESDB db = new PAGESDB();
                //it will call function ShowPageInfo
                ShowPageInfo(db);
            }
        }

        //function used  to update the page content
        protected void UpdatePage(object sender, EventArgs e)
        {   
            //object of PAGESDB
            PAGESDB db = new PAGESDB();
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {
                //object  of Page
                Page new_page = new Page();
                new_page.SetBusinessName(business_name.Text);
                new_page.SetTagline(tag_line.Text);
                new_page.SetTitle(title_page.Text);
                new_page.SetSubtitle(subtitle_page.Text);
                new_page.SetDescription(description_page.Text);
                try
                {
                    db.Update_Page(Int32.Parse(pageid), new_page);
                    //redirect to  Your_Designs.aspx
                    Response.Redirect("Your_Designs.aspx?pageid=" + pageid);
                }
                catch
                {
                    valid = false;
                }
            }
            if (!valid)
            {
                pages.InnerHtml = "There was an error updating that page.";
            }
        }

        //function used to display the list
        protected void ShowPageInfo(PAGESDB db)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {
                Page page_record = db.FindPage(Int32.Parse(pageid));
                page_title.InnerHtml = page_record.GetBusinessName();
                business_name.Text = page_record.GetBusinessName();
                tag_line.Text = page_record.GetTagline();
                title_page.Text = page_record.GetTitle();
                subtitle_page.Text = page_record.GetSubtitle();
                description_page.Text = page_record.GetDescription();
            }
            else
            {
                valid = false;
            }
        }
    }
}