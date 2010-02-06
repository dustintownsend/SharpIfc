using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcRoot
    {
        public virtual Guid GlobalId { get; set; }
        public virtual IfcOwnerHistory OwnerHistory { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        //ENTITY IfcRoot
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcPropertyDefinition, IfcRelationship, IfcObjectDefinition));
        //      GlobalId	 : 	IfcGloballyUniqueId;
        //      OwnerHistory	 : 	IfcOwnerHistory;
        //      Name	 : 	OPTIONAL IfcLabel;
        //      Description	 : 	OPTIONAL IfcText;
        //  UNIQUE
        //      UR1	 : 	GlobalId;
        //END_ENTITY;
    }
}
