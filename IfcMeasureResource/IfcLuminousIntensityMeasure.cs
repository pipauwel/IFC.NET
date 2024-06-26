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
	[Guid("9bb900a5-d683-4488-94a2-c96367176ad3")]
	public partial struct IfcLuminousIntensityMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLuminousIntensityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLuminousIntensityMeasure(Double value)
		{
			return new IfcLuminousIntensityMeasure(value);
		}
	
		public static implicit operator Double(IfcLuminousIntensityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
