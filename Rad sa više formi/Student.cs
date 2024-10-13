using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_sa_više_formi
{
    internal class Student
    {
        

        public string ime { get; set; }
        public string prezime { get; set; }
        public string brojIndeksa { get; set; }
        public string smjer { get; set; }
        public DateTime datumRodjenja { get; set; }

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        public string BrojIndeksa
        {
            get
            {
                return brojIndeksa;
            }

            set
            {
                brojIndeksa = value;
            }
        }
        public string Smjer
        {
            get
            {
                return smjer;
            }
            set
            {
                smjer = value;
            }
        }
        public DateTime DatumRodjenja

        {

            get

            {

                return datumRodjenja;

            }

            set

            {

                datumRodjenja = value;

            }

        }
        public override string ToString()
        {
            return $"{Ime} {Prezime} - {BrojIndeksa} - {Smjer} - {DatumRodjenja.ToString("yyyy-MM-dd")}";
        }
    }
}
