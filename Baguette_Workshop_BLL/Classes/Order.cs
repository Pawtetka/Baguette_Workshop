using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
namespace Baguette_Workshop_BLL.Classes
{
    [DataContract]
    class Order
    {
        [DataMember]
        public Baguette Baguette { get; }
        [DataMember]
        public DateTime ReadyBy { get; }
        [DataMember]
        public int Count { get; }
        [DataMember]

        public bool ready = false; //I must do something with this sheet
        [DataMember]
        public string Surname { get; }
        public Order()
        {

        }
        public Order(int count, Baguette baguette, string surname)
        {
            Baguette = baguette;
            Count = count;
            Surname = surname;
        }
        public Order(int count, Baguette baguette, string surname, DateTime readyBy)
        {
            Baguette = baguette;
            Count = count;
            Surname = surname;
            ReadyBy = readyBy;
        }
        public void OrderReady()
        {
            ready = true;
        }

        public double GetPrice(ICounter counter)
        {
            return counter.GetPrice();
        }

        ~Order() { }
    }
}
