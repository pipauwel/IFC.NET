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
	[Guid("41818906-f93c-465b-b7ab-c30dbe86d46d")]
	public partial class IfcAirTerminalBoxType : IfcFlowControllerType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The air terminal box type.")]
		[Required()]
		public IfcAirTerminalBoxTypeEnum PredefinedType { get; set; }
	
	
		public IfcAirTerminalBoxType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcAirTerminalBoxTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
