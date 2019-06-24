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
	[Guid("14976879-1ae4-476a-8bfa-d72becabda73")]
	public partial class IfcTypeObject : IfcObjectDefinition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The attribute optionally defines the data type of the occurrence object, to which the assigned type object can relate. If not present, no instruction is given to which occurrence object the type object is applicable.")]
		public IfcLabel? ApplicableOccurrence { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  Set <strike>list</strike> of unique property sets, that are associated with the object type and are common to all object occurrences referring to this object type.  <blockquote><small><font color=\"#ff0000\">    IFC2x Edition 3 CHANGE&nbsp; The attribute aggregate type has been changed from LIST to SET.  </font></small></blockquote>  </EPM-HTML>")]
		[MinLength(1)]
		public ISet<IfcPropertySetDefinition> HasPropertySets { get; protected set; }
	
		[InverseProperty("RelatingType")] 
		[Description("Reference to the relationship IfcRelDefinedByType and thus to those occurrence objects, which are defined by this type.")]
		[MaxLength(1)]
		public ISet<IfcRelDefinesByType> ObjectTypeOf { get; protected set; }
	
	
		public IfcTypeObject(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.HasPropertySets = new HashSet<IfcPropertySetDefinition>();
			this.ObjectTypeOf = new HashSet<IfcRelDefinesByType>();
		}
	
	
	}
	
}
