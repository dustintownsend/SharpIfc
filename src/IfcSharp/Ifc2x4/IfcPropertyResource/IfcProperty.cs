using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcProperty
    {
        public IfcIdentifier Name { get; set; }

        public IfcText Description { get; set; }

        //ENTITY IfcProperty
        //  ABSTRACT SUPERTYPE OF	(ONEOF(IfcComplexProperty, IfcSimpleProperty));
        //      Name	 : 	IfcIdentifier;
        //      Description	 : 	OPTIONAL IfcText;
        //  INVERSE
        //      PartOfPset	 : 	SET OF IfcPropertySet FOR HasProperties;
        //      HasExternalReferences	 : 	SET OF IfcExternalReferenceRelationship FOR RelatedResourceObjects;
        //      IsDefinedBy	 : 	SET [0:1] OF IfcRelDefinesByItemTemplate FOR RelatedProperties;
        //      PropertyForDependance	 : 	SET OF IfcPropertyDependencyRelationship FOR DependingProperty;
        //      PropertyDependsOn	 : 	SET OF IfcPropertyDependencyRelationship FOR DependantProperty;
        //      PartOfComplex	 : 	SET OF IfcComplexProperty FOR HasProperties;
        //END_ENTITY;
    }
}
