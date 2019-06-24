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
	[Guid("a07e519b-a38a-44c2-b3aa-2fb700d47528")]
	public partial class IfcFilterType : IfcFlowTreatmentDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The type of air filter.")]
		[Required()]
		public IfcFilterTypeEnum PredefinedType { get; set; }
	
	
		public IfcFilterType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcFilterTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
