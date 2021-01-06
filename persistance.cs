using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace COVID_19
{
    class persistance
    {
        private Individu individu;
        //private Etranger etranger;
        /*private CodeQR codeQR;
        private Depistage depistage;
        private Lieu lieu;
        private Consultationenligne consultationenligne;
        private Traitement traitement;*/

        static String ChaineConnection = "Data Source=DESKTOP-8PGDD1D;Initial Catalog=covid19;Integrated Security=True";
        static SqlConnection Connection = new SqlConnection(ChaineConnection);
        static SqlCommand Command = new SqlCommand();
        static SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        public persistance()
        {
            individu = new Individu();
        }
        public persistance(Individu citoyen)
        {
            this.individu = new Individu(citoyen);
        }
        /*public persistance(Etranger etranger)
        {
            etranger = new Etranger(etranger);
        }*/

        public void Insert()
        {
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = "INSERT INTO citoyen(identifiant, nom) VALUES('" + individu.Identifiant + "','" + individu.Nom + "')";
            Command.ExecuteNonQuery();
            Connection.Close();
        }

        /*public void Insert(Etranger newEtranger)
        {

        }*/
    }
}
