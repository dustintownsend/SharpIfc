using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    /// <summary>
    /// Definition from IAI: An IfcContext is the generalization of a project context in which objects, type objects, property sets, and properties are defined. 
    /// The IfcProject as subtype of IfcContext provides the context for all information on a construction project, it may include an IfcProjectLibrary as subtype 
    /// of IfcContext to register the included libraries for the project.
    /// </summary>
    /// <remarks>HISTORY  New abstract entity in IFC2x4.</remarks>
    public abstract class IfcContext : IfcObjectDefinition
    {
        public virtual IfcLabel ObjectType { get; set; }
        public virtual IfcLabel LongName { get; set; }
        public virtual IfcLabel Phase { get; set; }

        //ENTITY IfcContext
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcProject, IfcProjectLibrary))
        //  SUBTYPE OF (	IfcObjectDefinition);
        //      ObjectType	 : 	OPTIONAL IfcLabel;
        //      LongName	 : 	OPTIONAL IfcLabel;
        //      Phase	 : 	OPTIONAL IfcLabel;
        //  INVERSE
        //      IsAssignedTo	 : 	SET OF IfcRelAssignsToContext FOR RelatingContext;
        //END_ENTITY;
    }
}
