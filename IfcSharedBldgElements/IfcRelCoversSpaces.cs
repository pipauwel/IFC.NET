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

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("d7038275-a6b7-4293-86c1-f69337a29534")]
	public partial class IfcRelCoversSpaces : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Relationship to the space object that is covered.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; The attribute name has been changed from <em>RelatedSpace</em> to <em>RelatingSpace</em> with upward compatibility for file based exchange.</blockquote>")]
		[Required()]
		public IfcSpace RelatingSpace { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Relationship to the set of coverings covering that cover surfaces of this space.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcCovering> RelatedCoverings { get; protected set; }
	
	
		public IfcRelCoversSpaces(IfcGloballyUniqueId globalId, IfcSpace relatingSpace, IfcCovering[] relatedCoverings)
			: base(globalId)
		{
			this.RelatingSpace = relatingSpace;
			this.RelatedCoverings = new HashSet<IfcCovering>(relatedCoverings);
		}
	
	
	}
	
}
