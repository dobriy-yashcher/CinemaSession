//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaSessionWPF.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
