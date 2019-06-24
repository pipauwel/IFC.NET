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

using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IFCFACILITIESMGMTDOMAIN
{
	[Guid("eba22b2c-f893-4c98-8335-f0d8e1a3c556")]
	public partial class IfcConditionCriterion : IfcControl
	{
		[DataMember(Order = 0)] 
		[Description("The measured or assessed value of a criterion.")]
		[Required()]
		public IfcConditionCriterionSelect Criterion { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The time and/or date at which the criterion is determined.")]
		[Required()]
		public IfcDateTimeSelect CriterionDateTime { get; set; }
	
	
		public IfcConditionCriterion(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcConditionCriterionSelect criterion, IfcDateTimeSelect criterionDateTime)
			: base(globalId, ownerHistory)
		{
			this.Criterion = criterion;
			this.CriterionDateTime = criterionDateTime;
		}
	
	
	}
	
}
