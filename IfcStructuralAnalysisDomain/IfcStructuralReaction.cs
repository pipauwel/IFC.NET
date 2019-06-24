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
	[Guid("6430b90a-bc13-49fa-90e0-254576ac9316")]
	public abstract partial class IfcStructuralReaction : IfcStructuralActivity
	{
		[InverseProperty("CausedBy")] 
		[Description("Optional reference to instances of IfcStructuralAction which directly depend on this reaction. This reference is only needed if dependencies between structural analysis models must be captured.")]
		public ISet<IfcStructuralAction> Causes { get; protected set; }
	
	
		protected IfcStructuralReaction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal)
			: base(globalId, ownerHistory, appliedLoad, globalOrLocal)
		{
			this.Causes = new HashSet<IfcStructuralAction>();
		}
	
	
	}
	
}
