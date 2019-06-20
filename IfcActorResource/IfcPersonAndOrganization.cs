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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcActorResource
{
	[Guid("52b0207c-cc6a-42c8-a632-c3d63a70b2a5")]
	public partial class IfcPersonAndOrganization :
		IfcActorSelect,
		BuildingSmart.IFC.IfcPropertyResource.IfcObjectReferenceSelect,
		BuildingSmart.IFC.IfcExternalReferenceResource.IfcResourceObjectSelect
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The person who is related to the organization.")]
		[Required()]
		public IfcPerson ThePerson { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("The organization to which the person is related.")]
		[Required()]
		public IfcOrganization TheOrganization { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Roles played by the person within the context of an organization.  These may differ from the roles in <em>ThePerson.Roles</em> which may be asserted without organizational context.")]
		[MinLength(1)]
		public IList<IfcActorRole> Roles { get; protected set; }
	
	
		public IfcPersonAndOrganization(IfcPerson thePerson, IfcOrganization theOrganization)
		{
			this.ThePerson = thePerson;
			this.TheOrganization = theOrganization;
			this.Roles = new List<IfcActorRole>();
		}
	
	
	}
	
}
