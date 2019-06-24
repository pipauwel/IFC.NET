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
using BuildingSmart.IFC.IfcProfileResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("401881db-55c5-4915-badf-e9a6e9d4517c")]
	public partial class IfcSurfaceOfLinearExtrusion : IfcSweptSurface
	{
		[DataMember(Order = 0)] 
		[Description("The direction of the extrusion.")]
		[Required()]
		public IfcDirection ExtrudedDirection { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The depth of the extrusion, it determines the parameterization.")]
		[Required()]
		public IfcLengthMeasure Depth { get; set; }
	
	
		public IfcSurfaceOfLinearExtrusion(IfcProfileDef sweptCurve, IfcAxis2Placement3D position, IfcDirection extrudedDirection, IfcLengthMeasure depth)
			: base(sweptCurve, position)
		{
			this.ExtrudedDirection = extrudedDirection;
			this.Depth = depth;
		}
	
		public new IfcVector ExtrusionAxis { get { return null; } }
	
	
	}
	
}
