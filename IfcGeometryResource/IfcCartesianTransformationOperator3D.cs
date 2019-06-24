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
	[Guid("73f48fda-5891-43f6-8efd-fb8be2d9808c")]
	public partial class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator
	{
		[DataMember(Order = 0)] 
		[Description("The exact direction of U[3], the derived Z axis direction.")]
		public IfcDirection Axis3 { get; set; }
	
	
		public IfcCartesianTransformationOperator3D(IfcCartesianPoint localOrigin)
			: base(localOrigin)
		{
		}
	
		public new IList<IfcDirection> U { get { return null; } }
	
	
	}
	
}
