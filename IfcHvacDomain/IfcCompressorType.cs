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
	[Guid("51c0fcf6-3956-4c6e-b077-4419532c5e74")]
	public partial class IfcCompressorType : IfcFlowMovingDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the type of compressor (e.g., hermetic, reciprocating, etc.).")]
		[Required()]
		public IfcCompressorTypeEnum PredefinedType { get; set; }
	
	
		public IfcCompressorType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcCompressorTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
