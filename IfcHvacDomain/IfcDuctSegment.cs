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

namespace BuildingSmart.IFC.IfcHvacDomain
{
	[Guid("69c85fcc-5dec-4731-af87-612401edf054")]
	public partial class IfcDuctSegment : IfcFlowSegment
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		public IfcDuctSegmentTypeEnum? PredefinedType { get; set; }
	
	
		public IfcDuctSegment(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
