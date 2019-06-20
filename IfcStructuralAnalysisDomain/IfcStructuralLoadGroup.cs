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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("eda81530-0687-4842-bde0-d6567c6ba98b")]
	public partial class IfcStructuralLoadGroup : IfcGroup
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Selects a predefined type for the load group.  It can be differentiated between load groups, load cases, load combinations, or userdefined grouping levels.")]
		[Required()]
		public IfcLoadGroupTypeEnum PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Type of actions in the group. Normally needed if 'PredefinedType' specifies a LOAD_CASE.")]
		[Required()]
		public IfcActionTypeEnum ActionType { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Source of actions in the group. Normally needed if 'PredefinedType' specifies a LOAD_CASE.")]
		[Required()]
		public IfcActionSourceTypeEnum ActionSource { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Load factor. If omitted, a factor is not yet known or not specified. A load factor of 1.0 shall be explicitly exported as Coefficient = 1.0.")]
		public IfcRatioMeasure? Coefficient { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Description of the purpose of this instance. Among else, possible values of the Purpose of load combinations are 'SLS', 'ULS', 'ALS' to indicate serviceability, ultimate, or accidental limit state.")]
		public IfcLabel? Purpose { get; set; }
	
		[InverseProperty("ResultForLoadGroup")] 
		[Description("Results which were computed using this load group.")]
		[MaxLength(1)]
		public ISet<IfcStructuralResultGroup> SourceOfResultGroup { get; protected set; }
	
		[InverseProperty("LoadedBy")] 
		[Description("Analysis models in which this load group is used.")]
		public ISet<IfcStructuralAnalysisModel> LoadGroupFor { get; protected set; }
	
	
		public IfcStructuralLoadGroup(IfcGloballyUniqueId globalId, IfcLoadGroupTypeEnum predefinedType, IfcActionTypeEnum actionType, IfcActionSourceTypeEnum actionSource)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
			this.ActionType = actionType;
			this.ActionSource = actionSource;
			this.SourceOfResultGroup = new HashSet<IfcStructuralResultGroup>();
			this.LoadGroupFor = new HashSet<IfcStructuralAnalysisModel>();
		}
	
	
	}
	
}
