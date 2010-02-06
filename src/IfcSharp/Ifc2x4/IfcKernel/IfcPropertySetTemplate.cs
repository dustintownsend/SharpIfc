using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcPropertySetTemplate : IfcPropertyItemDefinition
    {

        public IfcPropertySetTemplateTypeEnum PropertySetType { get; set; }
        public string ApplicableEntity { get; set; }
        public List<IfcPropertyTemplate> HasPropertyTemplates { get; set; }

        //ENTITY IfcPropertySetTemplate
        //  SUBTYPE OF (	IfcPropertyItemDefinition);
        //      PropertySetType	 : 	IfcPropertySetTemplateTypeEnum;
        //      ApplicableEntity	 : 	OPTIONAL IfcIdentifier;
        //      HasPropertyTemplates	 : 	SET [1:?] OF IfcPropertyTemplate;
        //  INVERSE
        //      Defines	 : 	SET OF IfcRelDefinesByTemplate FOR RelatingTemplate;
        //  WHERE
        //      ExistsName	 : 	EXISTS(SELF\IfcRoot.Name);
        //      UniquePropertyNames	 : 	IfcUniquePropertyTemplateName(HasPropertyTemplates);
        //END_ENTITY;

        //  HISTORY New Entity in Release IFC 2x4.
    }
}