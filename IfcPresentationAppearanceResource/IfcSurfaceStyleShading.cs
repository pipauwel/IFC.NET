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

using BuildingSmart.IFC.IfcPresentationResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("31f81d9d-1cd5-4de7-852f-142b8bea58de")]
	public partial class IfcSurfaceStyleShading :
		IfcSurfaceStyleElementSelect
	{
		[DataMember(Order = 0)] 
		[Description("The colour used to render the surface. The surface colour for visualisation is defined by specifying the intensity of red, green and blue.")]
		[Required()]
		public IfcColourRgb SurfaceColour { get; set; }
	
	
		public IfcSurfaceStyleShading(IfcColourRgb surfaceColour)
		{
			this.SurfaceColour = surfaceColour;
		}
	
	
	}
	
}
