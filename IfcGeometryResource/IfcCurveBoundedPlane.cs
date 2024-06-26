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
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("e3f2858e-1dfd-4bcb-b2a8-e0c8e64b4e6a")]
	public partial class IfcCurveBoundedPlane : IfcBoundedSurface
	{
		[DataMember(Order = 0)] 
		[Description("The surface to be bound.")]
		[Required()]
		public IfcPlane BasisSurface { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The outer boundary of the surface.")]
		[Required()]
		public IfcCurve OuterBoundary { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("An optional set of inner boundaries. They shall not intersect each other or the outer boundary.")]
		[Required()]
		public ISet<IfcCurve> InnerBoundaries { get; protected set; }
	
	
		public IfcCurveBoundedPlane(IfcPlane basisSurface, IfcCurve outerBoundary, IfcCurve[] innerBoundaries)
		{
			this.BasisSurface = basisSurface;
			this.OuterBoundary = outerBoundary;
			this.InnerBoundaries = new HashSet<IfcCurve>(innerBoundaries);
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
