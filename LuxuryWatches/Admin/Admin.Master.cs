﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LuxuryWatches.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["tk"] == null)
            {
                Response.Redirect("/Login");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}