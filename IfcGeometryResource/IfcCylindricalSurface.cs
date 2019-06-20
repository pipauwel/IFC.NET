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
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("724208fb-1891-42c2-957a-3425addde369")]
	public partial class IfcCylindricalSurface : IfcElementarySurface
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The radius of the cylindrical surface.")]
		[Required()]
		public IfcPositiveLengthMeasure Radius { get; set; }
	
	
		public IfcCylindricalSurface(IfcAxis2Placement3D position, IfcPositiveLengthMeasure radius)
			: base(position)
		{
			this.Radius = radius;
		}
	
	
	}
	
}
