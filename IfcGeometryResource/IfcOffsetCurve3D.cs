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
	[Guid("5acd9188-3058-4913-a572-4b14d6ad086c")]
	public partial class IfcOffsetCurve3D : IfcCurve
	{
		[DataMember(Order = 0)] 
		[Description("The curve that is being offset.")]
		[Required()]
		public IfcCurve BasisCurve { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The distance of the offset curve from the basis curve. The distance may be positive, negative or zero.")]
		[Required()]
		public IfcLengthMeasure Distance { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("An indication of whether the offset curve self-intersects, this is for information only.")]
		[Required()]
		public Boolean? SelfIntersect { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("The direction used to define the direction of the offset curve 3d from the basis curve.")]
		[Required()]
		public IfcDirection RefDirection { get; set; }
	
	
		public IfcOffsetCurve3D(IfcCurve basisCurve, IfcLengthMeasure distance, Boolean? selfIntersect, IfcDirection refDirection)
		{
			this.BasisCurve = basisCurve;
			this.Distance = distance;
			this.SelfIntersect = selfIntersect;
			this.RefDirection = refDirection;
		}
	
	
	}
	
}
