//***************************************************************************
//File: Currency.cs
//
//Purpose: Class blueprint for Currency. 
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
//         and Member variables.
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
    public class Currency
    {
        #region Private Member Variables

        [DataMember(Name = "code")]
        private string m_code;
        [DataMember(Name = "name")]
        private string m_name;
        [DataMember(Name = "symbol")]
        private string m_symbol;

        #endregion

        #region Properties
        //***************************************************************************
        //Method: Code
        //
        //Purpose: Properties get/set method for code attribute.
        //		   
        //***************************************************************************

        public string Code
        {
            get
            {
                if (m_code != null)
                {
                    return m_code;
                }
                else
                {
                    return "no code";
                }
            }
            set
            {
                if (value != null)
                {
                    m_code = value;
                }
                else
                {
                    return;
                }
            }
        }

        //***************************************************************************
        //Method: Name
        //
        //Purpose: Properties get/set method for name attribute.
        //		   
        //***************************************************************************

        public string Name
        {
            get
            {
                if (m_name != null)
                {
                    return m_name;
                }
                else
                {
                    return "no name";
                }
            }
            set
            {
                if (value != null)
                {
                    m_name = value;
                }
            }
        }

        //***************************************************************************
        //Method: Symbol
        //
        //Purpose: Properties get/set method for symbol attribute.
        //		   
        //***************************************************************************

        public string Symbol
        {
            get
            {
                if (m_symbol != null)
                {
                    return m_symbol;
                }
                else
                {
                    return "no symbol";
                }
            }
            set
            {
                if (value != null)
                {
                    m_symbol = value;
                }
            }
        }
        #endregion

        #region Methods
        //***************************************************************************
        //Method: Currency()
        //
        //Purpose: To construct a default currency class.
        //		   
        //***************************************************************************

        public Currency() // Default Constructor
        {
            m_code = "no code";
            m_name = "no name";
            m_symbol = "no symbol";
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

            String s = "\n\nCurrency\n-------" +
                       "\nCode: " + Code +
                       "\nName: " + Name +
                       "\nSymbol: " + Symbol;
          
            return s;
        }
        #endregion
    }
}
