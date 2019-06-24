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
	[Guid("d1a37749-a948-455e-a882-22389225f89e")]
	public partial struct IfcAmountOfSubstanceMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcAmountOfSubstanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcAmountOfSubstanceMeasure(Double value)
		{
			return new IfcAmountOfSubstanceMeasure(value);
		}
	
		public static implicit operator Double(IfcAmountOfSubstanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
