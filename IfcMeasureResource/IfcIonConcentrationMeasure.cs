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
	[Guid("6ec472b1-a902-4d4a-9930-478faf6d4a6c")]
	public partial struct IfcIonConcentrationMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcIonConcentrationMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcIonConcentrationMeasure(Double value)
		{
			return new IfcIonConcentrationMeasure(value);
		}
	
		public static implicit operator Double(IfcIonConcentrationMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
