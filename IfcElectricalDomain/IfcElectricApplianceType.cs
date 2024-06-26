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
	[Guid("be19a872-6f1f-4092-bda3-2eb40ffddb3a")]
	public partial class IfcElectricApplianceType : IfcFlowTerminalType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifies the predefined types of electrical appliance from which the type required may be set.")]
		[Required()]
		public IfcElectricApplianceTypeEnum PredefinedType { get; set; }
	
	
		public IfcElectricApplianceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElectricApplianceTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
