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


namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("9cc2c277-dce2-45a4-83ff-50f25a31ece8")]
	public partial class IfcSIUnit : IfcNamedUnit
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The SI Prefix for defining decimal multiples and submultiples of the unit.")]
		public IfcSIPrefix? Prefix { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The word, or group of words, by which the SI unit is referred to.    <blockquote class=\"note\">NOTE&nbsp; Even though the SI system's base unit for mass is kilogram, the <em>IfcSIUnit</em> for mass is gram if no <em>Prefix</em> is asserted.</blockquote>")]
		[Required()]
		public IfcSIUnitName Name { get; set; }
	
	
		public IfcSIUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType, IfcSIUnitName name)
			: base(dimensions, unitType)
		{
			this.Name = name;
		}
	
		public new IfcDimensionalExponents Dimensions { get { return null; } }
	
	
	}
	
}
