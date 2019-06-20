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
	[Guid("5cf374d3-9550-4d89-8870-9e50d9d4d7f6")]
	public partial class IfcBSplineCurveWithKnots : IfcBSplineCurve
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The multiplicities of the knots. This list defines the number of times each knot in the knots list is to be repeated in constructing the knot array.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcInteger> KnotMultiplicities { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The list of distinct knots used to define the B-spline basis functions.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcParameterValue> Knots { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The description of the knot type. This is for information only.")]
		[Required()]
		public IfcKnotType KnotSpec { get; set; }
	
	
		public IfcBSplineCurveWithKnots(IfcInteger degree, IfcCartesianPoint[] controlPointsList, IfcBSplineCurveForm curveForm, IfcLogical closedCurve, IfcLogical selfIntersect, IfcInteger[] knotMultiplicities, IfcParameterValue[] knots, IfcKnotType knotSpec)
			: base(degree, controlPointsList, curveForm, closedCurve, selfIntersect)
		{
			this.KnotMultiplicities = new List<IfcInteger>(knotMultiplicities);
			this.Knots = new List<IfcParameterValue>(knots);
			this.KnotSpec = knotSpec;
		}
	
		public new IfcInteger UpperIndexOnKnots { get { return new IfcInteger(); } }
	
	
	}
	
}
