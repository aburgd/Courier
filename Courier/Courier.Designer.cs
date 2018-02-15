namespace Courier
{
    partial class Courier
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkNameProvided = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.txtTraits = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtNukaSunset = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.radGhoul = new System.Windows.Forms.RadioButton();
            this.radHuman = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPerception = new System.Windows.Forms.TextBox();
            this.txtEndurance = new System.Windows.Forms.TextBox();
            this.txtCharisma = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.txtAgility = new System.Windows.Forms.TextBox();
            this.txtLuck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 20);
            this.txtName.TabIndex = 1;
            // 
            // chkNameProvided
            // 
            this.chkNameProvided.AutoSize = true;
            this.chkNameProvided.Location = new System.Drawing.Point(409, 16);
            this.chkNameProvided.Name = "chkNameProvided";
            this.chkNameProvided.Size = new System.Drawing.Size(131, 17);
            this.chkNameProvided.TabIndex = 2;
            this.chkNameProvided.Text = "I have a name already";
            this.chkNameProvided.UseVisualStyleBackColor = true;
            this.chkNameProvided.CheckStateChanged += new System.EventHandler(this.ChkNameProvided_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Skills";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Traits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "SPECIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nuka-Cola/\r\nSunset Sarsparilla";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(112, 40);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(270, 20);
            this.txtGender.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(112, 66);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(270, 20);
            this.txtAge.TabIndex = 10;
            // 
            // txtSkills
            // 
            this.txtSkills.Location = new System.Drawing.Point(112, 92);
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.ReadOnly = true;
            this.txtSkills.Size = new System.Drawing.Size(270, 20);
            this.txtSkills.TabIndex = 11;
            // 
            // txtTraits
            // 
            this.txtTraits.Location = new System.Drawing.Point(112, 118);
            this.txtTraits.Name = "txtTraits";
            this.txtTraits.ReadOnly = true;
            this.txtTraits.Size = new System.Drawing.Size(270, 20);
            this.txtTraits.TabIndex = 12;
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(112, 144);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.ReadOnly = true;
            this.txtStrength.Size = new System.Drawing.Size(32, 20);
            this.txtStrength.TabIndex = 13;
            // 
            // txtNukaSunset
            // 
            this.txtNukaSunset.Location = new System.Drawing.Point(112, 170);
            this.txtNukaSunset.Name = "txtNukaSunset";
            this.txtNukaSunset.ReadOnly = true;
            this.txtNukaSunset.Size = new System.Drawing.Size(270, 20);
            this.txtNukaSunset.TabIndex = 14;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(385, 258);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(466, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // radGhoul
            // 
            this.radGhoul.AutoSize = true;
            this.radGhoul.Location = new System.Drawing.Point(415, 92);
            this.radGhoul.Name = "radGhoul";
            this.radGhoul.Size = new System.Drawing.Size(53, 17);
            this.radGhoul.TabIndex = 18;
            this.radGhoul.Text = "Ghoul";
            this.radGhoul.UseVisualStyleBackColor = true;
            // 
            // radHuman
            // 
            this.radHuman.AutoSize = true;
            this.radHuman.Checked = true;
            this.radHuman.Location = new System.Drawing.Point(415, 115);
            this.radHuman.Name = "radHuman";
            this.radHuman.Size = new System.Drawing.Size(59, 17);
            this.radHuman.TabIndex = 19;
            this.radHuman.TabStop = true;
            this.radHuman.Text = "Human";
            this.radHuman.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Courier Race:";
            // 
            // txtPerception
            // 
            this.txtPerception.Location = new System.Drawing.Point(152, 144);
            this.txtPerception.Name = "txtPerception";
            this.txtPerception.ReadOnly = true;
            this.txtPerception.Size = new System.Drawing.Size(32, 20);
            this.txtPerception.TabIndex = 21;
            // 
            // txtEndurance
            // 
            this.txtEndurance.Location = new System.Drawing.Point(192, 144);
            this.txtEndurance.Name = "txtEndurance";
            this.txtEndurance.ReadOnly = true;
            this.txtEndurance.Size = new System.Drawing.Size(32, 20);
            this.txtEndurance.TabIndex = 22;
            // 
            // txtCharisma
            // 
            this.txtCharisma.Location = new System.Drawing.Point(232, 144);
            this.txtCharisma.Name = "txtCharisma";
            this.txtCharisma.ReadOnly = true;
            this.txtCharisma.Size = new System.Drawing.Size(32, 20);
            this.txtCharisma.TabIndex = 23;
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(272, 144);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.ReadOnly = true;
            this.txtIntelligence.Size = new System.Drawing.Size(32, 20);
            this.txtIntelligence.TabIndex = 24;
            // 
            // txtAgility
            // 
            this.txtAgility.Location = new System.Drawing.Point(312, 144);
            this.txtAgility.Name = "txtAgility";
            this.txtAgility.ReadOnly = true;
            this.txtAgility.Size = new System.Drawing.Size(32, 20);
            this.txtAgility.TabIndex = 25;
            // 
            // txtLuck
            // 
            this.txtLuck.Location = new System.Drawing.Point(350, 144);
            this.txtLuck.Name = "txtLuck";
            this.txtLuck.ReadOnly = true;
            this.txtLuck.Size = new System.Drawing.Size(32, 20);
            this.txtLuck.TabIndex = 26;
            // 
            // Courier
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(553, 296);
            this.Controls.Add(this.txtLuck);
            this.Controls.Add(this.txtAgility);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtCharisma);
            this.Controls.Add(this.txtEndurance);
            this.Controls.Add(this.txtPerception);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radHuman);
            this.Controls.Add(this.radGhoul);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNukaSunset);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtTraits);
            this.Controls.Add(this.txtSkills);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNameProvided);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "Courier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Courier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkNameProvided;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.TextBox txtTraits;
        private System.Windows.Forms.TextBox txtNukaSunset;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radGhoul;
        private System.Windows.Forms.RadioButton radHuman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtPerception;
        private System.Windows.Forms.TextBox txtEndurance;
        private System.Windows.Forms.TextBox txtCharisma;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.TextBox txtAgility;
        private System.Windows.Forms.TextBox txtLuck;
    }
}

