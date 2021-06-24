//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.DancingGoatMvc;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(Contacts.CLASS_NAME, typeof(Contacts))]

namespace CMS.DocumentEngine.Types.DancingGoatMvc
{
	/// <summary>
	/// Represents a content item of type Contacts.
	/// </summary>
	public partial class Contacts : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DancingGoatMvc.Contacts";


		/// <summary>
		/// The instance of the class that provides extended API for working with Contacts fields.
		/// </summary>
		private readonly ContactsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ContactsID.
		/// </summary>
		[DatabaseIDField]
		public int ContactsID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ContactsID"), 0);
			}
			set
			{
				SetValue("ContactsID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string ContactName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactName"), @"");
			}
			set
			{
				SetValue("ContactName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Contacts fields.
		/// </summary>
		[RegisterProperty]
		public ContactsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Contacts fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ContactsFields : AbstractHierarchicalObject<ContactsFields>
		{
			/// <summary>
			/// The content item of type Contacts that is a target of the extended API.
			/// </summary>
			private readonly Contacts mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ContactsFields" /> class with the specified content item of type Contacts.
			/// </summary>
			/// <param name="instance">The content item of type Contacts that is a target of the extended API.</param>
			public ContactsFields(Contacts instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ContactsID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ContactsID;
				}
				set
				{
					mInstance.ContactsID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string ContactName
			{
				get
				{
					return mInstance.ContactName;
				}
				set
				{
					mInstance.ContactName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Contacts" /> class.
		/// </summary>
		public Contacts() : base(CLASS_NAME)
		{
			mFields = new ContactsFields(this);
		}

		#endregion
	}
}