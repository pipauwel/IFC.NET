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
	[Guid("0c960765-58fa-400e-a2e0-8a38ab83214e")]
	public partial struct IfcContextDependentMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcContextDependentMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcContextDependentMeasure(Double value)
		{
			return new IfcContextDependentMeasure(value);
		}
	
		public static implicit operator Double(IfcContextDependentMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
