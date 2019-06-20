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
	[Guid("7789fb0b-53be-45a1-b878-560be43f3601")]
	public partial struct IfcElectricConductanceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcElectricConductanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcElectricConductanceMeasure(Double value)
		{
			return new IfcElectricConductanceMeasure(value);
		}
	
		public static implicit operator Double(IfcElectricConductanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
