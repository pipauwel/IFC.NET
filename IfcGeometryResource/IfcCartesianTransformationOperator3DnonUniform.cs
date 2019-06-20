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
	[Guid("283bc76c-8d97-414d-a5ef-96f76f53702f")]
	public partial class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The scaling value specified for the transformation along the axis 2. This is normally the y scale factor.")]
		public IfcReal? Scale2 { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The scaling value specified for the transformation along the axis 3. This is normally the z scale factor.")]
		public IfcReal? Scale3 { get; set; }
	
	
		public IfcCartesianTransformationOperator3DnonUniform(IfcCartesianPoint localOrigin)
			: base(localOrigin)
		{
		}
	
		public new IfcReal Scl2 { get { return new IfcReal(); } }
	
		public new IfcReal Scl3 { get { return new IfcReal(); } }
	
	
	}
	
}
