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
	[Guid("6b83f3bc-08a2-4147-aa9d-353fb6ea8b10")]
	public partial class IfcIrregularTimeSeries : IfcTimeSeries
	{
		[DataMember(Order = 0)] 
		[Description("The collection of time series values.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcIrregularTimeSeriesValue> Values { get; protected set; }
	
	
		public IfcIrregularTimeSeries(IfcLabel name, IfcDateTime startTime, IfcDateTime endTime, IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, IfcIrregularTimeSeriesValue[] values)
			: base(name, startTime, endTime, timeSeriesDataType, dataOrigin)
		{
			this.Values = new List<IfcIrregularTimeSeriesValue>(values);
		}
	
	
	}
	
}
