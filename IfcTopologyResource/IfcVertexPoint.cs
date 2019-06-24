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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcTopologyResource
{
	[Guid("4eb98543-6244-4c9d-b40a-05b26a73efe2")]
	public partial class IfcVertexPoint : IfcVertex,
		BuildingSmart.IFC.IfcGeometricConstraintResource.IfcPointOrVertexPoint
	{
		[DataMember(Order = 0)] 
		[Description("The geometric point, which defines the position in geometric space of the vertex.")]
		[Required()]
		public IfcPoint VertexGeometry { get; set; }
	
	
		public IfcVertexPoint(IfcPoint vertexGeometry)
		{
			this.VertexGeometry = vertexGeometry;
		}
	
	
	}
	
}
