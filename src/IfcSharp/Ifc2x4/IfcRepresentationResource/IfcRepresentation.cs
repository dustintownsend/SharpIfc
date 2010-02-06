using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcRepresentation
    {
        public virtual IfcRepresentationContext ContextOfItems { get; set; }
        public virtual IfcLabel RepresentationIdentifier { get; set; }
        public virtual IfcLabel RepresentationType { get; set; }
        public virtual HashSet<IfcRepresentationItem> Items { get; set; }

        //ENTITY IfcRepresentation
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcStyleModel, IfcShapeModel));
        //      ContextOfItems	 : 	IfcRepresentationContext;
        //      RepresentationIdentifier	 : 	OPTIONAL IfcLabel;
        //      RepresentationType	 : 	OPTIONAL IfcLabel;
        //      Items	 : 	SET [1:?] OF IfcRepresentationItem;
        //  INVERSE
        //      RepresentationMap	 : 	SET [0:1] OF IfcRepresentationMap FOR MappedRepresentation;
        //      LayerAssignments	 : 	SET OF IfcPresentationLayerAssignment FOR AssignedItems;
        //      OfProductRepresentation	 : 	SET OF IfcProductRepresentation FOR Representations;
        //END_ENTITY;
    }
}
