using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
    public class TblMaster
    {
      public int Id { get; set; }
      public string EquipmentName { get; set; }
      public string EquipmentLocation { get; set; }
      public DateTime Purchased { get; set; }
      public double PurchasePrice { get; set; }
      public bool Active { get; set; }
      public int EnteredBY { get; set; }
      public Customer EnteredBYCustomer { get; set; }
      public DateTime EnteredOn { get; set; }
      public int LastUpdateBY { get; set; }
      public Customer LastUpdateBYCustomer { get; set; }
      public DateTime LastUpdateOn { get; set; }
      public IEnumerable<TblDetail> EquipmentDetails { get; set; }
  }
}
