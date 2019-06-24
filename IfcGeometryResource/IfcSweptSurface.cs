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
using BuildingSmart.IFC.IfcProfileResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("f2867726-186b-4245-b97b-1107c4d81252")]
	public abstract partial class IfcSweptSurface : IfcSurface
	{
		[DataMember(Order = 0)] 
		[Description("The curve to be swept in defining the surface. The curve is defined as a profile within the position coordinate system.")]
		[Required()]
		public IfcProfileDef SweptCurve { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Position coordinate system for the placement of the profile within the xy plane of the axis placement.")]
		[Required()]
		public IfcAxis2Placement3D Position { get; set; }
	
	
		protected IfcSweptSurface(IfcProfileDef sweptCurve, IfcAxis2Placement3D position)
		{
			this.SweptCurve = sweptCurve;
			this.Position = position;
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
