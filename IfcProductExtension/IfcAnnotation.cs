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
	[Guid("34d6582a-8218-4a4c-9073-fdbe06d6d40a")]
	public partial class IfcAnnotation : IfcProduct
	{
		[InverseProperty("RelatedElements")] 
		[Description("Relationship to a spatial structure element, to which the associate is primarily associated.")]
		[MaxLength(1)]
		public ISet<IfcRelContainedInSpatialStructure> ContainedInStructure { get; protected set; }
	
	
		public IfcAnnotation(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.ContainedInStructure = new HashSet<IfcRelContainedInSpatialStructure>();
		}
	
	
	}
	
}
