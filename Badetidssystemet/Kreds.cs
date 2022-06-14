using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        private string _id;
        private string _navn;
        private string _adresse;
        private int _antalDeltagere;

        public Kreds(string id, string navn, string adresse, int antalDeltagere)
        {
            _id = id;
            _navn = navn;
            _adresse = adresse;
            _antalDeltagere = antalDeltagere;
            try
            {
                if (_antalDeltagere < 1 || _antalDeltagere > 20)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Der er ingen deltagere eller for mange!");
            }
            try
            {
                if (adresse.Length > 6)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Adressen er ikke rigtig!");
            }
        }

        public string ID { get { return _id; } set { _id = value; } }
        public string Navn { get { return _navn; } set { _navn = value; } }
        public string Adresse { get { return _adresse; } 
            set {
                _adresse = value;
                try
                {
                    if (value.Length > 6)
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Adressen er ikke rigtig!");
                }
            } }
        public int AntalDeltagere { get { return _antalDeltagere; } 
            set { 
                if (_antalDeltagere < 1 || _antalDeltagere > 20)
                {
                    _antalDeltagere = value;
                }
                try
                {
                    if (_antalDeltagere < 1 || _antalDeltagere > 20)
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Der er ingen deltagere eller for mange!");
                }
            } }

        public override string ToString()
        {
            return $"ID: {_id}. Navn: {_navn}. Adresse: {_adresse}. Antal deltagere: {_antalDeltagere}.";
        }
    }
}
