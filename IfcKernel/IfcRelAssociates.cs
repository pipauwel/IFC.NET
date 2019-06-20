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
	[Guid("50e72608-2b70-4951-afa7-68d8cf130d15")]
	public abstract partial class IfcRelAssociates : IfcRelationship
	{
		[DataMember(Order = 0)] 
		[Description("Set of object or property definitions to which the external references or information is associated. It includes object and type objects, property set templates, property templates and property sets and contexts.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; The attribute datatype has been changed from <em>IfcRoot</em> to <em>IfcDefinitionSelect</em>.</blockquote>")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcDefinitionSelect> RelatedObjects { get; protected set; }
	
	
		protected IfcRelAssociates(IfcGloballyUniqueId globalId, IfcDefinitionSelect[] relatedObjects)
			: base(globalId)
		{
			this.RelatedObjects = new HashSet<IfcDefinitionSelect>(relatedObjects);
		}
	
	
	}
	
}
