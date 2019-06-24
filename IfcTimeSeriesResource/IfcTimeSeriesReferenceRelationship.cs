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

using BuildingSmart.IFC.IfcExternalReferenceResource;

namespace BuildingSmart.IFC.IFCTIMESERIESRESOURCE
{
	[Guid("247d10b2-f345-453b-b7cd-87e9bd8192f8")]
	public partial class IfcTimeSeriesReferenceRelationship
	{
		[DataMember(Order = 0)] 
		[Required()]
		public IfcTimeSeries ReferencedTimeSeries { get; set; }
	
		[DataMember(Order = 1)] 
		[Required()]
		[MinLength(1)]
		public ISet<IfcDocumentSelect> TimeSeriesReferences { get; protected set; }
	
	
		public IfcTimeSeriesReferenceRelationship(IfcTimeSeries referencedTimeSeries, IfcDocumentSelect[] timeSeriesReferences)
		{
			this.ReferencedTimeSeries = referencedTimeSeries;
			this.TimeSeriesReferences = new HashSet<IfcDocumentSelect>(timeSeriesReferences);
		}
	
	
	}
	
}
