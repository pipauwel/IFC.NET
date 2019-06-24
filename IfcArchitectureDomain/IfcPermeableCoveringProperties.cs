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
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcArchitectureDomain
{
	[Guid("03425406-b295-412a-b30a-b2ce3e274218")]
	public partial class IfcPermeableCoveringProperties : IfcPropertySetDefinition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Types of permeable covering operations. Also used to assign standard symbolic presentations according to national building standards.")]
		[Required()]
		public IfcPermeableCoveringOperationEnum OperationType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Position of this permeable covering panel within the overall window or door type.")]
		[Required()]
		public IfcWindowPanelPositionEnum PanelPosition { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Depth of panel frame (used to include the permeable covering), measured from front face to back face horizontally (i.e. perpendicular to the window or door (elevation) plane.")]
		public IfcPositiveLengthMeasure? FrameDepth { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Width of panel frame (used to include the permeable covering), measured from inside of panel (at permeable covering) to outside of panel (at lining), i.e. parallel to the window or door (elevation) plane.")]
		public IfcPositiveLengthMeasure? FrameThickness { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("Optional link to a shape aspect definition, which points to the part of the geometric representation of the window style, which is used to represent the permeable covering.")]
		public IfcShapeAspect ShapeAspectStyle { get; set; }
	
	
		public IfcPermeableCoveringProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcPermeableCoveringOperationEnum operationType, IfcWindowPanelPositionEnum panelPosition)
			: base(globalId, ownerHistory)
		{
			this.OperationType = operationType;
			this.PanelPosition = panelPosition;
		}
	
	
	}
	
}
