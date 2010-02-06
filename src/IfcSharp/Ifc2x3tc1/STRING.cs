using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x3tc1
{
    public class STRING
    {
        public static long counter = 0;

        public String value = new string();

        public STRING()
        {
            counter++;
        }

        public STRING(String value)
        {
            this.value = value;
            counter++;
        }

        public void SetValue(String value)
        {
            this.value = value;
        }

        public void SetValue(STRING value)
        {
            this.value = value.value;
        }

        public String GetStepLine()
        {
            return null;
        }

        public Object Clone()
        {
            STRING str = new STRING(this.value);
            return str;
        }

        public String ToString()
        {
            return this.value;
        }
    }
}
