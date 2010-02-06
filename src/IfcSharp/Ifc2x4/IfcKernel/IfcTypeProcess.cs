using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcTypeProcess : IfcTypeObject
    {
        public IfcIdentifier Identification { get; set; }

        public IfcText LongDescription { get; set; }

        public IfcLabel ProcessType { get; set; }

        //ENTITY IfcTypeProcess
        //  ABSTRACT SUPERTYPE	
        //  SUBTYPE OF (	IfcTypeObject);
        //      Identification	 : 	OPTIONAL IfcIdentifier;
        //      LongDescription	 : 	OPTIONAL IfcText;
        //      ProcessType	 : 	OPTIONAL IfcLabel;
        //  INVERSE
        //      Nests	 : 	SET [0:1] OF IfcRelNests FOR RelatedObjects;
        //      IsNestedBy	 : 	SET OF IfcRelNests FOR RelatingObject;
        //      OperatesOn	 : 	SET OF IfcRelAssignsToProcess FOR RelatingProcess;
        //END_ENTITY;
    }
}
