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
	[Guid("63704ce8-f787-4e3a-9bf7-71c7b61b60ac")]
	public partial class IfcClassificationItemRelationship
	{
		[DataMember(Order = 0)] 
		[Description("The parent level item in a classification structure that is used for relating the child level items.")]
		[Required()]
		public IfcClassificationItem RelatingItem { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The child level items in a classification structure that are related to the parent level item.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcClassificationItem> RelatedItems { get; protected set; }
	
	
		public IfcClassificationItemRelationship(IfcClassificationItem relatingItem, IfcClassificationItem[] relatedItems)
		{
			this.RelatingItem = relatingItem;
			this.RelatedItems = new HashSet<IfcClassificationItem>(relatedItems);
		}
	
	
	}
	
}
