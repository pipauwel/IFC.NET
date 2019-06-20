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
	[Guid("8af578ab-a0d2-4d1e-b725-2f0d1ac24326")]
	public partial class IfcBSplineSurfaceWithKnots : IfcBSplineSurface
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The multiplicities of the knots in the <em>u</em> parameter direction.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcInteger> UMultiplicities { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The multiplicities of the knots in the <em>v</em> parameter direction.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcInteger> VMultiplicities { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The list of the distinct knots in the <em>u</em> parameter direction.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcParameterValue> UKnots { get; protected set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The list of the distinct knots in the <em>v</em> parameter direction.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcParameterValue> VKnots { get; protected set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The description of the knot type.")]
		[Required()]
		public IfcKnotType KnotSpec { get; set; }
	
	
		public IfcBSplineSurfaceWithKnots(IfcInteger uDegree, IfcInteger vDegree, IfcCartesianPoint[] controlPointsList, IfcBSplineSurfaceForm surfaceForm, IfcLogical uClosed, IfcLogical vClosed, IfcLogical selfIntersect, IfcInteger[] uMultiplicities, IfcInteger[] vMultiplicities, IfcParameterValue[] uKnots, IfcParameterValue[] vKnots, IfcKnotType knotSpec)
			: base(uDegree, vDegree, controlPointsList, surfaceForm, uClosed, vClosed, selfIntersect)
		{
			this.UMultiplicities = new List<IfcInteger>(uMultiplicities);
			this.VMultiplicities = new List<IfcInteger>(vMultiplicities);
			this.UKnots = new List<IfcParameterValue>(uKnots);
			this.VKnots = new List<IfcParameterValue>(vKnots);
			this.KnotSpec = knotSpec;
		}
	
		public new IfcInteger KnotVUpper { get { return new IfcInteger(); } }
	
		public new IfcInteger KnotUUpper { get { return new IfcInteger(); } }
	
	
	}
	
}
