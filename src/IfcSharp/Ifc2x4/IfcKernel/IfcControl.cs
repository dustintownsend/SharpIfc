using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcControl : IfcObject
    {

        //ENTITY IfcControl
        //  ABSTRACT SUPERTYPE	
        //  SUBTYPE OF (	IfcObject);
        //  INVERSE
        //      Nests	 : 	SET [0:1] OF IfcRelNests FOR RelatedObjects;
        //      IsNestedBy	 : 	SET OF IfcRelNests FOR RelatingObject;
        //      Controls	 : 	SET OF IfcRelAssignsToControl FOR RelatingControl;
        //END_ENTITY;
    }
}
