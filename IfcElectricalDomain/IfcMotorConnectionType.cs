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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcElectricalDomain
{
	[Guid("ec824845-e28c-4abc-a57a-8c95bf556dc8")]
	public partial class IfcMotorConnectionType : IfcEnergyConversionDeviceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<p>Identifies the predefined types of motor connection from which the type required may be set.</p>")]
		[Required()]
		public IfcMotorConnectionTypeEnum PredefinedType { get; set; }
	
	
		public IfcMotorConnectionType(IfcGloballyUniqueId globalId, IfcMotorConnectionTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
