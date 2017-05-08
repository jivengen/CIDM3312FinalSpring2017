using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Q400Calculator.Models
{
    public class ClimbData
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        [Display (Name = "V FRI Flaps 5")]
        public int Vfri5 { get; set; }
        [Display(Name = "V FRI Flaps 10")]
        public int Vfri10 { get; set; }
        [Display(Name = "V FRI Flaps 15")]
        public int Vfri15 { get; set; }
        [Display(Name = "V Climb")]
        public int Vclmb { get; set; }
        public int Temperature { get; set; }


    }

    //udner 20 degrees
    public class flaps518ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }

    }

    public class flaps520ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps522ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps524ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps526ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps528ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps529ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }

    public class flaps1018ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1020ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1022ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1024ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1026ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1028ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1029ColdData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }



    //Over 20 degress

    public class flaps518HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps520HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps522HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps524HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps526HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps528HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps529HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }

    public class flaps1018HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1020HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1022HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1024HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1026HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1028HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
    public class flaps1029HotData
    {
        public int Altitude { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
    }
}
