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
	[Guid("3e7d104e-f42b-479a-a851-1137fe09d6e8")]
	public partial class IfcConversionBasedUnit : IfcNamedUnit
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The word, or group of words, by which the conversion based unit is referred to.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The physical quantity from which the converted unit is derived.")]
		[Required()]
		public IfcMeasureWithUnit ConversionFactor { get; set; }
	
	
		public IfcConversionBasedUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType, IfcLabel name, IfcMeasureWithUnit conversionFactor)
			: base(dimensions, unitType)
		{
			this.Name = name;
			this.ConversionFactor = conversionFactor;
		}
	
	
	}
	
}
