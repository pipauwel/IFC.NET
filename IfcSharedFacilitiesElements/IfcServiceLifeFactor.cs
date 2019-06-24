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

namespace BuildingSmart.IFC.IfcSharedFacilitiesElements
{
	[Guid("8a4f8c35-5289-4e38-a1b9-9f40410d6e20")]
	public partial class IfcServiceLifeFactor : IfcPropertySetDefinition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined service life factor types from which that required may be set.")]
		[Required()]
		public IfcServiceLifeFactorTypeEnum PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Upper of the three values assigned to the service life factor.")]
		public IfcMeasureValue UpperValue { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Most used of the three values assigned to the service life factor.")]
		[Required()]
		public IfcMeasureValue MostUsedValue { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("Lower of the three values assigned to the service life factor.")]
		public IfcMeasureValue LowerValue { get; set; }
	
	
		public IfcServiceLifeFactor(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcServiceLifeFactorTypeEnum predefinedType, IfcMeasureValue mostUsedValue)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
			this.MostUsedValue = mostUsedValue;
		}
	
	
	}
	
}
