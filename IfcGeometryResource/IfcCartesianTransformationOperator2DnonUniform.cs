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

using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("f45b9882-e0fb-41eb-9b0a-805615a37351")]
	public partial class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The scaling value specified for the transformation along the axis 2. This is normally the y scale factor.")]
		public IfcReal? Scale2 { get; set; }
	
	
		public IfcCartesianTransformationOperator2DnonUniform(IfcCartesianPoint localOrigin)
			: base(localOrigin)
		{
		}
	
		public new IfcReal Scl2 { get { return new IfcReal(); } }
	
	
	}
	
}
