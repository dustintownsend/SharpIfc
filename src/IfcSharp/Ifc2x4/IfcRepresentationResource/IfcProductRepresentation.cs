using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcProductRepresentation
    {
        public IfcLabel Name { get; set; }
        public IfcLabel Description { get; set; }
        public List<IfcRepresentation> Representations { get; set; }
        //ENTITY IfcProductRepresentation
        //  SUPERTYPE OF	(ONEOF(IfcProductDefinitionShape, IfcMaterialDefinitionRepresentation));
        //      Name	 : 	OPTIONAL IfcLabel;
        //      Description	 : 	OPTIONAL IfcText;
        //      Representations	 : 	LIST [1:?] OF IfcRepresentation;
        //END_ENTITY;
    }
}
