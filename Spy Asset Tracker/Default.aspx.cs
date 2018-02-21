using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spy_Asset_Tracker
{
    public partial class Default : System.Web.UI.Page
    {
        string[] assetNameArray;
        int[] electionsRiggedArray;
        int[] subterfugeArray;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetNameArray = new string[0];
                ViewState.Add("Asset", assetNameArray);

                int[] electionsRiggedArray = new int[0];
                ViewState.Add("Elections", electionsRiggedArray);

                int[] subterfugeArray = new int[0];
                ViewState.Add("Subterfuge", subterfugeArray);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] assetNameArray = (string[])ViewState["Asset"];
            int[] electionsRiggedArray = (int[])ViewState["Elections"];
            int[] subterfugeArray = (int[])ViewState["Subterfuge"];

            Array.Resize(ref assetNameArray, assetNameArray.Length + 1);
            Array.Resize(ref electionsRiggedArray, electionsRiggedArray.Length + 1);
            Array.Resize(ref subterfugeArray, subterfugeArray.Length + 1);

            int lastItem = assetNameArray.GetUpperBound(0);

            assetNameArray[lastItem] = assetNameTextbox.Text;
            electionsRiggedArray[lastItem] = int.Parse(electionsTextbox.Text);
            subterfugeArray[lastItem] = int.Parse(subterfugeTextbox.Text);

            ViewState["Asset"] = assetNameArray;
            ViewState["Elections"] = electionsRiggedArray;
            ViewState["Subterfuge"] = subterfugeArray;

            resultLabel.Text = string.Format(
                "Total Elections Rigged: {0}<br />" +
                "Average acts of subterfuge per Asset: {1:N2}<br />" +
                "(Last Asset Added: {2})",
                electionsRiggedArray.Sum(), subterfugeArray.Average(), assetNameArray[lastItem]);

            assetNameTextbox.Text = "";
            electionsTextbox.Text = "";
            subterfugeTextbox.Text = "";
        }
    }
}