using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcSharp.Ifc2x4
{
    public class IfcPerson
    {
        Guid _identification;
        string _familyName;
        string _givenName;
        List<string> _middleNames;
        List<string> _prefixTitles;
        List<string> _suffixTitles;
        List<IfcActorRole> _roles;
        List<IfcAddress> _addresses;

        public Guid Identification { get { return _identification; } set { _identification = value; } }
        public string FamilyName { get { return _familyName; } set { _familyName = value; } }
        public string GivenName { get { return _givenName; } set { _givenName = value; } }
        public List<string> MiddleNames { get { return _middleNames; } set { _middleNames = value; } }
        public List<string> PrefixTitles { get { return _prefixTitles; } set { _prefixTitles = value; } }
        public List<string> SuffixTitles { get { return _suffixTitles; } set { _suffixTitles = value; } }
        public List<IfcActorRole> Roles { get { return _roles; } set { _roles = value; } }
        public List<IfcAddress> Addresses { get { return _addresses; } set { _addresses = value; } }

	
//ENTITY IfcPerson;
//  ENTITY IfcPerson;
//      Identification	 : 	OPTIONAL IfcIdentifier;
//      FamilyName	 : 	OPTIONAL IfcLabel;
//      GivenName	 : 	OPTIONAL IfcLabel;
//      MiddleNames	 : 	OPTIONAL LIST [1:?] OF IfcLabel;
//      PrefixTitles	 : 	OPTIONAL LIST [1:?] OF IfcLabel;
//      SuffixTitles	 : 	OPTIONAL LIST [1:?] OF IfcLabel;
//      Roles	 : 	OPTIONAL LIST [1:?] OF IfcActorRole;
//      Addresses	 : 	OPTIONAL LIST [1:?] OF IfcAddress;
//  INVERSE
//      EngagedIn	 : 	SET OF IfcPersonAndOrganization FOR ThePerson;
//END_ENTITY;

    }
}
