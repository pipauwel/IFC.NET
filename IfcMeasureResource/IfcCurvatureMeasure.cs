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
	[Guid("3e0ec516-9f60-443b-b46d-58c271c00a09")]
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
