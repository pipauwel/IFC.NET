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
using BuildingSmart.IFC.IfcPresentationResource;

namespace BuildingSmart.IFC.IfcPresentationOrganizationResource
{
	[Guid("3b705245-20db-4ec6-9d25-c59a79898392")]
	public abstract partial class IfcLightSource : IfcGeometricRepresentationItem
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The name given to the light source in presentation.")]
		public IfcLabel? Name { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Definition from ISO/CD 10303-46:1992: Based on the current lighting model, the colour of the light to be used for shading.  Definition from VRML97 - ISO/IEC 14772-1:1997: The color field specifies the spectral color properties of both the direct and ambient light emission as an RGB value.")]
		[Required()]
		public IfcColourRgb LightColour { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Definition from VRML97 - ISO/IEC 14772-1:1997: The ambientIntensity specifies the intensity of the ambient emission from the light. Light intensity may range from 0.0 (no light emission) to 1.0 (full intensity).")]
		public IfcNormalisedRatioMeasure? AmbientIntensity { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Definition from VRML97 - ISO/IEC 14772-1:1997: The intensity field specifies the brightness of the direct emission from the ligth. Light intensity may range from 0.0 (no light emission) to 1.0 (full intensity).")]
		public IfcNormalisedRatioMeasure? Intensity { get; set; }
	
	
		protected IfcLightSource(IfcColourRgb lightColour)
		{
			this.LightColour = lightColour;
		}
	
	
	}
	
}
