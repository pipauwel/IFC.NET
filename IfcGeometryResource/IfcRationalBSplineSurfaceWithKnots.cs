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
	[Guid("fa4d0f85-ebcc-4a94-aa4d-e9876009463c")]
	public partial class IfcRationalBSplineSurfaceWithKnots : IfcBSplineSurfaceWithKnots
	{
		[DataMember(Order = 0)] 
		[XmlElement("IfcReal")]
		[Description("The weights associated with the control points in the rational case.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcReal> WeightsData { get; protected set; }
	
	
		public IfcRationalBSplineSurfaceWithKnots(IfcInteger uDegree, IfcInteger vDegree, IfcCartesianPoint[] controlPointsList, IfcBSplineSurfaceForm surfaceForm, IfcLogical uClosed, IfcLogical vClosed, IfcLogical selfIntersect, IfcInteger[] uMultiplicities, IfcInteger[] vMultiplicities, IfcParameterValue[] uKnots, IfcParameterValue[] vKnots, IfcKnotType knotSpec, IfcReal[] weightsData)
			: base(uDegree, vDegree, controlPointsList, surfaceForm, uClosed, vClosed, selfIntersect, uMultiplicities, vMultiplicities, uKnots, vKnots, knotSpec)
		{
			this.WeightsData = new List<IfcReal>(weightsData);
		}
	
		public new IfcReal Weights { get { return new IfcReal(); } }
	
	
	}
	
}
