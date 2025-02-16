using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace KitaplıkTest
{
    public class KitapDB
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Veli\\Documents\\Kitaplik.accdb");
        public List<Kitap> kliste()
        {
            List<Kitap> liste = new List<Kitap>();
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Kitaplar", baglanti);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Kitap kitap = new Kitap();
                kitap.Id = Convert.ToInt32(reader[0]);
                kitap.Ad = reader[1].ToString();
                kitap.Yazar = reader[2].ToString();
                liste.Add(kitap);
            }
            baglanti.Close();
            return liste;

        }

    }
}
