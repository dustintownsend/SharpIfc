using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcPersonAndOrganization
    {
        public IfcPerson ThePerson { get; set; }
        public IfcOrganization TheOrganization { get; set; }
        public List<IfcActorRole> Roles { get; set; }

        //ENTITY IfcPersonAndOrganization;
        //  ThePerson	 : 	IfcPerson;
        //  TheOrganization	 : 	IfcOrganization;
        //  Roles	 : 	OPTIONAL LIST [1:?] OF IfcActorRole;
        //END_ENTITY;
    }
}
