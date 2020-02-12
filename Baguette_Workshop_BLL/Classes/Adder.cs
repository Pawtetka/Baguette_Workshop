using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    public class Adder : IOrderAdder
    {
        private Dictionary<string, string> orderInfo;
        private Order order;
        private Baguette baguette;
        private DateTime readyTime;
        public Adder() { }
        private void CreateBaguette()
        {
            baguette = new Baguette(orderInfo["Baguette_type:"], Convert.ToInt32(orderInfo["Width:"]), Convert.ToInt32(orderInfo["Height:"]));
        }
        private void CountReadyTime()
        {
            readyTime.AddHours(baguette.TimeToDo * Convert.ToInt32(orderInfo["Count"]));
        }
        private void CheckMaterials()
        {
            foreach (KeyValuePair<Material, int> keyValue in baguette.Materials)
            {
                if (ShopInfo.materialAvailability[keyValue.Key.type] < (keyValue.Value * baguette.Width * baguette.Height))
                {
                    readyTime.AddDays(7);
                }
            }
        }
        private void AddOrderToShop()
        {
            foreach (Material key in baguette.Materials.Keys)
            {
                ShopInfo.materialAvailability[key.type] -= baguette.Materials[key] * baguette.Width * baguette.Height;
            }
            ShopInfo.orders.Add(new Order(Convert.ToInt32(orderInfo["Count:"]), baguette, orderInfo["Surname:"], readyTime));
        }

        public void AddNewOrder(Dictionary<string, string> orderInfo)
        {
            this.orderInfo = orderInfo;
            CreateBaguette();
            CountReadyTime();
            CheckMaterials();
            AddOrderToShop();
        }
    }
}
