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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("e471c212-612d-4578-8f9e-e9623be892bf")]
	public partial class IfcDistributionChamberElementType : IfcDistributionFlowElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined types of distribution chambers.")]
		[Required()]
		public IfcDistributionChamberElementTypeEnum PredefinedType { get; set; }
	
	
		public IfcDistributionChamberElementType(IfcGloballyUniqueId globalId, IfcDistributionChamberElementTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
