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
	[Guid("45a9aa37-8fea-43c9-8011-c36e95b552d0")]
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
