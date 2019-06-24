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
	[Guid("4ff7f220-96e6-41f8-88ff-1bcd36ddb698")]
	public partial struct IfcElectricCurrentMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcElectricCurrentMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcElectricCurrentMeasure(Double value)
		{
			return new IfcElectricCurrentMeasure(value);
		}
	
		public static implicit operator Double(IfcElectricCurrentMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
