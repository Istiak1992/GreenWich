//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreenWichData.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public Event()
        {
            this.Staffs = new HashSet<Staff>();
            this.Trainers = new HashSet<Trainer>();
            this.Trainings = new HashSet<Training>();
            this.Sessions = new HashSet<Session>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Event_Code { get; set; }
        public Nullable<int> Session_ID { get; set; }
        public Nullable<int> Staff_ID { get; set; }
        public Nullable<int> Trainer_ID { get; set; }
    
        public virtual Staff Staff { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Training> Trainings { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
