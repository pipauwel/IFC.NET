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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("dab1861e-d96c-4f3d-b54a-bbd4034f8cc6")]
	public abstract partial class IfcProduct : IfcObject
	{
		[DataMember(Order = 0)] 
		[Description("Placement of the product in space, the placement can either be absolute (relative to the world coordinate system), relative (relative to the object placement of another product), or constraint (e.g. relative to grid axes). It is determined by the various subtypes of IfcObjectPlacement, which includes the axis placement information to determine the  transformation for the object coordinate system.")]
		public IfcObjectPlacement ObjectPlacement { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Reference to the representations of the product, being either a representation (IfcProductRepresentation) or as a special case a shape representations (IfcProductDefinitionShape). The product definition shape provides for multiple geometric representations of the shape property of the object within the same object coordinate system, defined by the object placement.")]
		public IfcProductRepresentation Representation { get; set; }
	
		[InverseProperty("RelatingProduct")] 
		[Description("Reference to the IfcRelAssignsToProduct relationship, by which other subtypes of IfcObject can be related to the product.")]
		public ISet<IfcRelAssignsToProduct> ReferencedBy { get; protected set; }
	
	
		protected IfcProduct(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.ReferencedBy = new HashSet<IfcRelAssignsToProduct>();
		}
	
	
	}
	
}
