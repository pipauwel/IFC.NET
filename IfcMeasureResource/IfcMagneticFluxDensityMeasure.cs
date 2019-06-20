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
	[Guid("68195c29-3d06-445c-9a17-4a7d0520126a")]
	public partial struct IfcMagneticFluxDensityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMagneticFluxDensityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMagneticFluxDensityMeasure(Double value)
		{
			return new IfcMagneticFluxDensityMeasure(value);
		}
	
		public static implicit operator Double(IfcMagneticFluxDensityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
