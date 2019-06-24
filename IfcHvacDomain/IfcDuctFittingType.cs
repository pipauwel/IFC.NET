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
	[Guid("af8c4daa-5e29-40de-99dd-a1a3cf869178")]
	public partial class IfcDuctFittingType : IfcFlowFittingType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The type of duct fitting.")]
		[Required()]
		public IfcDuctFittingTypeEnum PredefinedType { get; set; }
	
	
		public IfcDuctFittingType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcDuctFittingTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
