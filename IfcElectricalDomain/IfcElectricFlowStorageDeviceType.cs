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

namespace BuildingSmart.IFC.IfcElectricalDomain
{
	[Guid("36231551-863d-412e-9977-03a196cf6537")]
	public partial class IfcElectricFlowStorageDeviceType : IfcFlowStorageDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Required()]
		public IfcElectricFlowStorageDeviceTypeEnum PredefinedType { get; set; }
	
	
		public IfcElectricFlowStorageDeviceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElectricFlowStorageDeviceTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
