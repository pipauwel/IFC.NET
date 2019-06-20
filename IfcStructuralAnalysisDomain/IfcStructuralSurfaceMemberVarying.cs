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
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("66950826-279c-419b-94ba-f2cc8d28c876")]
	public partial class IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember
	{
	
		public IfcStructuralSurfaceMemberVarying(IfcGloballyUniqueId globalId, IfcStructuralSurfaceMemberTypeEnum predefinedType)
			: base(globalId, predefinedType)
		{
		}
	
	
	}
	
}
