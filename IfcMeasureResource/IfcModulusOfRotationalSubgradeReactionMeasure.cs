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
	[Guid("390dca1c-dafb-4f6b-a7ce-ea43a6af6075")]
	public partial struct IfcModulusOfRotationalSubgradeReactionMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcModulusOfRotationalSubgradeReactionMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcModulusOfRotationalSubgradeReactionMeasure(Double value)
		{
			return new IfcModulusOfRotationalSubgradeReactionMeasure(value);
		}
	
		public static implicit operator Double(IfcModulusOfRotationalSubgradeReactionMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
