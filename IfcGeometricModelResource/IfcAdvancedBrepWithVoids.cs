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
	[Guid("e6acb3a9-e21b-4936-936f-c5e1059a8929")]
	public partial class IfcAdvancedBrepWithVoids : IfcAdvancedBrep
	{
		[DataMember(Order = 0)] 
		[Required()]
		[MinLength(1)]
		public ISet<IfcClosedShell> Voids { get; protected set; }
	
	
		public IfcAdvancedBrepWithVoids(IfcClosedShell outer, IfcClosedShell[] voids)
			: base(outer)
		{
			this.Voids = new HashSet<IfcClosedShell>(voids);
		}
	
	
	}
	
}
