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
	[Guid("0fb1cf26-3a59-44f5-9a5e-adc7ac27e46a")]
	public abstract partial class IfcTypeResource : IfcTypeObject,
		IfcResourceSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("An identifying designation given to a resource type.")]
		public IfcIdentifier? Identification { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("An long description, or text, describing the resource in detail.  <blockquote class=\"note\">NOTE&nbsp; The inherited <em>SELF\\IfcRoot.Description</em> attribute is used as the short description.</blockquote>")]
		public IfcText? LongDescription { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The type denotes a particular type that indicates the resource further. The use has to be established at the level of instantiable subtypes. In particular it holds the user defined type, if the enumeration of the attribute 'PredefinedType' is set to USERDEFINED.")]
		public IfcLabel? ResourceType { get; set; }
	
		[InverseProperty("RelatingResource")] 
		[Description("Set of relationships to other objects, e.g. products, processes, controls, resources or actors to which this resource type is a resource.  <blockquote class=\"history\">HISTORY New inverse relationship in IFC4.</blockquote>")]
		public ISet<IfcRelAssignsToResource> ResourceOf { get; protected set; }
	
	
		protected IfcTypeResource(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.ResourceOf = new HashSet<IfcRelAssignsToResource>();
		}
	
	
	}
	
}
