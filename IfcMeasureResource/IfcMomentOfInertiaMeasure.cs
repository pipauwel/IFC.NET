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
	[Guid("eb7767c1-e16b-440a-8a60-1fd615208dc0")]
	public partial struct IfcMomentOfInertiaMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMomentOfInertiaMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMomentOfInertiaMeasure(Double value)
		{
			return new IfcMomentOfInertiaMeasure(value);
		}
	
		public static implicit operator Double(IfcMomentOfInertiaMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
