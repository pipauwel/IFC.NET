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
	[Guid("ba187b36-e83a-4b22-86dc-e9b56e48248e")]
	public partial struct IfcIsothermalMoistureCapacityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcIsothermalMoistureCapacityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcIsothermalMoistureCapacityMeasure(Double value)
		{
			return new IfcIsothermalMoistureCapacityMeasure(value);
		}
	
		public static implicit operator Double(IfcIsothermalMoistureCapacityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
