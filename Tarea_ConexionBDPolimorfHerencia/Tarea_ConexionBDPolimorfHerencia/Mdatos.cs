using System;
using System.Collections.Generic;
using Npgsql;
using Mono.Security;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_ConexionBDPolimorfHerencia
{
    class Mdatos:ListaString
    {
        public string commPgSql { get; set; }

        public void MdatosDB() {
            using (NpgsqlConnection con = new NpgsqlConnection(@"Server=baasu.db.elephantsql.com;Database=jrdkibpv;User Id=jrdkibpv;Password=65hxdEfRt-7GeWf3CnWw_5iI7Yx_wdRB;Port=5432"))
            {
                con.Open();
                string commPgSql = "SELECT * FROM \"public\".\"spatial_ref_sys\" LIMIT 5";
                NpgsqlCommand comando = new NpgsqlCommand(commPgSql,con);
                NpgsqlDataReader dr = comando.ExecuteReader(); //Error - La conexion no esta abierta.
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);

                    Console.WriteLine("id: {0} - name: {1}", id, name);
                }

                con.Close();
            }
            }
        public void MdatosDB(string commPgSql) {//A esta funcion aun no le he asignado nada.. 
            using (NpgsqlConnection con = new NpgsqlConnection(@"Server=baasu.db.elephantsql.com;Database=jrdkibpv;User Id=jrdkibpv;Password=65hxdEfRt-7GeWf3CnWw_5iI7Yx_wdRB;Port=5432"))
            {
                con.Open();
                NpgsqlCommand comando = new NpgsqlCommand(commPgSql, con);
                NpgsqlDataReader dr = comando.ExecuteReader(); //Error - La conexion no esta abierta.
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);

                    Console.WriteLine("id: {0} - name: {1}", id, name);
                }

                con.Close();
            }                                       //la idea es que el usuario pueda introducir su propio Query de 
            

            
        }

    }
}
