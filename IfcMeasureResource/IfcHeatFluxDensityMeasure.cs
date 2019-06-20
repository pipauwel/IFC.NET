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
	[Guid("8dcf44c7-215d-42ae-a330-6308a0d8d3ec")]
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
