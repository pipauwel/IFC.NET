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
	[Guid("d4a072dd-513c-42b9-bca3-97a683fdfb56")]
	public partial class IfcSpaceProgram : IfcControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifier for this space program. It often refers to a number (or code) assigned to the space program. Example: R-001.")]
		[Required()]
		public IfcIdentifier SpaceProgramIdentifier { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The maximum floor area programmed for this space (according to client requirements)")]
		public IfcAreaMeasure? MaxRequiredArea { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The minimum floor area programmed for this space (according to client requirements)")]
		public IfcAreaMeasure? MinRequiredArea { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("Location within the building structure, requested for the space.")]
		public IfcSpatialStructureElement RequestedLocation { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The floor area programmed for this space (according to client requirements).")]
		[Required()]
		public IfcAreaMeasure StandardRequiredArea { get; set; }
	
		[InverseProperty("RelatedSpaceProgram")] 
		[Description("Set of inverse relationships to space or work interaction requirement objects (FOR RelatedObject).")]
		public ISet<IfcRelInteractionRequirements> HasInteractionReqsFrom { get; protected set; }
	
		[InverseProperty("RelatingSpaceProgram")] 
		[Description("Set of inverse relationships to space or work interaction requirements (FOR RelatingObject).")]
		public ISet<IfcRelInteractionRequirements> HasInteractionReqsTo { get; protected set; }
	
	
		public IfcSpaceProgram(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcIdentifier spaceProgramIdentifier, IfcAreaMeasure standardRequiredArea)
			: base(globalId, ownerHistory)
		{
			this.SpaceProgramIdentifier = spaceProgramIdentifier;
			this.StandardRequiredArea = standardRequiredArea;
			this.HasInteractionReqsFrom = new HashSet<IfcRelInteractionRequirements>();
			this.HasInteractionReqsTo = new HashSet<IfcRelInteractionRequirements>();
		}
	
	
	}
	
}
