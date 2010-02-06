using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcActor<T> : IfcObject
    {
        public virtual T TheActor { get; set; }

        //ENTITY IfcActor
        //  SUBTYPE OF (	IfcObject);
        //      TheActor	 : 	IfcActorSelect;
        //  INVERSE
        //      IsActingUpon	 : 	SET OF IfcRelAssignsToActor FOR RelatingActor;
        //END_ENTITY;
    }

    public class IfcRelAssignsToContext
    {
    }

    public class IfcRelAssignsToControl
    {
    }

    public class IfcRelAssignsToGroup
    {
    }

    public class IfcRelAssignsToGroupByFactor
    {
    }

    public class IfcRelAssignsToProcess
    {
    }

    public class IfcRelAssignsToProduct
    {
    }

    public class IfcRelAssignsToResource
    {
    }

    public class IfcRelAssociates
    {
    }

    public class IfcRelAssociatesClassification
    {
    }

    public class IfcRelAssociatesDocument
    {
    }

    public class IfcRelAssociatesLibrary
    {
    }

    public class IfcRelConnects
    {
    }

    public class IfcRelDecomposes
    {
    }

    public class IfcRelDefines
    {
    }

    public class IfcRelDefinesByItemTemplate
    {
    }

    public class IfcRelDefinesByObject
    {
    }

    public class IfcRelDefinesByProperties
    {
    }

    public class IfcRelDefinesByTemplate
    {
    }

    public class IfcRelDefinesByType
    {
    }

}