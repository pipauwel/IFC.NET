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
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("75ae2131-56ed-42b5-9e52-3b0346c0d442")]
	public partial class IfcAnnotation : IfcProduct
	{
		[InverseProperty("RelatedElements")] 
		[Description("Relationship to a spatial structure element, to which the associate is primarily associated.")]
		[MaxLength(1)]
		public ISet<IfcRelContainedInSpatialStructure> ContainedInStructure { get; protected set; }
	
	
		public IfcAnnotation(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.ContainedInStructure = new HashSet<IfcRelContainedInSpatialStructure>();
		}
	
	
	}
	
}
