using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcTelecomAddress : IfcAddress
    {
        public List<string> TelephoneNumbers { get; set; }
        public List<string> FacsimileNumber { get; set; }
        public string PagerNumber { get; set; }
        public List<string> ElectronicMailAddresses { get; set; }
        public string WWWHomePageURL { get; set; }
        public List<string> MessagingIDs { get; set; }


        //ENTITY IfcTelecomAddress
        //  SUBTYPE OF (	IfcAddress);
        //      TelephoneNumbers	 : 	OPTIONAL LIST [1:?] OF IfcLabel;
        //      FacsimileNumbers	 : 	OPTIONAL LIST [1:?] OF IfcLabel;
        //      PagerNumber	 : 	OPTIONAL IfcLabel;
        //      ElectronicMailAddresses	 : 	OPTIONAL LIST [1:?] OF IfcLabel;
        //      WWWHomePageURL	 : 	OPTIONAL IfcLabel;
        //      MessagingIDs	 : 	OPTIONAL LIST [1:?] OF IfcLabel;
        //  WHERE
        //      MinimumDataProvided	 : 	EXISTS (TelephoneNumbers) OR EXISTS (PagerNumber) OR EXISTS (FacsimileNumbers) OR EXISTS (ElectronicMailAddresses) OR EXISTS (WWWHomePageURL) OR EXISTS (MessagingIDs);
        //END_ENTITY;

        //  IFC 2x4 change: added attribute MessagingIDs.
    }
}