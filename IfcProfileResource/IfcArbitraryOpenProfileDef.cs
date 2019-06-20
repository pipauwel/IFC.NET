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
	[Guid("65ea2e1f-aa07-4338-9f78-43c237e707f8")]
	public partial class IfcArbitraryOpenProfileDef : IfcProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Open bounded curve defining the profile.")]
		[Required()]
		public IfcBoundedCurve Curve { get; set; }
	
	
		public IfcArbitraryOpenProfileDef(IfcProfileTypeEnum profileType, IfcBoundedCurve curve)
			: base(profileType)
		{
			this.Curve = curve;
		}
	
	
	}
	
}
