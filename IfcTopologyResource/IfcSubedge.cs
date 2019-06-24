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
	[Guid("94384d21-b0e3-4673-bcd6-b22f0283ff84")]
	public partial class IfcSubedge : IfcEdge
	{
		[DataMember(Order = 0)] 
		[Description("The Edge, or Subedge, which contains the Subedge.")]
		[Required()]
		public IfcEdge ParentEdge { get; set; }
	
	
		public IfcSubedge(IfcVertex edgeStart, IfcVertex edgeEnd, IfcEdge parentEdge)
			: base(edgeStart, edgeEnd)
		{
			this.ParentEdge = parentEdge;
		}
	
	
	}
	
}
