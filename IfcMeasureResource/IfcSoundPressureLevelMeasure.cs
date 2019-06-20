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
	[Guid("e9d19605-8727-42e5-87d3-1439397cc6a4")]
	public partial struct IfcSoundPressureLevelMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSoundPressureLevelMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSoundPressureLevelMeasure(Double value)
		{
			return new IfcSoundPressureLevelMeasure(value);
		}
	
		public static implicit operator Double(IfcSoundPressureLevelMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
