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
	[Guid("2c38fdf3-24b0-43f4-9cee-c3904d8e3a59")]
	public partial struct IfcTorqueMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcTorqueMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTorqueMeasure(Double value)
		{
			return new IfcTorqueMeasure(value);
		}
	
		public static implicit operator Double(IfcTorqueMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
