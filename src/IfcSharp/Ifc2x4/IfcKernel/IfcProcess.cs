using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcProcess : IfcObject
    {
        public IfcIdentifier Identification { get; set; }

        //ENTITY IfcProcess
        //  ABSTRACT SUPERTYPE	
        //  SUBTYPE OF (	IfcObject);
        //      Identification	 : 	OPTIONAL IfcIdentifier;
        //  INVERSE
        //      Nests	 : 	SET [0:1] OF IfcRelNests FOR RelatedObjects;
        //      IsNestedBy	 : 	SET OF IfcRelNests FOR RelatingObject;
        //      IsPredecessorTo	 : 	SET OF IfcRelSequence FOR RelatingProcess;
        //      IsSuccessorFrom	 : 	SET OF IfcRelSequence FOR RelatedProcess;
        //      OperatesOn	 : 	SET OF IfcRelAssignsToProcess FOR RelatingProcess;
        //END_ENTITY;
    }
}
