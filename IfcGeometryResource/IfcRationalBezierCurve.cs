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
	[Guid("33d227e6-5f5f-4564-83b9-c46f7a472385")]
	public partial class IfcRationalBezierCurve : IfcBezierCurve
	{
		[DataMember(Order = 0)] 
		[Description("The supplied values of the weights.")]
		[Required()]
		[MinLength(2)]
		public IList<Double> WeightsData { get; protected set; }
	
	
		public IfcRationalBezierCurve(Int64 degree, IfcCartesianPoint[] controlPointsList, IfcBSplineCurveForm curveForm, Boolean? closedCurve, Boolean? selfIntersect, Double[] weightsData)
			: base(degree, controlPointsList, curveForm, closedCurve, selfIntersect)
		{
			this.WeightsData = new List<Double>(weightsData);
		}
	
		public new Double Weights { get { return null; } }
	
	
	}
	
}
