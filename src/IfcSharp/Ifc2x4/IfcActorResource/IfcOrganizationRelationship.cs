using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcOrganizationRelationship
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IfcOrganization RelatingOrganization { get; set; }
        public List<IfcOrganization> RelatedOrganizations { get; set; }

        //ENTITY IfcOrganizationRelationship;
        //  Name	 : 	OPTIONAL IfcLabel;
        //  Description	 : 	OPTIONAL IfcText;
        //  RelatingOrganization	 : 	IfcOrganization;
        //  RelatedOrganizations	 : 	SET [1:?] OF IfcOrganization;
        //END_ENTITY;

        //  HISTORY New entity in IFC Release 2x.
        //  IFC 2x4 change: attribute Name made optional.
    }
}
