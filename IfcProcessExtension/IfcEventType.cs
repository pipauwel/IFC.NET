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

namespace BuildingSmart.IFC.IfcProcessExtension
{
	[Guid("155c5cde-5c7b-4097-ab18-9e8bbd7c4981")]
	public partial class IfcEventType : IfcTypeProcess
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifies the predefined types of an event from which       the type required may be set.")]
		[Required()]
		public IfcEventTypeEnum PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Identifies the predefined types of event trigger from which       the type required may be set.")]
		[Required()]
		public IfcEventTriggerTypeEnum EventTriggerType { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("A user defined event trigger type, the value of which       is asserted when the value of an event trigger type is       declared as USERDEFINED.")]
		public IfcLabel? UserDefinedEventTriggerType { get; set; }
	
	
		public IfcEventType(IfcGloballyUniqueId globalId, IfcEventTypeEnum predefinedType, IfcEventTriggerTypeEnum eventTriggerType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
			this.EventTriggerType = eventTriggerType;
		}
	
	
	}
	
}
