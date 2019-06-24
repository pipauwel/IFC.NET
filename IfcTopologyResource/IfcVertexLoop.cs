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
	[Guid("be13b85b-d93e-42da-9d2d-6b12cb2d3f5a")]
	public partial class IfcVertexLoop : IfcLoop
	{
		[DataMember(Order = 0)] 
		[Description("The vertex which defines the entire loop.")]
		[Required()]
		public IfcVertex LoopVertex { get; set; }
	
	
		public IfcVertexLoop(IfcVertex loopVertex)
		{
			this.LoopVertex = loopVertex;
		}
	
	
	}
	
}
