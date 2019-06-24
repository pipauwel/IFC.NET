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

using BuildingSmart.IFC.IfcActorResource;

namespace BuildingSmart.IFC.IfcApprovalResource
{
	[Guid("6ae78aed-f390-404d-8b25-5bae729a7cd7")]
	public partial class IfcApprovalActorRelationship
	{
		[DataMember(Order = 0)] 
		[Description("The reference to the actor who is acting in the given role on the approval specified in this relationship.")]
		[Required()]
		public IfcActorSelect Actor { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The approval on which the actor is acting in the role specified in this relationship.")]
		[Required()]
		public IfcApproval Approval { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("The role of the actor w.r.t the approval.")]
		[Required()]
		public IfcActorRole Role { get; set; }
	
	
		public IfcApprovalActorRelationship(IfcActorSelect actor, IfcApproval approval, IfcActorRole role)
		{
			this.Actor = actor;
			this.Approval = approval;
			this.Role = role;
		}
	
	
	}
	
}
