using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcObject : IfcObjectDefinition
    {
        public virtual string ObjectType { get; set; }

        //ENTITY IfcObject
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcActor, IfcControl, IfcGroup, IfcProcess, IfcProduct, IfcResource))
        //  SUBTYPE OF (	IfcObjectDefinition);
        //      ObjectType	 : 	OPTIONAL IfcLabel;
        //  INVERSE
        //      IsDeclaredBy	 : 	SET [0:1] OF IfcRelDefinesByObject FOR RelatedObjects;
        //      Declares	 : 	SET OF IfcRelDefinesByObject FOR RelatingObject;
        //      IsTypedBy	 : 	SET [0:1] OF IfcRelDefinesByType FOR RelatedObjects;
        //      IsDefinedBy	 : 	SET OF IfcRelDefinesByProperties FOR RelatedObjects;
        //END_ENTITY;

        //  IFC2x4 CHANGE The inverse relationships Declares, IsDeclaredBy, and IsTypedBy have been added, types are not longer included in the IsDefinesBy relationship. 
        //                IfcProject has been promoted to be a subtype of IfcObjectDefinition -> IfcContext.
    }
}