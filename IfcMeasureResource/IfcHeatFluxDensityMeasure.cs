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
	[Guid("fe14d9d1-aa0d-4d41-aa95-a8f2e37786e8")]
	public partial struct IfcHeatFluxDensityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcHeatFluxDensityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcHeatFluxDensityMeasure(Double value)
		{
			return new IfcHeatFluxDensityMeasure(value);
		}
	
		public static implicit operator Double(IfcHeatFluxDensityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
