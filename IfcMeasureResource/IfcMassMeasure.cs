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
	[Guid("c491619e-9a98-41eb-9867-5f7255c1a280")]
	public partial struct IfcMassMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMassMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMassMeasure(Double value)
		{
			return new IfcMassMeasure(value);
		}
	
		public static implicit operator Double(IfcMassMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
