using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpyStore.Models.ViewModels;

namespace SpyStore.MVC.ViewModels.Base
{
    public class CartViewModelBase : ProductAndCategoryBase
    {
        public int? CustomerId { get; set; }

        [DataType(DataType.Currency), Display(Name = "Total")]
        public decimal LineItemTotal { get; set; }

        public string TimeStampString =>
            TimeStamp != null ? JsonConvert.SerializeObject(TimeStamp).Replace("\"", "") : string.Empty;
    }
}
