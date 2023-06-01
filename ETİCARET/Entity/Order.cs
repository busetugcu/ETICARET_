﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ETİCARET.Entity
{

    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekleniyor")]
        Waiting,
        [Display(Name = "Kargolandı")]
        Shipping,
        [Display(Name = "Teslim Edildi")]
        Completed
    }



    public class Order
    {

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }
        public string Username { get; set; }
        public string AdresBasligi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }

        public virtual List<OrderItem> orderItems { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}