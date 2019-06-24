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
	[Guid("9a25a464-da5d-45c5-97ee-51a3a57ba941")]
	public partial class IfcRelFillsElement : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[Description("Opening Element being filled by virtue of this relationship.")]
		[Required()]
		public IfcOpeningElement RelatingOpeningElement { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  Reference to <strike>building</strike> element that occupies fully or partially the associated opening.  <blockquote><small><font color=\"#ff0000\">  IFC2x PLATFORM CHANGE: The data type has been changed from <i>IfcBuildingElement</i> to <i>IfcElement</i> with upward compatibility for file based exchange.  </font><small></blockquote>  </EPM-HTML>")]
		[Required()]
		public IfcElement RelatedBuildingElement { get; set; }
	
	
		public IfcRelFillsElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcOpeningElement relatingOpeningElement, IfcElement relatedBuildingElement)
			: base(globalId, ownerHistory)
		{
			this.RelatingOpeningElement = relatingOpeningElement;
			this.RelatedBuildingElement = relatedBuildingElement;
		}
	
	
	}
	
}
