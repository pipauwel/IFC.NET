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
	[Guid("032c813c-b4d0-4b43-80ab-18d0084058b5")]
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
