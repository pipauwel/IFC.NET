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
	[Guid("ab684a10-9929-49b2-991a-ce9a77594e0e")]
	public partial struct IfcLuminousFluxMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLuminousFluxMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLuminousFluxMeasure(Double value)
		{
			return new IfcLuminousFluxMeasure(value);
		}
	
		public static implicit operator Double(IfcLuminousFluxMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
