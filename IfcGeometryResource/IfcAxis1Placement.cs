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
	[Guid("c8b3d74c-f4b5-470f-9869-a0abb477b699")]
	public partial class IfcAxis1Placement : IfcPlacement
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The direction of the local Z axis.")]
		public IfcDirection Axis { get; set; }
	
	
		public IfcAxis1Placement(IfcCartesianPoint location)
			: base(location)
		{
		}
	
		public new IfcDirection Z { get { return null; } }
	
	
	}
	
}
