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
using BuildingSmart.IFC.IFCTIMESERIESRESOURCE;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("59ccf55f-0899-4232-ba41-1fc821d5fcb5")]
	public partial class IfcSoundValue : IfcPropertySetDefinition
	{
		[DataMember(Order = 0)] 
		[Description("A time series of sound pressure or sound power values. For sound pressure levels, the values are measured in decibels at a reference pressure of 20 microPascals for the referenced octave band frequency. For sound power levels, the values are measured in decibels at a reference power of 1 picowatt(10^(-12) watt) for the referenced octave band frequency.")]
		public IfcTimeSeries SoundLevelTimeSeries { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The frequency of the sound.")]
		[Required()]
		public IfcFrequencyMeasure Frequency { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("A sound pressure or sound power value. For sound pressure levels, the values are measured in decibels at a reference pressure of 20 microPascals for the referenced octave band frequency. For sound power levels, the values are measured in decibels at a reference power of 1 picowatt(10^(-12) watt) for the referenced octave band frequency.")]
		public IfcDerivedMeasureValue SoundLevelSingleValue { get; set; }
	
	
		public IfcSoundValue(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcFrequencyMeasure frequency)
			: base(globalId, ownerHistory)
		{
			this.Frequency = frequency;
		}
	
	
	}
	
}
