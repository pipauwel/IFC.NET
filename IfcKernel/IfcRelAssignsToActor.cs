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
	[Guid("697bb1a2-488c-4282-8300-a66e028db272")]
	public partial class IfcRelAssignsToActor : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Reference to the information about the actor. It comprises the information about the person or organization and its addresses.")]
		[Required()]
		public IfcActor RelatingActor { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Role of the actor played within the context of the assignment to the object(s).")]
		public IfcActorRole ActingRole { get; set; }
	
	
		public IfcRelAssignsToActor(IfcGloballyUniqueId globalId, IfcObjectDefinition[] relatedObjects, IfcActor relatingActor)
			: base(globalId, relatedObjects)
		{
			this.RelatingActor = relatingActor;
		}
	
	
	}
	
}
