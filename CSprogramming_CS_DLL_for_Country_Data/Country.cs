//***************************************************************************
//File: Country.cs
//
//Purpose: Class blueprint for Country. 
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
//Name: Timothy Negron
//Date: 11/1/2018
//Description: m_currencies & m_languages data types have been change to
//  be a list. The constructor and ToString methods have been updated to 
//  reflect those changes.
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
    public class Country
    {
        #region Private Member Variables

        [DataMember(Name = "name")]
        private string m_name;
        [DataMember(Name = "capital")]
        private string m_capital;
        [DataMember(Name = "region")]
        private string m_region;
        [DataMember(Name = "subregion")]
        private string m_subregion;
        [DataMember(Name = "population")]
        private int m_population;
        [DataMember(Name = "currencies")] // Changed to "currencies" project 3
        List<Currency> m_currencies; // Changed to m_currencies project 3
        [DataMember(Name = "languages")] // Changed to "languages" project 3
        List<Language> m_languages; // Changed to m_languages project 3

        #endregion

        #region Properties
        //***************************************************************************
        //Method: Name
        //
        //Purpose: Properties get/set method for m_name attribute.
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
        //Method: Capital
        //
        //Purpose: Properties get/set method for m_capital attribute.
        //		   
        //***************************************************************************

        public string Capital
        {
            get
            {
                return m_capital;
            }
            set
            {
                m_capital = value;
            }
        }

        //***************************************************************************
        //Method: Region
        //
        //Purpose: Properties get/set method for m_region attribute.
        //		   
        //***************************************************************************

        public string Region
        {
            get
            {
                return m_region;
            }
            set
            {
                m_region = value;
            }
        }

        //***************************************************************************
        //Method: Subregion
        //
        //Purpose: Properties get/set method for m_subregion attribute.
        //		   
        //***************************************************************************

        public string Subregion
        {
            get
            {
                return m_subregion;
            }
            set
            {
                m_subregion = value;
            }
        }

        //***************************************************************************
        //Method: Population
        //
        //Purpose: Properties get/set method for m_population attribute.
        //		   
        //***************************************************************************

        public int Population
        {
            get
            {
                return m_population;
            }
            set
            {
                m_population = value;
            }
        }

        //***************************************************************************
        //Method: Currencies
        //
        //Purpose: Properties get/set method for m_currencies attribute.
        //
        //Update Information
        //------------------
        //
        //Name: Timothy Negron
        //Date: 11/1/2018
        //Description: m_currencies data type has been changed to List<Currency>.
        //
        //***************************************************************************

        public List<Currency> Currencies // Changed data type to List project 3
        {
            get
            {
                return m_currencies;
            }
            set
            {
                if (value != null)
                {
                    m_currencies = value;
                }
            }
        }

        //***************************************************************************
        //Method: Languages
        //
        //Purpose: Properties get/set method for m_languages attribute.
        //
        //Update Information
        //------------------
        //
        //Name: Timothy Negron
        //Date: 11/1/2018
        //Description: m_languages data type has been changed to List<Language>.   
        //
        //***************************************************************************

        public List<Language> Languages // Changed data type to list project 3
        {
            get
            {
                return m_languages;
            }
            set
            {
                if (value != null)
                {
                    m_languages = value;
                }
            }
        }
        #endregion

        #region Methods
        //***************************************************************************
        //Method: Country()
        //
        //Purpose: To run a default constructor that will set the attributes of the
        //  Country class to default values.
        //
        //Update Information
        //------------------
        //
        //Name: Timothy Negron
        //Date: 11/1/2018
        //Description: m_currencies & m_languages is now a list. This constructor
        //  now allocates memory for these member variables.
        //		   
        //***************************************************************************

        public Country() // Default Constructor
        {
            m_name = "No Country Name";
            m_capital = "No Capital";
            m_region = "No Region";
            m_subregion = "No Sub Region";
            m_population = 0;
            m_currencies = new List<Currency>(); // Changed to List Project 3
            m_languages = new List<Language>(); // Changed to List Project 3
        }

        //***************************************************************************
        //Method: ToString()
        //
        //Purpose: To display the values inside the attributes of the class.
        //
        //Update Information
        //------------------
        //
        //Name: Timothy Negron
        //Date: 11/1/2018
        //Description: m_currencies & m_languages is now a list. ToString() has been 
        //  updated to reflect those changes. There are now two loops that loop
        //  through the list and stores the ToString from the objects into the 
        //  variable s.
        //		   
        //***************************************************************************

        public override string ToString()
        {
            String s = "\n\n" + Name + " Country Object\n-------" +
                        "\nCountry Name: " + Name +
                        "\nCapital: " + Capital +
                        "\nRegion: " + Region +
                        "\nSub Region: " + Subregion +
                        "\nPopulation: " + Population +
                        "\n\n" + Name + " Currencies Object\n--------";

            foreach (Currency c in m_currencies)
            {
                s +=c.ToString();
            }

            s += "\n\n" + m_name + " Languages Object\n--------";

            foreach (Language l in m_languages)
            {
                s += l.ToString();
            }

            return s;
        }
        #endregion
    }
}
