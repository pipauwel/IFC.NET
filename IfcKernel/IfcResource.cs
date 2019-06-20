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
	[Guid("7d23ec63-a69d-48c1-9db7-f4089326e1f2")]
	public abstract partial class IfcResource : IfcObject,
		IfcResourceSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("An identifying designation given to a resource.      It is the identifier at the occurrence level.       <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  Attribute promoted from subtype <em>IfcConstructionResource</em>.</blockquote>")]
		public IfcIdentifier? Identification { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("A detailed description of the resource (e.g. the skillset for a labor resource).    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; The attribute <em>LongDescription</em> is added replacing the <em>ResourceGroup</em> attribute at subtype <em>IfcConstructionResource</em>.</blockquote>")]
		public IfcText? LongDescription { get; set; }
	
		[InverseProperty("RelatingResource")] 
		[Description("Set of relationships to other objects, e.g. products, processes, controls, resources or actors, for which this resource object is a resource.")]
		public ISet<IfcRelAssignsToResource> ResourceOf { get; protected set; }
	
	
		protected IfcResource(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.ResourceOf = new HashSet<IfcRelAssignsToResource>();
		}
	
	
	}
	
}
