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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcQuantityResource
{
	[Guid("3112a0f9-e07b-4712-abad-9576ad39a1e2")]
	public partial class IfcQuantityWeight : IfcPhysicalSimpleQuantity
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Mass measure value of this quantity.")]
		[Required()]
		public IfcMassMeasure WeightValue { get; set; }
	
	
		public IfcQuantityWeight(IfcLabel name, IfcMassMeasure weightValue)
			: base(name)
		{
			this.WeightValue = weightValue;
		}
	
	
	}
	
}
