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

namespace BuildingSmart.IFC.IfcPresentationResource
{
	[Guid("4c024f51-b79f-459c-866c-4e638601af7a")]
	public partial class IfcColourRgb : IfcColourSpecification,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcColourOrFactor
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The intensity of the red colour component.  <blockquote><small>  NOTE&npsp; The colour component value is given within the range of 0..1, and not within the range of 0..255 as otherwise usual.  </small></blockquote>  </EPM-HTML>")]
		[Required()]
		public IfcNormalisedRatioMeasure Red { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The intensity of the green colour component.  <blockquote><small>  NOTE&npsp; The colour component value is given within the range of 0..1, and not within the range of 0..255 as otherwise usual.  </small></blockquote>  </EPM-HTML>")]
		[Required()]
		public IfcNormalisedRatioMeasure Green { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The intensity of the blue colour component.  <blockquote><small>  NOTE&npsp; The colour component value is given within the range of 0..1, and not within the range of 0..255 as otherwise usual.  </small></blockquote>  </EPM-HTML>")]
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
