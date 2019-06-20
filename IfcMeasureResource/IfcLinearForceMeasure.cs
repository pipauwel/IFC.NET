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
	[Guid("d793d8d4-c325-4825-804e-c41a5291ac83")]
	public partial struct IfcLinearForceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLinearForceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLinearForceMeasure(Double value)
		{
			return new IfcLinearForceMeasure(value);
		}
	
		public static implicit operator Double(IfcLinearForceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
