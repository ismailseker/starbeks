﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrderPage orderForm = new OrderPage();
            checkoutPage checkoutForm = new checkoutPage();
            KitchenPage kitchenForm = new KitchenPage();
            orderForm.SetKitchenForm(kitchenForm);
            kitchenForm.Show();
            orderForm.Show();
            checkoutForm.Show();
            adminForm.Show();
        }    
    }
}
