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
	[Guid("44d13f39-e64a-45d8-80b7-e0a3c7253dc2")]
	public partial struct IfcSectionalAreaIntegralMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSectionalAreaIntegralMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSectionalAreaIntegralMeasure(Double value)
		{
			return new IfcSectionalAreaIntegralMeasure(value);
		}
	
		public static implicit operator Double(IfcSectionalAreaIntegralMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
