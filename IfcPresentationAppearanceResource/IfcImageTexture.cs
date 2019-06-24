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

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("15e29732-f8d2-4bce-882e-1173c7f66d31")]
	public partial class IfcImageTexture : IfcSurfaceTexture
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Required()]
		public IfcIdentifier UrlReference { get; set; }
	
	
		public IfcImageTexture(Boolean repeatS, Boolean repeatT, IfcSurfaceTextureEnum textureType, IfcIdentifier urlReference)
			: base(repeatS, repeatT, textureType)
		{
			this.UrlReference = urlReference;
		}
	
	
	}
	
}
