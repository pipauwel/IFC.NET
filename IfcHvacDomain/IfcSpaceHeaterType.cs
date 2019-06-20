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

namespace BuildingSmart.IFC.IfcHvacDomain
{
	[Guid("0f52a5c7-5f1e-4406-8e80-801782467a1a")]
	public partial class IfcSpaceHeaterType : IfcFlowTerminalType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Enumeration of possible types of space heater (e.g., baseboard heater, convector, radiator, etc.).")]
		[Required()]
		public IfcSpaceHeaterTypeEnum PredefinedType { get; set; }
	
	
		public IfcSpaceHeaterType(IfcGloballyUniqueId globalId, IfcSpaceHeaterTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
