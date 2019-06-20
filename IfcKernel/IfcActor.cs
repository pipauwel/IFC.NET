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
	[Guid("463dbc90-5ef6-4411-b9c2-71144e8ed08d")]
	public partial class IfcActor : IfcObject
	{
		[DataMember(Order = 0)] 
		[Description("Information about the actor.")]
		[Required()]
		public IfcActorSelect TheActor { get; set; }
	
		[InverseProperty("RelatingActor")] 
		[Description("Reference to the relationship that associates the actor to an object.")]
		public ISet<IfcRelAssignsToActor> IsActingUpon { get; protected set; }
	
	
		public IfcActor(IfcGloballyUniqueId globalId, IfcActorSelect theActor)
			: base(globalId)
		{
			this.TheActor = theActor;
			this.IsActingUpon = new HashSet<IfcRelAssignsToActor>();
		}
	
	
	}
	
}
