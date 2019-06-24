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
	[Guid("3c4a0114-740c-44cc-9f01-330789a56fae")]
	public partial class IfcDuctSegmentType : IfcFlowSegmentType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The type of duct segment.")]
		[Required()]
		public IfcDuctSegmentTypeEnum PredefinedType { get; set; }
	
	
		public IfcDuctSegmentType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcDuctSegmentTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
