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
	[Guid("fe23e954-f7e9-4325-a60f-ca972e1516c4")]
	public abstract partial class IfcManifoldSolidBrep : IfcSolidModel
	{
		[DataMember(Order = 0)] 
		[Description("A closed shell defining the exterior boundary of the solid. The shell normal shall point away from the interior of the solid.")]
		[Required()]
		public IfcClosedShell Outer { get; set; }
	
	
		protected IfcManifoldSolidBrep(IfcClosedShell outer)
		{
			this.Outer = outer;
		}
	
	
	}
	
}
