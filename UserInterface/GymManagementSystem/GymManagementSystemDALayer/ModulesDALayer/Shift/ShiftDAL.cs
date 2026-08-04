using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymManagementSystemDALayer.ModulesDALayer.Shift
{
    public class ShiftDAL
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
