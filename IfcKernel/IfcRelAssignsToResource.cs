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
	[Guid("8e3fe369-7b2f-42e1-ba03-10771a673e88")]
	public partial class IfcRelAssignsToResource : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the resource to which the objects are assigned to.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE Datatype expanded to include <em>IfcResource</em> and <em>IfcTypeResource</em>.</blockquote>")]
		[Required()]
		public IfcResourceSelect RelatingResource { get; set; }
	
	
		public IfcRelAssignsToResource(IfcGloballyUniqueId globalId, IfcObjectDefinition[] relatedObjects, IfcResourceSelect relatingResource)
			: base(globalId, relatedObjects)
		{
			this.RelatingResource = relatingResource;
		}
	
	
	}
	
}
