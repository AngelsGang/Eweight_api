namespace Test
{
    partial class InscriptionView
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Lastname = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numeric_Age = new System.Windows.Forms.NumericUpDown();
            this.spin_Taille = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Taille)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(219, 30);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(120, 26);
            this.tb_Name.TabIndex = 0;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // tb_Lastname
            // 
            this.tb_Lastname.Location = new System.Drawing.Point(219, 99);
            this.tb_Lastname.Name = "tb_Lastname";
            this.tb_Lastname.Size = new System.Drawing.Size(120, 26);
            this.tb_Lastname.TabIndex = 1;
            this.tb_Lastname.TextChanged += new System.EventHandler(this.tb_Lastname_TextChanged);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(219, 228);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(120, 26);
            this.tb_Email.TabIndex = 4;
            this.tb_Email.TextChanged += new System.EventHandler(this.tb_Email_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Taille";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Suivant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numeric_Age
            // 
            this.numeric_Age.Location = new System.Drawing.Point(219, 165);
            this.numeric_Age.Name = "numeric_Age";
            this.numeric_Age.Size = new System.Drawing.Size(120, 26);
            this.numeric_Age.TabIndex = 16;
            this.numeric_Age.ValueChanged += new System.EventHandler(this.numeric_Age_ValueChanged);
            // 
            // spin_Taille
            // 
            this.spin_Taille.Location = new System.Drawing.Point(219, 301);
            this.spin_Taille.Name = "spin_Taille";
            this.spin_Taille.Size = new System.Drawing.Size(120, 26);
            this.spin_Taille.TabIndex = 17;
            this.spin_Taille.ValueChanged += new System.EventHandler(this.spin_Taille_ValueChanged);
            // 
            // InscriptionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 494);
            this.Controls.Add(this.spin_Taille);
            this.Controls.Add(this.numeric_Age);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Lastname);
            this.Controls.Add(this.tb_Name);
            this.Name = "InscriptionView";
            this.Text = "InscriptionView";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Taille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Lastname;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numeric_Age;
        private System.Windows.Forms.NumericUpDown spin_Taille;
    }
}