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
	[Guid("92c88cd9-71da-4242-ae8a-54ace1ebe445")]
	public partial struct IfcRotationalMassMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcRotationalMassMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcRotationalMassMeasure(Double value)
		{
			return new IfcRotationalMassMeasure(value);
		}
	
		public static implicit operator Double(IfcRotationalMassMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
