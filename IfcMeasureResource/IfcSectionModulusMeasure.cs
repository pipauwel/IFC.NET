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
	[Guid("2b8738a3-a679-4b3a-9bcd-e6fd894c2c69")]
	public partial struct IfcSectionModulusMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSectionModulusMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSectionModulusMeasure(Double value)
		{
			return new IfcSectionModulusMeasure(value);
		}
	
		public static implicit operator Double(IfcSectionModulusMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
