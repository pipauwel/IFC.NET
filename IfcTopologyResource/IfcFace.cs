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
	[Guid("61ff97f0-9e99-4209-8421-359d954df9dd")]
	public partial class IfcFace : IfcTopologicalRepresentationItem
	{
		[DataMember(Order = 0)] 
		[Description("Boundaries of the face.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcFaceBound> Bounds { get; protected set; }
	
	
		public IfcFace(IfcFaceBound[] bounds)
		{
			this.Bounds = new HashSet<IfcFaceBound>(bounds);
		}
	
	
	}
	
}
