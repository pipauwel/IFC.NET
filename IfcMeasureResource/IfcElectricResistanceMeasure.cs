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
	[Guid("80d960c2-e233-4717-94fd-7865469f4693")]
	public partial struct IfcElectricResistanceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcElectricResistanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcElectricResistanceMeasure(Double value)
		{
			return new IfcElectricResistanceMeasure(value);
		}
	
		public static implicit operator Double(IfcElectricResistanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
