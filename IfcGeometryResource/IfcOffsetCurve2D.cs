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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("f5ea20e7-98db-4aeb-b0f8-03ac3e6d947c")]
	public partial class IfcOffsetCurve2D : IfcCurve
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The curve that is being offset.")]
		[Required()]
		public IfcCurve BasisCurve { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The distance of the offset curve from the basis curve. distance may be positive, negative or zero. A positive value of distance defines an offset in the direction which is normal to the curve in the sense of an anti-clockwise rotation through 90 degrees from the tangent vector T at the given point. (This is in the direction of orthogonal complement(T).)")]
		[Required()]
		public IfcLengthMeasure Distance { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("An indication of whether the offset curve self-intersects; this is for information only.")]
		[Required()]
		public IfcLogical SelfIntersect { get; set; }
	
	
		public IfcOffsetCurve2D(IfcCurve basisCurve, IfcLengthMeasure distance, IfcLogical selfIntersect)
		{
			this.BasisCurve = basisCurve;
			this.Distance = distance;
			this.SelfIntersect = selfIntersect;
		}
	
	
	}
	
}
