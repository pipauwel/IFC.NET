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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcPropertyResource
{
	[Guid("e2eafe97-cfcc-4816-951d-b06cbb579702")]
	public partial class IfcPropertyTableValue : IfcSimpleProperty
	{
		[DataMember(Order = 0)] 
		[Description("List of defining values, which determine the defined values.")]
		[Required()]
		[CustomValidation(typeof(IfcPropertyTableValue), "Unique")]
		[MinLength(1)]
		public IList<IfcValue> DefiningValues { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("Defined values which are applicable for the scope as defined by the defining values.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcValue> DefinedValues { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Expression for the derivation of defined values from the defining values, the expression is given for information only, i.e. no automatic processing can be expected from the expression.")]
		public IfcText? Expression { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("Unit for the defining values, if not given, the default value for the measure type (given by the TYPE of the defining values) is used as defined by the global unit assignment at IfcProject.")]
		public IfcUnit DefiningUnit { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("Unit for the defined values, if not given, the default value for the measure type (given by the TYPE of the defined values) is used as defined by the global unit assignment at IfcProject.")]
		public IfcUnit DefinedUnit { get; set; }
	
	
		public IfcPropertyTableValue(IfcIdentifier name, IfcValue[] definingValues, IfcValue[] definedValues)
			: base(name)
		{
			this.DefiningValues = new List<IfcValue>(definingValues);
			this.DefinedValues = new List<IfcValue>(definedValues);
		}
	
	
	}
	
}
