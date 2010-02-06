using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcRelAggregates : IfcRelDecomposes
    {
        public IfcObjectDefinition RelatingObject { get; set; }

        public HashSet<IfcObjectDefinition> RelatedObjects { get; set; }

        //ENTITY IfcRelAggregates
        //  SUBTYPE OF (	IfcRelDecomposes);
        //      RelatingObject	 : 	IfcObjectDefinition;
        //      RelatedObjects	 : 	SET [1:?] OF IfcObjectDefinition;
        //  WHERE
        //      NoSelfReference	 : 	SIZEOF(QUERY(Temp <* RelatedObjects | RelatingObject :=: Temp)) = 0;
        //END_ENTITY;
    }
}
