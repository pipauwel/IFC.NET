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
	[Guid("3f24b989-aa9e-461e-b6d2-1dd3dabb466b")]
	public partial class IfcRationalBSplineCurveWithKnots : IfcBSplineCurveWithKnots
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The supplied values of the weights.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcReal> WeightsData { get; protected set; }
	
	
		public IfcRationalBSplineCurveWithKnots(IfcInteger degree, IfcCartesianPoint[] controlPointsList, IfcBSplineCurveForm curveForm, IfcLogical closedCurve, IfcLogical selfIntersect, IfcInteger[] knotMultiplicities, IfcParameterValue[] knots, IfcKnotType knotSpec, IfcReal[] weightsData)
			: base(degree, controlPointsList, curveForm, closedCurve, selfIntersect, knotMultiplicities, knots, knotSpec)
		{
			this.WeightsData = new List<IfcReal>(weightsData);
		}
	
		public new IfcReal Weights { get { return new IfcReal(); } }
	
	
	}
	
}
