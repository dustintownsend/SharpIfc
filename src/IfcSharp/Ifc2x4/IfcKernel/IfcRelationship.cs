using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public abstract class IfcRelationship : IfcRoot
    {

    }

    public abstract class IfcRelDecomposes : IfcRelationship
    {

    }

    public abstract class IfcRelAssociates : IfcRelationship
    {

    }

    public abstract class IfcRelDefines : IfcRelationship { }

    public abstract class IfcRelConnects : IfcRelationship { }
}
