using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitVaruButik
{
    class Kund
    {
        private string kundnummer;
        private string namn;
        private string email;
        private string telefonnummer;
        private string gatuadress;
        private string postnummer;
        private string postort;
        private string län;
        private string land;
        
        public Kund (string kundnummer, string namn, string email, string telefonnummer, 
            string gatuadress, string postnummer, string postort, string län, string land)
        {
            this.kundnummer = kundnummer;
            this.namn = namn;
            this.email = email;
            this.telefonnummer = telefonnummer;
            this.gatuadress = gatuadress;
            this.postnummer = postnummer;
            this.postort = postort;
            this.län = län;
            this.land = land;
        }

        public string Kundnummer
        {
            get { return kundnummer;  }
            set { kundnummer = value; }
        }
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefonnummer
        {
            get { return telefonnummer; }
            set { telefonnummer = value; }
        }
        public string Gatuadress
        {
            get { return gatuadress; }
            set { gatuadress = value; }
        }
        public string Postnummer
        {
            get { return postnummer; }
            set { postnummer = value; }
        }
        public string Postort
        {
            get { return postort; }
            set { postort = value; }
        }
        public string Län
        {
            get { return län; }
            set { län = value; }
        }
        public string Land
        {
            get { return land; }
            set { land = value; }
        }

        


    


        

    }
}
