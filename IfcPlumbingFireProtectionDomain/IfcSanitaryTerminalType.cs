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

namespace BuildingSmart.IFC.IfcPlumbingFireProtectionDomain
{
	[Guid("3e6d6990-982c-4e43-a72e-52557bdc1ac3")]
	public partial class IfcSanitaryTerminalType : IfcFlowTerminalType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<p>Identifies the predefined types of sanitary terminal from which the type required may be set.</p>")]
		[Required()]
		public IfcSanitaryTerminalTypeEnum PredefinedType { get; set; }
	
	
		public IfcSanitaryTerminalType(IfcGloballyUniqueId globalId, IfcSanitaryTerminalTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
