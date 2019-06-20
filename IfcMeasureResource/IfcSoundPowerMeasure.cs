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
	[Guid("3e67e9d6-4bc4-4773-992f-9bb3345ed39d")]
	public partial struct IfcSoundPowerMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSoundPowerMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSoundPowerMeasure(Double value)
		{
			return new IfcSoundPowerMeasure(value);
		}
	
		public static implicit operator Double(IfcSoundPowerMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
