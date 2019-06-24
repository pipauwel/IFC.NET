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
	[Guid("7075b401-84d0-4d10-8662-bc5063a63bec")]
	public partial class IfcRelAssignsToResource : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the resource to which the objects are assigned to.")]
		[Required()]
		public IfcResource RelatingResource { get; set; }
	
	
		public IfcRelAssignsToResource(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObjectDefinition[] relatedObjects, IfcResource relatingResource)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingResource = relatingResource;
		}
	
	
	}
	
}
