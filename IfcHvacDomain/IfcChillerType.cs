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
	[Guid("dbff40dc-2f71-4e72-9684-78cd6d4553a3")]
	public partial class IfcChillerType : IfcEnergyConversionDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the typical types of chillers (e.g., air-cooled, water-cooled, etc.).")]
		[Required()]
		public IfcChillerTypeEnum PredefinedType { get; set; }
	
	
		public IfcChillerType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcChillerTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
