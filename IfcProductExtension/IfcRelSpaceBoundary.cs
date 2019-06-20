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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("b5068876-210f-4343-a93a-674f2a9e63ff")]
	public partial class IfcRelSpaceBoundary : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[Description("Reference to one spaces that is delimited by this boundary.")]
		[Required()]
		public IfcSpaceBoundarySelect RelatingSpace { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Reference to <strike>Building</strike> Element, that defines the Space Boundaries.  <blockquote class=\"change-ifc2x\">IFC2x CHANGE&nbsp; The data type has been changed from <em>IfcBuildingElement</em> to <em>IfcElement</em> with upward compatibility for file based exchange. </blockquote>    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; The attribute has been changed to be mandatory.</blockquote>")]
		[Required()]
		public IfcElement RelatedBuildingElement { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlElement]
		[Description("Physical representation of the space boundary. Provided as a <u>curve or</u> surface given within the LCS of the space.  <blockquote class=\"change-ifc2x\">IFC2x CHANGE&nbsp; The data type has been changed from <em>IfcConnectionSurfaceGeometry</em> to <em>IfcConnectionGeometry</em> with upward compatibility for file based exchange.</blockquote>")]
		public IfcConnectionGeometry ConnectionGeometry { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Defines, whether the Space Boundary is physical (Physical) or virtual (Virtual).")]
		[Required()]
		public IfcPhysicalOrVirtualEnum PhysicalOrVirtualBoundary { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Defines, whether the Space Boundary is internal (Internal), or external, i.e. adjacent to open space (that can be an partially enclosed space, such as terrace (External).")]
		[Required()]
		public IfcInternalOrExternalEnum InternalOrExternalBoundary { get; set; }
	
	
		public IfcRelSpaceBoundary(IfcGloballyUniqueId globalId, IfcSpaceBoundarySelect relatingSpace, IfcElement relatedBuildingElement, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary, IfcInternalOrExternalEnum internalOrExternalBoundary)
			: base(globalId)
		{
			this.RelatingSpace = relatingSpace;
			this.RelatedBuildingElement = relatedBuildingElement;
			this.PhysicalOrVirtualBoundary = physicalOrVirtualBoundary;
			this.InternalOrExternalBoundary = internalOrExternalBoundary;
		}
	
	
	}
	
}
