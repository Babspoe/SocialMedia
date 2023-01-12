﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

    public class bericht
    {
        public int id { get; set; }
        public string Tekst { get; set; }
        public byte[] Afbeelding { get; set; }
        public int Likes { get; set; }
        public gebruiker gebruiker { get; set; }
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

        public List<bericht> SelectBericht()
        {
            string query = 
@"SELECT b.id,COUNT(*) Likes, b.Afbeelding ,Tekst, g.Afbeelding pfp, g.Gebruikersnaam, b.Gebruiker_Id FROM bericht b
INNER JOIN (`like` l, gebruiker g) ON (b.id = l.Bericht_Id AND b.Gebruiker_Id = g.Id )
WHERE b.Bericht_Id = 0";

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
                list.Add(newdbResponse);
            }
            dataReader.Close();

            connection.Close();

            return list;
        }

        public gebruiker SelectGebruiker()
        {
            string query = "SELECT * FROM `table` WHERE 1";

            //List<dbResponse> list = new List<dbResponse>();
            gebruiker ret = new gebruiker();
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
                //list.Add(newdbResponse);
            }
            dataReader.Close();

            connection.Close();

            return new gebruiker();
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

        public void InsertGebruiker(gebruiker insert)//, byte[] img
        {
            string query = "INSERT INTO `gebruiker`(`Gebruikersnaam`, `Email`, `Wachtwoord`) VALUES ('"+insert.Gebruikersnaam+ "','"+insert.Email+ "','"+insert.Wachtwoord+"')";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

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
