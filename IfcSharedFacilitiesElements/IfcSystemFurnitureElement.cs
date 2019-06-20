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

namespace BuildingSmart.IFC.IfcSharedFacilitiesElements
{
	[Guid("c337853a-d06e-4127-b850-0e1835ef32e3")]
	public partial class IfcSystemFurnitureElement : IfcFurnishingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		public IfcSystemFurnitureElementTypeEnum? PredefinedType { get; set; }
	
	
		public IfcSystemFurnitureElement(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
