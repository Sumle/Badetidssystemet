using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Badetidssystemet
{
    class BadetidsPeriodeForLoopAndList : Badetidsperiode
    {
        public List<Kreds> _kredseList;

        public BadetidsPeriodeForLoopAndList(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt, 
            List<Kreds> kredseList)
            : base (type, ugeDag, startTidspunkt, slutTidspunkt)
        {
            
        }

        public List<Kreds> KredseList { get { return _kredseList; } set {_kredseList = value; } }

        public virtual void AdderKreds()
        {

        }

        public virtual void SletKreds()
        {

        }

        public override string ToString()
        {
            return $"Type: ";

        }
    }
}
