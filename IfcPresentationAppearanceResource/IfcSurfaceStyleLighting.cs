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

using BuildingSmart.IFC.IfcPresentationDefinitionResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("5c51bae3-8ace-443a-9e9b-d416bb389d95")]
	public partial class IfcSurfaceStyleLighting : IfcPresentationItem,
		IfcSurfaceStyleElementSelect
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The degree of diffusion of the transmitted light. In the case of completely transparent materials there is no diffusion. The greater the diffusing power, the smaller the direct component of the transmitted light, up to the point where only diffuse light is produced. A value of 1 means totally diffuse for that colour part of the light.  <blockquote class=\"note\">NOTE&nbsp; The factor can be measured physically and has three ratios for the red, green and blue part of the light.</blockquote>")]
		[Required()]
		public IfcColourRgb DiffuseTransmissionColour { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("The degree of diffusion of the reflected light. In the case of specular surfaces there is no diffusion. The greater the diffusing power of the reflecting surface, the smaller the specular component of the reflected light, up to the point where only diffuse light is produced. A value of 1 means totally diffuse for that colour part of the light.   <blockquote class=\"note\">NOTE&nbsp; The factor can be measured physically and has three ratios for the red, green and blue part of the light.</blockquote>")]
		[Required()]
		public IfcColourRgb DiffuseReflectionColour { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlElement]
		[Description("Describes how the light falling on a body is totally or partially transmitted.   <blockquote class=\"note\">The factor can be measured physically and has three ratios for the red, green and blue part of the light.</blockquote>")]
		[Required()]
		public IfcColourRgb TransmissionColour { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlElement]
		[Description("A coefficient that determines the extent that the light falling onto a surface is fully or partially reflected.   <blockquote class=\"note\">NOTE&nbsp; The factor can be measured physically and has three ratios for the red, green and blue part of the light.</blockquote>")]
		[Required()]
		public IfcColourRgb ReflectanceColour { get; set; }
	
	
		public IfcSurfaceStyleLighting(IfcColourRgb diffuseTransmissionColour, IfcColourRgb diffuseReflectionColour, IfcColourRgb transmissionColour, IfcColourRgb reflectanceColour)
		{
			this.DiffuseTransmissionColour = diffuseTransmissionColour;
			this.DiffuseReflectionColour = diffuseReflectionColour;
			this.TransmissionColour = transmissionColour;
			this.ReflectanceColour = reflectanceColour;
		}
	
	
	}
	
}
