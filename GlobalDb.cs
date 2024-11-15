using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    public static class GlobalDb
    {
        public static DbHelper Db { get; private set; }
        static GlobalDb()
        {
            Db = DbHelper.GetDb();
        }
    }

    public class DbHelper
    {
        private string _connectionString;
        private DbHelper()
        {
            _connectionString = @"Data Source=NB2401\SQLEXPRESS;Initial Catalog=MitarbeiterDB;Integrated Security=True;TrustServerCertificate=True";
        }

        private static DbHelper _instance;
        public static DbHelper GetDb()
        {
            if (_instance == null)
            {
                _instance = new DbHelper();
            }
            return _instance;
        }

        // Einfache Version für SELECT
        public DataTable SqlGetData(string sqlBefehl)
        {
            DataTable ergebnis = new DataTable();
            SqlConnection verbindung = null;
            try
            {
                verbindung = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand(sqlBefehl, verbindung);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                verbindung.Open();
                adapter.Fill(ergebnis);
                return ergebnis;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datenbankfehler: {ex.Message}");
                return null;
            }
            finally
            {
                if (verbindung != null)
                {
                    verbindung.Close();
                    verbindung.Dispose();
                }
            }
        }

        // Version mit Parametern für SELECT
        public DataTable SqlGetData(string sqlBefehl, params SqlParameter[] parameters)
        {
            DataTable ergebnis = new DataTable();
            SqlConnection verbindung = null;
            try
            {
                verbindung = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand(sqlBefehl, verbindung);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                verbindung.Open();
                adapter.Fill(ergebnis);
                return ergebnis;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datenbankfehler: {ex.Message}");
                return null;
            }
            finally
            {
                if (verbindung != null)
                {
                    verbindung.Close();
                    verbindung.Dispose();
                }
            }
        }

        // Einfache Version für INSERT, UPDATE, DELETE
        public int SqlSetData(string sqlBefehl)
        {
            SqlConnection verbindung = null;
            try
            {
                verbindung = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand(sqlBefehl, verbindung);
                verbindung.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datenbankfehler: {ex.Message}");
                return -1;
            }
            finally
            {
                if (verbindung != null)
                {
                    verbindung.Close();
                    verbindung.Dispose();
                }
            }
        }

        // Version mit Parametern für INSERT, UPDATE, DELETE
        public int SqlSetData(string sqlBefehl, params SqlParameter[] parameters)
        {
            SqlConnection verbindung = null;
            try
            {
                verbindung = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand(sqlBefehl, verbindung);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                verbindung.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datenbankfehler: {ex.Message}");
                return -1;
            }
            finally
            {
                if (verbindung != null)
                {
                    verbindung.Close();
                    verbindung.Dispose();
                }
            }
        }
    }
}