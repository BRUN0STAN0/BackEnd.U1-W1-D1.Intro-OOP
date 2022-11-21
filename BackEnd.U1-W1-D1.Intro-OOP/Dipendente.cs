using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D1.Intro_OOP
{
    internal class Dipendente : Persona
    {
        private string[] _softSkill, _hardSkill;
        private double _stipendio;

        public double Stipendio { get { return _stipendio; } set { _stipendio = value; } }
        public string[] SoftSkill { get { return _softSkill; } set { _softSkill = value; } }
        public string[] HardSkill { get { return _hardSkill; } set { _hardSkill = value; } }    
    }
}
