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
	[Guid("6cc49723-24d6-446e-b2cc-fef52a6229c4")]
	public abstract partial class IfcBSplineSurface : IfcBoundedSurface
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Algebraic degree of basis functions in <em>u</em>.")]
		[Required()]
		public IfcInteger UDegree { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Algebraic degree of basis functions in <em>v</em>.")]
		[Required()]
		public IfcInteger VDegree { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlElement("IfcCartesianPoint")]
		[Description("This is a list of lists of control points.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcCartesianPoint> ControlPointsList { get; protected set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Indicator of special surface types.")]
		[Required()]
		public IfcBSplineSurfaceForm SurfaceForm { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Indication of whether the surface is closed in the <em>u</em> direction; this is for information only.")]
		[Required()]
		public IfcLogical UClosed { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Indication of whether the surface is closed in the <em>v</em> direction; this is for information only.")]
		[Required()]
		public IfcLogical VClosed { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("Flag to indicate whether, or not, surface is self-intersecting; this is for information only.")]
		[Required()]
		public IfcLogical SelfIntersect { get; set; }
	
	
		protected IfcBSplineSurface(IfcInteger uDegree, IfcInteger vDegree, IfcCartesianPoint[] controlPointsList, IfcBSplineSurfaceForm surfaceForm, IfcLogical uClosed, IfcLogical vClosed, IfcLogical selfIntersect)
		{
			this.UDegree = uDegree;
			this.VDegree = vDegree;
			this.ControlPointsList = new List<IfcCartesianPoint>(controlPointsList);
			this.SurfaceForm = surfaceForm;
			this.UClosed = uClosed;
			this.VClosed = vClosed;
			this.SelfIntersect = selfIntersect;
		}
	
		public new IfcInteger UUpper { get { return new IfcInteger(); } }
	
		public new IfcInteger VUpper { get { return new IfcInteger(); } }
	
		public new IfcCartesianPoint ControlPoints { get { return null; } }
	
	
	}
	
}
