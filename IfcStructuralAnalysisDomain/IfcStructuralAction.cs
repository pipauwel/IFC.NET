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
	[Guid("db0b36c0-b174-4a54-9aee-a0ca2238d6ec")]
	public abstract partial class IfcStructuralAction : IfcStructuralActivity
	{
		[DataMember(Order = 0)] 
		[Description("Indicates if this action may cause a stability problem. If it is 'FALSE', no further investigations regarding stability problems are necessary.")]
		[Required()]
		public Boolean DestabilizingLoad { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Optional reference to an instance of IfcStructuralReaction representing a result of another structural analysis model which creates this action upon the considered structural analysis model.")]
		public IfcStructuralReaction CausedBy { get; set; }
	
	
		protected IfcStructuralAction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal, Boolean destabilizingLoad)
			: base(globalId, ownerHistory, appliedLoad, globalOrLocal)
		{
			this.DestabilizingLoad = destabilizingLoad;
		}
	
	
	}
	
}
