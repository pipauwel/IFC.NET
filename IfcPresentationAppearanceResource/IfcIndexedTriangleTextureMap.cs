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

using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationDefinitionResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("2749b740-94fa-4cfa-ba95-c6f30ee8024d")]
	public partial class IfcIndexedTriangleTextureMap : IfcIndexedTextureMap
	{
		[DataMember(Order = 0)] 
		[Description("Index into the <em>IfcTextureVertexList</em> for each vertex of the triangles representing the <em>IfcTriangulatedFaceSet</em>.")]
		[MinLength(1)]
		public IList<IfcPositiveInteger> TexCoordIndex { get; protected set; }
	
	
		public IfcIndexedTriangleTextureMap(IfcSurfaceTexture[] maps, IfcTessellatedFaceSet mappedTo, IfcTextureVertexList texCoords)
			: base(maps, mappedTo, texCoords)
		{
			this.TexCoordIndex = new List<IfcPositiveInteger>();
		}
	
	
	}
	
}
