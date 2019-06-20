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
	[Guid("0f127537-4dfb-420f-bcea-6637237ef8e4")]
	public partial class IfcCircleProfileDef : IfcParameterizedProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The radius of the circle.")]
		[Required()]
		public IfcPositiveLengthMeasure Radius { get; set; }
	
	
		public IfcCircleProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure radius)
			: base(profileType)
		{
			this.Radius = radius;
		}
	
	
	}
	
}
