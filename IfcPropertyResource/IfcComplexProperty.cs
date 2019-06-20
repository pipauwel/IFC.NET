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

using BuildingSmart.IFC.IfcApprovalResource;
using BuildingSmart.IFC.IfcConstraintResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcPropertyResource
{
	[Guid("c8722acc-8737-44f1-b24d-0eb804a9a4da")]
	public partial class IfcComplexProperty : IfcProperty
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Usage description of the <em>IfcComplexProperty</em> within the property set which references the <em>IfcComplexProperty</em>.  <blockquote class=\"note\">NOTE&nbsp; Consider a complex property for glazing properties. The <em>Name</em> attribute of the <em>IfcComplexProperty</em> could be <em>Pset_GlazingProperties</em>, and the UsageName attribute could be <em>OuterGlazingPane</em>.</blockquote>")]
		[Required()]
		public IfcIdentifier UsageName { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Set of properties that can be used within this complex property (may include other complex properties).")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcProperty> HasProperties { get; protected set; }
	
	
		public IfcComplexProperty(IfcIdentifier name, IfcIdentifier usageName, IfcProperty[] hasProperties)
			: base(name)
		{
			this.UsageName = usageName;
			this.HasProperties = new HashSet<IfcProperty>(hasProperties);
		}
	
	
	}
	
}
