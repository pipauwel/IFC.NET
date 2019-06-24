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
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcHvacDomain
{
	[Guid("114f245e-92ae-4ee8-acb6-f89683165b50")]
	public partial class IfcVibrationIsolatorType : IfcDiscreteAccessoryType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the type of vibration isolator.")]
		[Required()]
		public IfcVibrationIsolatorTypeEnum PredefinedType { get; set; }
	
	
		public IfcVibrationIsolatorType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcVibrationIsolatorTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
