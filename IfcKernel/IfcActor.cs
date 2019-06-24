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
	[Guid("4539d35c-fe44-4f6b-b7b2-db4abe00bb5f")]
	public partial class IfcActor : IfcObject
	{
		[DataMember(Order = 0)] 
		[Description("Information about the actor.")]
		[Required()]
		public IfcActorSelect TheActor { get; set; }
	
		[InverseProperty("RelatingActor")] 
		[Description("Reference to the relationship that associates the actor to an object.")]
		public ISet<IfcRelAssignsToActor> IsActingUpon { get; protected set; }
	
	
		public IfcActor(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcActorSelect theActor)
			: base(globalId, ownerHistory)
		{
			this.TheActor = theActor;
			this.IsActingUpon = new HashSet<IfcRelAssignsToActor>();
		}
	
	
	}
	
}
