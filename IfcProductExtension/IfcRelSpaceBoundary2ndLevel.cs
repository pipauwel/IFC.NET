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
	[Guid("002bda71-0a52-40b9-8ef9-82bc20f96bf3")]
	public partial class IfcRelSpaceBoundary2ndLevel : IfcRelSpaceBoundary1stLevel
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Reference to the other space boundary of the pair of two space boundaries on either side of a space separating thermal boundary element.")]
		public IfcRelSpaceBoundary2ndLevel CorrespondingBoundary { get; set; }
	
		[InverseProperty("CorrespondingBoundary")] 
		[Description("Reference to the other space boundary of the pair of two space boundaries on either side of a space separating thermal boundary element.")]
		[MaxLength(1)]
		public ISet<IfcRelSpaceBoundary2ndLevel> Corresponds { get; protected set; }
	
	
		public IfcRelSpaceBoundary2ndLevel(IfcGloballyUniqueId globalId, IfcSpaceBoundarySelect relatingSpace, IfcElement relatedBuildingElement, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary, IfcInternalOrExternalEnum internalOrExternalBoundary)
			: base(globalId, relatingSpace, relatedBuildingElement, physicalOrVirtualBoundary, internalOrExternalBoundary)
		{
			this.Corresponds = new HashSet<IfcRelSpaceBoundary2ndLevel>();
		}
	
	
	}
	
}
