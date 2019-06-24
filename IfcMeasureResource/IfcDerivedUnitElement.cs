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
	[Guid("2129b759-b439-40db-bc00-5909784c9e63")]
	public partial class IfcDerivedUnitElement
	{
		[DataMember(Order = 0)] 
		[Description("The fixed quantity which is used as the mathematical factor.")]
		[Required()]
		public IfcNamedUnit Unit { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The power that is applied to the unit attribute.")]
		[Required()]
		public Int64 Exponent { get; set; }
	
	
		public IfcDerivedUnitElement(IfcNamedUnit unit, Int64 exponent)
		{
			this.Unit = unit;
			this.Exponent = exponent;
		}
	
	
	}
	
}
