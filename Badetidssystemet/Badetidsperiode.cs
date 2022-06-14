using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Badetidssystemet
{
    class Badetidsperiode
    {
        private string _type;
        private DayOfWeek _ugeDag;
        private DateTime _startTidspunkt;
        private DateTime _slutTidspunkt;
        private Dictionary<string, Kreds> _dicKreds;

        public Badetidsperiode(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            _type = type;
            _ugeDag = ugeDag;
            _startTidspunkt = startTidspunkt;
            _slutTidspunkt = slutTidspunkt;
            _dicKreds = new Dictionary<string, Kreds>();
            try
            {
                if (_startTidspunkt >= _slutTidspunkt)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Starttidspunkt kan ikke være efter sluttidspunkt!");
            }
            try
            {
                if (type.Length < 4)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Typen er ikke lang nok!");
            }
        }

        public string Type { get { return _type; } 
            set { 
                _type = value;
                try
                {
                    if (value.Length < 4)
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Typen er ikke lang nok!");
                }
            } }
        public DayOfWeek UgeDag { get { return _ugeDag; } set { _ugeDag = value; } }
        public DateTime StartTidspunkt { get { return _startTidspunkt; } 
            set { 
                _startTidspunkt = value;
                try
                {
                    if (_startTidspunkt >= _slutTidspunkt)
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Starttidspunkt kan ikke være efter sluttidspunkt!");
                }
            } }
        public DateTime SlutTidspunkt { get { return _slutTidspunkt; } set { _slutTidspunkt = value; } }
        public Dictionary<string, Kreds> DicKreds { get { return _dicKreds; } set { _dicKreds = value; } }

        public override string ToString()
        {
            return $"Type: {_type}. Ugedag: {_ugeDag}. Starttidspunkt: {StartTidspunkt}. Sluttidspunkt: {_slutTidspunkt}.";
        }

        public virtual void AdderKreds(Kreds kreds)
        {
            _dicKreds.Add(kreds.ID, kreds);
        }

        public virtual void SletKreds(string id)
        {
            _dicKreds.Remove(id);
        }
    }
}
