using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcActorRole
    {
        public IfcRoleEnum Role { get; set; }
        public IfcLabel UserDefinedRole { get; set; }
        public string Description { get; set; }

        //ENTITY IfcActorRole;
        //  ENTITY IfcActorRole;
        //      Role	 : 	IfcRoleEnum;
        //      UserDefinedRole	 : 	OPTIONAL IfcLabel;
        //      Description	 : 	OPTIONAL IfcText;
        //  INVERSE
        //      HasExternalReference	 : 	SET OF IfcExternalReferenceRelationship FOR RelatedResourceObjects;
        //END_ENTITY;

    }
}
