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

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("907e3b05-19b5-4d83-a001-b63a5a87ef22")]
	public partial class IfcRelVoidsElement : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  Reference to <strike>building</strike> element in which a void is created by associated <strike>opening</strike> feature subtraction element.  <blockquote><small><font color=\"#ff0000\">  IFC2x PLATFORM CHANGE: The data type has been changed from <i>IfcBuildingElement</i> to <i>IfcElement</i> with upward compatibility for file based exchange.  </font></small></blockquote>  </EPM-HTML>")]
		[Required()]
		public IfcElement RelatingBuildingElement { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  Reference to the <strike>opening</strike> feature subtraction element which defines a void in the associated <strike>opening</strike> element.  <blockquote><small><font color=\"#ff0000\">  IFC2x PLATFORM CHANGE&nbsp; The data type has been changed from <i>IfcOpeningElement</i> to <i>IfcFeatureElementSubtraction</i> with upward compatibility for file based exchange.  </font></small></blockquote>  </EPM-HTML>")]
		[Required()]
		public IfcFeatureElementSubtraction RelatedOpeningElement { get; set; }
	
	
		public IfcRelVoidsElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElement relatingBuildingElement, IfcFeatureElementSubtraction relatedOpeningElement)
			: base(globalId, ownerHistory)
		{
			this.RelatingBuildingElement = relatingBuildingElement;
			this.RelatedOpeningElement = relatedOpeningElement;
		}
	
	
	}
	
}
