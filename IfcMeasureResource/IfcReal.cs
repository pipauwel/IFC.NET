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
	[Guid("e689b68c-66b6-4d00-8ab5-f5fb64ecbab6")]
	public partial struct IfcReal :
		IfcSimpleValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcReal(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcReal(Double value)
		{
			return new IfcReal(value);
		}
	
		public static implicit operator Double(IfcReal value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
