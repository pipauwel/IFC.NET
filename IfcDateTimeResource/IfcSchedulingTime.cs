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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcDateTimeResource
{
	[Guid("b80d3213-eccf-4e8a-84a3-21c1381ff3cc")]
	public abstract partial class IfcSchedulingTime
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Optional name for the time definition.")]
		public IfcLabel? Name { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Specifies the origin of the scheduling time entity. It currently      differentiates between predicted, simulated, measured, and user defined values.")]
		public IfcDataOriginEnum? DataOrigin { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Value of the data origin if DataOrigin attribute is USERDEFINED.")]
		public IfcLabel? UserDefinedDataOrigin { get; set; }
	
	
		protected IfcSchedulingTime()
		{
		}
	
	
	}
	
}
