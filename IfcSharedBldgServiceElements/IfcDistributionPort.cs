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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("1b957306-e396-43ea-b6ee-e7e28d37f9e9")]
	public partial class IfcDistributionPort : IfcPort
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Enumeration that identifies if this port is a Sink (inlet), a Source (outlet) or both a SinkAndSource.")]
		public IfcFlowDirectionEnum? FlowDirection { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		public IfcDistributionPortTypeEnum? PredefinedType { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Enumeration that identifies the system type.  If a system type is defined, the port may only be connected to other ports having the same system type.")]
		public IfcDistributionSystemEnum? SystemType { get; set; }
	
	
		public IfcDistributionPort(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
