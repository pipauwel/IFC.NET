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
	[Guid("8ddc85b8-3dd6-476b-b356-d2dad877a83a")]
	public partial struct IfcPowerMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcPowerMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcPowerMeasure(Double value)
		{
			return new IfcPowerMeasure(value);
		}
	
		public static implicit operator Double(IfcPowerMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
