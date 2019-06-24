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
	[Guid("eb396405-b178-411b-a29f-a8489ff89ed9")]
	public partial struct IfcIlluminanceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcIlluminanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcIlluminanceMeasure(Double value)
		{
			return new IfcIlluminanceMeasure(value);
		}
	
		public static implicit operator Double(IfcIlluminanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
