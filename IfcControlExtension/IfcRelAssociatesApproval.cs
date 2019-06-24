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

using BuildingSmart.IFC.IfcApprovalResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcControlExtension
{
	[Guid("196fb722-ac59-498f-8159-2eb6608566d6")]
	public partial class IfcRelAssociatesApproval : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[Description("Reference to approval that is being applied using this relationship.")]
		[Required()]
		public IfcApproval RelatingApproval { get; set; }
	
	
		public IfcRelAssociatesApproval(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRoot[] relatedObjects, IfcApproval relatingApproval)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingApproval = relatingApproval;
		}
	
	
	}
	
}
