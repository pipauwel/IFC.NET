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
	[Guid("e019e0b0-86e1-4188-85b1-4d934b9a1046")]
	public partial class IfcEllipseProfileDef : IfcParameterizedProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The first radius of the ellipse. It is measured along the direction of Position.P[1].")]
		[Required()]
		public IfcPositiveLengthMeasure SemiAxis1 { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The second radius of the ellipse. It is measured along the direction of Position.P[2].")]
		[Required()]
		public IfcPositiveLengthMeasure SemiAxis2 { get; set; }
	
	
		public IfcEllipseProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure semiAxis1, IfcPositiveLengthMeasure semiAxis2)
			: base(profileType)
		{
			this.SemiAxis1 = semiAxis1;
			this.SemiAxis2 = semiAxis2;
		}
	
	
	}
	
}
