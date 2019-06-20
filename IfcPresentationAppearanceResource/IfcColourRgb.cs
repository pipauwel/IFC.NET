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
	[Guid("388e833a-1b3c-4462-8e69-376d83bdcbb7")]
	public partial class IfcColourRgb : IfcColourSpecification,
		IfcColourOrFactor
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The intensity of the red colour component.  <blockquote class=\"note\">NOTE&nbsp; The colour component value is given within the range of 0..1, and not within the range of 0..255 as otherwise usual.</blockquote>")]
		[Required()]
		public IfcNormalisedRatioMeasure Red { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The intensity of the green colour component.  <blockquote class=\"note\">NOTE&nbsp; The colour component value is given within the range of 0..1, and not within the range of 0..255 as otherwise usual.</blockquote>")]
		[Required()]
		public IfcNormalisedRatioMeasure Green { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The intensity of the blue colour component.  <blockquote class=\"note\">NOTE&nbsp; The colour component value is given within the range of 0..1, and not within the range of 0..255 as otherwise usual.</blockquote>")]
		[Required()]
		public IfcNormalisedRatioMeasure Blue { get; set; }
	
	
		public IfcColourRgb(IfcNormalisedRatioMeasure red, IfcNormalisedRatioMeasure green, IfcNormalisedRatioMeasure blue)
		{
			this.Red = red;
			this.Green = green;
			this.Blue = blue;
		}
	
	
	}
	
}
