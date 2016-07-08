using Dapper;
using MySql.Data.MySqlClient;
using System;

namespace ConsoleApplication_Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            String serverIP = "";
            String serverUser = "application";
            String serverPwd = "";
            String serverPort = "3306";
            String serverDataBaseName = "application";
            String conStr = "Server=" + serverIP
                  + ";Port=" + serverPort
                  + ";Database=" + serverDataBaseName
                  + ";User=" + serverUser
                  + ";Pwd=" + serverPwd
                  + ";CharSet=utf8;";

            using (var cn = new MySqlConnection(conStr))
            {
                var list = cn.Query("SELECT * FROM `hentai_page`");
                foreach (var item in list)
                {
                    Console.WriteLine("{0}.{1}({2})",
                        item.uid, item.title, item.url);
                }
            }
        }
    }
}
