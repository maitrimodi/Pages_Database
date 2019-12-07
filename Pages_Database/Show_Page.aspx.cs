using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages_Database
{
    public partial class Show_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PAGESDB db = new PAGESDB();
            ShowPageInfo(db);
        }
        protected void ShowPageInfo(PAGESDB db)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {
                Page page_record = db.FindPage(Int32.Parse(pageid));
                show_page_title.InnerHtml = page_record.GetBusinessName();
                page_tagline.InnerHtml = page_record.GetTagline();
                page_title.InnerHtml = page_record.GetTitle();
                page_subtitle.InnerHtml = page_record.GetSubtitle();
                page_description.InnerHtml = page_record.GetDescription();
            }
            else
            {
                valid = false;
            }
            if (!valid)
            {
                page_show.InnerHtml = "There was an error fining that page.";
            }
        }

        protected void Delete_Page(object sender, EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            PAGESDB db = new PAGESDB();
            if (valid)
            {
                db.DeletePage(Int32.Parse(pageid));
                Response.Redirect("Your_Designs.aspx");
            }
        }
    }
}