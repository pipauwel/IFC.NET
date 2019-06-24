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

using BuildingSmart.IFC.IfcConstraintResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IFCTIMESERIESRESOURCE
{
	[Guid("16385c7b-e0f0-4a6e-ac99-615c3bd64eb7")]
	public partial class IfcRegularTimeSeries : IfcTimeSeries
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("A duration of time intervals between values.")]
		[Required()]
		public IfcTimeMeasure TimeStep { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The collection of time series values.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcTimeSeriesValue> Values { get; protected set; }
	
	
		public IfcRegularTimeSeries(IfcLabel name, IfcDateTimeSelect startTime, IfcDateTimeSelect endTime, IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, IfcTimeMeasure timeStep, IfcTimeSeriesValue[] values)
			: base(name, startTime, endTime, timeSeriesDataType, dataOrigin)
		{
			this.TimeStep = timeStep;
			this.Values = new List<IfcTimeSeriesValue>(values);
		}
	
	
	}
	
}
