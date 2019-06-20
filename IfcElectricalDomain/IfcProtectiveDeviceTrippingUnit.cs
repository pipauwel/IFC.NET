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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcElectricalDomain
{
	[Guid("a8488154-175e-4eda-b9b6-157a9fa9cafe")]
	public partial class IfcProtectiveDeviceTrippingUnit : IfcDistributionControlElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		public IfcProtectiveDeviceTrippingUnitTypeEnum? PredefinedType { get; set; }
	
	
		public IfcProtectiveDeviceTrippingUnit(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
