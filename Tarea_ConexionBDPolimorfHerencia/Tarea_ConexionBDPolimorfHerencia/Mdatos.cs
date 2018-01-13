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
        public string commPgSql;

        public void MdatosDB() {
                
                string commPgSql = "SELECT * FROM \"public\".\"spatial_ref_sys\" LIMIT 5";
                NpgsqlCommand comando = new NpgsqlCommand(commPgSql);
                NpgsqlDataReader dr = comando.ExecuteReader(); //Error - La conexion no esta abierta.
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);

                    Console.WriteLine("id: {0} - name: {1}", id, name);
                }
            }
        public void MdatosDB(string commPgSql) {//A esta funcion aun no le he asignado nada.. 
                                                    //la idea es que el usuario pueda introducir su propio Query de SQL

            this.commPgSql = commPgSql;
            
        }

    }
}
