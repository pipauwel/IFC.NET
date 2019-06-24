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
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("c5319aaa-961e-4cc6-804c-662e631fb696")]
	public partial class IfcFacetedBrepWithVoids : IfcManifoldSolidBrep
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
