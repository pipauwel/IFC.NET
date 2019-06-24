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
	[Guid("01a8f47a-8141-48ea-bb02-b2f28b81914a")]
	public partial struct IfcDoseEquivalentMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcDoseEquivalentMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDoseEquivalentMeasure(Double value)
		{
			return new IfcDoseEquivalentMeasure(value);
		}
	
		public static implicit operator Double(IfcDoseEquivalentMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
