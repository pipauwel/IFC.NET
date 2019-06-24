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
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcElectricalDomain
{
	[Guid("839af1db-2fba-4218-b66d-51a6d1ec4eca")]
	public partial class IfcElectricDistributionPoint : IfcFlowController
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifies the functions or purposes that a distribution point may fulfill from which that required may be selected.")]
		[Required()]
		public IfcElectricDistributionPointFunctionEnum DistributionPointFunction { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		public IfcLabel? UserDefinedFunction { get; set; }
	
	
		public IfcElectricDistributionPoint(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElectricDistributionPointFunctionEnum distributionPointFunction)
			: base(globalId, ownerHistory)
		{
			this.DistributionPointFunction = distributionPointFunction;
		}
	
	
	}
	
}
