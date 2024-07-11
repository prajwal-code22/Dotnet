// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using MySql.Data.MySqlClient;
using System.Data;
namespace AdoNetDemo
{
    class Program
    {
        MySqlConnection conn;
        MySqlCommand command;
        string constr = "";
      public Program()
        {
            string constr = "SERVER=localhost; DATABASE=dotnet; UID=root; PASSWORD=;";
            conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "SELECT * from Prajwal";
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter=new MySqlDataAdapter(command);
            
            DataTable dt=new DataTable();
            Console.WriteLine(dt);
            adapter.Fill(dt);
            if(dt.Rows.Count!=0){
                for(int i=0; i<dt.Rows.Count; i++){
                    string sid=dt.Rows[i]["ID"].ToString();
                    string name=dt.Rows[i]["Name"].ToString();
                    Console.WriteLine(sid+" "+name);
                }
            }
            conn.Close();

        }
        static void Main(string[] args)
        {
            new Program();
        }

    }
}