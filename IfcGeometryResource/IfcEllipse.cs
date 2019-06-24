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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("d3860283-bd32-4830-a777-1521522011ac")]
	public partial class IfcEllipse : IfcConic
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The first radius of the ellipse which shall be positive. Placement.Axes[1] gives the direction of the SemiAxis1.")]
		[Required()]
		public IfcPositiveLengthMeasure SemiAxis1 { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The second radius of the ellipse which shall be positive.")]
		[Required()]
		public IfcPositiveLengthMeasure SemiAxis2 { get; set; }
	
	
		public IfcEllipse(IfcAxis2Placement position, IfcPositiveLengthMeasure semiAxis1, IfcPositiveLengthMeasure semiAxis2)
			: base(position)
		{
			this.SemiAxis1 = semiAxis1;
			this.SemiAxis2 = semiAxis2;
		}
	
	
	}
	
}
