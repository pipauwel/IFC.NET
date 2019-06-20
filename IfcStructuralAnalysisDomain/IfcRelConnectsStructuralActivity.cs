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

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("d755201f-41e5-41f3-b37c-30c473853a22")]
	public partial class IfcRelConnectsStructuralActivity : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[Description("Reference to a structural item or element to which the specified activity is applied.")]
		[Required()]
		public IfcStructuralActivityAssignmentSelect RelatingElement { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Reference to a structural activity which is acting upon the specified structural item or element.")]
		[Required()]
		public IfcStructuralActivity RelatedStructuralActivity { get; set; }
	
	
		public IfcRelConnectsStructuralActivity(IfcGloballyUniqueId globalId, IfcStructuralActivityAssignmentSelect relatingElement, IfcStructuralActivity relatedStructuralActivity)
			: base(globalId)
		{
			this.RelatingElement = relatingElement;
			this.RelatedStructuralActivity = relatedStructuralActivity;
		}
	
	
	}
	
}
