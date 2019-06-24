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
	[Guid("d67c6683-c658-451a-82b2-833d8e0ed253")]
	public partial class IfcPixelTexture : IfcSurfaceTexture
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The number of pixels in width (S) direction.  </EPM-HTML>")]
		[Required()]
		public IfcInteger Width { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The number of pixels in height (T) direction.  </EPM-HTML>")]
		[Required()]
		public IfcInteger Height { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("<EPM-HTML>Indication whether the pixel values contain a 1, 2, 3, or 4 colour component.  </EPM-HTML>")]
		[Required()]
		public IfcInteger ColourComponents { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("<EPM-HTML>  Flat list of hexadecimal values, each describing one pixel by 1, 2, 3, or 4 components.  <blockquote><small><font color\"#ff0000\">  IFC2x Edition 3 CHANGE&nbsp; The data type has been changed from STRING to BINARY.  </font></small></blockquote>  </EPM-HTML>")]
		[Required()]
		[MinLength(1)]
		public IList<BINARY (32)> Pixel { get; protected set; }
	
	
		public IfcPixelTexture(Boolean repeatS, Boolean repeatT, IfcSurfaceTextureEnum textureType, IfcInteger width, IfcInteger height, IfcInteger colourComponents, BINARY (32)[] pixel)
			: base(repeatS, repeatT, textureType)
		{
			this.Width = width;
			this.Height = height;
			this.ColourComponents = colourComponents;
			this.Pixel = new List<BINARY (32)>(pixel);
		}
	
	
	}
	
}
