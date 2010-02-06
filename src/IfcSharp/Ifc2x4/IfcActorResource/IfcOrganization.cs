using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcOrganization
    {

        public Guid Identification { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IfcActorRole> Roles { get; set; }
        public List<IfcAddress> Addresses { get; set; }

        //ENTITY IfcOrganization;
        //  Identification	 : 	OPTIONAL IfcIdentifier;
        //  Name	 : 	IfcLabel;
        //  Description	 : 	OPTIONAL IfcText;
        //  Roles	 : 	OPTIONAL LIST [1:?] OF IfcActorRole;
        //  Addresses	 : 	OPTIONAL LIST [1:?] OF IfcAddress;
        //INVERSE
        //  IsRelatedBy	 : 	SET OF IfcOrganizationRelationship FOR RelatedOrganizations;
        //  Relates	 : 	SET OF IfcOrganizationRelationship FOR RelatingOrganization;
        //  Engages	 : 	SET OF IfcPersonAndOrganization FOR TheOrganization;
        //END_ENTITY;

        //  IFC 2x4 change: attribute Id renamed to Identification
    }
}
