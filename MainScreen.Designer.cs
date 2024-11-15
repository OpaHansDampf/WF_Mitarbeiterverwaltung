namespace Mitarbeiterverwaltung
{
    partial class MainScreen
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
            this.btn_MitarbeiterAnlegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MitarbeiterAnlegen
            // 
            this.btn_MitarbeiterAnlegen.Location = new System.Drawing.Point(316, 34);
            this.btn_MitarbeiterAnlegen.Name = "btn_MitarbeiterAnlegen";
            this.btn_MitarbeiterAnlegen.Size = new System.Drawing.Size(158, 40);
            this.btn_MitarbeiterAnlegen.TabIndex = 1;
            this.btn_MitarbeiterAnlegen.Text = "Mitarbeiter anlegen";
            this.btn_MitarbeiterAnlegen.UseVisualStyleBackColor = true;
            this.btn_MitarbeiterAnlegen.Click += new System.EventHandler(this.btn_MitarbeiterAnlegen_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MitarbeiterAnlegen);
            this.Name = "MainScreen";
            this.Text = "Hauptfenster";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_MitarbeiterAnlegen;
    }
}