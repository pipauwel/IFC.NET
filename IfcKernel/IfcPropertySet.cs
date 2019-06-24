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
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("cec1f626-7d52-40c1-b081-863946b3bab4")]
	public partial class IfcPropertySet : IfcPropertySetDefinition
	{
		[DataMember(Order = 0)] 
		[Description("Contained set of properties. For property sets defined as part of the IFC Object model, the property objects within a property set are defined as part of the standard. If a property is not contained within the set of predefined properties, its value has not been set at this time.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcProperty> HasProperties { get; protected set; }
	
	
		public IfcPropertySet(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcProperty[] hasProperties)
			: base(globalId, ownerHistory)
		{
			this.HasProperties = new HashSet<IfcProperty>(hasProperties);
		}
	
	
	}
	
}
