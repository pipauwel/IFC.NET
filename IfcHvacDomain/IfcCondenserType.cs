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
	[Guid("2466a40b-ca8e-4d0b-9b07-6e14f31daa59")]
	public partial class IfcCondenserType : IfcEnergyConversionDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the type of condenser.")]
		[Required()]
		public IfcCondenserTypeEnum PredefinedType { get; set; }
	
	
		public IfcCondenserType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcCondenserTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
