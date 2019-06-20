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
	[Guid("2e356ce2-028b-4845-b180-50a6b89ac6a2")]
	public partial struct IfcComplexNumber :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcComplexNumber(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcComplexNumber(Double value)
		{
			return new IfcComplexNumber(value);
		}
	
		public static implicit operator Double(IfcComplexNumber value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
