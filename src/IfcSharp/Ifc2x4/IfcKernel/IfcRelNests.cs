using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcRelNests : IfcRelDecomposes
    {
        // TODO: Properties
        //public IfcNonProductSelect RelatingObject { get; set; }

        //ENTITY IfcRelNests
        //  SUBTYPE OF (	IfcRelDecomposes);
        //      RelatingObject	 : 	IfcNonProductSelect;
        //      RelatedObjects	 : 	LIST [1:?] OF IfcNonProductSelect;
        //  WHERE
        //      NoSelfReference	 : 	SIZEOF(QUERY(Temp <* RelatedObjects | RelatingObject :=: Temp)) = 0;
        //END_ENTITY;
    }
}
