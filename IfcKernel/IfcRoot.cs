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
	[Guid("573a9f55-5906-4592-af57-a0b4b630765d")]
	public abstract partial class IfcRoot
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Assignment of a globally unique identifier within the entire software world.")]
		[Required()]
		public IfcGloballyUniqueId GlobalId { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Assignment of the information about the current ownership of that object, including owning actor, application, local identification and information captured about the recent changes of the object, NOTE: only the last modification in stored.")]
		[Required()]
		public IfcOwnerHistory OwnerHistory { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Optional name for use by the participating software systems or users. For some subtypes of IfcRoot the insertion of the Name attribute may be required. This would be enforced by a where rule.")]
		public IfcLabel? Name { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Optional description, provided for exchanging informative comments.")]
		public IfcText? Description { get; set; }
	
	
		protected IfcRoot(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
		{
			this.GlobalId = globalId;
			this.OwnerHistory = ownerHistory;
		}
	
	
	}
	
}
