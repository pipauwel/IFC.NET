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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("df38acbf-c70a-45d4-965d-4f328a31a361")]
	public partial class IfcRightCircularCone : IfcCsgPrimitive3D
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  </EPM-HTML>")]
		[Required()]
		public IfcPositiveLengthMeasure Height { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  </EPM-HTML>")]
		[Required()]
		public IfcPositiveLengthMeasure BottomRadius { get; set; }
	
	
		public IfcRightCircularCone(IfcAxis2Placement3D position, IfcPositiveLengthMeasure height, IfcPositiveLengthMeasure bottomRadius)
			: base(position)
		{
			this.Height = height;
			this.BottomRadius = bottomRadius;
		}
	
	
	}
	
}
