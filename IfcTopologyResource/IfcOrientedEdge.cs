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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcTopologyResource
{
	[Guid("6db216a4-6262-452a-968f-fdeb785eeb09")]
	public partial class IfcOrientedEdge : IfcEdge
	{
		[DataMember(Order = 0)] 
		[Description("Edge entity used to construct this oriented edge.")]
		[Required()]
		public IfcEdge EdgeElement { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("BOOLEAN, If TRUE the topological orientation as used coincides with the orientation from start vertex to end vertex of the edge element. If FALSE otherwise.")]
		[Required()]
		public Boolean Orientation { get; set; }
	
	
		public IfcOrientedEdge(IfcVertex edgeStart, IfcVertex edgeEnd, IfcEdge edgeElement, Boolean orientation)
			: base(edgeStart, edgeEnd)
		{
			this.EdgeElement = edgeElement;
			this.Orientation = orientation;
		}
	
		public new IfcVertex EdgeStart { get { return null; } }
	
		public new IfcVertex EdgeEnd { get { return null; } }
	
	
	}
	
}
