using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    public partial class MainScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=NB2401\SQLEXPRESS;Initial Catalog=MitarbeiterDB;Integrated Security=True;TrustServerCertificate=True");
        
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btn_MitarbeiterAnlegen_Click(object sender, EventArgs e)
        {
            MitarbeiterAnlegen mitarbeiterAnlegen = new MitarbeiterAnlegen();
            mitarbeiterAnlegen.ShowDialog();
            
        }
    }
}
