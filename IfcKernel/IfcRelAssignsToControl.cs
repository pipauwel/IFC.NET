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
	[Guid("142af641-3046-4e25-8652-dbf0d05c61da")]
	public partial class IfcRelAssignsToControl : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Reference to the <em>IfcControl</em> that applies a control upon objects.")]
		[Required()]
		public IfcControl RelatingControl { get; set; }
	
	
		public IfcRelAssignsToControl(IfcGloballyUniqueId globalId, IfcObjectDefinition[] relatedObjects, IfcControl relatingControl)
			: base(globalId, relatedObjects)
		{
			this.RelatingControl = relatingControl;
		}
	
	
	}
	
}
