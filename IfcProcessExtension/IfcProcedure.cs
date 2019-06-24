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

namespace BuildingSmart.IFC.IfcProcessExtension
{
	[Guid("0c523651-bc17-41eb-b22e-d09db16fe089")]
	public partial class IfcProcedure : IfcProcess
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("An identifying designation given to a procedure.")]
		[Required()]
		public IfcIdentifier ProcedureID { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Predefined procedure types from which that required may be set.")]
		[Required()]
		public IfcProcedureTypeEnum ProcedureType { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("A user defined procedure type.")]
		public IfcLabel? UserDefinedProcedureType { get; set; }
	
	
		public IfcProcedure(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcIdentifier procedureID, IfcProcedureTypeEnum procedureType)
			: base(globalId, ownerHistory)
		{
			this.ProcedureID = procedureID;
			this.ProcedureType = procedureType;
		}
	
	
	}
	
}
