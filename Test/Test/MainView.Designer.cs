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
            this.SuspendLayout();
            // 
            // b_MainConnect
            // 
            this.b_MainConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_MainConnect.Location = new System.Drawing.Point(57, 73);
            this.b_MainConnect.Name = "b_MainConnect";
            this.b_MainConnect.Size = new System.Drawing.Size(338, 104);
            this.b_MainConnect.TabIndex = 0;
            this.b_MainConnect.Text = "Se connecter";
            this.b_MainConnect.UseVisualStyleBackColor = false;
            // 
            // bt_MainInscript
            // 
            this.bt_MainInscript.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_MainInscript.Location = new System.Drawing.Point(57, 265);
            this.bt_MainInscript.Name = "bt_MainInscript";
            this.bt_MainInscript.Size = new System.Drawing.Size(338, 104);
            this.bt_MainInscript.TabIndex = 1;
            this.bt_MainInscript.Text = "S\'incrire";
            this.bt_MainInscript.UseVisualStyleBackColor = false;
            this.bt_MainInscript.Click += new System.EventHandler(this.bt_MainInscript_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(442, 458);
            this.Controls.Add(this.bt_MainInscript);
            this.Controls.Add(this.b_MainConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_MainConnect;
        private System.Windows.Forms.Button bt_MainInscript;
    }
}

