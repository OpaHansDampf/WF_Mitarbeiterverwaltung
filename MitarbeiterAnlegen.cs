using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    using static GlobalDb;
    public partial class MitarbeiterAnlegen : Form
    {
        public MitarbeiterAnlegen()
        {
            InitializeComponent();
            showMitarbeiter(); // Gleich beim Start die Daten anzeigen
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string vorname = txt_vorname.Text;
            string nachname = txt_nachname.Text;
            int geschlecht = (cb_geschlecht.SelectedIndex == 0) ? 1 : 2;

            if (vorname != "" && nachname != "" && cb_geschlecht.SelectedIndex >= 0)
            {
                Db.SqlSetData($"INSERT INTO Mitarbeiter (Vorname, Nachname, ID_GESCHLECHT) VALUES ('{vorname}','{nachname}',{geschlecht})");
                showMitarbeiter(); 

                // Optional: Felder leeren
                txt_vorname.Text = "";
                txt_nachname.Text = "";
                cb_geschlecht.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
            }
        }

        private void dgvMitarbeiterAnlegenResultView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void showMitarbeiter()
        {
            // Direkt das DataTable-Objekt zuweisen
            dgvMitarbeiterAnlegenResultView.DataSource = Db.SqlGetData(@"
                SELECT m.Vorname, m.Nachname, g.Geschlecht_Lang 
                FROM Mitarbeiter m
                LEFT JOIN Geschlecht g ON m.ID_GESCHLECHT = g.ID_GESCHLECHT
            ");
        }
    }
}