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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcConstraintResource
{
	[Guid("f27d8f9b-d773-45c4-b8cf-20a75a7c28c4")]
	public partial class IfcMetric : IfcConstraint
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Enumeration that identifies the type of benchmark data.")]
		[Required()]
		public IfcBenchmarkEnum Benchmark { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Reference source for data values.")]
		public IfcLabel? ValueSource { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Value with data type defined by the DataType enumeration.")]
		[Required()]
		public IfcMetricValueSelect DataValue { get; set; }
	
	
		public IfcMetric(IfcLabel name, IfcConstraintEnum constraintGrade, IfcBenchmarkEnum benchmark, IfcMetricValueSelect dataValue)
			: base(name, constraintGrade)
		{
			this.Benchmark = benchmark;
			this.DataValue = dataValue;
		}
	
	
	}
	
}
