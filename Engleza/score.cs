using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engleza
{
    class score
    {
        static public int ShowBestScore(string joc)
        {
            int rezultat = 0;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\soft.accdb");//se creeaza o noua conexiune
            con.Open();
            string text = "select * from scoruri where utilizator=@utilizator and joc=@joc";
            OleDbCommand com = new OleDbCommand(text, con);
            com.Parameters.AddWithValue("utilizator", variabile.utilizator.ToString());
            com.Parameters.AddWithValue("joc", joc);
            OleDbDataReader r = com.ExecuteReader();
            if (r.Read())
            {
                rezultat = int.Parse(r["scor"].ToString());
            }
            r.Close();
            con.Close();
            return rezultat;
        }
        static public int SetBestScore(string joc, int scor)
        {
            int rezultat = 0;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\soft.accdb");//se creeaza o noua conexiune
            con.Open();
            string textAdd = "select count(*) as cate from scoruri where utilizator=@utilizator and joc=@joc and scor>@scor";
            string textDel = "delete from scoruri where utilizator=@utilizator and joc=@joc ";
            string textIns = "insert into scoruri(utilizator,joc,scor) values(@utilizator,@joc,@scor)";
            OleDbCommand com = new OleDbCommand(textAdd, con);
            com.Parameters.AddWithValue("utilizator", variabile.utilizator.ToString());
            com.Parameters.AddWithValue("joc", joc);
            com.Parameters.AddWithValue("scor", scor);
            com.Parameters["scor"].DbType = System.Data.DbType.Int16;
            com.ExecuteNonQuery();
            OleDbDataReader r = com.ExecuteReader();
            if ( r.Read() && r["cate"].ToString()=="0")
            {
                r.Close();
                com.CommandText = textDel;
                com.ExecuteNonQuery();
                com.CommandText = textIns;
                com.ExecuteNonQuery();
                rezultat = 1;
            }
            r.Close();
            con.Close();
            return rezultat;
        }
    }
}
