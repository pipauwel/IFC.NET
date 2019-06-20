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
	[Guid("7045cc64-c05a-4a43-aaa5-b5b4d849f3f5")]
	public partial class IfcActionRequest : IfcControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifies the predefined type of sources through which a request can be made.    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  The attribute has been added.</blockquote>")]
		public IfcActionRequestTypeEnum? PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The status currently assigned to the request.  Possible values include:<br/>  Hold: wait to see if further requests are received before deciding on action<br/>  NoAction: no action is required on this request<br/>  Schedule: plan action to take place as part of maintenance or other task planning/scheduling<br/>  Urgent: take action immediately<br/>    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  The attribute has been added.</blockquote>")]
		public IfcLabel? Status { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Detailed description of the permit.    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  The attribute has been added.</blockquote>")]
		public IfcText? LongDescription { get; set; }
	
	
		public IfcActionRequest(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
