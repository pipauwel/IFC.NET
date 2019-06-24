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
	[Guid("6fed7bf7-51a0-4122-9d88-58595e71cb87")]
	public partial struct IfcLinearMomentMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLinearMomentMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLinearMomentMeasure(Double value)
		{
			return new IfcLinearMomentMeasure(value);
		}
	
		public static implicit operator Double(IfcLinearMomentMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
