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

using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("b776074c-fd25-4516-a5ee-d3d6a692e772")]
	public partial class IfcAxis2Placement2D : IfcPlacement,
		IfcAxis2Placement
	{
		[DataMember(Order = 0)] 
		[Description("The direction used to determine the direction of the local X Axis.")]
		public IfcDirection RefDirection { get; set; }
	
	
		public IfcAxis2Placement2D(IfcCartesianPoint location)
			: base(location)
		{
		}
	
		public new IList<IfcDirection> P { get { return null; } }
	
	
	}
	
}
