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
	[Guid("1bc680e3-8fa8-4a89-b4ea-0d65dad0c3f4")]
	public partial struct IfcModulusOfLinearSubgradeReactionMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcModulusOfLinearSubgradeReactionMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcModulusOfLinearSubgradeReactionMeasure(Double value)
		{
			return new IfcModulusOfLinearSubgradeReactionMeasure(value);
		}
	
		public static implicit operator Double(IfcModulusOfLinearSubgradeReactionMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
