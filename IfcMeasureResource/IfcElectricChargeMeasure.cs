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
	[Guid("3313f0f6-7058-4878-824b-3065b8978804")]
	public partial struct IfcElectricChargeMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcElectricChargeMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcElectricChargeMeasure(Double value)
		{
			return new IfcElectricChargeMeasure(value);
		}
	
		public static implicit operator Double(IfcElectricChargeMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
