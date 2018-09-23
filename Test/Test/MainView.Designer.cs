namespace Test
{
    partial class MainView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_MainConnect = new System.Windows.Forms.Button();
            this.bt_MainInscript = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_MainConnect
            // 
            this.b_MainConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_MainConnect.Location = new System.Drawing.Point(126, 212);
            this.b_MainConnect.Name = "b_MainConnect";
            this.b_MainConnect.Size = new System.Drawing.Size(198, 43);
            this.b_MainConnect.TabIndex = 0;
            this.b_MainConnect.Text = "Connexion";
            this.b_MainConnect.UseVisualStyleBackColor = false;
            this.b_MainConnect.Click += new System.EventHandler(this.b_MainConnect_Click);
            // 
            // bt_MainInscript
            // 
            this.bt_MainInscript.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_MainInscript.Location = new System.Drawing.Point(57, 309);
            this.bt_MainInscript.Name = "bt_MainInscript";
            this.bt_MainInscript.Size = new System.Drawing.Size(338, 105);
            this.bt_MainInscript.TabIndex = 1;
            this.bt_MainInscript.Text = "Inscription";
            this.bt_MainInscript.UseVisualStyleBackColor = false;
            this.bt_MainInscript.Click += new System.EventHandler(this.bt_MainInscript_Click);
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(57, 93);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(338, 26);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(57, 163);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(338, 26);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(442, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.bt_MainInscript);
            this.Controls.Add(this.b_MainConnect);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_MainConnect;
        private System.Windows.Forms.Button bt_MainInscript;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

