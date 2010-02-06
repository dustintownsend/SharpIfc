//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace IfcSharp.Ifc2x3tc1.Interfaces
//{
//    public interface IIfcClass
//    {
//        string StepParameter { get; private set; }
//        string StepLine { get; private set; }
//        int StepLineNumber { get; set; }
//    }

//    public interface IIfcRoot
//    {
//        IIfcGloballyUniqueId GlobalId { get; set; }
//        IIfcOwnerHistory OwnerHistory { get; set; }
//        IIfcLabel Name { get; set; }
//        IIfcText Description { get; set; }
//    }

//    public interface IIfcObjectDefinition
//        : IIfcRoot
//    {

//    }

//    public interface IIfcObject
//    {
//        IIfcLabel ObjectType { get; set; }
//    }

//    public interface IIfcControl
//    {

        
//    }

//    public interface IIfcWorkControl
//    {
        
//        IIfcIdentifier Identifier { get; set; }
//        IIfcDateTimeSelect CreationDate { get; set; }
//        List<IIfcPerson> Creators { get; set; }
//        IIfcLabel Purpose { get; set; }
//        IIfcTimeMeasure Duration { get; set; }
//        IIfcTimeMeasure TotalFloat { get; set; }
//        IIfcDateTimeSelect StartTime { get; set; }
//        IIfcDateTimeSelect FinishTime { get; set; }
//        IIfcWorkControlTypeEnum WorkControlType { get; set; }
//        IIfcLabel UserDefinedControlType { get; set; }
//    }

//    public interface IIfcGloballyUniqueId
//    {

//    }

//    public interface IIfcOwnerHistory
//    {
//    }

//    public interface IIfcLabel
//    {

//    }

//    public interface IIfcText
//    {

//    }

//    public interface IIfcIdentifier
//    {

//    }

//    public interface IIfcDateTimeSelect
//    {

//    }

//    public interface IIfcPerson
//    {

//    }

//    public interface IIfcTimeMeasure
//    {

//    }

//    public interface IIfcWorkControlTypeEnum
//    {

//    }

//    public interface IIfcWorkPlan
//    {
        
//    }
//}
