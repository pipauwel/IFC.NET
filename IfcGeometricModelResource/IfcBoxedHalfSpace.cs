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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("6d52ef81-4176-4ab5-a2d3-39b86c31c378")]
	public partial class IfcBoxedHalfSpace : IfcHalfSpaceSolid
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The box which bounds the resulting solid of the Boolean operation involving the half space solid for computational purposes only.")]
		[Required()]
		public IfcBoundingBox Enclosure { get; set; }
	
	
		public IfcBoxedHalfSpace(IfcSurface baseSurface, IfcBoolean agreementFlag, IfcBoundingBox enclosure)
			: base(baseSurface, agreementFlag)
		{
			this.Enclosure = enclosure;
		}
	
	
	}
	
}
