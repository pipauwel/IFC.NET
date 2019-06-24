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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("0fd59f0d-0b17-493b-b13f-bc678b2f2c87")]
	public partial class IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  Constant thickness applied along the center line.  </EPM-HTML>")]
		[Required()]
		public IfcPositiveLengthMeasure Thickness { get; set; }
	
	
		public IfcCenterLineProfileDef(IfcProfileTypeEnum profileType, IfcBoundedCurve curve, IfcPositiveLengthMeasure thickness)
			: base(profileType, curve)
		{
			this.Thickness = thickness;
		}
	
	
	}
	
}
