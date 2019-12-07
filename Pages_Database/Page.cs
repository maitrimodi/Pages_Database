using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace Pages_Database
{
    public class Page
    {   
        //declaring variable  
        private string BusinessName;
        private string Tagline;
        private string Title;
        private string Subtitle;
        private string Description;

        //get method is used to get data from field
        public string GetBusinessName()
        {
            return BusinessName;
        }
        public string GetTagline()
        {
            return Tagline;
        }
        public string GetTitle()
        {
            return Title;
        }
        public string GetSubtitle()
        {
            return Subtitle;
        }
        public string GetDescription()
        {
            return Description;
        }

        //set method is used to set a value to the property
        public void SetBusinessName(string value)
        {
            BusinessName = value;
        }
        public void SetTagline(string value)
        {
            
            Tagline = value;
        }
        public void SetTitle(string value)
        {
            Title = value;
        }
        public void SetSubtitle(string value)
        {
            Subtitle = value;
        }
        public void SetDescription(string value)
        {
            Description = value;
        }
    }
}