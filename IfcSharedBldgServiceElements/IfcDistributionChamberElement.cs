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
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("0ed9ba24-3b80-425e-989f-171cef0fce7a")]
	public partial class IfcDistributionChamberElement : IfcDistributionFlowElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		public IfcDistributionChamberElementTypeEnum? PredefinedType { get; set; }
	
	
		public IfcDistributionChamberElement(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
