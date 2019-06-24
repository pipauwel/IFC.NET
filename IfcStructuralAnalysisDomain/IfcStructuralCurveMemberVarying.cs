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
	[Guid("d39530b5-8c0d-4562-9116-4b7d38714ec8")]
	public partial class IfcStructuralCurveMemberVarying : IfcStructuralCurveMember
	{
	
		public IfcStructuralCurveMemberVarying(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcStructuralCurveTypeEnum predefinedType)
			: base(globalId, ownerHistory, predefinedType)
		{
		}
	
	
	}
	
}
