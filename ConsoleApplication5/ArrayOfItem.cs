﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class ArrayOfItem
    {

        public List<Item> items;
        public ArrayOfItem()
        {
        }

        public ArrayOfItem(List<Item> items)
        {
            this.items = items;
        }
    }
}