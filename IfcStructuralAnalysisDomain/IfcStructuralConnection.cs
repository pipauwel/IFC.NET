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
	[Guid("d4640db1-7b55-4f79-8ba6-05b016369801")]
	public abstract partial class IfcStructuralConnection : IfcStructuralItem
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Optional boundary conditions which define support conditions of this connection object, given in local coordinate directions of the connection object.  If left unspecified, the connection object is assumed to have no supports besides being connected with members.")]
		public IfcBoundaryCondition AppliedCondition { get; set; }
	
		[InverseProperty("RelatedStructuralConnection")] 
		[Description("References to the IfcRelConnectsStructuralMembers relationship by which structural members can be associated to structural connections.")]
		[MinLength(1)]
		public ISet<IfcRelConnectsStructuralMember> ConnectsStructuralMembers { get; protected set; }
	
	
		protected IfcStructuralConnection(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.ConnectsStructuralMembers = new HashSet<IfcRelConnectsStructuralMember>();
		}
	
	
	}
	
}
