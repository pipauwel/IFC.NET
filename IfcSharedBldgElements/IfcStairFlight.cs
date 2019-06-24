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
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("c9d3cb6e-0d99-4b3e-bf59-208b93718306")]
	public partial class IfcStairFlight : IfcBuildingElement
	{
		[DataMember(Order = 0)] 
		[Description("Number of the risers included in the stair flight.")]
		public Int64? NumberOfRiser { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Number of treads included in the stair flight.")]
		public Int64? NumberOfTreads { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Vertical distance from tread to tread. The riser height is supposed to be equal for all stairs in a stair flight.")]
		public IfcPositiveLengthMeasure? RiserHeight { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Horizontal distance from the front to the back of the tread. The tread length is supposed to be equal for all steps of the stair flight.")]
		public IfcPositiveLengthMeasure? TreadLength { get; set; }
	
	
		public IfcStairFlight(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
		}
	
	
	}
	
}
