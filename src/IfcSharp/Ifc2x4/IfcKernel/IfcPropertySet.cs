using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcPropertySet : IfcPropertySetDefinition
    {
        HashSet<IfcProperty> HasProperties { get; set; }

        //ENTITY IfcPropertySet
        //  SUBTYPE OF (	IfcPropertySetDefinition);
        //      HasProperties	 : 	SET [1:?] OF IfcProperty;
        //  INVERSE
        //      IsDefinedBy	 : 	SET [0:1] OF IfcRelDefinesByTemplate FOR RelatedPropertySets;
        //  WHERE
        //      ExistsName	 : 	EXISTS(SELF\IfcRoot.Name);
        //      UniquePropertyNames	 : 	IfcUniquePropertyName(HasProperties);
        //END_ENTITY;
    }
}
