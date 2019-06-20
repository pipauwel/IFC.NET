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

namespace BuildingSmart.IFC.IfcPresentationOrganizationResource
{
	[Guid("78a1fa33-c4d1-4c69-9137-f32a6c56f59e")]
	public partial class IfcLightSourceAmbient : IfcLightSource
	{
	
		public IfcLightSourceAmbient(IfcColourRgb lightColour)
			: base(lightColour)
		{
		}
	
	
	}
	
}
