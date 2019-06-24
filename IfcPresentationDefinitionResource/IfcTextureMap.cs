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


namespace BuildingSmart.IFC.IfcPresentationDefinitionResource
{
	[Guid("7b2e30ff-3e94-443a-9e20-2fbf226ef0ce")]
	public partial class IfcTextureMap : IfcTextureCoordinate
	{
		[DataMember(Order = 0)] 
		[Description("Reference to a list of texture vertex assignment to coordinates within a vertex based geometry.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcVertexBasedTextureMap> TextureMaps { get; protected set; }
	
	
		public IfcTextureMap(IfcVertexBasedTextureMap[] textureMaps)
		{
			this.TextureMaps = new HashSet<IfcVertexBasedTextureMap>(textureMaps);
		}
	
	
	}
	
}
