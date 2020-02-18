using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_new.Interfaces;
using BLL_new.Classes;

namespace BaguetteWorkshopUserInterface
{
    public partial class Form1 : Form
    {
        public static readonly string jsonPath = @"C:\Users\PashkaPustik\Desktop\TRPZ_Baguette\Baguette_Workshop\Shop.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            txt_Price.Text = Convert.ToString(Program.container.GetShop().CountBaguettePrice(txt_Type.Text, Convert.ToDouble(txt_Width.Text), Convert.ToDouble(txt_Height.Text)));
        }

        /*private Dictionary<string, string> ReadOrderInfo()
        {
            Dictionary<string, string> orderInfo = new Dictionary<string, string>();
            orderInfo.Add("Baguette_type:", txt_Type.Text);
            orderInfo.Add("Width:", txt_Width.Text);
            orderInfo.Add("Height:", txt_Height.Text);
            return orderInfo;
        }*/

        /*private void Serialize()
        {
            ISerialization serializator = new Serialization();
            serializator.Serialize(shop, jsonPath);
        }
        private Object Deserialize()
        {
            ISerialization serializator = new Serialization();
            return serializator.Deserialize(jsonPath);
        }*/
    }
}
