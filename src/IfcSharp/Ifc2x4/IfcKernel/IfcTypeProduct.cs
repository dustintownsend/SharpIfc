using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcTypeProduct
    {
        public List<IfcRepresentationMap> RepresentationMaps { get; set; }
        public IfcLabel Tag { get; set; }

        //ENTITY IfcTypeProduct
        //  SUBTYPE OF (	IfcTypeObject);
        //      RepresentationMaps	 : 	OPTIONAL LIST [1:?] OF UNIQUE IfcRepresentationMap;
        //      Tag	 : 	OPTIONAL IfcLabel;
        //  INVERSE
        //      ReferencedBy	 : 	SET OF IfcRelAssignsToProduct FOR RelatingProduct;
        //  WHERE
        //      ApplicableOccurrence	 : 	NOT(EXISTS(SELF\IfcTypeObject.Types[1])) OR (SIZEOF(QUERY(temp <* SELF\IfcTypeObject.Types[1].RelatedObjects | NOT('IFCKERNEL.IFCPRODUCT' IN TYPEOF(temp))) ) = 0);
        //END_ENTITY;
    }
}
