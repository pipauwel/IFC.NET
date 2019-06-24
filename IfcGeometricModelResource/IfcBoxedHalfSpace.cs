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

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("411fdc4b-ec30-4513-b554-f7ce4a481085")]
	public partial class IfcBoxedHalfSpace : IfcHalfSpaceSolid
	{
		[DataMember(Order = 0)] 
		[Description("The box which bounds the half space for computational purposes only.")]
		[Required()]
		public IfcBoundingBox Enclosure { get; set; }
	
	
		public IfcBoxedHalfSpace(IfcSurface baseSurface, Boolean agreementFlag, IfcBoundingBox enclosure)
			: base(baseSurface, agreementFlag)
		{
			this.Enclosure = enclosure;
		}
	
	
	}
	
}
