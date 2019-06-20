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
	[Guid("1548cb11-3dfc-4d82-ac51-6413bb5ccb3d")]
	public partial class IfcCompositeCurveOnSurface : IfcCompositeCurve,
		IfcCurveOnSurface
	{
	
		public IfcCompositeCurveOnSurface(IfcCompositeCurveSegment[] segments, IfcLogical selfIntersect)
			: base(segments, selfIntersect)
		{
		}
	
		public new ISet<IfcSurface> BasisSurface { get { return null; } }
	
	
	}
	
}
