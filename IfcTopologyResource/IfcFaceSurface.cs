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
	[Guid("33f5691b-7957-46f4-a44c-3b5069f82548")]
	public partial class IfcFaceSurface : IfcFace,
		BuildingSmart.IFC.IfcGeometricConstraintResource.IfcSurfaceOrFaceSurface
	{
		[DataMember(Order = 0)] 
		[Description("The surface which defines the internal shape of the face. This surface may be unbounded. The domain of the face is defined by this surface and the bounding loops in the inherited attribute SELF\\FaceBounds.")]
		[Required()]
		public IfcSurface FaceSurface { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("This flag indicates whether the sense of the surface normal agrees with (TRUE), or opposes (FALSE), the sense of the topological normal to the face.")]
		[Required()]
		public Boolean SameSense { get; set; }
	
	
		public IfcFaceSurface(IfcFaceBound[] bounds, IfcSurface faceSurface, Boolean sameSense)
			: base(bounds)
		{
			this.FaceSurface = faceSurface;
			this.SameSense = sameSense;
		}
	
	
	}
	
}
