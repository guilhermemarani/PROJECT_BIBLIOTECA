using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PROJECT_BIBLIOTECA
{
    class Conexao
    {
        public SQLiteConnection conn = new SQLiteConnection("Data Source=base.sdb");

        public void conectar()
        {
            conn.Open();
        }
        public void desconectar()
        {
            conn.Close();
        }
    }
}
