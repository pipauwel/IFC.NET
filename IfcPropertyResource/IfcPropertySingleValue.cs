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
	[Guid("f8a2ecb3-b33b-4e48-a3a3-3e232f14a986")]
	public partial class IfcPropertySingleValue : IfcSimpleProperty
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  Value and measure type of this property.   <blockquote><small>  NOTE&nbsp; By virtue of the defined data type, that is selected from the SELECT <i>IfcValue</i>, the appropriate unit can be found within the <i>IfcUnitAssignment</i>, defined for the project if no value for the unit attribute is given.<br>  <font color=\"#ff0000\">  IFC2x Edition 3 CHANGE&nbsp; The attribute has been made optional with upward compatibility for file based exchange.  </font>  </small></blockquote>  </EPM-HTML>")]
		public IfcValue NominalValue { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Unit for the nominal value, if not given, the default value for the measure type (given by the TYPE of nominal value) is used as defined by the global unit assignment at IfcProject.")]
		public IfcUnit Unit { get; set; }
	
	
		public IfcPropertySingleValue(IfcIdentifier name)
			: base(name)
		{
		}
	
	
	}
	
}
