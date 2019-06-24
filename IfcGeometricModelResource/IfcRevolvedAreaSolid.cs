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
using BuildingSmart.IFC.IfcProfileResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("7da3601b-9ac2-4100-91e3-d883f16a8be8")]
	public partial class IfcRevolvedAreaSolid : IfcSweptAreaSolid
	{
		[DataMember(Order = 0)] 
		[Description("Axis about which revolution will take place.")]
		[Required()]
		public IfcAxis1Placement Axis { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Angle through which the sweep will be made. This angle is measured from the plane of the sweep.")]
		[Required()]
		public IfcPlaneAngleMeasure Angle { get; set; }
	
	
		public IfcRevolvedAreaSolid(IfcProfileDef sweptArea, IfcAxis2Placement3D position, IfcAxis1Placement axis, IfcPlaneAngleMeasure angle)
			: base(sweptArea, position)
		{
			this.Axis = axis;
			this.Angle = angle;
		}
	
		public new IfcLine AxisLine { get { return null; } }
	
	
	}
	
}
