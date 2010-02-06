using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcGroup : IfcObject
    {

        //ENTITY IfcGroup
        //  SUBTYPE OF (	IfcObject);
        //  INVERSE
        //      IsGroupedBy	 : 	SET OF IfcRelAssignsToGroup FOR RelatingGroup;
        //END_ENTITY;
    }
}
