///////////////////////////////////////////////////////////
//  Customer.cs
//  Implementation of the Class Customer
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:24 PM
//  Original author: User
///////////////////////////////////////////////////////////

namespace OOSEStore
{
    public class Customer
    {
        private string m_Name;
        public int LoyaltyPoints { get; internal set; }
        public string Name { get { return m_Name; } }

        public Customer(string name)
        {
            m_Name = name;
        }

        internal Transaction CheckOut(string transactionName)
        {
            return new Transaction(transactionName);
        }

    }//end Customer

}//end namespace Store