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
	[Guid("88c02c7c-0d03-4394-8c14-b10c4e76fcc4")]
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
