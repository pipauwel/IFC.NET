// This file may be edited manually or auto-generated using IfcKit at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("f8b65977-9d30-4926-8cba-c173c2ef3216")]
	public partial class IfcDoorLiningProperties : IfcPropertySetDefinition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Depth of the door lining, measured perpendicular to the plane of the door lining. If omitted (and with a given value to lining thickness) it indicates an adjustable depth (i.e. a depth that adjusts to the thickness of the wall into which the occurrence of this door style is inserted).")]
		public IfcPositiveLengthMeasure? LiningDepth { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Thickness (width in plane parallel to door leaf) of the door lining.")]
		public IfcPositiveLengthMeasure? LiningThickness { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Depth (dimension in plane perpendicular to door leaf) of the door threshold. Only given if the door lining includes a threshold. If omitted (and with a given value to threshold thickness) it indicates an adjustable depth (i.e. a depth that adjusts to the thickness of the wall into which the occurrence of this door style is inserted).")]
		public IfcPositiveLengthMeasure? ThresholdDepth { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Thickness (width in plane parallel to door leaf) of the door threshold. Only given if the door lining includes a threshold and the parameter is known.")]
		public IfcPositiveLengthMeasure? ThresholdThickness { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Thickness (width in plane parallel to door leaf) of the transom (if given) which divides the door leaf from a glazing (or window) above.")]
		public IfcPositiveLengthMeasure? TransomThickness { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Offset of the transom (if given) which divides the door leaf from a glazing (or window) above. The offset is given from the bottom of the door opening.")]
		public IfcLengthMeasure? TransomOffset { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("Offset (dimension in plane perpendicular to door leaf) of the door lining. The offset is given as distance to the x axis of the local placement.")]
		public IfcLengthMeasure? LiningOffset { get; set; }
	
		[DataMember(Order = 7)] 
		[XmlAttribute]
		[Description("Offset (dimension in plane perpendicular to door leaf) of the door threshold. The offset is given as distance to the x axis of the local placement. Only given if the door lining includes a threshold and the parameter is known.")]
		public IfcLengthMeasure? ThresholdOffset { get; set; }
	
		[DataMember(Order = 8)] 
		[XmlAttribute]
		[Description("Thickness of the casing (dimension in plane of the door leaf). If given it is applied equally to all four sides of the adjacent wall.")]
		public IfcPositiveLengthMeasure? CasingThickness { get; set; }
	
		[DataMember(Order = 9)] 
		[XmlAttribute]
		[Description("Depth of the casing (dimension in plane perpendicular to door leaf). If given it is applied equally to all four sides of the adjacent wall.")]
		public IfcPositiveLengthMeasure? CasingDepth { get; set; }
	
		[DataMember(Order = 10)] 
		[Description("Pointer to the shape aspect, if given. The shape aspect reflects the part of the door shape, which represents the door lining.")]
		public IfcShapeAspect ShapeAspectStyle { get; set; }
	
	
		public IfcDoorLiningProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
		}
	
	
	}
	
}
