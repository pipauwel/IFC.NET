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
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcConstraintResource
{
	[Guid("80e1bafe-6a4a-46c1-9f7d-1c432b1ad3f8")]
	public partial class IfcMetric : IfcConstraint
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Enumeration that identifies the type of benchmark data.")]
		[Required()]
		public IfcBenchmarkEnum Benchmark { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Reference source for data values.     If <i>DataValue</i> refers to an <i>IfcTable</i>, this attribute identifies the relevent column identified by <i>IfcTableColumn</i>.<i>Identifier</i>.")]
		public IfcLabel? ValueSource { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("The value to be compared on associated objects. A null value indicates comparison to null.  <blockquote class=\"change-ifc4\">IFC4 ADD1 CHANGE&nbsp;  This attribute is now optional.</blockquote>")]
		public IfcMetricValueSelect DataValue { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlElement]
		[Description("Optional path to an attribute to be constrained on associated objects.  If provided, the metric may be validated by resolving the path to the current value on associated object(s), and comparing such value with <i>DataValue</i> according to the <i>Benchmark</i>.")]
		public IfcReference ReferencePath { get; set; }
	
	
		public IfcMetric(IfcLabel name, IfcConstraintEnum constraintGrade, IfcBenchmarkEnum benchmark)
			: base(name, constraintGrade)
		{
			this.Benchmark = benchmark;
		}
	
	
	}
	
}
