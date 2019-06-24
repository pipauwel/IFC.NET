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

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProcessExtension;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IFCFACILITIESMGMTDOMAIN
{
	[Guid("fc8522b4-c759-407e-a896-1ae680a0dd83")]
	public partial class IfcMove : IfcTask
	{
		[DataMember(Order = 0)] 
		[Description("The place from which actors and their associated equipment are moving.")]
		[Required()]
		public IfcSpatialStructureElement MoveFrom { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The place to which actors and their associated equipment are moving.")]
		[Required()]
		public IfcSpatialStructureElement MoveTo { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("A list of points concerning a move that require attention.")]
		[CustomValidation(typeof(IfcMove), "Unique")]
		[MinLength(1)]
		public IList<IfcText> PunchList { get; protected set; }
	
	
		public IfcMove(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcIdentifier taskId, Boolean isMilestone, IfcSpatialStructureElement moveFrom, IfcSpatialStructureElement moveTo)
			: base(globalId, ownerHistory, taskId, isMilestone)
		{
			this.MoveFrom = moveFrom;
			this.MoveTo = moveTo;
			this.PunchList = new List<IfcText>();
		}
	
	
	}
	
}
