﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
   public class Node
    {
        public string Text { get; private set; }
        public int SerialNumber { get; private set; }
        public DateTime Date { get; private set; }

        public Node(string text, int serialNumber, DateTime date)
        {
            if (serialNumber > 0)
            {
                this.Text = text;
                this.SerialNumber = serialNumber;
                this.Date = date;
            }
        }

        public override string ToString()
        {
            return string.Format("№ {0,3}  Текст: {1}  Дата выполнения: {2}",SerialNumber,Text,Date.ToShortDateString());
        }
    }
}
