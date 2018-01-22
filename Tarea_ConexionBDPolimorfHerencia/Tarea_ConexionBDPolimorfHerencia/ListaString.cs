using System;
using Npgsql;
using Mono.Security;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_ConexionBDPolimorfHerencia
{
    class ListaString : IExecConexString
    {
        public void conectarBD() {

            

            /*
            NpgsqlConnection con = new NpgsqlConnection(@"Server=baasu.db.elephantsql.com;Database=jrdkibpv;User Id=jrdkibpv;Password=65hxdEfRt-7GeWf3CnWw_5iI7Yx_wdRB;Port=5432");
            con.Open();
            Console.WriteLine("Welcome, the connection now is: "+con.State);
            //NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"public\".\"spatial_ref_sys\" LIMIT 5",con);
            */

        }
        public void desconectarBD(){

            using(NpgsqlConnection con = new NpgsqlConnection(@"Server=baasu.db.elephantsql.com;Database=jrdkibpv;User Id=jrdkibpv;Password=65hxdEfRt-7GeWf3CnWw_5iI7Yx_wdRB;Port=5432"))
    {
                con.Close();
                Console.WriteLine("The connection now is: "+con.State+", good bye");
            }



        }
            
        }  
    }
