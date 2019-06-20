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
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("1e012790-9138-46ab-b075-8f853dffbdf8")]
	public partial class IfcReinforcementDefinitionProperties : IfcPreDefinedPropertySet
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Descriptive type name applied to reinforcement definition properties.")]
		public IfcLabel? DefinitionType { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The list of section reinforcement properties attached to the reinforcement definition properties.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcSectionReinforcementProperties> ReinforcementSectionDefinitions { get; protected set; }
	
	
		public IfcReinforcementDefinitionProperties(IfcGloballyUniqueId globalId, IfcSectionReinforcementProperties[] reinforcementSectionDefinitions)
			: base(globalId)
		{
			this.ReinforcementSectionDefinitions = new List<IfcSectionReinforcementProperties>(reinforcementSectionDefinitions);
		}
	
	
	}
	
}
