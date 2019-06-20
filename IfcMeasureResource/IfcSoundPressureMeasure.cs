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
	[Guid("23e5bb19-55d4-41e7-8393-2bbb5704b69f")]
	public partial struct IfcSoundPressureMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSoundPressureMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSoundPressureMeasure(Double value)
		{
			return new IfcSoundPressureMeasure(value);
		}
	
		public static implicit operator Double(IfcSoundPressureMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
