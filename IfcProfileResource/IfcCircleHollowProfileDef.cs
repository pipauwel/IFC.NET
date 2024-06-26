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
	[Guid("2d8e8f4a-8947-49ca-b146-77ad07842c99")]
	public partial class IfcCircleHollowProfileDef : IfcCircleProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Thickness of the material, it is the difference between the outer and inner radius.")]
		[Required()]
		public IfcPositiveLengthMeasure WallThickness { get; set; }
	
	
		public IfcCircleHollowProfileDef(IfcProfileTypeEnum profileType, IfcAxis2Placement2D position, IfcPositiveLengthMeasure radius, IfcPositiveLengthMeasure wallThickness)
			: base(profileType, position, radius)
		{
			this.WallThickness = wallThickness;
		}
	
	
	}
	
}
