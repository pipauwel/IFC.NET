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
	[Guid("e9e318da-ceb2-4700-9c42-17311e5549b1")]
	public partial class IfcComplexPropertyTemplate : IfcPropertyTemplate
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		public IfcLabel? UsageName { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		public IfcComplexPropertyTemplateTypeEnum? TemplateType { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Reference to a set of property templates. It should only be provided, if the <em>PropertyType</em> is set to <small>COMPLEX</small>.")]
		[MinLength(1)]
		public ISet<IfcPropertyTemplate> HasPropertyTemplates { get; protected set; }
	
	
		public IfcComplexPropertyTemplate(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.HasPropertyTemplates = new HashSet<IfcPropertyTemplate>();
		}
	
	
	}
	
}
