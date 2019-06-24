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
	[Guid("6598c933-b905-44ea-8878-9e20fd96c12d")]
	public abstract partial class IfcStructuralMember : IfcStructuralItem
	{
		[InverseProperty("RelatedStructuralMember")] 
		[Description("<EPM-HTML>  Inverse link to the relationship object, that connects a physical element to this structural member (the element of which this structural member is the analytical idealization).  </EPM-HTML>")]
		public ISet<IfcRelConnectsStructuralElement> ReferencesElement { get; protected set; }
	
		[InverseProperty("RelatingStructuralMember")] 
		[Description("Inverse relationship to all structural connections (i.e. to supports or connecting elements) which are defined for this structural member.")]
		public ISet<IfcRelConnectsStructuralMember> ConnectedBy { get; protected set; }
	
	
		protected IfcStructuralMember(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.ReferencesElement = new HashSet<IfcRelConnectsStructuralElement>();
			this.ConnectedBy = new HashSet<IfcRelConnectsStructuralMember>();
		}
	
	
	}
	
}
