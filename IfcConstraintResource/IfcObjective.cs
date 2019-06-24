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
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcConstraintResource
{
	[Guid("b0794e67-9191-4c55-a93f-70f1d753d31e")]
	public partial class IfcObjective : IfcConstraint
	{
		[DataMember(Order = 0)] 
		[Description("A list of any benchmark values used for comparison purposes.")]
		public IfcMetric BenchmarkValues { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("A list of any resultant values used for comparison purposes.")]
		public IfcMetric ResultValues { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Enumeration that qualifies the type of objective constraint.")]
		[Required()]
		public IfcObjectiveEnum ObjectiveQualifier { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("<EPM-HTML>A user defined value that qualifies the type of objective constraint when ObjectiveQualifier attribute of type <I>IfcObjectiveEnum</I> has value USERDEFINED.</EPM-HTML>")]
		public IfcLabel? UserDefinedQualifier { get; set; }
	
	
		public IfcObjective(IfcLabel name, IfcConstraintEnum constraintGrade, IfcObjectiveEnum objectiveQualifier)
			: base(name, constraintGrade)
		{
			this.ObjectiveQualifier = objectiveQualifier;
		}
	
	
	}
	
}
