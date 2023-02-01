﻿using iscaBar.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace iscaBar.Models
{
    [Table("table")]
    public class Order:ModelBase
    {
        private int id;
        private int num;
        private int diners;
        private String waiter;
        private String client;
        private decimal total;
        private String state;
        private List<OrderLine> lineorders;

        [PrimaryKey,AutoIncrement]
        public int Id { get { return id; } set { id = value; OnPropertyChanged(); } }
        public int Num { get { return num; } set { num = value; OnPropertyChanged(); } }
        public int Diners { get { return diners; } set { diners = value; OnPropertyChanged(); } }
        public String Waiter { get { return waiter; } set { waiter = value; OnPropertyChanged(); } }
        public String Client { get { return client; } set { client = value; OnPropertyChanged(); } }
        public decimal Total { get { return total; } set { total = value; OnPropertyChanged(); } }
        public String State { get { return state; } set { state = value; OnPropertyChanged(); } }
        public List<OrderLine> Lineorders { get { return lineorders; } set { lineorders = value; OnPropertyChanged(); } }

    }
}
