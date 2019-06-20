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
	[Guid("c7cb5514-571e-4cf4-84c8-cb001a0de7b5")]
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
