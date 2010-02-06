using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcRepresentationContext
    {
        public IfcLabel ContentIdentifier { get; set; }
        public IfcLabel ContextType { get; set; }

        //ENTITY IfcRepresentationContext
        //  ABSTRACT SUPERTYPE OF	(IfcGeometricRepresentationContext);
        //      ContextIdentifier	 : 	OPTIONAL IfcLabel;
        //      ContextType	 : 	OPTIONAL IfcLabel;
        //  INVERSE
        //      RepresentationsInContext	 : 	SET OF IfcRepresentation FOR ContextOfItems;
        //END_ENTITY;
    }
}
