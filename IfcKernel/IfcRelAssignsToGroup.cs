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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("69a2f5df-0a6f-46a6-b8cd-5a91fed61989")]
	public partial class IfcRelAssignsToGroup : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[Description("Reference to group that finally contains all assigned group members.")]
		[Required()]
		public IfcGroup RelatingGroup { get; set; }
	
	
		public IfcRelAssignsToGroup(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObjectDefinition[] relatedObjects, IfcGroup relatingGroup)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingGroup = relatingGroup;
		}
	
	
	}
	
}
