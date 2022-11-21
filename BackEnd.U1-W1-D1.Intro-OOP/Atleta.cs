using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D1.Intro_OOP
{
    internal class Atleta : Persona
    {
        private string _ruolo;

        public string Ruolo { get { return _ruolo; } set { _ruolo = value; }  }
    }
}
