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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("d3e186ee-a556-43ee-af1a-e7dcdeba8bf0")]
	public abstract partial class IfcCsgPrimitive3D : IfcGeometricRepresentationItem,
		IfcBooleanOperand,
		IfcCsgSelect
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  The placement coordinate system to which the parameters of each individual CSG primitive apply.  </EPM-HTML>")]
		[Required()]
		public IfcAxis2Placement3D Position { get; set; }
	
	
		protected IfcCsgPrimitive3D(IfcAxis2Placement3D position)
		{
			this.Position = position;
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
