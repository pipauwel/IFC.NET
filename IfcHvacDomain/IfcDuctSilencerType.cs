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
	[Guid("b6e2b5f0-ba5e-4c1d-8134-0a940db3ccec")]
	public partial class IfcDuctSilencerType : IfcFlowTreatmentDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The type of duct silencer.")]
		[Required()]
		public IfcDuctSilencerTypeEnum PredefinedType { get; set; }
	
	
		public IfcDuctSilencerType(IfcGloballyUniqueId globalId, IfcDuctSilencerTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
