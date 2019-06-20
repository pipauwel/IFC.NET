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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcProfileResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("d15358b0-162a-4760-993f-02cce84f936b")]
	public partial class IfcRevolvedAreaSolidTapered : IfcRevolvedAreaSolid
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Required()]
		public IfcProfileDef EndSweptArea { get; set; }
	
	
		public IfcRevolvedAreaSolidTapered(IfcProfileDef sweptArea, IfcAxis1Placement axis, IfcPlaneAngleMeasure angle, IfcProfileDef endSweptArea)
			: base(sweptArea, axis, angle)
		{
			this.EndSweptArea = endSweptArea;
		}
	
	
	}
	
}
