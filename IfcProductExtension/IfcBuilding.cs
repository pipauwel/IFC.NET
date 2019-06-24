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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("eade5642-82aa-489b-a89f-fc5a1c9022f0")]
	public partial class IfcBuilding : IfcSpatialStructureElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Elevation above sea level of the reference height used for all storey elevation measures, equals to height 0.0. It is usually the ground floor level.")]
		public IfcLengthMeasure? ElevationOfRefHeight { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Elevation above the minimal terrain level around the foot print of the building, given in elevation above sea level.")]
		public IfcLengthMeasure? ElevationOfTerrain { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Address given to the building for postal purposes.")]
		public IfcPostalAddress BuildingAddress { get; set; }
	
	
		public IfcBuilding(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElementCompositionEnum compositionType)
			: base(globalId, ownerHistory, compositionType)
		{
		}
	
	
	}
	
}
