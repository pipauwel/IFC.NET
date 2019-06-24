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

namespace BuildingSmart.IFC.IfcConstructionMgmtDomain
{
	[Guid("3b596541-4bc7-45ac-8419-fe38754b2d16")]
	public abstract partial class IfcConstructionResource : IfcResource
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Optional identification of a code or ID for the construction resource")]
		public IfcIdentifier? ResourceIdentifier { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The group label, or title of the type resource, e.g. the title of a labour resource as carpenter, crane operator, superintendent, etc.")]
		public IfcLabel? ResourceGroup { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  A value that indicates how the resource is consumed during its use in a process (see <I>IfcResourceConsumptionEnum</I> for more detail)  </EPM-HTML>")]
		public IfcResourceConsumptionEnum? ResourceConsumption { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("The basic (i.e. default, or recommended) unit that should be used for measuring the volume (or amount) of the resource and the basic quantity of the resource fully or partially consumed.")]
		public IfcMeasureWithUnit BaseQuantity { get; set; }
	
	
		protected IfcConstructionResource(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
		}
	
	
	}
	
}
