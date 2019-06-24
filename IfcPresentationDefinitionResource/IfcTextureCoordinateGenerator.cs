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

namespace BuildingSmart.IFC.IfcPresentationDefinitionResource
{
	[Guid("f74d17a0-4ce5-490b-a72b-803150ebe125")]
	public partial class IfcTextureCoordinateGenerator : IfcTextureCoordinate
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The mode describes the algorithm used to compute texture coordinates.")]
		[Required()]
		public IfcLabel Mode { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The parameter used by the function as specified by Mode.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcSimpleValue> Parameter { get; protected set; }
	
	
		public IfcTextureCoordinateGenerator(IfcLabel mode, IfcSimpleValue[] parameter)
		{
			this.Mode = mode;
			this.Parameter = new List<IfcSimpleValue>(parameter);
		}
	
	
	}
	
}
