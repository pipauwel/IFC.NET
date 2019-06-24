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
	[Guid("2f1dc4c5-4ebd-4780-9983-7c1c2904aaf0")]
	public partial class IfcDuctSilencerType : IfcFlowTreatmentDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The type of duct silencer.")]
		[Required()]
		public IfcDuctSilencerTypeEnum PredefinedType { get; set; }
	
	
		public IfcDuctSilencerType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcDuctSilencerTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
