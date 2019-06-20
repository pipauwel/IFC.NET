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
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcDateTimeResource
{
	[Guid("70d36884-89fe-4808-9584-00b43dbc8c2e")]
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
	
	
		public IfcRegularTimeSeries(IfcLabel name, IfcDateTime startTime, IfcDateTime endTime, IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, IfcTimeMeasure timeStep, IfcTimeSeriesValue[] values)
			: base(name, startTime, endTime, timeSeriesDataType, dataOrigin)
		{
			this.TimeStep = timeStep;
			this.Values = new List<IfcTimeSeriesValue>(values);
		}
	
	
	}
	
}
