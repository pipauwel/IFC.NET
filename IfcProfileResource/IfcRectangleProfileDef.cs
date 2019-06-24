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
	[Guid("f2c31cff-899c-4273-805a-2c951a82489d")]
	public partial class IfcRectangleProfileDef : IfcParameterizedProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The extent of the rectangle in the direction of the x-axis.")]
		[Required()]
		public IfcPositiveLengthMeasure XDim { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The extent of the rectangle in the direction of the y-axis.")]
		[Required()]
		public IfcPositiveLengthMeasure YDim { get; set; }
	
	
		public IfcRectangleProfileDef(IfcProfileTypeEnum profileType, IfcAxis2Placement2D position, IfcPositiveLengthMeasure xDim, IfcPositiveLengthMeasure yDim)
			: base(profileType, position)
		{
			this.XDim = xDim;
			this.YDim = yDim;
		}
	
	
	}
	
}
