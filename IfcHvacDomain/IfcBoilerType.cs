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
	[Guid("c87227ad-0a1d-4c30-a4a2-fe16fb058634")]
	public partial class IfcBoilerType : IfcEnergyConversionDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines types of boilers.")]
		[Required()]
		public IfcBoilerTypeEnum PredefinedType { get; set; }
	
	
		public IfcBoilerType(IfcGloballyUniqueId globalId, IfcBoilerTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}