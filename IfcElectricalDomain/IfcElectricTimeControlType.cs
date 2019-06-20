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
	[Guid("2bb86abe-9d7d-49e5-8a0e-89e7617eddf6")]
	public partial class IfcElectricTimeControlType : IfcFlowControllerType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<p>Identifies the predefined types of electrical time control from which the type required may be set.</p>")]
		[Required()]
		public IfcElectricTimeControlTypeEnum PredefinedType { get; set; }
	
	
		public IfcElectricTimeControlType(IfcGloballyUniqueId globalId, IfcElectricTimeControlTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
