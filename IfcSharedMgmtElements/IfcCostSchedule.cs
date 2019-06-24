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
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedMgmtElements
{
	[Guid("288d213e-1d98-4845-8a80-52750f1ef316")]
	public partial class IfcCostSchedule : IfcControl
	{
		[DataMember(Order = 0)] 
		[Description("The identity of the person or organization submitting the cost schedule.")]
		public IfcActorSelect SubmittedBy { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The identity of the person or organization preparing the cost schedule.")]
		public IfcActorSelect PreparedBy { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("The date on which the cost schedule was submitted.")]
		public IfcDateTimeSelect SubmittedOn { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The current status of a cost schedule. Examples of status values that might be used for a cost schedule status include:  - PLANNED  - APPROVED  - AGREED  - ISSUED  - STARTED")]
		public IfcLabel? Status { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("The actors for whom the cost schedule was prepared.")]
		[MinLength(1)]
		public ISet<IfcActorSelect> TargetUsers { get; protected set; }
	
		[DataMember(Order = 5)] 
		[Description("The date that this cost schedule is updated; this allows tracking the schedule history.")]
		public IfcDateTimeSelect UpdateDate { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("A unique identification assigned to a cost schedule that enables its differentiation from other cost schedules.")]
		[Required()]
		public IfcIdentifier ID { get; set; }
	
		[DataMember(Order = 7)] 
		[XmlAttribute]
		[Description("Predefined types of cost schedule from which that required may be selected.")]
		[Required()]
		public IfcCostScheduleTypeEnum PredefinedType { get; set; }
	
	
		public IfcCostSchedule(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcIdentifier iD, IfcCostScheduleTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.TargetUsers = new HashSet<IfcActorSelect>();
			this.ID = iD;
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
