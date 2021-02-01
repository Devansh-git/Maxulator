using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernCalulator
{
    class variables
    {

        

        public string Time { get; private set; }
      

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public variables()
        { }

        public variables(string time,double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            
            Time = time;
            
            
        }



        
    
    }
}
