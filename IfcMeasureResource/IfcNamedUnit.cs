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
	[Guid("feff0f85-92ea-4f67-8748-661f27621758")]
	public abstract partial class IfcNamedUnit :
		IfcUnit
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The dimensional exponents of the SI base units by which the named unit is defined.")]
		[Required()]
		public IfcDimensionalExponents Dimensions { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The type of the unit.")]
		[Required()]
		public IfcUnitEnum UnitType { get; set; }
	
	
		protected IfcNamedUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType)
		{
			this.Dimensions = dimensions;
			this.UnitType = unitType;
		}
	
	
	}
	
}
