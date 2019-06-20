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

using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("73dcb7dc-33d9-44b6-9ff1-1c8ded7c722d")]
	public partial class IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Required()]
		public IfcParameterValue ParamLength { get; set; }
	
	
		public IfcReparametrisedCompositeCurveSegment(IfcTransitionCode transition, IfcBoolean sameSense, IfcCurve parentCurve, IfcParameterValue paramLength)
			: base(transition, sameSense, parentCurve)
		{
			this.ParamLength = paramLength;
		}
	
	
	}
	
}
