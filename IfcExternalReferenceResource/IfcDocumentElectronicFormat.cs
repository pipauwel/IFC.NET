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

namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("0c03942c-41f7-44bf-a8d0-90c3f3366789")]
	public partial class IfcDocumentElectronicFormat
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("File extension of electronic document used by computer operating system.")]
		public IfcLabel? FileExtension { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Main Mime type (as published by W3C or as user defined application type)")]
		public IfcLabel? MimeContentType { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Mime subtype information.")]
		public IfcLabel? MimeSubtype { get; set; }
	
	
		public IfcDocumentElectronicFormat()
		{
		}
	
	
	}
	
}
