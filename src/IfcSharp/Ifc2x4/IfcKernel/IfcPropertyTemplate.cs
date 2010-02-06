using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcPropertyTemplate : IfcPropertyItemDefinition
    {
        public IfcPropertyTemplateTypeEnum PropertyType { get; set; }
        public string PrimaryDataType { get; set; }
        public string SecondaryDataType { get; set; }
        public IfcUnit PrimaryUnit { get; set; }
        public IfcUnit SecondaryUnit { get; set; }
        public IfcStateEnum AccessState { get; set; }
        public List<IfcPropertyTemplate> HasPropertyTemplates { get; set; }

        //ENTITY IfcPropertyTemplate
        //  SUBTYPE OF (	IfcPropertyItemDefinition);
        //      PropertyType	 : 	IfcPropertyTemplateTypeEnum;
        //      PrimaryDataType	 : 	OPTIONAL IfcIdentifier;
        //      SecondaryDataType	 : 	OPTIONAL IfcIdentifier;
        //      PrimaryUnit	 : 	OPTIONAL IfcUnit;
        //      SecondaryUnit	 : 	OPTIONAL IfcUnit;
        //      AccessState	 : 	OPTIONAL IfcStateEnum;
        //      HasPropertyTemplates	 : 	OPTIONAL SET [1:?] OF IfcPropertyTemplate;
        //  INVERSE
        //      PartOfPropertyTemplate	 : 	SET OF IfcPropertyTemplate FOR HasPropertyTemplates;
        //      PartOfPsetTemplate	 : 	SET OF IfcPropertySetTemplate FOR HasPropertyTemplates;
        //      Defines	 : 	IfcRelDefinesByItemTemplate FOR RelatingTemplate;
        //  WHERE
        //      CorrectDecomposition	 : 	((PropertyType = IfcPropertyTemplateTypeEnum.COMPLEX) AND EXISTS(HasPropertyTemplates)) XOR ((PropertyType <> IfcPropertyTemplateTypeEnum.COMPLEX) AND NOT(EXISTS(HasPropertyTemplates))) ;
        //END_ENTITY;
    }
}