using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Login.Classes
{
    class Global
    {
        private static string _nome;
        public static string nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
        }

    }
}
