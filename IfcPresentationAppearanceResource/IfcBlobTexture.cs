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
using BuildingSmart.IFC.IfcPresentationDefinitionResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("6f3625b4-6b27-4ac2-8c49-34b2079baf0c")]
	public partial class IfcBlobTexture : IfcSurfaceTexture
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The format of the <em>RasterCode</em> often using a compression.")]
		[Required()]
		public IfcIdentifier RasterFormat { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Blob, given as a single binary, to capture the texture within one popular file (compression) format. The file format is provided by the <em>RasterFormat</em> attribute.")]
		[Required()]
		public IfcBinary RasterCode { get; set; }
	
	
		public IfcBlobTexture(IfcBoolean repeatS, IfcBoolean repeatT, IfcIdentifier rasterFormat, IfcBinary rasterCode)
			: base(repeatS, repeatT)
		{
			this.RasterFormat = rasterFormat;
			this.RasterCode = rasterCode;
		}
	
	
	}
	
}
