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
	[Guid("e0ad2575-9d73-47b1-89ca-9117f41a0a96")]
	public partial struct IfcModulusOfSubgradeReactionMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcModulusOfSubgradeReactionMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcModulusOfSubgradeReactionMeasure(Double value)
		{
			return new IfcModulusOfSubgradeReactionMeasure(value);
		}
	
		public static implicit operator Double(IfcModulusOfSubgradeReactionMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
