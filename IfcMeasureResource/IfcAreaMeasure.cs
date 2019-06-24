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
	[Guid("22fab2f3-75d5-4a84-8164-5198dd222ef3")]
	public partial struct IfcAreaMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcAreaMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcAreaMeasure(Double value)
		{
			return new IfcAreaMeasure(value);
		}
	
		public static implicit operator Double(IfcAreaMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
