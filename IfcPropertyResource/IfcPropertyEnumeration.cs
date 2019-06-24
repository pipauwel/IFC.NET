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
	[Guid("b0a8d959-6be7-4b37-8bd8-74c971669777")]
	public partial class IfcPropertyEnumeration
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Name of this enumeration.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("List of values that form the enumeration.")]
		[Required()]
		[CustomValidation(typeof(IfcPropertyEnumeration), "Unique")]
		[MinLength(1)]
		public IList<IfcValue> EnumerationValues { get; protected set; }
	
		[DataMember(Order = 2)] 
		[Description("Unit for the enumerator values, if not given, the default value for the measure type (given by the TYPE of nominal value) is used as defined by the global unit assignment at IfcProject.")]
		public IfcUnit Unit { get; set; }
	
	
		public IfcPropertyEnumeration(IfcLabel name, IfcValue[] enumerationValues)
		{
			this.Name = name;
			this.EnumerationValues = new List<IfcValue>(enumerationValues);
		}
	
	
	}
	
}
