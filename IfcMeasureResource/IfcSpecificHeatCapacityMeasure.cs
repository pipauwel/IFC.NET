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
	[Guid("0f57889c-6a13-4557-8b80-c063fbd9ba79")]
	public partial struct IfcSpecificHeatCapacityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSpecificHeatCapacityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSpecificHeatCapacityMeasure(Double value)
		{
			return new IfcSpecificHeatCapacityMeasure(value);
		}
	
		public static implicit operator Double(IfcSpecificHeatCapacityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
