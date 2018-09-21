namespace Test
{
    partial class AparaillageView
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
            this.Lv_Appareil = new System.Windows.Forms.ListView();
            this.Label_ApareillView = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lv_Appareil
            // 
            this.Lv_Appareil.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.Lv_Appareil.GridLines = true;
            this.Lv_Appareil.Location = new System.Drawing.Point(12, 42);
            this.Lv_Appareil.Name = "Lv_Appareil";
            this.Lv_Appareil.Size = new System.Drawing.Size(333, 403);
            this.Lv_Appareil.TabIndex = 0;
            this.Lv_Appareil.UseCompatibleStateImageBehavior = false;
            this.Lv_Appareil.View = System.Windows.Forms.View.List;
            this.Lv_Appareil.SelectedIndexChanged += new System.EventHandler(this.Lv_Appareil_SelectedIndexChanged);
            // 
            // Label_ApareillView
            // 
            this.Label_ApareillView.AutoSize = true;
            this.Label_ApareillView.Location = new System.Drawing.Point(109, 9);
            this.Label_ApareillView.Name = "Label_ApareillView";
            this.Label_ApareillView.Size = new System.Drawing.Size(141, 20);
            this.Label_ApareillView.TabIndex = 1;
            this.Label_ApareillView.Text = "Liste des appareils";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AparaillageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label_ApareillView);
            this.Controls.Add(this.Lv_Appareil);
            this.Name = "AparaillageView";
            this.Text = "AparaillageView";
            this.Load += new System.EventHandler(this.AparaillageView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Appareil;
        private System.Windows.Forms.Label Label_ApareillView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}