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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("28b9f074-33d7-4367-9560-a706ea198e5a")]
	public partial class IfcSoundProperties : IfcPropertySetDefinition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("If TRUE, values represent sound attenuation. If FALSE, values represent sound generation.")]
		[Required()]
		public IfcBoolean IsAttenuating { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Reference sound scale")]
		public IfcSoundScaleEnum? SoundScale { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Sound values at a specific frequency. There may be cases where less than eight values are specified.")]
		[Required()]
		[MinLength(1)]
		[MaxLength(8)]
		public IList<IfcSoundValue> SoundValues { get; protected set; }
	
	
		public IfcSoundProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcBoolean isAttenuating, IfcSoundValue[] soundValues)
			: base(globalId, ownerHistory)
		{
			this.IsAttenuating = isAttenuating;
			this.SoundValues = new List<IfcSoundValue>(soundValues);
		}
	
	
	}
	
}
