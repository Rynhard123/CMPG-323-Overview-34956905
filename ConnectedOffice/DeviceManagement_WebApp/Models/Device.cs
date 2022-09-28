#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;



namespace DeviceManagement_WebApp.Models
{
    public partial class Device
    {
        public Guid DeviceId { get; set; }
        public string DeviceName { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ZoneId { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Category Category { get;  set; }
        public virtual Zone Zone { get;  set; }
    }
}
