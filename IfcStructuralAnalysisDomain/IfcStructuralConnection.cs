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
	[Guid("d51c7f76-137f-4445-9406-c987d9f4cf65")]
	public abstract partial class IfcStructuralConnection : IfcStructuralItem
	{
		[DataMember(Order = 0)] 
		[Description("Optional reference to an instance of IfcBoundaryCondition which defines the support condition of this 'connection'.")]
		public IfcBoundaryCondition AppliedCondition { get; set; }
	
		[InverseProperty("RelatedStructuralConnection")] 
		[Description("References to the IfcRelConnectsStructuralMembers relationship by which structural members can be associated to structural connections.")]
		[MinLength(1)]
		public ISet<IfcRelConnectsStructuralMember> ConnectsStructuralMembers { get; protected set; }
	
	
		protected IfcStructuralConnection(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.ConnectsStructuralMembers = new HashSet<IfcRelConnectsStructuralMember>();
		}
	
	
	}
	
}
