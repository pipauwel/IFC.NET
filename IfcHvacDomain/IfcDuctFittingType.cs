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
	[Guid("cb200223-5993-48b1-9720-c4e9380a4074")]
	public partial class IfcDuctFittingType : IfcFlowFittingType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The type of duct fitting.")]
		[Required()]
		public IfcDuctFittingTypeEnum PredefinedType { get; set; }
	
	
		public IfcDuctFittingType(IfcGloballyUniqueId globalId, IfcDuctFittingTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
