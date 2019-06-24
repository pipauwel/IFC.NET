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
	[Guid("619066ad-d580-4d0b-8d39-b41023bc4584")]
	public partial class IfcQuantityTime : IfcPhysicalSimpleQuantity
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Time measure value of this quantity.")]
		[Required()]
		public IfcTimeMeasure TimeValue { get; set; }
	
	
		public IfcQuantityTime(IfcLabel name, IfcTimeMeasure timeValue)
			: base(name)
		{
			this.TimeValue = timeValue;
		}
	
	
	}
	
}
