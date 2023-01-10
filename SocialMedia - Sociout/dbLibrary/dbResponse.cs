using System;
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
            string database = "sakila";
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

        //Insert statement
        public void InsertNewProduct(string[] insert, byte[] img)
        {
            string query = "INSERT INTO `table`(`kolom`, `kolom`) VALUES ('" + insert[0] + "','" + insert[1] + "')";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            //image
            UpdateProductImg(img, insert[0]);

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
