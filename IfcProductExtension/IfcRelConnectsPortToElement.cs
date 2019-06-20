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
	[Guid("ade898d9-502a-402f-b2b5-25e8a097c9e9")]
	public partial class IfcRelConnectsPortToElement : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Reference to an Port that is connected by the objectified relationship.")]
		[Required()]
		public IfcPort RelatingPort { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Reference to an <em>IfcDistributionElement</em> that has ports assigned.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  Data type restricted to <em>IfcDistributionElement</em>.</blockquote>")]
		[Required()]
		public IfcDistributionElement RelatedElement { get; set; }
	
	
		public IfcRelConnectsPortToElement(IfcGloballyUniqueId globalId, IfcPort relatingPort, IfcDistributionElement relatedElement)
			: base(globalId)
		{
			this.RelatingPort = relatingPort;
			this.RelatedElement = relatedElement;
		}
	
	
	}
	
}
