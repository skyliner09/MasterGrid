using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
    public class TblDetail
    {
      public int Id { get; set; }
      public int EquipmentID { get; set; }
      public TblMaster EquipmentIDTblMaster { get; set; }
      public DateTime ActivityDate { get; set; }
      public string Activity { get; set; }
      public bool ActivityComplete { get; set; }
      public int CompletedBY { get; set; }
      public DateTime CompletedOn { get; set; }
      public int EnteredBY { get; set; }
      public Customer EnteredBYCustomer { get; set; }
      public DateTime EnteredOn { get; set; }
      public int LastUpdatedBY { get; set; }
      public Customer LastUpdateBYCustomer { get; set; }
      public DateTime LastUpdatedOn { get; set; }
  }
}
