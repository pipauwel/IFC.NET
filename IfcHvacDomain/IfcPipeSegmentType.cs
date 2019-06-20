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
	[Guid("6ff8bb62-5b12-4204-85f9-d8aea8bb8b00")]
	public partial class IfcPipeSegmentType : IfcFlowSegmentType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The type of pipe segment.")]
		[Required()]
		public IfcPipeSegmentTypeEnum PredefinedType { get; set; }
	
	
		public IfcPipeSegmentType(IfcGloballyUniqueId globalId, IfcPipeSegmentTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
