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
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcArchitectureDomain
{
	[Guid("fb93ae0f-ebff-4dd4-8c7f-b8a9fe4099d4")]
	public partial class IfcRelInteractionRequirements : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Number of interactions occurring on a daily basis.")]
		public IfcCountMeasure? DailyInteraction { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Represents the level of importance of interaction. 0 represents lowest importance, 1 represents highest importance.")]
		public IfcNormalisedRatioMeasure? ImportanceRating { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("The location where this interaction happens.")]
		public IfcSpatialStructureElement LocationOfInteraction { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("Related space program for the interaction requirement.")]
		[Required()]
		public IfcSpaceProgram RelatedSpaceProgram { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("Relating space program for the interaction requirement.")]
		[Required()]
		public IfcSpaceProgram RelatingSpaceProgram { get; set; }
	
	
		public IfcRelInteractionRequirements(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcSpaceProgram relatedSpaceProgram, IfcSpaceProgram relatingSpaceProgram)
			: base(globalId, ownerHistory)
		{
			this.RelatedSpaceProgram = relatedSpaceProgram;
			this.RelatingSpaceProgram = relatingSpaceProgram;
		}
	
	
	}
	
}
