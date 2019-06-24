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
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("297f17bf-b2bb-4961-a224-dcc444a66eca")]
	public partial class IfcRelConnectsStructuralElement : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  The physical element, representing a design or detailing part, that is connected to the structural member as its (partial) analytical  idealization.  </EPM-HTML>")]
		[Required()]
		public IfcElement RelatingElement { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  The structural member that is associated with the element of which it represents the analytical idealization.  </EPM-HTML>")]
		[Required()]
		public IfcStructuralMember RelatedStructuralMember { get; set; }
	
	
		public IfcRelConnectsStructuralElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElement relatingElement, IfcStructuralMember relatedStructuralMember)
			: base(globalId, ownerHistory)
		{
			this.RelatingElement = relatingElement;
			this.RelatedStructuralMember = relatedStructuralMember;
		}
	
	
	}
	
}
