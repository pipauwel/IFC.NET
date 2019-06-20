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
	[Guid("bae52a64-1034-464e-8c4d-a00aa45bafa0")]
	public partial class IfcRelSpaceBoundary1stLevel : IfcRelSpaceBoundary
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Reference to the host, or parent, space boundary within which this inner boundary is defined.")]
		public IfcRelSpaceBoundary1stLevel ParentBoundary { get; set; }
	
		[InverseProperty("ParentBoundary")] 
		[Description("Reference to the inner boundaries of the space boundary. Inner boundaries are defined by the space boundaries of openings, doors and windows.")]
		public ISet<IfcRelSpaceBoundary1stLevel> InnerBoundaries { get; protected set; }
	
	
		public IfcRelSpaceBoundary1stLevel(IfcGloballyUniqueId globalId, IfcSpaceBoundarySelect relatingSpace, IfcElement relatedBuildingElement, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary, IfcInternalOrExternalEnum internalOrExternalBoundary)
			: base(globalId, relatingSpace, relatedBuildingElement, physicalOrVirtualBoundary, internalOrExternalBoundary)
		{
			this.InnerBoundaries = new HashSet<IfcRelSpaceBoundary1stLevel>();
		}
	
	
	}
	
}
