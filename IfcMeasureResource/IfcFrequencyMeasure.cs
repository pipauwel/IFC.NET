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
	[Guid("58072872-49e3-4ec3-828d-36e71e3563cd")]
	public partial struct IfcFrequencyMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcFrequencyMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcFrequencyMeasure(Double value)
		{
			return new IfcFrequencyMeasure(value);
		}
	
		public static implicit operator Double(IfcFrequencyMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
