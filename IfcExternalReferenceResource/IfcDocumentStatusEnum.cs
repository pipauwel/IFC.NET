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


namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("5da7ac6c-0494-4c97-9373-49698ac9372f")]
	public enum IfcDocumentStatusEnum
	{
		[Description("Document is a draft.")]
		DRAFT = 1,
	
		[Description("Document is a final draft.")]
		FINALDRAFT = 2,
	
		[Description("Document is final.")]
		FINAL = 3,
	
		[Description("Document has undergone revision.")]
		REVISION = 4,
	
		NOTDEFINED = 0,
	
	}
}
