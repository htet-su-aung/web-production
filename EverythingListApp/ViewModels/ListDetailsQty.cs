﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverythingListApp.ViewModels
{
    public class ListDetailsQty
    {
        public ListDetailsQty()
        {

        }

        public ListDetailsQty(int itemID, string itemName)
        {
            ItemID = itemID;
            ItemName = itemName;
        }

        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public bool IsChecked { get; set; }
        public int ItemQty { get; set; }
    }
}