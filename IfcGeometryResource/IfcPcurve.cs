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

using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("dd30ecc9-e76f-48d9-b2d9-5340b2f0c0b8")]
	public partial class IfcPcurve : IfcCurve,
		IfcCurveOnSurface
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Required()]
		public IfcSurface BasisSurface { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Required()]
		public IfcCurve ReferenceCurve { get; set; }
	
	
		public IfcPcurve(IfcSurface basisSurface, IfcCurve referenceCurve)
		{
			this.BasisSurface = basisSurface;
			this.ReferenceCurve = referenceCurve;
		}
	
	
	}
	
}
