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
	[Guid("8ee8ef7b-68ac-46bb-8c28-b6f508eeb0ab")]
	public partial class IfcRelDefinesByTemplate : IfcRelDefines
	{
		[DataMember(Order = 0)] 
		[Description("One or many property sets or quantity sets that obtain their definitions from the single property set template.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcPropertySetDefinition> RelatedPropertySets { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Property set template that provides the common definition of related property sets.")]
		[Required()]
		public IfcPropertySetTemplate RelatingTemplate { get; set; }
	
	
		public IfcRelDefinesByTemplate(IfcGloballyUniqueId globalId, IfcPropertySetDefinition[] relatedPropertySets, IfcPropertySetTemplate relatingTemplate)
			: base(globalId)
		{
			this.RelatedPropertySets = new HashSet<IfcPropertySetDefinition>(relatedPropertySets);
			this.RelatingTemplate = relatingTemplate;
		}
	
	
	}
	
}
