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
	[Guid("5f499b56-7ed2-47e8-8f73-65e8da5ede24")]
	public partial struct IfcLengthMeasure :
		BuildingSmart.IFC.IfcStructuralElementsDomain.IfcBendingParameterSelect,
		IfcMeasureValue,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcSizeSelect
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLengthMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLengthMeasure(Double value)
		{
			return new IfcLengthMeasure(value);
		}
	
		public static implicit operator Double(IfcLengthMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
