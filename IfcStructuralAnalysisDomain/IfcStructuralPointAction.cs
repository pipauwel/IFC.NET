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
	[Guid("f2ce99ea-99d3-451f-a967-09b259db6dff")]
	public partial class IfcStructuralPointAction : IfcStructuralAction
	{
	
		public IfcStructuralPointAction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal, Boolean destabilizingLoad)
			: base(globalId, ownerHistory, appliedLoad, globalOrLocal, destabilizingLoad)
		{
		}
	
	
	}
	
}
