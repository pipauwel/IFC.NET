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


namespace BuildingSmart.IFC.IfcRepresentationResource
{
	[Guid("5abaa3e9-3b43-4c49-9e66-afe0a3c094d5")]
	public abstract partial class IfcCoordinateOperation
	{
		[DataMember(Order = 0)] 
		[XmlIgnore]
		[Description("Source coordinate reference system for the operation.")]
		[Required()]
		public IfcCoordinateReferenceSystemSelect SourceCRS { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Target coordinate reference system for the operation.")]
		[Required()]
		public IfcCoordinateReferenceSystem TargetCRS { get; set; }
	
	
		protected IfcCoordinateOperation(IfcCoordinateReferenceSystemSelect sourceCRS, IfcCoordinateReferenceSystem targetCRS)
		{
			this.SourceCRS = sourceCRS;
			this.TargetCRS = targetCRS;
		}
	
	
	}
	
}
