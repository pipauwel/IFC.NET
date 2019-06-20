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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("19db74b8-9bbd-4310-a2b8-d47984481a40")]
	public partial class IfcRectangleHollowProfileDef : IfcRectangleProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Thickness of the material.")]
		[Required()]
		public IfcPositiveLengthMeasure WallThickness { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Inner corner radius.")]
		public IfcNonNegativeLengthMeasure? InnerFilletRadius { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Outer corner radius.")]
		public IfcNonNegativeLengthMeasure? OuterFilletRadius { get; set; }
	
	
		public IfcRectangleHollowProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure xDim, IfcPositiveLengthMeasure yDim, IfcPositiveLengthMeasure wallThickness)
			: base(profileType, xDim, yDim)
		{
			this.WallThickness = wallThickness;
		}
	
	
	}
	
}
