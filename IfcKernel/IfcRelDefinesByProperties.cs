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
	[Guid("349d602e-d775-4785-ac74-0632e4fdd015")]
	public partial class IfcRelDefinesByProperties : IfcRelDefines
	{
		[DataMember(Order = 0)] 
		[XmlIgnore]
		[Description("Reference to the objects (or single object) to which the property definition applies.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; Data type promoted from subtype <em>IfcObject</em>.  </blockquote>")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcObjectDefinition> RelatedObjects { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("Reference to the property set definition for that object or set of objects.")]
		[Required()]
		public IfcPropertySetDefinitionSelect RelatingPropertyDefinition { get; set; }
	
	
		public IfcRelDefinesByProperties(IfcGloballyUniqueId globalId, IfcObjectDefinition[] relatedObjects, IfcPropertySetDefinitionSelect relatingPropertyDefinition)
			: base(globalId)
		{
			this.RelatedObjects = new HashSet<IfcObjectDefinition>(relatedObjects);
			this.RelatingPropertyDefinition = relatingPropertyDefinition;
		}
	
	
	}
	
}
