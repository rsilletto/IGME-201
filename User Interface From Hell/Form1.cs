using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface_From_Hell
{
    public partial class QuizForm : Form
    {

        string answer;

        public QuizForm()
        {
            InitializeComponent();

            this.textBox.Visible = false;
            // this.questionListBox.Visible = false;
            this.questionLabel2.Visible = false;

            this.checkAnswerButton.Click += new EventHandler(checkAnswerButton__Click);
            this.radioButtonA.Click += new EventHandler(radioButtonA__Click);
            this.radioButtonB.Click += new EventHandler(radioButtonB__Click);
            this.radioButtonC.Click += new EventHandler(radioButtonC__Click);
            this.radioButtonD.Click += new EventHandler(radioButtonD__Click);
            this.questionListBox.Click += new EventHandler(questionListBox__Click);
            this.textBox.Click += new EventHandler(textBox__Click);


        }

        // if user hovers over check answer button (if mouse is within button coords)
        // move button location to other side of form


        private void checkAnswerButton__Click(object sender, EventArgs e)
        {
            if (answer == "11/3")
            {
                checkAnswerButton.BackColor = Color.Green;
            }
            else
            {
                if (answer == "7") {
                    
                    // ErrorProvider.SetError(radioButtonB, errorMsg);
                    // displays an error icon and tooltip beside object
                }
                else if(answer == "10")
                {
                    // ErrorProvider.SetError(radioButtonC, errorMsg);
                }
                else
                {
                    // ErrorProvider.SetError(radioButtonD, errorMsg);
                }
            }
        }

        private void radioButtonA__Click(object sender, EventArgs e)
        {
            string answer = "11/3";
        }

        private void radioButtonB__Click(object sender, EventArgs e)
        {
            string answer = "7";
        }

        private void radioButtonC__Click(object sender, EventArgs e)
        {
            string answer = "10";
        }

        private void radioButtonD__Click(object sender, EventArgs e)
        {
            string answer = "13/3";
        }

        private void questionListBox__Click(object sender, EventArgs e)
        {
            if(questionListBox.SelectedIndex == 0)
            {
                radioButtonA.Visible = true;
                radioButtonB.Visible = true;
                radioButtonC.Visible = true;
                radioButtonD.Visible = true;
                questionLabel.Visible = true;
            }
            else if (questionListBox.SelectedIndex == 1)
            {
                radioButtonA.Visible = false;
                radioButtonB.Visible = false;
                radioButtonC.Visible = false;
                radioButtonD.Visible = false;
                questionLabel.Visible = false;

                textBox.Visible = true;
                questionLabel2.Visible = true;
            }
            else
            {
                questionLabel2.Visible = false;
                textBox.Visible = false;
            }
        }

        private void textBox__Click(object sender, EventArgs e)
        {

        }

    }
}
