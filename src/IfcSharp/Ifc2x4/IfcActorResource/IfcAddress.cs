using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcAddress
    {
        public IfcAddressTypeEnum Purpose { get; set; }
        public string Description { get; set; }
        public string UserDefinedPurpose { get; set; }

	
//ENTITY IfcAddress
//  ABSTRACT SUPERTYPE OF	(ONEOF(IfcPostalAddress, IfcTelecomAddress));
//      Purpose	 : 	OPTIONAL IfcAddressTypeEnum;
//      Description	 : 	OPTIONAL IfcText;
//      UserDefinedPurpose	 : 	OPTIONAL IfcLabel;
//  INVERSE
//      OfPerson	 : 	SET OF IfcPerson FOR Addresses;
//      OfOrganization	 : 	SET OF IfcOrganization FOR Addresses;
//  WHERE
//      WR1	 : 	(NOT(EXISTS(Purpose))) OR ((Purpose <> IfcAddressTypeEnum.USERDEFINED) OR ((Purpose = IfcAddressTypeEnum.USERDEFINED) AND EXISTS(SELF.UserDefinedPurpose)));
//END_ENTITY;
    }
}
