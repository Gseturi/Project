using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using System.Xml;


namespace Exampleproject
{
    static public class SqlCom
    {   
        
        private static string conecstring = 
            ConfigurationManager.ConnectionStrings["connectionstr"].ConnectionString;
        private static SqlCommand Command;
        private static SqlConnection connection;
        private static DataTable Table;
        private static SqlDataAdapter Adapter;

        public static bool FechDoctor(string username , string pass)
        {

            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("FechDoctor", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.VarChar);
            param[1] = new SqlParameter("@pass", SqlDbType.VarChar);

            param[0].Value = username;
            param[1].Value = pass;
            Command.Parameters.AddRange(param);

            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            Table = new DataTable();

            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Table);
            if (Table.Rows.Count == 0 || Table.Rows.Count == null)
            {
                return true;
            }
            return false;
        }
        public static DataTable FechDoctorInfo(string username , string pass)
        {
            // აბრუნებს არსებობს თუ არა ეგ ექიმი
            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("FechDoctor", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.VarChar);
            param[1] = new SqlParameter("@pass", SqlDbType.VarChar);
            param[0].Value = username;
            param[1].Value = pass;
            Command.Parameters.AddRange(param);

            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            Table = new DataTable();

            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Table);

            return Table;
        }
        public static bool FechPatient(string username , string pass)
        {
            // აბრუნებს არსებობს თუ არა პაციენტი

            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("FechPatient", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param =new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.VarChar);
            param[1] = new SqlParameter("@pass", SqlDbType.VarChar);
            param[0].Value = username;
            param[1].Value = pass;
            Command.Parameters.AddRange(param);

            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            Table = new DataTable();

            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Table);
            if (Table.Rows.Count == 0 || Table.Rows.Count == null)
            {
                return true;
            }
            return false;
        }
        public static DataTable FechPatientInfo(string username , string pass)
        {

            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("FechPatient", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.VarChar);
            param[1] = new SqlParameter("@pass", SqlDbType.VarChar);
            param[0].Value = username;
            param[1].Value = pass;
            Command.Parameters.AddRange(param);

            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            Table = new DataTable();

            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Table);

            return Table;
        }

        public static void Register_Doctor(string Name, string LastName, string Username, string passcode, string Speciallity, string Bio, string discription)
        {
            //არეგისტრირებს ექმის
            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("Register_Doctor", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Name", SqlDbType.VarChar);
            param[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[2] = new SqlParameter("@Username", SqlDbType.VarChar);
            param[3] = new SqlParameter("@passcode", SqlDbType.VarChar);
            param[4] = new SqlParameter("@Speciallity", SqlDbType.VarChar);
            param[5] = new SqlParameter("@Bio", SqlDbType.VarChar);
            param[6] = new SqlParameter("@discription", SqlDbType.VarChar);

            param[0].Value = Name;
            param[1].Value = LastName;
            param[2].Value = Username;
            param[3].Value = passcode;
            param[4].Value = Speciallity;
            param[5].Value = Bio;
            param[6].Value = discription;
            Command.Parameters.AddRange(param);


            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();

        }
        public static void Register_Patient(string Name, string LastName, string Username, string passcode, string Bio)
        {
            // არეგისტრირებს პაციენტს 
            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("Register_Patient", connection);
            Command.CommandType = CommandType.StoredProcedure;

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Name", SqlDbType.VarChar);
            param[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[2] = new SqlParameter("@Username", SqlDbType.VarChar);
            param[3] = new SqlParameter("@passcode", SqlDbType.VarChar);
            param[4] = new SqlParameter("@Bio", SqlDbType.VarChar);


            param[0].Value = Name;
            param[1].Value = LastName;
            param[2].Value = Username;
            param[3].Value = passcode;
            param[4].Value = Bio;


            Command.Parameters.AddRange(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();

        }
        public static List<string> GetMesseges(string username)
        {


            List<String> Values = new List<String>();
            //აქ სადაც ამ შემთხვევაში ვწერ სახელს უნდა შეიქმნას xml ის ფაილი სადაც შენ ინფორმაციას შეინსახავ და ავტომატურად ჩაიწერება შენი სახელი
            string myname = username;
            while (int.Parse(GetAmountM(myname)) != 0)
            {
                //ყველა შენ მესსიგს გიბრუნებს
                connection = new SqlConnection(conecstring);
                Command = new SqlCommand("GetMesseges", connection);
                Command.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Username", SqlDbType.VarChar);
                string hold = Encrypte.Encrypt(username);
                param.Value = hold;

                Command.Parameters.Add(param);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();

                string holder, holderone;
                Table = new DataTable();
                Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(Table);
                DataRow[] temp = Table.Select();
                Values.Add(temp[0][0].ToString());
                Values.Add(temp[1][0].ToString());
                Values.Add(temp[2][0].ToString());
                DeleteM(myname);
            }
            return Values;
        }

        public static void SendMessege(int id, string type, string setto, string messege)
        {
            //მესსიჯს აგზავნის
            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("SendMessege", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Id", SqlDbType.VarChar);
            param[1] = new SqlParameter("@type", SqlDbType.VarChar);
            param[2] = new SqlParameter("@sentto", SqlDbType.VarChar);
            param[3] = new SqlParameter("@messege", SqlDbType.VarChar);


            param[0].Value = id;
            param[1].Value = Encrypte.Encrypt(type);
            param[2].Value = Encrypte.Encrypt(setto);
            param[3].Value = Encrypte.Encrypt(messege);
            Command.Parameters.AddRange(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }

        public static string GetAmountM(string name)
        {
            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("getamoutofM", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param = new SqlParameter("@Name", SqlDbType.VarChar);
            param.Value = Encrypte.Encrypt(name);

            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();

            DataTable holder = new DataTable();
            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(holder);

            return holder.Rows[0][0].ToString();
        }
        public static void DeleteM(String name)
        {
            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("Deletemessege", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param = new SqlParameter("@Username", SqlDbType.VarChar);
            param.Value = Encrypte.Encrypt(name);

            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();

        }
        public static DataTable CreateInt()
        {
            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("createint", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@id",SqlDbType.Int);
            XmlDocument YourInfo = new XmlDocument();
            YourInfo.Load("C://Users//User//OneDrive//Desktop//Project//newTeamProject//WindowsFormsDoctor//YourInfo.xml");
            param.Value = YourInfo.SelectSingleNode("User/Id").InnerText;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();

            Table = new DataTable();
            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Table);


            return Table;
        }
        public static List<DataTable> GetInteraction(List<string> x)
        {
            connection = new SqlConnection(conecstring);
            Command = new SqlCommand("GetChatTF", connection);
            Command.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[1] = new SqlParameter("@id_p", SqlDbType.Int);
            XmlDocument YourInfo = new XmlDocument();
            YourInfo.Load("C://Users//User//OneDrive//Desktop//Project//newTeamProject//WindowsFormsDoctor//YourInfo.xml");
            List<DataTable> holder = new List<DataTable>();
            DataTable temp = new DataTable();
            
            for (int i = 0; i < x.Count; i++) {
               
                param[0].Value = x[i];
                param[1].Value = YourInfo.SelectSingleNode("User/Id").InnerText;
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(temp);
                holder.Add(temp);
            }
            
            return holder;
        }
    }
}
