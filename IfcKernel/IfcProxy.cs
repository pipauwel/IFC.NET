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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("71ecd3f4-0c37-4779-a722-9dddefe6a6bf")]
	public partial class IfcProxy : IfcProduct
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("High level (and only) semantic meaning attached to the IfcProxy, defining the basic construct type behind the Proxy, e.g. Product or Process.")]
		[Required()]
		public IfcObjectTypeEnum ProxyType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The tag (or label) identifier at the particular instance of a product, e.g. the serial number, or the position number. It is the identifier at the occurrence level.")]
		public IfcLabel? Tag { get; set; }
	
	
		public IfcProxy(IfcGloballyUniqueId globalId, IfcObjectTypeEnum proxyType)
			: base(globalId)
		{
			this.ProxyType = proxyType;
		}
	
	
	}
	
}
