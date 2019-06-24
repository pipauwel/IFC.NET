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
	[Guid("7a38518c-4644-4c92-a76d-62b537919702")]
	public partial class IfcBezierCurve : IfcBSplineCurve
	{
	
		public IfcBezierCurve(Int64 degree, IfcCartesianPoint[] controlPointsList, IfcBSplineCurveForm curveForm, Boolean? closedCurve, Boolean? selfIntersect)
			: base(degree, controlPointsList, curveForm, closedCurve, selfIntersect)
		{
		}
	
	
	}
	
}
