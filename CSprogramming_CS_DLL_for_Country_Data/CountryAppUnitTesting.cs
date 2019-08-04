//***************************************************************************
//File: CountryAppUnitTesting.cs
//
//Purpose: This class was designed to test the properties of the Currency
//  & the Language class.
//
//Written By: Timothy Negron
//
//Compiler: Visual Studio C# 2017
//
//Update Information
//------------------
//
//***************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSprogramming_CS_DLL_for_Country_Data
{
    public class CountryAppUnitTesting
    {

        #region Methods

        //***************************************************************************
        //Method: UnitTestCurrency()
        //
        //Purpose: To run a Unit Test on the Currency Class properties.	   
        //***************************************************************************
        public void UnitTestCurrency()
        {
            Currency curr = new Currency();

            Console.WriteLine("\n**********************");
            Console.WriteLine("Unit Testing: Currency");
            Console.WriteLine("**********************");

            // Testing m_code
            string testCode = "0101";
            curr.Code = testCode;

            if (curr.Code == testCode)
            {
                Console.WriteLine("Currency Code Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Code Property: FAIL!");
            }

            // Testing m_name
            string testName = "Pound";
            curr.Name = testName;

            if (curr.Name == testName)
            {
                Console.WriteLine("Currency Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Name Property: FAIL!");
            }

            // Testing m_symbol
            string testSymbol = "Capital";
            curr.Symbol = testSymbol;

            if (curr.Symbol == testSymbol)
            {
                Console.WriteLine("Currency Symbol Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Symbol Property: FAIL!");
            }
        }

        //***************************************************************************
        //Method: UnitTestLanguage()
        //
        //Purpose: To run a Unit Test on the Language Class properties.   
        //***************************************************************************

        public void UnitTestLanguage()
        {
            Language lang = new Language();

            Console.WriteLine("\n**********************");
            Console.WriteLine("Unit Testing: Language");
            Console.WriteLine("**********************");

            // Testing m_name
            string testName = "Spanish";
            lang.Name = testName;

            if (lang.Name == testName)
            {
                Console.WriteLine("Currency Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Name Property: FAIL!");
            }

            // Testing m_nativeName
            string testNativeName = "Espanol";
            lang.nativeName = testNativeName;

            if (lang.nativeName == testNativeName)
            {
                Console.WriteLine("Currency NativeName Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency NativeName Property: FAIL!");
            }

            // Testing m_iso639_1
            string testIso639_1 = "639_111";
            lang.Iso639_1 = testIso639_1;

            if (lang.Iso639_1 == testIso639_1)
            {
                Console.WriteLine("Currency ISO639_1 Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency ISO639_1 Property: FAIL!");
            }

            // Testing m_iso639_2
            string testIso639_2 = "639_222";
            lang.Iso639_2 = testIso639_2;

            if (lang.Iso639_2 == testIso639_2)
            {
                Console.WriteLine("Currency ISO639_2 Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency ISO639_2 Property: FAIL!");
            }
        }
        #endregion

    }
}
