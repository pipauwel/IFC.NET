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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("28220f1d-2ef9-48f4-9aa6-198f7af996d8")]
	public partial class IfcLine : IfcCurve
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The location of the <em>IfcLine</em>.")]
		[Required()]
		public IfcCartesianPoint Pnt { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("The direction of the <em>IfcLine</em>, the magnitude and units of <em>Dir</em> affect the parameterization of the line.")]
		[Required()]
		public IfcVector Dir { get; set; }
	
	
		public IfcLine(IfcCartesianPoint pnt, IfcVector dir)
		{
			this.Pnt = pnt;
			this.Dir = dir;
		}
	
	
	}
	
}
