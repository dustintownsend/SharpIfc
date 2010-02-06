using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcProject : IfcContext
    {
        public HashSet<IfcRepresentationContext> RepresentationContexts { get; set; }

        public IfcUnitAssignment UnitsInContext { get; set; }

        //ENTITY IfcProject
        //  SUBTYPE OF (	IfcContext);
        //      RepresentationContexts	 : 	SET [1:?] OF IfcRepresentationContext;
        //      UnitsInContext	 : 	IfcUnitAssignment;
        //  WHERE
        //      WR31	 : 	EXISTS(SELF\IfcRoot.Name);
        //      WR32	 : 	SIZEOF(QUERY(Temp <* RepresentationContexts | 'IFCREPRESENTATIONRESOURCE.IFCGEOMETRICREPRESENTATIONSUBCONTEXT' IN TYPEOF(Temp) )) = 0 ;
        //      WR33	 : 	SIZEOF(SELF\IfcObjectDefinition.Decomposes) = 0;
        //END_ENTITY;
    }
}
