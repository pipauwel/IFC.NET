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
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcUtilityResource
{
	[Guid("a43b33fa-7560-44f0-a028-e14e498b919b")]
	public partial class IfcApplication
	{
		[DataMember(Order = 0)] 
		[Description("Name of the application developer, being requested to be member of the IAI.")]
		[Required()]
		public IfcOrganization ApplicationDeveloper { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The version number of this software as specified by the developer of the application.")]
		[Required()]
		public IfcLabel Version { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The full name of the application as specified by the application developer.")]
		[Required()]
		public IfcLabel ApplicationFullName { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Short identifying name for the application.")]
		[Required()]
		public IfcIdentifier ApplicationIdentifier { get; set; }
	
	
		public IfcApplication(IfcOrganization applicationDeveloper, IfcLabel version, IfcLabel applicationFullName, IfcIdentifier applicationIdentifier)
		{
			this.ApplicationDeveloper = applicationDeveloper;
			this.Version = version;
			this.ApplicationFullName = applicationFullName;
			this.ApplicationIdentifier = applicationIdentifier;
		}
	
	
	}
	
}
