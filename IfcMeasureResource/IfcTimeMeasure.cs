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
	[Guid("9f6d3432-f09f-43df-876b-d1fa7f5401af")]
	public partial struct IfcTimeMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcTimeMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTimeMeasure(Double value)
		{
			return new IfcTimeMeasure(value);
		}
	
		public static implicit operator Double(IfcTimeMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
