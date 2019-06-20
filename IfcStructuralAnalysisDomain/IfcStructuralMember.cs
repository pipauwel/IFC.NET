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
	[Guid("a37e785d-9c63-4d0c-acff-e17f5fc43811")]
	public abstract partial class IfcStructuralMember : IfcStructuralItem
	{
		[InverseProperty("RelatingStructuralMember")] 
		[Description("Inverse relationship to all structural connections (i.e. to supports or connecting elements) which are defined for this structural member.")]
		public ISet<IfcRelConnectsStructuralMember> ConnectedBy { get; protected set; }
	
	
		protected IfcStructuralMember(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.ConnectedBy = new HashSet<IfcRelConnectsStructuralMember>();
		}
	
	
	}
	
}
