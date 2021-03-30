using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int num = 100;
            int t = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    t += i;
                }
            }
            Response.Write(t);

        }
    }
}
