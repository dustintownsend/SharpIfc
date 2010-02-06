using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcPostalAddress : IfcAddress
    {
        public string InternalLocation { get; set; }
        public List<string> AddressLines { get; set; }
        public string PostalBox { get; set; }
        public string Town { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        //ENTITY IfcPostalAddress
        //  SUBTYPE OF (	IfcAddress);
        //      InternalLocation	 : 	OPTIONAL IfcLabel;
        //      AddressLines	 : 	OPTIONAL LIST [1:?] OF IfcLabel;
        //      PostalBox	 : 	OPTIONAL IfcLabel;
        //      Town	 : 	OPTIONAL IfcLabel;
        //      Region	 : 	OPTIONAL IfcLabel;
        //      PostalCode	 : 	OPTIONAL IfcLabel;
        //      Country	 : 	OPTIONAL IfcLabel;
        //  WHERE
        //      WR1	 : 	EXISTS (InternalLocation) OR EXISTS (AddressLines) OR EXISTS (PostalBox) OR EXISTS (PostalCode) OR EXISTS (Town) OR EXISTS (Region) OR EXISTS (Country);
        //END_ENTITY;
    }
}