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
	[Guid("2923468f-7a3d-4521-9900-c76a41447138")]
	public partial class IfcDerivedUnit :
		IfcUnit
	{
		[DataMember(Order = 0)] 
		[Description("The group of units and their exponents that define the derived unit.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcDerivedUnitElement> Elements { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Name of the derived unit chosen from an enumeration of derived unit types for use in IFC models.")]
		[Required()]
		public IfcDerivedUnitEnum UnitType { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		public IfcLabel? UserDefinedType { get; set; }
	
	
		public IfcDerivedUnit(IfcDerivedUnitElement[] elements, IfcDerivedUnitEnum unitType)
		{
			this.Elements = new HashSet<IfcDerivedUnitElement>(elements);
			this.UnitType = unitType;
		}
	
		public new IfcDimensionalExponents Dimensions { get { return null; } }
	
	
	}
	
}
