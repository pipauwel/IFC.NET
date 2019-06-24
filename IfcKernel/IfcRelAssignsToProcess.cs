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
	[Guid("61204dbc-e9f6-40ab-aaaf-0c7f854fa124")]
	public partial class IfcRelAssignsToProcess : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the process to which the objects are assigned to.")]
		[Required()]
		public IfcProcess RelatingProcess { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Quantity of the object specific for the operation by this process.")]
		public IfcMeasureWithUnit QuantityInProcess { get; set; }
	
	
		public IfcRelAssignsToProcess(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObjectDefinition[] relatedObjects, IfcProcess relatingProcess)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingProcess = relatingProcess;
		}
	
	
	}
	
}
