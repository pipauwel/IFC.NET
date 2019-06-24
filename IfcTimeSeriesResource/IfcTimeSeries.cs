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
	[Guid("bc1798c5-7055-4819-ae25-b976bd53c66a")]
	public abstract partial class IfcTimeSeries :
		BuildingSmart.IFC.IfcConstraintResource.IfcMetricValueSelect,
		BuildingSmart.IFC.IfcPropertyResource.IfcObjectReferenceSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("An unique name for the time series.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("A text description of the data that the series represents.")]
		public IfcText? Description { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("The start time of a time series.")]
		[Required()]
		public IfcDateTimeSelect StartTime { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("The end time of a time series.")]
		[Required()]
		public IfcDateTimeSelect EndTime { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The time series data type.")]
		[Required()]
		public IfcTimeSeriesDataTypeEnum TimeSeriesDataType { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("The orgin of a time series data.")]
		[Required()]
		public IfcDataOriginEnum DataOrigin { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("Value of the data origin if DataOrigin attribute is USERDEFINED.")]
		public IfcLabel? UserDefinedDataOrigin { get; set; }
	
		[DataMember(Order = 7)] 
		[Description("<EPM-HTML>  The unit to be assigned to all values within the time series. Note that mixing units is not allowed. If the value is not given, the global unit for the type of <I>IfcValue</I>, as defined at <I>IfcProject.UnitsInContext</I> is used.  </EPM-HTML>")]
		public IfcUnit Unit { get; set; }
	
		[InverseProperty("ReferencedTimeSeries")] 
		[MaxLength(1)]
		public ISet<IfcTimeSeriesReferenceRelationship> DocumentedBy { get; protected set; }
	
	
		protected IfcTimeSeries(IfcLabel name, IfcDateTimeSelect startTime, IfcDateTimeSelect endTime, IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin)
		{
			this.Name = name;
			this.StartTime = startTime;
			this.EndTime = endTime;
			this.TimeSeriesDataType = timeSeriesDataType;
			this.DataOrigin = dataOrigin;
			this.DocumentedBy = new HashSet<IfcTimeSeriesReferenceRelationship>();
		}
	
	
	}
	
}
