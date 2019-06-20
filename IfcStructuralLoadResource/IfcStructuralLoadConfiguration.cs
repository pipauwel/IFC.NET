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

namespace BuildingSmart.IFC.IfcStructuralLoadResource
{
	[Guid("9918b5b5-eb80-483e-b901-d25ba01b4ae7")]
	public partial class IfcStructuralLoadConfiguration : IfcStructuralLoad
	{
		[DataMember(Order = 0)] 
		[Description("List of load or result values.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcStructuralLoadOrResult> Values { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlElement("IfcLengthMeasure")]
		[Description("Locations of the load samples or result samples, given within the local coordinate system defined by the instance which uses this resource object.  Each item in the list of locations pertains to the values list item at the same list index.  This attribute is optional for configurations in which the locations are implicitly known from higher-level definitions.")]
		[CustomValidation(typeof(IfcStructuralLoadConfiguration), "Unique")]
		[MinLength(1)]
		public IList<IfcLengthMeasure> Locations { get; protected set; }
	
	
		public IfcStructuralLoadConfiguration(IfcStructuralLoadOrResult[] values)
		{
			this.Values = new List<IfcStructuralLoadOrResult>(values);
			this.Locations = new List<IfcLengthMeasure>();
		}
	
	
	}
	
}
