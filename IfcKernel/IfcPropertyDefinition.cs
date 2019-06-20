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
	[Guid("244ca500-edbb-46f5-9ab8-9560710b61a4")]
	public abstract partial class IfcPropertyDefinition : IfcRoot,
		IfcDefinitionSelect
	{
		[InverseProperty("RelatedDefinitions")] 
		[MaxLength(1)]
		public ISet<IfcRelDeclares> HasContext { get; protected set; }
	
		[InverseProperty("RelatedObjects")] 
		[Description("Reference to the relationship IfcRelAssociates and thus to those externally defined concepts, like classifications, documents, or library information, which are associated to the property definition.")]
		public ISet<IfcRelAssociates> HasAssociations { get; protected set; }
	
	
		protected IfcPropertyDefinition(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.HasContext = new HashSet<IfcRelDeclares>();
			this.HasAssociations = new HashSet<IfcRelAssociates>();
		}
	
	
	}
	
}
