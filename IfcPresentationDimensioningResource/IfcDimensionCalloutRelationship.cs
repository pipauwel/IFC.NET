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

namespace BuildingSmart.IFC.IFCPRESENTATIONDIMENSIONINGRESOURCE
{
	[Guid("be25928a-2cbb-435f-b070-c3afa0ead2f1")]
	public partial class IfcDimensionCalloutRelationship : IfcDraughtingCalloutRelationship
	{
	
		public IfcDimensionCalloutRelationship(IfcDraughtingCallout relatingDraughtingCallout, IfcDraughtingCallout relatedDraughtingCallout)
			: base(relatingDraughtingCallout, relatedDraughtingCallout)
		{
		}
	
	
	}
	
}
