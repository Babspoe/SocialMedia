using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Net.WebRequestMethods;
using Org.BouncyCastle.Ocsp;

namespace dbLibrary
{
    public class dbResponse
    {
        public string id { get; set; }
        public string naam { get; set; }
        public string waarde { get; set; }
    }

    public class gebruiker
    {
        public string id { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public byte[] Afbeelding { get; set; }
    }

    public class Like
    {
        public string Bericht_id { get; set; }
        public string Gebruiker_id { get; set; }
    }

    public class bericht
    {
        public int id { get; set; }
        public string Tekst { get; set; }
        public byte[] Afbeelding { get; set; }
        public int Likes { get; set; }
        public gebruiker gebruiker { get; set; }
        public int berichtId { get; set; }
    }

    public enum BerichtenOpvraag
    {
        Alles,
        Geliked,
        Volgt,
        Gebruiker,
        Reacties
    }


    public class volger
    {
        public string Volgend { get; set; }
        public string Volger { get; set; }
        public DateTime Datum { get; set; }
    }

    public class gebruikerZoek
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string volgers { get; set; }
    }


    public class dbFunctions
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;

        //Constructor
        public dbFunctions()
        {
            Initialize();
        }

        private void Initialize()
        {
            string server = "localhost";
            string database = "socialmedia";
            string uid = "root";
            string password = "";

            string connectionString;
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //test connection
        public bool tryConnection()
        {
            //MessageBox.Show(db.tryConnection().ToString());
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Select[] statement
        public List<dbResponse> Select()
        {
            string query = "SELECT * FROM `table` WHERE 1";

            List<dbResponse> list = new List<dbResponse>();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                dbResponse newdbResponse = new dbResponse()
                {
                    id = dataReader["id"] + "",
                    naam = dataReader["naam"] + "",
                    waarde = dataReader["waarde"] + "",
                };
                list.Add(newdbResponse);
            }
            dataReader.Close();

            connection.Close();

            return list;
        }

        public string[] SelectLogin(string naam, string wachtwoord)
        {
            string query = "SELECT EXISTS(SELECT * FROM gebruiker WHERE Gebruikersnaam = '"+naam+"' && Wachtwoord = '"+wachtwoord+ "') AS login, id FROM gebruiker WHERE Gebruikersnaam = '"+naam+"'";

            string[] ret = new string[2];
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ret[0] = dataReader["login"] + "";
                ret[1] = dataReader["id"] + "";
                
            }
            dataReader.Close();

            connection.Close();

            return ret;
        }

        public int SelectCheckNewBerichten()
        {
            string query = "SELECT COUNT(Id) Aantal FROM bericht WHERE Bericht_Id = 0";
            connection.Open();
            int aantal = 0;

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                aantal = Convert.ToInt32(dataReader["Aantal"]);

            }
            dataReader.Close();

            connection.Close();

            return  aantal;
        }

        public string SelectCheckLogin(string naam)
        {
            string query = "SELECT EXISTS(SELECT * FROM gebruiker WHERE Gebruikersnaam = '"+naam+"') AS login, Id FROM gebruiker WHERE Gebruikersnaam = '"+naam+"';";

            string ret = "";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ret = dataReader["bestaat"] + "";

            }
            dataReader.Close();

            connection.Close();

            return ret;
        }

        public string SelectVolgerExists(string idVolgend, string idVolger)
        {
            string query = "SELECT EXISTS(SELECT * FROM volger WHERE `Volgend` = '"+idVolgend+"' AND `Volger` = '"+idVolger+"') AS bestaat FROM `volger` WHERE 1 GROUP BY bestaat;";

            string ret = "";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ret = dataReader["bestaat"] + "";

            }
            dataReader.Close();

            connection.Close();

            return ret;
        }

        public string SelectLikeExists(string Bericht, string Gebruiker)
        {
            string query = "SELECT EXISTS(SELECT * FROM `like` WHERE `Bericht_Id` = '" + Bericht + "' AND `Gebruiker_Id` = '" + Gebruiker + "') AS bestaat FROM `like` WHERE 1 GROUP BY bestaat;";

            string ret = "";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ret = dataReader["bestaat"] + "";

            }
            dataReader.Close();

            connection.Close();

            return ret;
        }

        public List<gebruikerZoek> SelectGebruikerZoek(string naam)
        {
            string query = "SELECT Id,`Gebruikersnaam`,COUNT(Volgend) AS Volgers FROM `gebruiker` LEFT JOIN volger ON gebruiker.Id = volger.Volger WHERE `Gebruikersnaam` LIKE '%"+naam+ "%' GROUP BY Gebruikersnaam ORDER BY COUNT(Volgend) DESC";

            List<gebruikerZoek> ret = new List<gebruikerZoek>();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                gebruikerZoek newGebruikerZoek = new gebruikerZoek()
                {
                    id = Convert.ToInt32(dataReader["Id"]),
                    naam = dataReader["Gebruikersnaam"] + "",
                    volgers = dataReader["Volgers"] + "",
                };
                ret.Add(newGebruikerZoek);
            }
            dataReader.Close();

            connection.Close();

            return ret;
        }

        public List<gebruikerZoek> SelectVolgt(string id)
        {
            string query = "SELECT Id,`Gebruikersnaam`,COUNT(v2.Volgend) AS Volgers FROM `gebruiker` LEFT JOIN volger v1 ON gebruiker.Id = v1.Volger LEFT JOIN volger v2 ON gebruiker.Id = v2.Volger WHERE v1.`Volgend` = '"+id+ "' GROUP BY `Gebruikersnaam` ORDER BY COUNT(v2.Volgend) DESC;";

            List<gebruikerZoek> ret = new List<gebruikerZoek>();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                gebruikerZoek newGebruikerZoek = new gebruikerZoek()
                {
                    id = Convert.ToInt32(dataReader["Id"]),
                    naam = dataReader["Gebruikersnaam"] + "",
                    volgers = dataReader["Volgers"] + "",
                };
                ret.Add(newGebruikerZoek);
            }
            dataReader.Close();

            connection.Close();

            return ret;
        }

        public List<bericht> SelectBericht(BerichtenOpvraag bo, int Id = 0)
        {
            string query = "";
            switch (bo)
            {
                case BerichtenOpvraag.Alles:
                    query =
@"SELECT b.id,COUNT(l.Gebruiker_Id) Likes, b.Afbeelding ,Tekst, g.Afbeelding pfp, g.Gebruikersnaam, b.Gebruiker_Id FROM bericht b
LEFT JOIN `like` l ON b.Id = l.Bericht_Id
INNER JOIN gebruiker g ON b.Gebruiker_Id = g.Id
WHERE b.Bericht_Id = 0
GROUP BY b.Id
ORDER BY b.id DESC";
                    break;
                case BerichtenOpvraag.Volgt:
                    query =
$@"SELECT b.id,COUNT(l.Gebruiker_Id) Likes, b.Afbeelding ,Tekst, g.Afbeelding pfp, g.Gebruikersnaam, b.Gebruiker_Id FROM bericht b
LEFT JOIN `like` l ON b.Id = l.Bericht_Id
INNER JOIN gebruiker g ON b.Gebruiker_Id = g.Id
WHERE b.Bericht_Id = 0 AND b.Gebruiker_Id IN (SELECT Volgend FROM volger WHERE volger = {Id})
GROUP BY b.Id
ORDER BY b.id DESC";
                    break;
                case BerichtenOpvraag.Geliked:
                    query =
$@"SELECT b.id,COUNT(l1.Gebruiker_Id) Likes, b.Afbeelding ,Tekst, g.Afbeelding pfp, g.Gebruikersnaam, b.Gebruiker_Id FROM bericht b
LEFT JOIN `like` l1 ON b.Id = l1.Bericht_Id
LEFT JOIN `like` l2 ON b.Id = l2.Bericht_Id
INNER JOIN gebruiker g ON b.Gebruiker_Id = g.Id
WHERE b.Bericht_Id = 0 AND l2.Gebruiker_Id = {Id}
GROUP BY b.Id
ORDER BY b.id DESC";
                    break;
                case BerichtenOpvraag.Gebruiker:
                    query =
$@"SELECT b.Id,COUNT(l.Gebruiker_Id) Likes, b.Afbeelding ,Tekst, g.Afbeelding pfp, g.Gebruikersnaam, b.Gebruiker_Id FROM bericht b
LEFT JOIN `like` l ON b.Id = l.Bericht_Id
INNER JOIN gebruiker g ON b.Gebruiker_Id = g.Id
WHERE b.Bericht_Id = 0 AND b.Gebruiker_Id = {Id}
GROUP BY b.Id
ORDER BY b.id DESC";
                    break;
                case BerichtenOpvraag.Reacties:
                    query =
$@"SELECT b.Id,COUNT(l.Gebruiker_Id) Likes, b.Afbeelding ,Tekst, g.Afbeelding pfp, g.Gebruikersnaam, b.Gebruiker_Id FROM bericht b
LEFT JOIN `like` l ON b.Id = l.Bericht_Id
INNER JOIN gebruiker g ON b.Gebruiker_Id = g.Id
WHERE b.Bericht_Id = {Id}
GROUP BY b.Id";
                    break;
            }

            List<bericht> list = new List<bericht>();
            //gebruiker ret = new gebruiker();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                bericht newdbResponse = new bericht()
                {
                    id = (int)dataReader["id"],
                    Tekst = (string)dataReader["Tekst"],
                    Afbeelding = dataReader["Afbeelding"] == DBNull.Value ? null : (byte[])dataReader["Afbeelding"],
                    Likes = Convert.ToInt32((dataReader["Likes"])),
                    gebruiker = new gebruiker
                    {
                        id = ((int)dataReader["Gebruiker_Id"]).ToString(),
                        Gebruikersnaam = (string)dataReader["Gebruikersnaam"],
                        Afbeelding = dataReader["pfp"] == DBNull.Value ? null : (byte[])dataReader["pfp"]
                    }
                };
                if(bo == BerichtenOpvraag.Reacties)
                {
                    newdbResponse.berichtId = Id;
                }
                list.Add(newdbResponse);
            }
            dataReader.Close();

            connection.Close();

            return list;
        }

        public gebruiker SelectGebruiker(int id = 1)
        {
            string query = $"SELECT `Gebruikersnaam`, `Email`, `Wachtwoord`, `Afbeelding` FROM `gebruiker` WHERE Id = {id}";

            //List<dbResponse> list = new List<dbResponse>();
            var ret = new gebruiker();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ret = new gebruiker()
                {
                    id = id.ToString(),
                    Gebruikersnaam = (string)dataReader["Gebruikersnaam"],
                    Email = (string)dataReader["Email"],
                    Wachtwoord = (string)dataReader["Wachtwoord"],
                    Afbeelding = dataReader["Afbeelding"] == DBNull.Value ? null : (byte[])dataReader["Afbeelding"]
                };
            }
            dataReader.Close();

            connection.Close();

            return ret;
        }

        //Insert statement
        public void Insert(string[] insert, byte[] img)
        {
            string query = "INSERT INTO `table`(`kolom`, `kolom`) VALUES ('" + insert[0] + "','" + insert[1] + "')";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            //image
            UpdateProductImg(img, insert[0]);

            connection.Close();
        }

        public void InsertBericht(bericht insert)//, byte[] img
        {
            var query = "";
            if(insert.berichtId != 0)
            {
                query = 
$@"INSERT INTO `bericht`(`Tekst`, `Gebruiker_Id`, `Bericht_Id`)
VALUES ('{insert.Tekst}',{insert.gebruiker.id}, {insert.berichtId})";
            }
            else
            {
                if(insert.Afbeelding.Length == 0)
                {
                    query =
$@"INSERT INTO `bericht`(`Tekst`, `Gebruiker_Id`)
VALUES ('{insert.Tekst}' ,{insert.gebruiker.id})";
                }
                else
                {
                    query = 
$@"INSERT INTO `bericht`(`Tekst`, `Afbeelding`, `Gebruiker_Id`)
VALUES ('{insert.Tekst}',@afbeelding ,{insert.gebruiker.id})";
                }
            }


            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            if(insert.Afbeelding.Length != 0)
            {
                cmd.Parameters.Add("@afbeelding", MySqlDbType.MediumBlob, insert.Afbeelding.Length).Value = insert.Afbeelding;
            }

            cmd.ExecuteNonQuery();

            //image
            //UpdateProductImg(img, insert[0]);

            connection.Close();
        }

        public void InsertGebruiker(gebruiker insert)//, byte[] img
        {
            string query = "INSERT INTO `gebruiker`(`Gebruikersnaam`, `Email`, `Wachtwoord`, `Afbeelding`) VALUES ('" + insert.Gebruikersnaam+ "','"+insert.Email+ "','"+insert.Wachtwoord+ "',@afbeelding)";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            if (insert.Afbeelding.Length != 0)
            {
                cmd.Parameters.Add("@afbeelding", MySqlDbType.MediumBlob, insert.Afbeelding.Length).Value = insert.Afbeelding;
            }
            cmd.ExecuteNonQuery();

            //image
            //UpdateProductImg(img, insert[0]);

            connection.Close();
        }

        public void InsertLike(Like insert)//, byte[] img
        {
            string query = "INSERT INTO `like`(`Bericht_Id`, `Gebruiker_Id`) VALUES ('"+insert.Bericht_id+"','"+insert.Gebruiker_id+"')";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            

            //image
            //UpdateProductImg(img, insert[0]);

            connection.Close();
        }

        public void InsertVolger(volger insert)
        {
            string query = "INSERT INTO `volger`(`Volgend`, `Volger`, `Datum`) VALUES ('"+insert.Volgend+ "','"+insert.Volger+"','"+insert.Datum+"')";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

                
            }
            

            //image
            //UpdateProductImg(img, insert[0]);

            connection.Close();
        }

        //Insert image
        public void UpdateProductImg(byte[] userImage, string naam)
        {
            var command = new MySqlCommand("", connection);

            command.CommandText = "UPDATE `table` SET Image = @userImage WHERE 'kolom'='" + naam + "'";

            var paramUserImage = new MySqlParameter("@userImage", MySqlDbType.Blob, userImage.Length);
            var paramUserId = new MySqlParameter("@userId", MySqlDbType.VarChar, 256);

            paramUserImage.Value = userImage;
            //paramUserId.Value = UserID.globalUserID;

            command.Parameters.Add(paramUserImage);
            //command.Parameters.Add(paramUserId);

            command.ExecuteNonQuery();
        }

        //Update statement
        public void Update(string[] insert, string name)
        {
            string query = "";

            connection.Open();

            //run mysql command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void UpdateGebruiker(gebruiker insert)
        {
            string query = "UPDATE `gebruiker` SET `Gebruikersnaam`='"+insert.Gebruikersnaam+ "',`Email`='"+insert.Email+ "',`Wachtwoord`='"+insert.Wachtwoord+ "',`Afbeelding`='@afbeelding' WHERE `Gebruikersnaam` = '"+insert.Gebruikersnaam+"'";

            connection.Open();

            //run mysql command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            if (insert.Afbeelding.Length != 0)
            {
                cmd.Parameters.Add("@afbeelding", MySqlDbType.MediumBlob, insert.Afbeelding.Length).Value = insert.Afbeelding;
            }
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //Delete statement
        public void DeleteOnName(string name)
        {
            string query = "DELETE FROM `table` WHERE `kolom` = '" + name + "'";

            connection.Open();

            //run mysql command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void DeleteVolger(string volger,string volgend)
        {
            string query = "DELETE FROM `volger` WHERE `Volgend` = '"+volger+"' AND `Volger` = '"+volgend+"'";

            connection.Open();

            //run mysql command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void DeleteLike(string Bericht, string Gebruikerid)
        {
            string query = "DELETE FROM `like` WHERE `Bericht_Id` = '"+Bericht+"' AND `Gebruiker_Id` = '"+Gebruikerid+"'";

            connection.Open();

            //run mysql command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //Select img
        public List<MemoryStream> SelectImgs()
        {
            string query = "SELECT * FROM `table` WHERE 1";

            connection.Open();
            List<MemoryStream> ImageStreams = new List<MemoryStream>();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                ImageStreams.Add(new MemoryStream((byte[])dataTable.Rows[i][3]));
            }

            connection.Close();

            return ImageStreams;
        }
    }
}
