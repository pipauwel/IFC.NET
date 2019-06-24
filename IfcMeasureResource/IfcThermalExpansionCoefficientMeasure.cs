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
	[Guid("df6bea31-0807-40f6-a5b4-63b2e7198909")]
	public partial struct IfcThermalExpansionCoefficientMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcThermalExpansionCoefficientMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcThermalExpansionCoefficientMeasure(Double value)
		{
			return new IfcThermalExpansionCoefficientMeasure(value);
		}
	
		public static implicit operator Double(IfcThermalExpansionCoefficientMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
