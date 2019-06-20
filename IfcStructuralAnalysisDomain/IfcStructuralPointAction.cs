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
using BuildingSmart.IFC.IfcStructuralLoadResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("bb3faf6b-1958-4e7d-87fd-72938d5456cc")]
	public partial class IfcStructuralPointAction : IfcStructuralAction
	{
	
		public IfcStructuralPointAction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal)
			: base(globalId, appliedLoad, globalOrLocal)
		{
		}
	
	
	}
	
}
