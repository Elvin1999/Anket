﻿namespace WindowsFormsApp9
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
            this.backLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnamelabel = new System.Windows.Forms.Label();
            this.fathernamelabel = new System.Windows.Forms.Label();
            this.countrylabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.phonenumberlabel = new System.Windows.Forms.Label();
            this.birthdaylabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.surnametextBox = new System.Windows.Forms.TextBox();
            this.fathernametextBox = new System.Windows.Forms.TextBox();
            this.countrytextBox = new System.Windows.Forms.TextBox();
            this.citytextBox = new System.Windows.Forms.TextBox();
            this.phonenumbertextBox = new System.Windows.Forms.TextBox();
            this.genderlabel = new System.Windows.Forms.Label();
            this.maleradioButton = new System.Windows.Forms.RadioButton();
            this.femaleradiobutton = new System.Windows.Forms.RadioButton();
            this.deserealizelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filenametextbox = new System.Windows.Forms.TextBox();
            this.buttonGetresult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backLabel.Location = new System.Drawing.Point(213, 9);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(491, 464);
            this.backLabel.TabIndex = 1;
            this.backLabel.Text = "Anket";
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(256, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(117, 27);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Firstname";
            // 
            // surnamelabel
            // 
            this.surnamelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.surnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamelabel.Location = new System.Drawing.Point(256, 126);
            this.surnamelabel.Name = "surnamelabel";
            this.surnamelabel.Size = new System.Drawing.Size(117, 27);
            this.surnamelabel.TabIndex = 4;
            this.surnamelabel.Text = "Lastname";
            // 
            // fathernamelabel
            // 
            this.fathernamelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fathernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathernamelabel.Location = new System.Drawing.Point(256, 161);
            this.fathernamelabel.Name = "fathernamelabel";
            this.fathernamelabel.Size = new System.Drawing.Size(117, 27);
            this.fathernamelabel.TabIndex = 5;
            this.fathernamelabel.Text = "Father name";
            // 
            // countrylabel
            // 
            this.countrylabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.countrylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countrylabel.Location = new System.Drawing.Point(256, 207);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(117, 27);
            this.countrylabel.TabIndex = 6;
            this.countrylabel.Text = "Country";
            // 
            // citylabel
            // 
            this.citylabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.citylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylabel.Location = new System.Drawing.Point(256, 246);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(117, 27);
            this.citylabel.TabIndex = 7;
            this.citylabel.Text = "City";
            // 
            // phonenumberlabel
            // 
            this.phonenumberlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phonenumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberlabel.Location = new System.Drawing.Point(256, 285);
            this.phonenumberlabel.Name = "phonenumberlabel";
            this.phonenumberlabel.Size = new System.Drawing.Size(117, 27);
            this.phonenumberlabel.TabIndex = 8;
            this.phonenumberlabel.Text = "Phone number";
            // 
            // birthdaylabel
            // 
            this.birthdaylabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.birthdaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdaylabel.Location = new System.Drawing.Point(256, 316);
            this.birthdaylabel.Name = "birthdaylabel";
            this.birthdaylabel.Size = new System.Drawing.Size(117, 27);
            this.birthdaylabel.TabIndex = 9;
            this.birthdaylabel.Text = "Birthdate";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker.Location = new System.Drawing.Point(379, 316);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // nametextBox
            // 
            this.nametextBox.ForeColor = System.Drawing.Color.Gray;
            this.nametextBox.Location = new System.Drawing.Point(379, 91);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(200, 20);
            this.nametextBox.TabIndex = 11;
            this.nametextBox.Text = "Name";
            this.nametextBox.Enter += new System.EventHandler(this.nametextBox_Enter);
            this.nametextBox.Leave += new System.EventHandler(this.nametextBox_Leave);
            // 
            // surnametextBox
            // 
            this.surnametextBox.ForeColor = System.Drawing.Color.Gray;
            this.surnametextBox.Location = new System.Drawing.Point(379, 126);
            this.surnametextBox.Name = "surnametextBox";
            this.surnametextBox.Size = new System.Drawing.Size(200, 20);
            this.surnametextBox.TabIndex = 12;
            this.surnametextBox.Text = "Surname";
            this.surnametextBox.Enter += new System.EventHandler(this.surnametextBox_Enter);
            this.surnametextBox.Leave += new System.EventHandler(this.surnametextBox_Leave);
            // 
            // fathernametextBox
            // 
            this.fathernametextBox.ForeColor = System.Drawing.Color.Gray;
            this.fathernametextBox.Location = new System.Drawing.Point(379, 161);
            this.fathernametextBox.Name = "fathernametextBox";
            this.fathernametextBox.Size = new System.Drawing.Size(200, 20);
            this.fathernametextBox.TabIndex = 13;
            this.fathernametextBox.Text = "Father_name";
            this.fathernametextBox.Enter += new System.EventHandler(this.fathernametextBox_Enter);
            this.fathernametextBox.Leave += new System.EventHandler(this.fathernametextBox_Leave);
            // 
            // countrytextBox
            // 
            this.countrytextBox.ForeColor = System.Drawing.Color.Gray;
            this.countrytextBox.Location = new System.Drawing.Point(379, 207);
            this.countrytextBox.Name = "countrytextBox";
            this.countrytextBox.Size = new System.Drawing.Size(200, 20);
            this.countrytextBox.TabIndex = 14;
            this.countrytextBox.Text = "Country";
            this.countrytextBox.Enter += new System.EventHandler(this.countrytextBox_Enter);
            this.countrytextBox.Leave += new System.EventHandler(this.countrytextBox_Leave);
            // 
            // citytextBox
            // 
            this.citytextBox.ForeColor = System.Drawing.Color.Gray;
            this.citytextBox.Location = new System.Drawing.Point(379, 246);
            this.citytextBox.Name = "citytextBox";
            this.citytextBox.Size = new System.Drawing.Size(200, 20);
            this.citytextBox.TabIndex = 15;
            this.citytextBox.Text = "City";
            this.citytextBox.Enter += new System.EventHandler(this.citytextBox_Enter);
            this.citytextBox.Leave += new System.EventHandler(this.citytextBox_Leave);
            // 
            // phonenumbertextBox
            // 
            this.phonenumbertextBox.ForeColor = System.Drawing.Color.Gray;
            this.phonenumbertextBox.Location = new System.Drawing.Point(379, 285);
            this.phonenumbertextBox.Name = "phonenumbertextBox";
            this.phonenumbertextBox.Size = new System.Drawing.Size(200, 20);
            this.phonenumbertextBox.TabIndex = 16;
            this.phonenumbertextBox.Text = "Phone number";
            this.phonenumbertextBox.Enter += new System.EventHandler(this.phonenumbertextBox_Enter);
            this.phonenumbertextBox.Leave += new System.EventHandler(this.phonenumbertextBox_Leave);
            // 
            // genderlabel
            // 
            this.genderlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(256, 364);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(117, 27);
            this.genderlabel.TabIndex = 17;
            this.genderlabel.Text = "Gender";
            // 
            // maleradioButton
            // 
            this.maleradioButton.AutoSize = true;
            this.maleradioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maleradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleradioButton.Location = new System.Drawing.Point(379, 364);
            this.maleradioButton.Name = "maleradioButton";
            this.maleradioButton.Size = new System.Drawing.Size(77, 29);
            this.maleradioButton.TabIndex = 18;
            this.maleradioButton.TabStop = true;
            this.maleradioButton.Text = "Male";
            this.maleradioButton.UseVisualStyleBackColor = false;
            // 
            // femaleradiobutton
            // 
            this.femaleradiobutton.AutoSize = true;
            this.femaleradiobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.femaleradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleradiobutton.Location = new System.Drawing.Point(497, 364);
            this.femaleradiobutton.Name = "femaleradiobutton";
            this.femaleradiobutton.Size = new System.Drawing.Size(101, 29);
            this.femaleradiobutton.TabIndex = 20;
            this.femaleradiobutton.TabStop = true;
            this.femaleradiobutton.Text = "Female";
            this.femaleradiobutton.UseVisualStyleBackColor = false;
            // 
            // deserealizelabel
            // 
            this.deserealizelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deserealizelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deserealizelabel.Location = new System.Drawing.Point(256, 47);
            this.deserealizelabel.Name = "deserealizelabel";
            this.deserealizelabel.Size = new System.Drawing.Size(117, 27);
            this.deserealizelabel.TabIndex = 21;
            this.deserealizelabel.Text = "Deserialize";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filenametextbox
            // 
            this.filenametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenametextbox.ForeColor = System.Drawing.Color.Gray;
            this.filenametextbox.Location = new System.Drawing.Point(379, 45);
            this.filenametextbox.Multiline = true;
            this.filenametextbox.Name = "filenametextbox";
            this.filenametextbox.Size = new System.Drawing.Size(113, 29);
            this.filenametextbox.TabIndex = 23;
            this.filenametextbox.Text = "Filename";
            this.filenametextbox.Enter += new System.EventHandler(this.filenametextbox_Enter);
            this.filenametextbox.Leave += new System.EventHandler(this.filenametextbox_Leave);
            // 
            // buttonGetresult
            // 
            this.buttonGetresult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetresult.Location = new System.Drawing.Point(367, 424);
            this.buttonGetresult.Name = "buttonGetresult";
            this.buttonGetresult.Size = new System.Drawing.Size(212, 23);
            this.buttonGetresult.TabIndex = 24;
            this.buttonGetresult.Text = "Get Result";
            this.buttonGetresult.UseVisualStyleBackColor = true;
            this.buttonGetresult.Click += new System.EventHandler(this.buttonGetresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.buttonGetresult);
            this.Controls.Add(this.filenametextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deserealizelabel);
            this.Controls.Add(this.femaleradiobutton);
            this.Controls.Add(this.maleradioButton);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.phonenumbertextBox);
            this.Controls.Add(this.citytextBox);
            this.Controls.Add(this.countrytextBox);
            this.Controls.Add(this.fathernametextBox);
            this.Controls.Add(this.surnametextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.birthdaylabel);
            this.Controls.Add(this.phonenumberlabel);
            this.Controls.Add(this.citylabel);
            this.Controls.Add(this.countrylabel);
            this.Controls.Add(this.fathernamelabel);
            this.Controls.Add(this.surnamelabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backLabel);
            this.Name = "Form1";
            this.Text = "Anket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnamelabel;
        private System.Windows.Forms.Label fathernamelabel;
        private System.Windows.Forms.Label countrylabel;
        private System.Windows.Forms.Label citylabel;
        private System.Windows.Forms.Label phonenumberlabel;
        private System.Windows.Forms.Label birthdaylabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox surnametextBox;
        private System.Windows.Forms.TextBox fathernametextBox;
        private System.Windows.Forms.TextBox countrytextBox;
        private System.Windows.Forms.TextBox citytextBox;
        private System.Windows.Forms.TextBox phonenumbertextBox;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.RadioButton maleradioButton;
        private System.Windows.Forms.RadioButton femaleradiobutton;
        private System.Windows.Forms.Label deserealizelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filenametextbox;
        private System.Windows.Forms.Button buttonGetresult;
    }
}

