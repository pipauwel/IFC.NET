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
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcPlumbingFireProtectionDomain
{
	[Guid("8f0a8504-a6bc-4682-93f1-f55c09260b1a")]
	public partial class IfcWasteTerminal : IfcFlowTerminal
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		public IfcWasteTerminalTypeEnum? PredefinedType { get; set; }
	
	
		public IfcWasteTerminal(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}