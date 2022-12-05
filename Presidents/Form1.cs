/* Rose Silletto
 * IGME 201
 * Unit Test 3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class PresidentsForm : Form
    {
        public PresidentsForm()
        {
            InitializeComponent();

            this.benjaminHarrisonButton.Click += new EventHandler(BenjaminHarrisonButton__Click);
            this.fdrButton.Click += new EventHandler(FDRButton__Click);
            this.billClintonButton.Click += new EventHandler(BillClintonButton__Click);
            this.jamesBuchananButton.Click += new EventHandler(JamesBuchananButton__Click);
            this.franklinPierceButton.Click += new EventHandler(FranklinPierceButton__Click);
            this.georgeWBushButton.Click += new EventHandler(GeorgeWBushButton__Click);
            this.barackObamaButton.Click += new EventHandler(BarackObamaButton__Click);
            this.jfkButton.Click += new EventHandler(JFKButton__Click);
            this.williamMcKinleyButton.Click += new EventHandler(WilliamMcKinleyButton__Click);
            this.reaganButton.Click += new EventHandler(ReaganButton__Click);
            this.eisenhowerButton.Click += new EventHandler(EisenhowerButton__Click);
            this.vanburenButton.Click += new EventHandler(VanBurenButton__Click);
            this.washingtonButton.Click += new EventHandler(WashingtonButton__Click);
            this.adamsButton.Click += new EventHandler(AdamsButton__Click);
            this.rooseveltButton.Click += new EventHandler(RooseveltButton__Click);
            this.jeffersonButton.Click += new EventHandler(JeffersonButton__Click);

            this.jeffersonTextBox.Click += new EventHandler(JeffersonTextBox__Click);

            // tags for radio buttons to filter visibility
            this.benjaminHarrisonButton.Tag = "Republican";
            this.fdrButton.Tag = "Democrat";
            this.billClintonButton.Tag = "Democrat";
            this.jamesBuchananButton.Tag = "Democrat";
            this.franklinPierceButton.Tag = "Democrat";
            this.georgeWBushButton.Tag = "Republican";
            this.jfkButton.Tag = "Democrat";
            this.williamMcKinleyButton.Tag = "Republican";
            this.reaganButton.Tag = "Republican";
            this.eisenhowerButton.Tag = "Republican";
            this.vanburenButton.Tag = "Democrat";
            this.washingtonButton.Tag = "Federalist";
            this.adamsButton.Tag = "Federalist";
            this.rooseveltButton.Tag = "Republican";
            this.jeffersonButton.Tag = "Democratic-Republican";
            this.barackObamaButton.Tag = "Democrat";

            // event handlers for filtering radio buttons
            this.democratButton.Click += new EventHandler(DemocratButton__Click);
            this.republicanButton.Click += new EventHandler(RepublicanButton__Click);
            this.federalistButton.Click += new EventHandler(FederalistButton__Click);
            this.democratRepublicanButton.Click += new EventHandler(DemocraticRepublicanButton__Click);

            this.exitButton.Click += new EventHandler(ExitButton__Click);

        }

        private void BenjaminHarrisonButton__Click(object sender, EventArgs e)
        {
            // display picture in PictureBox
            // display wiki article in WebBrowser
        }

        private void FDRButton__Click(object sender, EventArgs e)
        {

        }

        private void BillClintonButton__CLick(object sender, EventArgs e)
        {

        }

        private void JamesBuchananButton__Click(object sender, EventArgs e)
        {

        }

        private void FranklinPierceButton__Click(Object sender, EventArgs e)
        {

        }

        private void GeorgeWBushButton_Click(object sender, EventArgs e)
        {

        }

        private void BarackObamaButton__Click(object sender, EventArgs e)
        {

        }

        private void JFKButton__Click(object sender, EventArgs e)
        {

        }

        private void WilliamMcKinleyButton__Click(object sender, EventArgs e)
        {

        }

        private void ReaganButton__Click(object sender, EventArgs e)
        {

        }

        private void EisenhowerButton__Click(object sender, EventArgs e)
        {

        }

        private void VanBurenButton__Click(object sender, EventArgs e)
        {

        }

        private void WashingtonButton__Click(object sender, EventArgs e)
        {

        }

        private void JeffersonButton__Click(object sender, EventArgs e)
        {

        }

        private void AdamsButton__Click(Object sender, EventArgs e)
        {

        }

        private void RooseveltButton__Click(object sender, EventArgs e)
        {

        }

        private void democratButton__Click(object sender, EventArgs e)
        {
            if (democratButton.Checked == true)
            {
                // only display radio buttons with tag "Democrat"
                for (/* each radio button on form */) {
                    if (Tag == "Democrat")
                    {
                        RadioButton.visible = true;
                    }
                    else
                    {
                        RadioButton.visible = false;
                    }

                }
            }
            else
            {
                // display all
            }
        }

        private void JeffersonTextBox__Click(object sender, EventArgs e)
        {
            // when clicked display tooltip - "Which # President?"
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            PresidentsForm.Close();
        }

    }

}
