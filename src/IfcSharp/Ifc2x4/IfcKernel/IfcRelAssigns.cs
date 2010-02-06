using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcRelAssigns : IfcRelationship
    {
        public virtual HashSet<IfcObjectDefinition> RelatedObjects { get; set; }
        public virtual IfcObjectTypeEnum RelatedObjectType { get; set; }

        //ENTITY IfcRelAssigns
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcRelAssignsToProcess, IfcRelAssignsToProduct, IfcRelAssignsToControl, IfcRelAssignsToResource, IfcRelAssignsToActor, IfcRelAssignsToGroup, IfcRelAssignsToContext))
        //  SUBTYPE OF (	IfcRelationship);
        //      RelatedObjects	 : 	SET [1:?] OF IfcObjectDefinition;
        //      RelatedObjectsType	 : 	OPTIONAL IfcObjectTypeEnum;
        //  WHERE
        //      WR1	 : 	IfcCorrectObjectAssignment(RelatedObjectsType, RelatedObjects);
        //END_ENTITY;
    }
}