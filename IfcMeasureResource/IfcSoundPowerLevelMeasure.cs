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
	[Guid("a1dd19be-4801-4c12-bdd3-f5ec9d3d86fe")]
	public partial struct IfcSoundPowerLevelMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSoundPowerLevelMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSoundPowerLevelMeasure(Double value)
		{
			return new IfcSoundPowerLevelMeasure(value);
		}
	
		public static implicit operator Double(IfcSoundPowerLevelMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
