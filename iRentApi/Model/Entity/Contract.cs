﻿using iRentApi.Model.Entity.Contract;
using System.ComponentModel.DataAnnotations.Schema;

namespace iRentApi.Model.Entity
{
    [Table("Contract")]
    public class ContractModel : EntityBase 
    {
        public long RentedWarehouseId { get; set; }
        public RentedWarehouseInfo RentedWarehouse { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Base64 { get; set; }
        public bool Actived { get; set; }
    }
}
