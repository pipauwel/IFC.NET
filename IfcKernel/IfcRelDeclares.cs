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
	[Guid("f38b268f-5cb1-42c3-81e3-89081e6b0528")]
	public partial class IfcRelDeclares : IfcRelationship
	{
		[DataMember(Order = 0)] 
		[XmlIgnore]
		[Description("Reference to the <em>IfcProject</em> to which additional information is assigned.")]
		[Required()]
		public IfcContext RelatingContext { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Set of object or property definitions that are assigned to a context and to which the unit and representation context definitions of that context apply.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcDefinitionSelect> RelatedDefinitions { get; protected set; }
	
	
		public IfcRelDeclares(IfcGloballyUniqueId globalId, IfcContext relatingContext, IfcDefinitionSelect[] relatedDefinitions)
			: base(globalId)
		{
			this.RelatingContext = relatingContext;
			this.RelatedDefinitions = new HashSet<IfcDefinitionSelect>(relatedDefinitions);
		}
	
	
	}
	
}
