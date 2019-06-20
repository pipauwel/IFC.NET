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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("8606dc84-8a2a-415b-8415-b98039c064b8")]
	public partial class IfcCurveBoundedSurface : IfcBoundedSurface
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The surface to be bounded.")]
		[Required()]
		public IfcSurface BasisSurface { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The outer boundary of the surface.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcBoundaryCurve> Boundaries { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Required()]
		public IfcBoolean ImplicitOuter { get; set; }
	
	
		public IfcCurveBoundedSurface(IfcSurface basisSurface, IfcBoundaryCurve[] boundaries, IfcBoolean implicitOuter)
		{
			this.BasisSurface = basisSurface;
			this.Boundaries = new HashSet<IfcBoundaryCurve>(boundaries);
			this.ImplicitOuter = implicitOuter;
		}
	
	
	}
	
}
