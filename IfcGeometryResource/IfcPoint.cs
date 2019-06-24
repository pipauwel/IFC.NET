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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("63bcc5b3-4e9c-4b21-a41d-5a4d58a2d15f")]
	public abstract partial class IfcPoint : IfcGeometricRepresentationItem,
		BuildingSmart.IFC.IfcGeometricModelResource.IfcGeometricSetSelect,
		BuildingSmart.IFC.IfcGeometricConstraintResource.IfcPointOrVertexPoint
	{
	
		protected IfcPoint()
		{
		}
	
	
	}
	
}
