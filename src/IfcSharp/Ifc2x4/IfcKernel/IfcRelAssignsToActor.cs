using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcRelAssignsToActor<T> : IfcRelAssigns
    {
        public IfcActor<T> RelatingActor { get; set; }

        public IfcActorRole ActingRole { get; set; }

        //ENTITY IfcRelAssignsToActor
        //  SUBTYPE OF (	IfcRelAssigns);
        //      RelatingActor	 : 	IfcActor;
        //      ActingRole	 : 	OPTIONAL IfcActorRole;
        //  WHERE
        //      NoSelfReference	 : 	SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingActor :=: Temp)) = 0;
        //END_ENTITY;
    }
}
