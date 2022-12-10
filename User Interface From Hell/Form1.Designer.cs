namespace User_Interface_From_Hell
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.checkAnswerButton = new System.Windows.Forms.Button();
            this.questionListBox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.questionLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.ForeColor = System.Drawing.Color.Fuchsia;
            this.radioButtonA.Location = new System.Drawing.Point(100, 81);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(48, 17);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "11/3";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.ForeColor = System.Drawing.Color.Cyan;
            this.radioButtonB.Location = new System.Drawing.Point(100, 104);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(31, 17);
            this.radioButtonB.TabIndex = 1;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "7";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButtonC.Location = new System.Drawing.Point(100, 128);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(37, 17);
            this.radioButtonC.TabIndex = 2;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "10";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.ForeColor = System.Drawing.Color.Gold;
            this.radioButtonD.Location = new System.Drawing.Point(100, 152);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(48, 17);
            this.radioButtonD.TabIndex = 3;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "13/3";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Lime;
            this.questionLabel.Location = new System.Drawing.Point(100, 43);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(105, 16);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = "What is 5 + 6 / 3?";
            // 
            // checkAnswerButton
            // 
            this.checkAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkAnswerButton.ForeColor = System.Drawing.Color.Blue;
            this.checkAnswerButton.Location = new System.Drawing.Point(103, 203);
            this.checkAnswerButton.Name = "checkAnswerButton";
            this.checkAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.checkAnswerButton.TabIndex = 5;
            this.checkAnswerButton.Text = "Check";
            this.checkAnswerButton.UseVisualStyleBackColor = false;
            // 
            // questionListBox
            // 
            this.questionListBox.FormattingEnabled = true;
            this.questionListBox.Items.AddRange(new object[] {
            "Question 1",
            "Question 2",
            "Question 3"});
            this.questionListBox.Location = new System.Drawing.Point(350, 43);
            this.questionListBox.Name = "questionListBox";
            this.questionListBox.Size = new System.Drawing.Size(120, 95);
            this.questionListBox.TabIndex = 6;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(177, 80);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // questionLabel2
            // 
            this.questionLabel2.AutoSize = true;
            this.questionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel2.ForeColor = System.Drawing.Color.Lime;
            this.questionLabel2.Location = new System.Drawing.Point(100, 27);
            this.questionLabel2.Name = "questionLabel2";
            this.questionLabel2.Size = new System.Drawing.Size(136, 16);
            this.questionLabel2.TabIndex = 8;
            this.questionLabel2.Text = "What color is the sky?";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionLabel2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.questionListBox);
            this.Controls.Add(this.checkAnswerButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Name = "QuizForm";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button checkAnswerButton;
        private System.Windows.Forms.ListBox questionListBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label questionLabel2;
    }
}

