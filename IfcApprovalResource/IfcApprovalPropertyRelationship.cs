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

using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcApprovalResource
{
	[Guid("1c2aec54-d28d-469c-bbc5-858f9995cd6c")]
	public partial class IfcApprovalPropertyRelationship
	{
		[DataMember(Order = 0)] 
		[Description("Properties approved by the approval.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcProperty> ApprovedProperties { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("The approval for the properties selected.")]
		[Required()]
		public IfcApproval Approval { get; set; }
	
	
		public IfcApprovalPropertyRelationship(IfcProperty[] approvedProperties, IfcApproval approval)
		{
			this.ApprovedProperties = new HashSet<IfcProperty>(approvedProperties);
			this.Approval = approval;
		}
	
	
	}
	
}
