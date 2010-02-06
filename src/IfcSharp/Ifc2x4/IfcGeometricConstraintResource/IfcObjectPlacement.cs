using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcObjectPlacement
    {
        //ENTITY IfcObjectPlacement
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcGridPlacement, IfcLocalPlacement));
        //  INVERSE
        //      PlacesObject	 : 	SET [1:?] OF IfcProduct FOR ObjectPlacement;
        //      ReferencedByPlacements	 : 	SET OF IfcLocalPlacement FOR PlacementRelTo;
        //END_ENTITY;
    }
}