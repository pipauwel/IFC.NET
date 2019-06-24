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
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedFacilitiesElements
{
	[Guid("266bce27-12d2-4e1d-b589-b8d2a405ff05")]
	public partial class IfcOccupant : IfcActor
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined occupant types from which that required may be set.")]
		[Required()]
		public IfcOccupantTypeEnum PredefinedType { get; set; }
	
	
		public IfcOccupant(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcActorSelect theActor, IfcOccupantTypeEnum predefinedType)
			: base(globalId, ownerHistory, theActor)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
