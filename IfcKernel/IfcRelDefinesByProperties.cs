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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("c0bc28d6-264e-4ba4-b40b-911c7ee80584")]
	public partial class IfcRelDefinesByProperties : IfcRelDefines
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the property set definition for that object or set of objects.")]
		[Required()]
		public IfcPropertySetDefinition RelatingPropertyDefinition { get; set; }
	
	
		public IfcRelDefinesByProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObject[] relatedObjects, IfcPropertySetDefinition relatingPropertyDefinition)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingPropertyDefinition = relatingPropertyDefinition;
		}
	
	
	}
	
}
