using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcRepresentationItem
    {


        //ENTITY IfcRepresentationItem
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcTopologicalRepresentationItem, IfcGeometricRepresentationItem, IfcMappedItem, IfcStyledItem));
        //  INVERSE
        //      LayerAssignments	 : 	SET OF IfcPresentationLayerAssignment FOR AssignedItems;
        //      StyledByItem	 : 	SET [0:1] OF IfcStyledItem FOR Item;
        //END_ENTITY;
    }
}
