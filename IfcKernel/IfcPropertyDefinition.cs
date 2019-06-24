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
	[Guid("613ef451-122d-45b6-b80b-e7f78ee431c5")]
	public abstract partial class IfcPropertyDefinition : IfcRoot
	{
		[InverseProperty("RelatedObjects")] 
		[Description("Reference to the relationship IfcRelAssociates and thus to those externally defined concepts, like classifications, documents, or library information, which are associated to the property definition.")]
		public ISet<IfcRelAssociates> HasAssociations { get; protected set; }
	
	
		protected IfcPropertyDefinition(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.HasAssociations = new HashSet<IfcRelAssociates>();
		}
	
	
	}
	
}
