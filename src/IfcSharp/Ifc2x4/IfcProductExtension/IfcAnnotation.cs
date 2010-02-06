using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4.IfcProductExtension
{
    public class IfcAnnotation
    {
    }

    public class IfcBuilding
    {
    }

    public class IfcBuildingElement
    {
    }

    public class IfcBuildingElementType
    {
    }

    public class IfcBuildingStorey
    {
    }

    public class IfcDistributionElement
    {
    }

    public class IfcDistributionElementType
    {
    }

    public class IfcElement
    {
    }

    public class IfcElementAssembly
    {
    }

    public class IfcElementAssemblyType
    {
    }

    public class IfcElementQuantity
    {
    }

    public class IfcElementType
    {
    }

    public class IfcExternalSpatialElement
    {
    }

    public class IfcExternalSpatialStructureElement
    {
    }

    public class IfcFeatureElement
    {
    }

    public class IfcFeatureElementAddition
    {
    }

    public class IfcFeatureElementSubtraction
    {
    }

    public class IfcFurnishingElement
    {
    }

    public class IfcFurnishingElementType
    {
    }

    public class IfcGeographicElement
    {
    }

    public class IfcGeographicElementType
    {
    }

    public class IfcGrid
    {
    }

    public class IfcOpeningElement
    {
    }

    public class IfcOpeningStandardCase
    {
    }

    public class IfcPort
    {
    }

    public class IfcProjectionElement
    {
    }

    public class IfcRelAssociatesMaterial
    {
    }

    public class IfcRelConnectsElements
    {
    }

    public class IfcRelConnectsPortToElement
    {
    }

    public class IfcRelConnectsPorts
    {
    }

    public class IfcRelConnectsWithRealizingElements
    {
    }

    public class IfcRelContainedInSpatialStructure
    {
    }

    public class IfcRelFillsElement
    {
    }

    public class IfcRelInterferesElements
    {
    }

    public class IfcRelProjectsElement
    {
    }

    public class IfcRelReferencedInSpatialStructure
    {
    }

    public class IfcRelServicesBuildings
    {
    }

    public class IfcRelSpaceBoundary
    {
    }

    public class IfcRelSpaceBoundary1stLevel
    {
    }

    public class IfcRelSpaceBoundary2ndLevel
    {
    }

    public class IfcRelVoidsElement
    {
    }

    public class IfcSite
    {
    }

    public class IfcSpace
    {
    }

    public class IfcSpaceType
    {
    }

    public class IfcSpatialElement
    {
    }

    public class IfcSpatialElementType
    {
    }

    public class IfcSpatialStructureElement
    {
    }

    public class IfcSpatialStructureElementType
    {
    }

    public class IfcSpatialZone
    {
    }

    public class IfcSpatialZoneType
    {
    }

    public class IfcSystem
    {
    }

    public class IfcTransportElement
    {
    }

    public class IfcTransportElementType
    {
    }

    public class IfcVirtualElement
    {
    }

    public class IfcZone
    {
    }

    /// <summary>
    /// Definition from IAI: Enumeration defining where the assembly is intended to take place, either in a factory or on the building site.
    /// </summary>
    /// <remarks>HISTORY New enumeration in Release IFC2x Edition 2.</remarks>
    public enum IfcAssemblyPlaceEnum
    {
        /// <summary>
        /// this assembly is assembled on site
        /// </summary>
        SITE,

        /// <summary>
        /// this assembly is assembled in a factor
        /// </summary>
        FACTORY,

        /// <summary>
        /// Undefined assembly place
        /// </summary>
        NOTDEFINED
    }

    /// <summary>
    /// Definition from IAI: An enumeration defining the basic configuration types for element assemblies.
    /// </summary>
    /// <remarks>HISTORY New enumeration type in Release IFC2x Edition 2.</remarks>
    public enum IfcElementAssemblyTypeEnum
    {
        /// <summary>
        /// Assembled accessories or components
        /// </summary>
        ACCESSORY_ASSEMBLY,

        /// <summary>
        /// A curved structure
        /// </summary>
        ARCH,

        /// <summary>
        /// Interconnected beams, located in one (typically horizontal) plane
        /// </summary>
        BEAM_GRID,

        /// <summary>
        /// A rigid frame with additional bracing members
        /// </summary>
        BRACED_FRAME,

        /// <summary>
        /// A beam-like superstructure
        /// </summary>
        GIRDER,

        /// <summary>
        /// Assembled reinforcement elements
        /// </summary>
        REINFORCEMENT_UNIT,

        /// <summary>
        /// A structure built up of beams, columns, etc. with moment-resisting joints
        /// </summary>
        RIGID_FRAME,

        /// <summary>
        /// Slabs, laid out in one plane
        /// </summary>
        SLAB_FIELD,

        /// <summary>
        /// A structure built up of members with (quasi) pinned joints
        /// </summary>
        TRUSS,

        /// <summary>
        /// User-defined element assembly
        /// </summary>
        USERDEFINED,

        /// <summary>
        /// Undefined element assembly
        /// </summary>
        NOTDEFINED
    }

    /// <summary>
    /// Definition from IAI: Enumeration that provides an indication of the spatial structure element or proxy represented:
    /// </summary>
    /// <remarks>HISTORY New enumeration in IFC Release 2.x</remarks>
    public enum IfcElementCompositionEnum
    {
        /// <summary>
        /// a group or aggregation of similar elements
        /// </summary>
        COMPLEX,

        /// <summary>
        /// a (undivided) element itself
        /// </summary>
        ELEMENT,

        /// <summary>
        /// a subelement or part
        /// </summary>
        PARTIAL
    }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>HISTORY New enumeration in IFC2x4.</remarks>
    /// TODO: CHECK ON NEXT IFC RELEASE
    public enum IfcExternalSpatialElementTypeEnum
    {
        /// <summary>
        /// External air space around the building.
        /// </summary>
        EXTERNAL,

        /// <summary>
        /// External volume covered by earth around the building.
        /// </summary>
        EXTERNAL_EARTH,

        /// <summary>
        /// External volume covered with water around the building.
        /// </summary>
        EXTERNAL_WATER,

        /// <summary>
        /// Space occupied by a neighboring building.
        /// </summary>
        EXTERNAL_FIRE,

        /// <summary>
        /// User defined external spatial element type
        /// </summary>
        USERDEFINED,

        /// <summary>
        /// Undefined external spatial element type
        /// </summary>
        NOTDEFINED
    }

    /// <summary>
    /// 
    /// </summary>
    /// TODO: CHECK ON NEXT IFC RELEASE
    public enum IfcGeographicElementTypeEnum
    {
        USERDEFINED,
        NOTDEFINED
    }

    /// <summary>
    /// Definition from IAI: This enumeration defines the different types of space boundaries in terms of 
    /// either being inside the building or outside the building.
    /// </summary>
    /// <remarks>
    /// HISTORY: New enumeration in IFC Release 2.0
    /// IFC2x4 CHANGE: Enumeration no longer applicable to IfcSpace. 
    /// The following enumerators are added: EXTERNAL_EARTH, EXTERNAL_WATER, EXTERNAL_FIRE
    /// </remarks>
    public enum IfcInternalOrExternalEnum
    {
        /// <summary>
        /// The <see cref="IfcSpaceBoundary"/> faces a physical or virtual element where there is an internal space on the other side.
        /// </summary>
        INTERNAL,

        /// <summary>
        /// The <see cref="IfcSpaceBoundary"/> faces a physical or virtual element where there is an external space on the other side (i.e. air). Or it is the space boundary of that external space against the building.
        /// </summary>
        EXTERNAL,

        /// <summary>
        /// The <see cref="IfcSpaceBoundary"/> faces a physical or virtual element where there is earth (or terrain) on the other side. Or it is the space boundary of that earth (or terrain object) external space against the building.
        /// </summary>
        EXTERNAL_EARTH,

        /// <summary>
        /// The <see cref="IfcSpaceBoundary"/> faces a physical or virtual element where there is water (water component of terrain) on the other side. Or it is the space boundary of that object representing water external space against the building.
        /// </summary>
        EXTERNAL_WATER,

        /// <summary>
        /// The <see cref="IfcSpaceBoundary"/> faces a physical or virtual element where there is another building on the other side. Or it is the space boundary of that other neighbor building against the building in question.
        /// </summary>
        EXTERNAL_FIRE,

        /// <summary>
        /// No information available.
        /// </summary>
        NOTDEFINED
    }

    /// <summary>
    /// Definition from IAI: This enumeration defines the different types of space boundaries in terms of its physical manifestation. 
    /// A space boundary can either be physically dividing or can be a virtual divider.
    /// </summary>
    /// <remarks>HISTORY: New enumeration in IFC Release 2.0</remarks>
    public enum IfcPhysicalOrVirtualEnum
    {
        /// <summary>
        /// The space boundary is provided physically, i.e. by an physical element.
        /// </summary>
        PHYSICAL,

        /// <summary>
        /// The space boundary is provided virtually, i.e. by a logical divider that has no physical manifestation.
        /// </summary>
        VIRTUAL,

        /// <summary>
        /// No information available.
        /// </summary>
        NOTDEFINED
    }

    /// <summary>
    /// Definition from IAI: This enumeration defines the available generic types for IfcSpace and IfcSpaceType.
    /// </summary>
    /// <remarks>
    /// HISTORY New enumeration in IFC2x Edition 3.
    /// IFC2x4 CHANGE The enumerators INTERNAL and EXTERNAL have been added for upward compatibility to replace InteriorOrExteriorSpace usage.
    ///</remarks>
    [Obsolete("Deprecated and only provided for backward compatibility purposes")]
    public enum IfcSpaceTypeEnum
    {
        INTERNAL,

        EXTERNAL,

        USERDEFINED,

        NOTDEFINED
    }

    /// <summary>
    /// Definition from IAI: This enumeration defines the range of different types of spatial zones that can further specify an IfcSpatialZoneTypeEnum.
    /// </summary>
    /// <remarks>HISTORY New enumeration in IFC Release 2x Edition 4.</remarks>
    public enum IfcSpatialZoneTypeEnum
    {
        /// <summary>
        /// the spatial zone is used to represent a construction zone for the production process.
        /// </summary>
        CONSTRUCTION,

        /// <summary>
        /// the spatial zone is used to represent a fire safety zone, or fire compartment.
        /// </summary>
        FIRESAFETY,

        /// <summary>
        /// the spatial zone is used to represent a lighting zone, e.g. a daylight zone, or a artificial lighting zone.
        /// </summary>
        LIGHTING,

        /// <summary>
        /// the spatial zone is used to represent a zone of particular occupancy.
        /// </summary>
        OCCUPANCY,

        /// <summary>
        /// the spatial zone is used to represent a zone for security planning and maintenance work.
        /// </summary>
        SECURITY,

        /// <summary>
        /// the spatial zone is used to represent a thermal zone.
        /// </summary>
        THERMAL,

        /// <summary>
        /// user defined type spatial zone.
        /// </summary>
        USERDEFINED,

        /// <summary>
        /// undefined type spatial zone.
        /// </summary>
        NOTDEFINE
    }

    /// <summary>
    /// Definition from IAI: This enumeration is used to identify primary transport element types.
    /// </summary>
    /// <remarks>
    /// HISTORY  New enumeration in IFC Release 2x.
    /// IFC2x4 CHANGE  New enumerator CRANEWAY added in IFC2x4.
    /// </remarks>
    public enum IfcTransportElementTypeEnum
    {
        /// <summary>
        /// Elevator or lift being a transport device to move people of good vertically.
        /// </summary>
        ELEVATOR,

        /// <summary>
        /// Escalator being a transport device to move people. It consists of individual linked steps that move up and down on tracks while keeping the threads horizontal.
        /// </summary>
        ESCALATOR,

        /// <summary>
        /// Moving walkway being a transport device to move people horizontally or on an incline. It is a slow conveyor belt that transports people.
        /// </summary>
        MOVINGWALKWAY,

        /// <summary>
        /// A crane way system, normally including the crane rails, fasteners and the crane. It is primarily used to move heavy goods in a factory or other industry buildings.
        /// </summary>
        CRANEWAY,

        /// <summary>
        /// User defined transport element type.
        /// </summary>
        USERDEFINED,

        /// <summary>
        /// Undefined transport element type.
        /// </summary>
        NOTDEFINED
    }

}
