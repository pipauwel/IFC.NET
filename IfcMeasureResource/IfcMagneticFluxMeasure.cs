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
	[Guid("d5e0b30d-397c-403f-8f2b-6f12d00713d7")]
	public partial struct IfcMagneticFluxMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMagneticFluxMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMagneticFluxMeasure(Double value)
		{
			return new IfcMagneticFluxMeasure(value);
		}
	
		public static implicit operator Double(IfcMagneticFluxMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
