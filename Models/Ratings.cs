﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Miubuy.Models
{
    public class Ratings
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }

        //[Display(Name = "訂單Id")]
        //public int OrderId { get; set; }

        //[ForeignKey("OrderId")]
        //public virtual Order Order { get; set; }

        //[Display(Name = "買方Id")]
        //public int Buyer { get; set; }

        [Display(Name = "買方評價分數")]
        public int BuyerStar { get; set; }

        [Display(Name = "買方評價內容")]
        public string BuyerReviews { get; set; }

        //[Display(Name = "賣方Id")]
        //public int Seller { get; set; }

        [Display(Name = "賣方評價分數")]
        public int SellerStar { get; set; }

        [Display(Name = "賣方評價內容")]
        public string SellerReviews { get; set; }
    }
}