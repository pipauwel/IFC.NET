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
	[Guid("cbe43c1f-9ddd-4279-bb40-699045a1e748")]
	public partial class IfcCableCarrierSegment : IfcFlowSegment
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<p>Identifies the predefined types of cable carrier segment from which the type required may be set.</p>")]
		public IfcCableCarrierSegmentTypeEnum? PredefinedType { get; set; }
	
	
		public IfcCableCarrierSegment(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
