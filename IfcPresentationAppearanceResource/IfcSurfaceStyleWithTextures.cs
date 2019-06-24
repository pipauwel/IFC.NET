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


namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("026decc8-92b6-4199-a0d0-600130d2010e")]
	public partial class IfcSurfaceStyleWithTextures :
		IfcSurfaceStyleElementSelect
	{
		[DataMember(Order = 0)] 
		[Description("The textures applied to the surface. Only one image map with the same image map type shall be applied.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcSurfaceTexture> Textures { get; protected set; }
	
	
		public IfcSurfaceStyleWithTextures(IfcSurfaceTexture[] textures)
		{
			this.Textures = new List<IfcSurfaceTexture>(textures);
		}
	
	
	}
	
}
