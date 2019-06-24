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
	[Guid("74f28ee8-1bff-4f28-bfde-eaa2ccce9e9d")]
	public abstract partial class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem
	{
		[DataMember(Order = 0)] 
		[Description("The direction used to determine U[1], the derived X axis direction.")]
		public IfcDirection Axis1 { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The direction used to determine U[2], the derived Y axis direction.")]
		public IfcDirection Axis2 { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("The required translation, specified as a cartesian point. The actual translation included in the transformation is from the geometric origin to the local origin.")]
		[Required()]
		public IfcCartesianPoint LocalOrigin { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("The scaling value specified for the transformation.")]
		public Double? Scale { get; set; }
	
	
		protected IfcCartesianTransformationOperator(IfcCartesianPoint localOrigin)
		{
			this.LocalOrigin = localOrigin;
		}
	
		public new Double Scl { get { return null; } }
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
