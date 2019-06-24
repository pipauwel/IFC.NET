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
	[Guid("86bda50e-7c18-4972-89f1-276f7945a013")]
	public partial class IfcPipeSegmentType : IfcFlowSegmentType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The type of pipe segment.")]
		[Required()]
		public IfcPipeSegmentTypeEnum PredefinedType { get; set; }
	
	
		public IfcPipeSegmentType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcPipeSegmentTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
