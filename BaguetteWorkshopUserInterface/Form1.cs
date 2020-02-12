using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baguette_Workshop_BLL.Interfaces;
using Baguette_Workshop_BLL.Classes;

namespace BaguetteWorkshopUserInterface
{
    public partial class Form1 : Form
    {
        static IShop shop = new Shop(new Adder(), new Printer());
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            shop.AddNewOrder(ReadOrderInfo());
        }

        private void btn_PrintOrder_Click(object sender, EventArgs e)
        {
            txt_PrintOrders.Text = null;
            foreach (string str in shop.ReturnOrders("White_Horse"))
            {
                txt_PrintOrders.Text += str;
            }
        }

        private Dictionary<string, string> ReadOrderInfo()
        {
            Dictionary<string, string> orderInfo = new Dictionary<string, string>();
            orderInfo.Add("Baguette_type:", txt_Type.Text);
            orderInfo.Add("Width:", txt_Width.Text);
            orderInfo.Add("Height:", txt_Height.Text);
            orderInfo.Add("Count:", txt_Count.Text);
            orderInfo.Add("Surname:", txt_Surname.Text);
            return orderInfo;
        }
    }
}
