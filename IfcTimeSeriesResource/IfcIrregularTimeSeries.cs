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
	[Guid("81b7ef9c-51e6-4318-9f1e-55983d7868e5")]
	public partial class IfcIrregularTimeSeries : IfcTimeSeries
	{
		[DataMember(Order = 0)] 
		[Description("The collection of time series values.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcIrregularTimeSeriesValue> Values { get; protected set; }
	
	
		public IfcIrregularTimeSeries(IfcLabel name, IfcDateTimeSelect startTime, IfcDateTimeSelect endTime, IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, IfcIrregularTimeSeriesValue[] values)
			: base(name, startTime, endTime, timeSeriesDataType, dataOrigin)
		{
			this.Values = new List<IfcIrregularTimeSeriesValue>(values);
		}
	
	
	}
	
}
