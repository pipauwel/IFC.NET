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
	[Guid("320059f8-dead-4f33-93db-3c12bda29326")]
	public partial struct IfcModulusOfElasticityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcModulusOfElasticityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcModulusOfElasticityMeasure(Double value)
		{
			return new IfcModulusOfElasticityMeasure(value);
		}
	
		public static implicit operator Double(IfcModulusOfElasticityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
