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

namespace BuildingSmart.IFC.IfcPropertyResource
{
	[Guid("4af5da7c-70c1-4f95-ac34-f4bab2f900e2")]
	public partial class IfcPropertyDependencyRelationship
	{
		[DataMember(Order = 0)] 
		[Description("The property on which the relationship depends.")]
		[Required()]
		public IfcProperty DependingProperty { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The dependant property.")]
		[Required()]
		public IfcProperty DependantProperty { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Name of the relationship that provides additional meaning to the nature of the dependency.")]
		public IfcLabel? Name { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Additional description of the dependency.")]
		public IfcText? Description { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Expression that further describes the nature of the dependency relation.")]
		public IfcText? Expression { get; set; }
	
	
		public IfcPropertyDependencyRelationship(IfcProperty dependingProperty, IfcProperty dependantProperty)
		{
			this.DependingProperty = dependingProperty;
			this.DependantProperty = dependantProperty;
		}
	
	
	}
	
}
