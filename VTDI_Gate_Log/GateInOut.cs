//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VTDI_Gate_Log
{
    using System;
    using System.Collections.Generic;
    
    public partial class GateInOut
    {
        public int Id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public int vehicle_id { get; set; }
        public string plateNum { get; set; }
        public int purpose_id { get; set; }
        public Nullable<int> toDeclare_id { get; set; }
        public System.DateTime dateTimeIn { get; set; }
        public System.DateTime dateTimeOut { get; set; }
        public int user_id { get; set; }
    
        public virtual Declare Declare { get; set; }
        public virtual Purpose Purpose { get; set; }
        public virtual User User { get; set; }
        public virtual vehicleType vehicleType { get; set; }
    }
}
