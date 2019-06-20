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
	[Guid("60d0fa03-7b5a-48f1-80a8-a62b1cb46ae0")]
	public partial struct IfcLinearStiffnessMeasure :
		IfcDerivedMeasureValue,
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcTranslationalStiffnessSelect
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLinearStiffnessMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLinearStiffnessMeasure(Double value)
		{
			return new IfcLinearStiffnessMeasure(value);
		}
	
		public static implicit operator Double(IfcLinearStiffnessMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
