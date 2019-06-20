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
	[Guid("caf50987-b923-4702-a6cf-5be6efebf0ef")]
	public partial struct IfcThermodynamicTemperatureMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcThermodynamicTemperatureMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcThermodynamicTemperatureMeasure(Double value)
		{
			return new IfcThermodynamicTemperatureMeasure(value);
		}
	
		public static implicit operator Double(IfcThermodynamicTemperatureMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
