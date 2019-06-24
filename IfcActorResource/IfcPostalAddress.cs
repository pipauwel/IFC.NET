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
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcActorResource
{
	[Guid("c748bb72-f703-4164-9e21-35cb62e2ae1a")]
	public partial class IfcPostalAddress : IfcAddress
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("An organization defined address for internal mail delivery.")]
		public IfcLabel? InternalLocation { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The postal address.  <EPM-HTML>  <BLOCKQUOTE><FONT SIZE=\"-1\">NOTE: A postal address may occupy several lines (or elements) when recorded.   It is expected that normal usage will incorporate relevant elements of the following address concepts:   A location within a building (e.g. 3rd Floor) Building name (e.g. Interoperability House) Street number   (e.g. 6400) Street name (e.g. Alliance Boulevard). Typical content of address lines may vary in different   countries.  </FONT></BLOCKQUOTE>  </EPM-HTML>")]
		[MinLength(1)]
		public IList<IfcLabel> AddressLines { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("An address that is implied by an identifiable mail drop.")]
		public IfcLabel? PostalBox { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The name of a town.")]
		public IfcLabel? Town { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The name of a region.  <EPM-HTML>  <BLOCKQUOTE><FONT SIZE=\"-1\">NOTE: The counties of the United Kingdom and the states of North America are examples of regions.  </FONT></BLOCKQUOTE>  </EPM-HTML>")]
		public IfcLabel? Region { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("The code that is used by the country's postal service.")]
		public IfcLabel? PostalCode { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("The name of a country.")]
		public IfcLabel? Country { get; set; }
	
	
		public IfcPostalAddress()
		{
			this.AddressLines = new List<IfcLabel>();
		}
	
	
	}
	
}
