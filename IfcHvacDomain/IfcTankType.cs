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
	[Guid("7b849964-3035-4c02-a538-ef49c8650633")]
	public partial class IfcTankType : IfcFlowStorageDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the type of tank.")]
		[Required()]
		public IfcTankTypeEnum PredefinedType { get; set; }
	
	
		public IfcTankType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcTankTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
