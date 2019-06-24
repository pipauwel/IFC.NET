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
	[Guid("37c336d3-742e-4f05-a1cd-617c9249a75b")]
	public partial struct IfcLinearStiffnessMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLinearStiffnessMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLinearStiffnessMeasure(Double value)
		{
			return new IfcLinearStiffnessMeasure(value);
		}
	
		public static implicit operator Double(IfcLinearStiffnessMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
