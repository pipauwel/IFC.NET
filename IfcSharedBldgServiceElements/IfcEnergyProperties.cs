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
	[Guid("394bd3c4-2aed-40d7-b419-a40224b9729a")]
	public partial class IfcEnergyProperties : IfcPropertySetDefinition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		public IfcEnergySequenceEnum? EnergySequence { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("This attribute must be defined if the EnergySequence is USERDEFINED.")]
		public IfcLabel? UserDefinedEnergySequence { get; set; }
	
	
		public IfcEnergyProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
		}
	
	
	}
	
}
