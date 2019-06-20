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

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("6763c7ee-edf0-48d2-a207-bc8e7ec8f122")]
	public partial class IfcRelConnectsPorts : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Reference to the first port that is connected by the objectified relationship.")]
		[Required()]
		public IfcPort RelatingPort { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Reference to the second port that is connected by the objectified relationship.")]
		[Required()]
		public IfcPort RelatedPort { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlElement]
		[Description("Defines the element that realizes a port connection relationship.")]
		public IfcElement RealizingElement { get; set; }
	
	
		public IfcRelConnectsPorts(IfcGloballyUniqueId globalId, IfcPort relatingPort, IfcPort relatedPort)
			: base(globalId)
		{
			this.RelatingPort = relatingPort;
			this.RelatedPort = relatedPort;
		}
	
	
	}
	
}
