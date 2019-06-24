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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("cf235ade-9bdb-4c6d-affb-f537deaad8c1")]
	public partial class IfcRelAssignsToActor : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the information about the actor. It comprises the information about the person or organization and its addresses.")]
		[Required()]
		public IfcActor RelatingActor { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Role of the actor played within the context of the assignment to the object(s).")]
		public IfcActorRole ActingRole { get; set; }
	
	
		public IfcRelAssignsToActor(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObjectDefinition[] relatedObjects, IfcActor relatingActor)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingActor = relatingActor;
		}
	
	
	}
	
}
