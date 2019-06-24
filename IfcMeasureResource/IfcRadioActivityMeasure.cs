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
	[Guid("300b47f8-609f-41f9-84b9-014b66ad44dd")]
	public partial struct IfcRadioActivityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcRadioActivityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcRadioActivityMeasure(Double value)
		{
			return new IfcRadioActivityMeasure(value);
		}
	
		public static implicit operator Double(IfcRadioActivityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
