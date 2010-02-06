using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcProduct : IfcObject
    {

        public IfcObjectPlacement ObjectPlacement { get; set; }

        public IfcProductRepresentation Representation { get; set; }

        //ENTITY IfcProduct
        //  ABSTRACT SUPERTYPE OF	(IfcProxy)
        //  SUBTYPE OF (	IfcObject);
        //      ObjectPlacement	 : 	OPTIONAL IfcObjectPlacement;
        //      Representation	 : 	OPTIONAL IfcProductRepresentation;
        //  INVERSE
        //      ReferencedBy	 : 	SET OF IfcRelAssignsToProduct FOR RelatingProduct;
        //  WHERE
        //      WR1	 : 	(EXISTS(Representation) AND EXISTS(ObjectPlacement)) OR (EXISTS(Representation) AND (NOT('IFCREPRESENTATIONRESOURCE.IFCPRODUCTDEFINITIONSHAPE' IN TYPEOF(Representation)))) OR (NOT(EXISTS(Representation))) ;
        //END_ENTITY;
    }
}
