using System.Collections;
using System.Collections.Generic;
using THETOWN.Models;

namespace THETOWN.ViewModels
{
    public class HomeVM
    {
        public TheTownBackground TheTownBackground { get; set; }
        public Introduction Introduction { get; set; }
        public IEnumerable<Transportation> transportation { get; set; }
        public WorkTitle WorkTitle { get; set; }
        public IEnumerable<WorkSlider> workSliders { get; set; }
        public Contact Contact { get; set; }
    }
}
