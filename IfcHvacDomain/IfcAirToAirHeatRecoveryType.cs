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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcHvacDomain
{
	[Guid("85f459a0-3831-4b34-b397-56bb368682cd")]
	public partial class IfcAirToAirHeatRecoveryType : IfcEnergyConversionDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the type of air to air heat recovery device.")]
		[Required()]
		public IfcAirToAirHeatRecoveryTypeEnum PredefinedType { get; set; }
	
	
		public IfcAirToAirHeatRecoveryType(IfcGloballyUniqueId globalId, IfcAirToAirHeatRecoveryTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
