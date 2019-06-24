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
	[Guid("57e60216-2aad-489a-b132-8f7d8963e2bc")]
	public partial struct IfcEnergyMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcEnergyMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcEnergyMeasure(Double value)
		{
			return new IfcEnergyMeasure(value);
		}
	
		public static implicit operator Double(IfcEnergyMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
