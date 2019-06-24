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
	[Guid("3dad840c-ea0d-49bf-a545-52ea60ed4fc7")]
	public partial class IfcStructuralResultGroup : IfcGroup
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Specifies the analysis theory used to obtain the respective results.")]
		[Required()]
		public IfcAnalysisTheoryTypeEnum TheoryType { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Reference to an instance of IfcStructuralLoadGroup for which this instance represents the result.")]
		public IfcStructuralLoadGroup ResultForLoadGroup { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("This Boolean value allows to easily recognize if a linear analysis has been applied (allowing the superposition of analysis results), or vice versa.")]
		[Required()]
		public Boolean IsLinear { get; set; }
	
		[InverseProperty("HasResults")] 
		[Description("Reference to an instance of IfcStructuralAnalysisModel for which this instance captures a result.")]
		[MaxLength(1)]
		public ISet<IfcStructuralAnalysisModel> ResultGroupFor { get; protected set; }
	
	
		public IfcStructuralResultGroup(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcAnalysisTheoryTypeEnum theoryType, Boolean isLinear)
			: base(globalId, ownerHistory)
		{
			this.TheoryType = theoryType;
			this.IsLinear = isLinear;
			this.ResultGroupFor = new HashSet<IfcStructuralAnalysisModel>();
		}
	
	
	}
	
}
