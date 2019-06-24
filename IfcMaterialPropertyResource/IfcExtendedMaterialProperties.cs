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

using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IFCMATERIALPROPERTYRESOURCE
{
	[Guid("d6b4f4cd-a0c3-4234-98ac-8d92cee7bcda")]
	public partial class IfcExtendedMaterialProperties : IfcMaterialProperties
	{
		[DataMember(Order = 0)] 
		[Description("The set of material properties defined by user for this material.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcProperty> ExtendedProperties { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Description for the set of extended properties.")]
		public IfcText? Description { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The name given to the set of extended properties.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
	
		public IfcExtendedMaterialProperties(IfcMaterial material, IfcProperty[] extendedProperties, IfcLabel name)
			: base(material)
		{
			this.ExtendedProperties = new HashSet<IfcProperty>(extendedProperties);
			this.Name = name;
		}
	
	
	}
	
}
