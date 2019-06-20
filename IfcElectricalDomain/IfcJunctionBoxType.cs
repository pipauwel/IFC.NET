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
	[Guid("5b0765d7-22a3-4ba4-a259-32523ca4082c")]
	public partial class IfcJunctionBoxType : IfcFlowFittingType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<p>Identifies the predefined types of junction boxes from which the type required may be set.</p>")]
		[Required()]
		public IfcJunctionBoxTypeEnum PredefinedType { get; set; }
	
	
		public IfcJunctionBoxType(IfcGloballyUniqueId globalId, IfcJunctionBoxTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}