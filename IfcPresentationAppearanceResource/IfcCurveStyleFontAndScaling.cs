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
using BuildingSmart.IFC.IfcPresentationDefinitionResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("9425eabf-9005-4536-ab59-ff8756b189e4")]
	public partial class IfcCurveStyleFontAndScaling : IfcPresentationItem,
		IfcCurveFontOrScaledCurveFontSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Name that may be assigned with the scaling of a curve font.")]
		public IfcLabel? Name { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The curve font to be scaled.")]
		[Required()]
		public IfcCurveStyleFontSelect CurveFont { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The scale factor.")]
		[Required()]
		public IfcPositiveRatioMeasure CurveFontScaling { get; set; }
	
	
		public IfcCurveStyleFontAndScaling(IfcCurveStyleFontSelect curveFont, IfcPositiveRatioMeasure curveFontScaling)
		{
			this.CurveFont = curveFont;
			this.CurveFontScaling = curveFontScaling;
		}
	
	
	}
	
}
