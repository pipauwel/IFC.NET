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
	[Guid("0d2b893e-3ec9-4095-b85b-a545df35355d")]
	public partial class IfcWindowPanelProperties : IfcPropertySetDefinition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Types of window panel operations. Also used to assign standard symbolic presentations according to national building standards.")]
		[Required()]
		public IfcWindowPanelOperationEnum OperationType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Position of this panel within the overall window style.")]
		[Required()]
		public IfcWindowPanelPositionEnum PanelPosition { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Depth of panel frame, measured from front face to back face horizontally (i.e. perpendicular to the window (elevation) plane.")]
		public IfcPositiveLengthMeasure? FrameDepth { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Width of panel frame, measured from inside of panel (at glazing) to outside of panel (at lining), i.e. parallel to the window (elevation) plane.")]
		public IfcPositiveLengthMeasure? FrameThickness { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("Optional link to a shape aspect definition, which points to the part of the geometric representation of the window style, which is used to represent the panel.")]
		public IfcShapeAspect ShapeAspectStyle { get; set; }
	
	
		public IfcWindowPanelProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcWindowPanelOperationEnum operationType, IfcWindowPanelPositionEnum panelPosition)
			: base(globalId, ownerHistory)
		{
			this.OperationType = operationType;
			this.PanelPosition = panelPosition;
		}
	
	
	}
	
}
