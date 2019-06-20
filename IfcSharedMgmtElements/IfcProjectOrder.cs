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

namespace BuildingSmart.IFC.IfcSharedMgmtElements
{
	[Guid("893d5903-b4b9-47a6-b246-30c5ec310142")]
	public partial class IfcProjectOrder : IfcControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined generic type for a project order that is specified in an enumeration. There may be a property set given specificly for the predefined types.    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  The attribute has been made optional.</blockquote>")]
		public IfcProjectOrderTypeEnum? PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The current status of a project order.Examples of status values that might be used for a project order status include:  <ul>  <li>PLANNED</li>  <li>REQUESTED</li>  <li>APPROVED</li>  <li>ISSUED</li>  <li>STARTED</li>  <li>DELAYED</li>  <li>DONE</li>  </ul>")]
		public IfcLabel? Status { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("A detailed description of the project order describing the work to be completed.")]
		public IfcText? LongDescription { get; set; }
	
	
		public IfcProjectOrder(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
