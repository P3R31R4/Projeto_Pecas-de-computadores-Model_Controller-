using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_Pichau.Model
{
    internal class Conexao
    {
        public string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guilherme.pnunes\source\repos\GP_Pichau\GP_Pichau\Model\pecasdesktopbd.mdf;Integrated Security=True";
        }
    }
}
