namespace Mitarbeiterverwaltung
{
    partial class MitarbeiterAnlegen
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
            this.labVorname = new System.Windows.Forms.Label();
            this.labNachname = new System.Windows.Forms.Label();
            this.labGeschlecht = new System.Windows.Forms.Label();
            this.txt_vorname = new System.Windows.Forms.TextBox();
            this.txt_nachname = new System.Windows.Forms.TextBox();
            this.cb_geschlecht = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dgvMitarbeiterAnlegenResultView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiterAnlegenResultView)).BeginInit();
            this.SuspendLayout();
            // 
            // labVorname
            // 
            this.labVorname.AutoSize = true;
            this.labVorname.Location = new System.Drawing.Point(54, 31);
            this.labVorname.Name = "labVorname";
            this.labVorname.Size = new System.Drawing.Size(49, 13);
            this.labVorname.TabIndex = 0;
            this.labVorname.Text = "Vorname";
            // 
            // labNachname
            // 
            this.labNachname.AutoSize = true;
            this.labNachname.Location = new System.Drawing.Point(44, 64);
            this.labNachname.Name = "labNachname";
            this.labNachname.Size = new System.Drawing.Size(59, 13);
            this.labNachname.TabIndex = 1;
            this.labNachname.Text = "Nachname";
            // 
            // labGeschlecht
            // 
            this.labGeschlecht.AutoSize = true;
            this.labGeschlecht.Location = new System.Drawing.Point(42, 98);
            this.labGeschlecht.Name = "labGeschlecht";
            this.labGeschlecht.Size = new System.Drawing.Size(61, 13);
            this.labGeschlecht.TabIndex = 2;
            this.labGeschlecht.Text = "Geschlecht";
            // 
            // txt_vorname
            // 
            this.txt_vorname.Location = new System.Drawing.Point(133, 24);
            this.txt_vorname.Name = "txt_vorname";
            this.txt_vorname.Size = new System.Drawing.Size(143, 20);
            this.txt_vorname.TabIndex = 3;
            // 
            // txt_nachname
            // 
            this.txt_nachname.Location = new System.Drawing.Point(133, 57);
            this.txt_nachname.Name = "txt_nachname";
            this.txt_nachname.Size = new System.Drawing.Size(143, 20);
            this.txt_nachname.TabIndex = 4;
            // 
            // cb_geschlecht
            // 
            this.cb_geschlecht.FormattingEnabled = true;
            this.cb_geschlecht.Items.AddRange(new object[] {
            "m",
            "w"});
            this.cb_geschlecht.Location = new System.Drawing.Point(133, 90);
            this.cb_geschlecht.Name = "cb_geschlecht";
            this.cb_geschlecht.Size = new System.Drawing.Size(143, 21);
            this.cb_geschlecht.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(57, 159);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(201, 158);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 7;
            this.btn_change.Text = "bearbeiten";
            this.btn_change.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(357, 158);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(516, 158);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(111, 23);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Felder leeren";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // dgvMitarbeiterAnlegenResultView
            // 
            this.dgvMitarbeiterAnlegenResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMitarbeiterAnlegenResultView.Location = new System.Drawing.Point(45, 251);
            this.dgvMitarbeiterAnlegenResultView.Name = "dgvMitarbeiterAnlegenResultView";
            this.dgvMitarbeiterAnlegenResultView.Size = new System.Drawing.Size(696, 173);
            this.dgvMitarbeiterAnlegenResultView.TabIndex = 10;
            this.dgvMitarbeiterAnlegenResultView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMitarbeiterAnlegenResultView_CellContentClick);
            // 
            // MitarbeiterAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMitarbeiterAnlegenResultView);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_geschlecht);
            this.Controls.Add(this.txt_nachname);
            this.Controls.Add(this.txt_vorname);
            this.Controls.Add(this.labGeschlecht);
            this.Controls.Add(this.labNachname);
            this.Controls.Add(this.labVorname);
            this.Name = "MitarbeiterAnlegen";
            this.Text = "MitarbeiterAnlegen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiterAnlegenResultView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labVorname;
        private System.Windows.Forms.Label labNachname;
        private System.Windows.Forms.Label labGeschlecht;
        private System.Windows.Forms.TextBox txt_vorname;
        private System.Windows.Forms.TextBox txt_nachname;
        private System.Windows.Forms.ComboBox cb_geschlecht;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgvMitarbeiterAnlegenResultView;
    }
}