﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
   public class Note
    {
        public string Text { get; private set; }
        public int SerialNumber { get; private set; }
        public DateTime Date { get; private set; }

        public Note(string text, int serialNumber, DateTime date) // проверка text и date на null
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
