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
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("f5095cfb-b085-4d65-82d7-98a1958e8fca")]
	public partial class IfcFacetedBrepWithVoids : IfcFacetedBrep
	{
		[DataMember(Order = 0)] 
		[Description("Set of closed shells defining voids within the solid.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcClosedShell> Voids { get; protected set; }
	
	
		public IfcFacetedBrepWithVoids(IfcClosedShell outer, IfcClosedShell[] voids)
			: base(outer)
		{
			this.Voids = new HashSet<IfcClosedShell>(voids);
		}
	
	
	}
	
}
