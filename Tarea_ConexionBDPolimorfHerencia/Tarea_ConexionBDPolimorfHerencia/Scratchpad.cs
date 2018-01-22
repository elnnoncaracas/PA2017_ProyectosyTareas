using System;
using Npgsql;
using Mono.Math;
using Mono;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_ConexionBDPolimorfHerencia
{
   public class Scratchpad:IExecConexString
    {
        public DbConnection Conx { get; private set; }

        public void conectarBD() {

            NpgsqlConnection con = new NpgsqlConnection(@"Server=baasu.db.elephantsql.com;Database=jrdkibpv;User Id=jrdkibpv;Password=65hxdEfRt-7GeWf3CnWw_5iI7Yx_wdRB;Port=5432");
            UnirBD(con);

        }
       

        public void UnirBD(DbConnection Conx)
        {
            Conx.Open();
            Console.WriteLine(Conx.State);
            
            Conx.Close();
            Console.WriteLine(Conx.State);
        }
        public void commander()
        {

            NpgsqlCommand como = new NpgsqlCommand("SELECT * FROM \"public\".\"spatial_ref_sys\" LIMIT 5");
            
                pasacmd(Conx, como);
            

        }
        public void pasacmd(DbConnection Conx, DbCommand cmd) {
            Conx.Open();
            cmd.ExecuteReader();
            DbDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);

                Console.WriteLine("id: {0} - name: {1}", id, name);
            }

            Conx.Close();
        }
        


        

    }

}