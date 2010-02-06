using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcObjectDefinition : IfcRoot
    {


        //ENTITY IfcObjectDefinition
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcObject, IfcTypeObject, IfcContext))
        //  SUBTYPE OF (	IfcRoot);
        //  INVERSE
        //      HasAssignments	 : 	SET OF IfcRelAssigns FOR RelatedObjects;
        //      IsDecomposedBy	 : 	SET OF IfcRelAggregates FOR RelatingObject;
        //      Decomposes	 : 	SET [0:1] OF IfcRelAggregates FOR RelatedObjects;
        //      HasAssociations	 : 	SET OF IfcRelAssociates FOR RelatedObjects;
        //END_ENTITY;

        //  HISTORY New abstract entity in Release IFC2x Edition 3.
        //  IFC2x3 CHANGE The abstract entity IfcObjectDefinition has been added.
        //  IFC2x4 CHANGE A new subtype IfcContext has been added.
    }
}
