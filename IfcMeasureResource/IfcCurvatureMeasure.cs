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
	[Guid("947118c4-9f84-4f7f-b520-bbb15bd41cbd")]
	public partial struct IfcCurvatureMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcCurvatureMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcCurvatureMeasure(Double value)
		{
			return new IfcCurvatureMeasure(value);
		}
	
		public static implicit operator Double(IfcCurvatureMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
