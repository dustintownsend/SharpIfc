using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcProxy
    {

        public IfcObjectTypeEnum ProxyType { get; set; }

        public IfcLabel Tag { get; set; }

        //ENTITY IfcProxy
        //  SUBTYPE OF (	IfcProduct);
        //      ProxyType	 : 	IfcObjectTypeEnum;
        //      Tag	 : 	OPTIONAL IfcLabel;
        //  WHERE
        //      WR1	 : 	EXISTS(SELF\IfcRoot.Name);
        //END_ENTITY;
    }
}
