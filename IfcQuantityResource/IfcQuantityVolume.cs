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
	[Guid("16ed104c-4bf5-4f35-8815-8c5337893a7a")]
	public partial class IfcQuantityVolume : IfcPhysicalSimpleQuantity
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Volume measure value of this quantity.")]
		[Required()]
		public IfcVolumeMeasure VolumeValue { get; set; }
	
	
		public IfcQuantityVolume(IfcLabel name, IfcVolumeMeasure volumeValue)
			: base(name)
		{
			this.VolumeValue = volumeValue;
		}
	
	
	}
	
}
