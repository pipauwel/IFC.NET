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
	[Guid("20dee03b-bfd0-4795-923f-4619fc628b6c")]
	public partial class IfcRelAssignsToGroup : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Reference to group that contains all assigned group members.")]
		[Required()]
		public IfcGroup RelatingGroup { get; set; }
	
	
		public IfcRelAssignsToGroup(IfcGloballyUniqueId globalId, IfcObjectDefinition[] relatedObjects, IfcGroup relatingGroup)
			: base(globalId, relatedObjects)
		{
			this.RelatingGroup = relatingGroup;
		}
	
	
	}
	
}
