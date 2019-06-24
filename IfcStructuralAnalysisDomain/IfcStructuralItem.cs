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
	[Guid("e4c8ad16-5d37-4592-b106-b37d095e620d")]
	public abstract partial class IfcStructuralItem : IfcProduct,
		IfcStructuralActivityAssignmentSelect
	{
		[InverseProperty("RelatingElement")] 
		[Description("Inverse relationship to all structural activities (i.e. to actions or reactions) which are assigned to this structural member.")]
		public ISet<IfcRelConnectsStructuralActivity> AssignedStructuralActivity { get; protected set; }
	
	
		protected IfcStructuralItem(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.AssignedStructuralActivity = new HashSet<IfcRelConnectsStructuralActivity>();
		}
	
	
	}
	
}
