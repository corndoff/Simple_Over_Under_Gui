namespace Simple_Over_Under_Gui
{
    partial class Form1
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
            this.submitButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.newNumberLabel = new System.Windows.Forms.Label();
            this.overUnderLabel = new System.Windows.Forms.Label();
            this.overButton = new System.Windows.Forms.RadioButton();
            this.underButton = new System.Windows.Forms.RadioButton();
            this.numLabel = new System.Windows.Forms.Label();
            this.buttonBox = new System.Windows.Forms.GroupBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(140, 270);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(127, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(29, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(381, 29);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to the Over Under Game";
            // 
            // newNumberLabel
            // 
            this.newNumberLabel.AutoSize = true;
            this.newNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNumberLabel.Location = new System.Drawing.Point(110, 83);
            this.newNumberLabel.Name = "newNumberLabel";
            this.newNumberLabel.Size = new System.Drawing.Size(157, 20);
            this.newNumberLabel.TabIndex = 2;
            this.newNumberLabel.Text = "Your new number is: ";
            this.newNumberLabel.Click += new System.EventHandler(this.newNumberLabel_Click);
            // 
            // overUnderLabel
            // 
            this.overUnderLabel.AutoSize = true;
            this.overUnderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overUnderLabel.Location = new System.Drawing.Point(12, 140);
            this.overUnderLabel.Name = "overUnderLabel";
            this.overUnderLabel.Size = new System.Drawing.Size(417, 17);
            this.overUnderLabel.TabIndex = 4;
            this.overUnderLabel.Text = "Do you think the next number with be over or under this number?";
            // 
            // overButton
            // 
            this.overButton.AutoSize = true;
            this.overButton.Location = new System.Drawing.Point(22, 28);
            this.overButton.Name = "overButton";
            this.overButton.Size = new System.Drawing.Size(48, 17);
            this.overButton.TabIndex = 5;
            this.overButton.TabStop = true;
            this.overButton.Text = "Over";
            this.overButton.UseVisualStyleBackColor = true;
            this.overButton.CheckedChanged += new System.EventHandler(this.overButton_CheckedChanged);
            // 
            // underButton
            // 
            this.underButton.AutoSize = true;
            this.underButton.Location = new System.Drawing.Point(22, 60);
            this.underButton.Name = "underButton";
            this.underButton.Size = new System.Drawing.Size(54, 17);
            this.underButton.TabIndex = 6;
            this.underButton.TabStop = true;
            this.underButton.Text = "Under";
            this.underButton.UseVisualStyleBackColor = true;
            this.underButton.CheckedChanged += new System.EventHandler(this.underButton_CheckedChanged);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.Location = new System.Drawing.Point(265, 83);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(89, 20);
            this.numLabel.TabIndex = 7;
            this.numLabel.Text = "<newNum>";
            this.numLabel.Click += new System.EventHandler(this.numLabel_Click);
            // 
            // buttonBox
            // 
            this.buttonBox.Controls.Add(this.overButton);
            this.buttonBox.Controls.Add(this.underButton);
            this.buttonBox.Location = new System.Drawing.Point(160, 164);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(92, 100);
            this.buttonBox.TabIndex = 8;
            this.buttonBox.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(246, 312);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(51, 15);
            this.scoreLabel.TabIndex = 9;
            this.scoreLabel.Text = "<score>";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.overUnderLabel);
            this.Controls.Add(this.newNumberLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Over Under Game";
            this.buttonBox.ResumeLayout(false);
            this.buttonBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label newNumberLabel;
        private System.Windows.Forms.Label overUnderLabel;
        private System.Windows.Forms.RadioButton overButton;
        private System.Windows.Forms.RadioButton underButton;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.GroupBox buttonBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
    }
}

