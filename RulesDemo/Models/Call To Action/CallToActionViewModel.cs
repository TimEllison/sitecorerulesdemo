using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RulesDemo.Models.Call_To_Action.Rendering_Parameters;

namespace RulesDemo.Models.Call_To_Action
{
    public class CallToActionViewModel
    {
        public CallToAction Model { get; set; }

        public CallToActionParameters Parameters { get; set; }
    }
}