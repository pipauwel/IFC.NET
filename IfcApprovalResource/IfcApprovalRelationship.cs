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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcApprovalResource
{
	[Guid("3ccb6ea3-b6eb-4134-b8a4-b738ae3f3001")]
	public partial class IfcApprovalRelationship
	{
		[DataMember(Order = 0)] 
		[Description("The approval that relates to another approval")]
		[Required()]
		public IfcApproval RelatedApproval { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The approval that other approval is related to.")]
		[Required()]
		public IfcApproval RelatingApproval { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Textual description explaining the relationship between approvals.")]
		public IfcText? Description { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The human readable name given to the relationship between the approvals.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
	
		public IfcApprovalRelationship(IfcApproval relatedApproval, IfcApproval relatingApproval, IfcLabel name)
		{
			this.RelatedApproval = relatedApproval;
			this.RelatingApproval = relatingApproval;
			this.Name = name;
		}
	
	
	}
	
}
