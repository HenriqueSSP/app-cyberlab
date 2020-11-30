using Android.App;
using Android.Widget;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;


namespace CyberLab_Integrador
{
    public class Conexao
    {
        //public static string conec = "SERVER=localhost;port=3306;User Id=root;database=db_cyberlab; password=";
        public static string conec = @"server=softkleen.com.br;user id=ti87cyberlab;database=wellington_db_cyberlab;port=3306;password=@vn0N6m8";
        

        public static MySqlCommand AbriCon()
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {

                MySqlConnection con = new MySqlConnection(conec);
                con.Open();
                cmd.Connection = con;
            }
            catch (System.TypeInitializationException ex)
            {

                Toast.MakeText(Application.Context, "Erro ao conectar" + ex, ToastLength.Long).Show();
            }
            return cmd;
        }

        public static void FecharCon(MySqlConnection conn)
        {
            try
            {
                if (conn.State ==  System.Data.ConnectionState.Open)
                conn.Close();
            }
            catch (Exception ex)
            {

                Toast.MakeText(Application.Context, "Erro ao fechar" + ex, ToastLength.Long).Show();
            }

        }
    }

    
}
