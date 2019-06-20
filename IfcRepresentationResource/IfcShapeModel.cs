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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcRepresentationResource
{
	[Guid("96fc3c5f-dd42-4a80-aea3-295fbe743fa9")]
	public abstract partial class IfcShapeModel : IfcRepresentation
	{
		[InverseProperty("ShapeRepresentations")] 
		[Description("Reference to the shape aspect, for which it is the shape representation.")]
		[MaxLength(1)]
		public ISet<IfcShapeAspect> OfShapeAspect { get; protected set; }
	
	
		protected IfcShapeModel(IfcRepresentationContext contextOfItems, IfcRepresentationItem[] items)
			: base(contextOfItems, items)
		{
			this.OfShapeAspect = new HashSet<IfcShapeAspect>();
		}
	
	
	}
	
}
