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
	[Guid("42fca5dd-e781-41ae-b6cd-728492fe33cf")]
	public partial class IfcExtrudedAreaSolidTapered : IfcExtrudedAreaSolid
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The surface defining the end of the swept area. It is given as a profile definition. The position coordinate system of the <em>EndSwptArea</em> is generated by translating the <em>SELF\\IfcSweptAreaSolid.Position</em> along the <em>SELF\\IfcExtrudedAreaSolid.ExtrudedDirection</em> by the distance of <em>SELF\\IfcExtrudedAreaSolid.Depth</em>.")]
		[Required()]
		public IfcProfileDef EndSweptArea { get; set; }
	
	
		public IfcExtrudedAreaSolidTapered(IfcProfileDef sweptArea, IfcDirection extrudedDirection, IfcPositiveLengthMeasure depth, IfcProfileDef endSweptArea)
			: base(sweptArea, extrudedDirection, depth)
		{
			this.EndSweptArea = endSweptArea;
		}
	
	
	}
	
}
