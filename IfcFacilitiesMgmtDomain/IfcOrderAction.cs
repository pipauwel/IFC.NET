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
using BuildingSmart.IFC.IfcProcessExtension;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IFCFACILITIESMGMTDOMAIN
{
	[Guid("c7a4c56f-a990-47cd-9d1a-7886d471fa80")]
	public partial class IfcOrderAction : IfcTask
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("A unique identifier assigned to an action on issue.")]
		[Required()]
		public IfcIdentifier ActionID { get; set; }
	
	
		public IfcOrderAction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcIdentifier taskId, Boolean isMilestone, IfcIdentifier actionID)
			: base(globalId, ownerHistory, taskId, isMilestone)
		{
			this.ActionID = actionID;
		}
	
	
	}
	
}
