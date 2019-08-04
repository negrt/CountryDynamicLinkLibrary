//***************************************************************************
//File: Language.cs
//
//Purpose: Class blueprint for Language. 
//
//Written By: Timothy Negron
//
//Compiler: Visual Studio C# 2017
//
//Update Information
//------------------
//
//Name: Timothy Negron
//Date: 10/9/2018
//Description: Added Serialize/Deserialize Code to Class 
//         and Member variables
//
//***************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization; // Added 10/9/2018
using System.Text;
using System.Threading.Tasks;

namespace CSprogramming_CS_DLL_for_Country_Data
{
    [DataContract]
    public class Language
    {
        #region Private Member Variables

        [DataMember(Name = "iso639_1")]
        private string m_iso639_1;
        [DataMember(Name = "iso639_2")]
        private string m_iso639_2;
        [DataMember(Name = "name")]
        private string m_name;
        [DataMember(Name = "nativeName")]
        private string m_nativeName;

        #endregion

        #region Properties
        //***************************************************************************
        //Method: Name
        //
        //Purpose: Properties get/set method for Name attribute.
        //		   
        //***************************************************************************

        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        //***************************************************************************
        //Method: nativeName
        //
        //Purpose: Properties get/set method for nativeName attribute.
        //		   
        //***************************************************************************

        public string nativeName
        {
            get
            {
                return m_nativeName;
            }
            set
            {
                m_nativeName = value;
            }
        }

        //***************************************************************************
        //Method: Iso639_1
        //
        //Purpose: Properties get/set method for Iso639_1 attribute.
        //
        //
        //
        //***************************************************************************

        public string Iso639_1
        {
            get
            {
                if (m_iso639_1 != null)
                {
                    return m_iso639_1;
                }
                else
                {
                    return "no iso639_1";
                }
            }
            set
            {
                if (value != null)
                {
                    m_iso639_1 = value;
                }
                else
                {
                    return;
                }
            }
        }

        //***************************************************************************
        //Method: Iso639_2
        //
        //Purpose: Properties get/set method for Iso639_2 attribute.
        //		   
        //***************************************************************************

        public string Iso639_2
        {
            get
            {
                return m_iso639_2;
            }
            set
            {
                m_iso639_2 = value;
            }
        }
        #endregion

        #region Methods
        //***************************************************************************
        //Method: Language()
        //
        //Purpose: To run a default constructor that will set the attributes of the
        //  language class to default values.
        //		   
        //***************************************************************************

        public Language()// Default Constructor
        {
            m_name = "no name";
            m_nativeName = "no native name";
            m_iso639_1 = "no iso639_1";
            m_iso639_2 = "no iso639_2";
        }

        //***************************************************************************
        //Method: ToString()
        //
        //Purpose: To display the values inside the attributes of the class.
        //		   
        //***************************************************************************

        override
        public String ToString()
        {
            String s = "\n\nLanguage\n-------" +
                       "\nName: " + Name+
                       "\nNative Name: " + nativeName +
                       "\nISO 639 1: " + Iso639_1 +
                       "\nISO 639 2: " + Iso639_2;
            return s;
        }
        #endregion
    }
}
