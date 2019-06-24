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
	[Guid("5b27a097-629c-4e3c-9109-7fea67812949")]
	public partial class IfcRelAssignsToControl : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the control that applies an control about objects.")]
		[Required()]
		public IfcControl RelatingControl { get; set; }
	
	
		public IfcRelAssignsToControl(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObjectDefinition[] relatedObjects, IfcControl relatingControl)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingControl = relatingControl;
		}
	
	
	}
	
}
