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
	[Guid("1db68cb4-51e9-4d7b-b43a-d738904596a5")]
	public partial class IfcRectangleHollowProfileDef : IfcRectangleProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Thickness of the material.")]
		[Required()]
		public IfcPositiveLengthMeasure WallThickness { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Radius of the circular arcs, by which all four corners of the outer contour of rectangle are equally rounded. If not given, zero (= no rounding arcs) applies.")]
		public IfcPositiveLengthMeasure? InnerFilletRadius { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Radius of the circular arcs, by which all four corners of the outer contour of rectangle are equally rounded. If not given, zero (= no rounding arcs) applies.")]
		public IfcPositiveLengthMeasure? OuterFilletRadius { get; set; }
	
	
		public IfcRectangleHollowProfileDef(IfcProfileTypeEnum profileType, IfcAxis2Placement2D position, IfcPositiveLengthMeasure xDim, IfcPositiveLengthMeasure yDim, IfcPositiveLengthMeasure wallThickness)
			: base(profileType, position, xDim, yDim)
		{
			this.WallThickness = wallThickness;
		}
	
	
	}
	
}
