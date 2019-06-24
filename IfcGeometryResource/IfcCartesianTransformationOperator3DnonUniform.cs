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
	[Guid("add777e1-a564-4099-a6ee-3f1b33f08944")]
	public partial class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D
	{
		[DataMember(Order = 0)] 
		[Description("The scaling value specified for the transformation along the axis 2. This is normally the y scale factor.")]
		public Double? Scale2 { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The scaling value specified for the transformation along the axis 3. This is normally the z scale factor.")]
		public Double? Scale3 { get; set; }
	
	
		public IfcCartesianTransformationOperator3DnonUniform(IfcCartesianPoint localOrigin)
			: base(localOrigin)
		{
		}
	
		public new Double Scl2 { get { return null; } }
	
		public new Double Scl3 { get { return null; } }
	
	
	}
	
}
