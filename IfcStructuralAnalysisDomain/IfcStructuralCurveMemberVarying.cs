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
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("4e0d2a97-7485-4958-a7af-66da7c2d8c31")]
	public partial class IfcStructuralCurveMemberVarying : IfcStructuralCurveMember
	{
	
		public IfcStructuralCurveMemberVarying(IfcGloballyUniqueId globalId, IfcStructuralCurveMemberTypeEnum predefinedType, IfcDirection axis)
			: base(globalId, predefinedType, axis)
		{
		}
	
	
	}
	
}
