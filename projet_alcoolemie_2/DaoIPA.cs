using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_alcoolemie_2 {
    public static class DaoIPA {
        private static string dbPath = ConfigurationManager.ConnectionStrings["DbPath"].ConnectionString;
        private static SQLiteConnection maConnexion = new SQLiteConnection(String.Format("Data Source={0};Version=3;", dbPath));

        public static List<Boisson> GetAllBoissons() {
            maConnexion.Open();
            List<Boisson> tmp = new List<Boisson>();

            string req = "select * from boisson order by nom asc";
            SQLiteCommand commande = new SQLiteCommand(req, maConnexion);
            SQLiteDataReader reader = commande.ExecuteReader();

            while (reader.Read()) {
                tmp.Add(new Boisson(reader["nom"].ToString(), Convert.ToDouble(reader["quantite"]), Convert.ToDouble(reader["degre"])));
            }

            maConnexion.Close();
            return tmp;
        }
    }
}
