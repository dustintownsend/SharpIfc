using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcTypeObject : IfcObjectDefinition
    {
        public IfcIdentifier ApplicableOccurrence { get; set; }

        public HashSet<IfcPropertySetDefinition> HasPropertySets { get; set; }

        //ENTITY IfcTypeObject
        //  SUPERTYPE OF	(ONEOF(IfcTypeProduct, IfcTypeProcess))
        //  SUBTYPE OF (	IfcObjectDefinition);
        //      ApplicableOccurrence	 : 	OPTIONAL IfcIdentifier;
        //      HasPropertySets	 : 	OPTIONAL SET [1:?] OF IfcPropertySetDefinition;
        //  INVERSE
        //      Types	 : 	SET [0:1] OF IfcRelDefinesByType FOR RelatingType;
        //  WHERE
        //      WR1	 : 	EXISTS(SELF\IfcRoot.Name);
        //END_ENTITY;
    }
}
