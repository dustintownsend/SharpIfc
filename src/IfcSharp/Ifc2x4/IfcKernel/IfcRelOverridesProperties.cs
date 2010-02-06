using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcRelOverridesProperties
    {
        public HashSet<IfcProperty> OverridingProperties { get; set; }

        //ENTITY IfcRelOverridesProperties
        //  SUBTYPE OF (	IfcRelDefinesByProperties);
        //      OverridingProperties	 : 	SET [1:?] OF IfcProperty;
        //  WHERE
        //      WR1	 : 	SIZEOF(SELF\IfcRelDefinesByProperties.RelatedObjects) = 1;
        //END_ENTITY;
    }
}
