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

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IFCFACILITIESMGMTDOMAIN
{
	[Guid("b6d11163-93eb-4d0a-b9aa-45d080259377")]
	public partial class IfcActionRequest : IfcControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("A unique identifier assigned to the request on receipt.")]
		[Required()]
		public IfcIdentifier RequestID { get; set; }
	
	
		public IfcActionRequest(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcIdentifier requestID)
			: base(globalId, ownerHistory)
		{
			this.RequestID = requestID;
		}
	
	
	}
	
}
