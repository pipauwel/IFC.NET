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
	[Guid("aaa04b5e-3444-4521-8945-7fa1f69e80d4")]
	public partial struct IfcMonetaryMeasure :
		BuildingSmart.IFC.IfcCostResource.IfcAppliedValueSelect,
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMonetaryMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMonetaryMeasure(Double value)
		{
			return new IfcMonetaryMeasure(value);
		}
	
		public static implicit operator Double(IfcMonetaryMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
