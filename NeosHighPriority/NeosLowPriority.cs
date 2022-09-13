using NeosModLoader;
using System.Diagnostics;

namespace NeosLowPriority
{
    public class NeosLowPriority : NeosMod
    {
        public override string Name => "NeosLowPriority";
        public override string Author => "runtime & cookie";
        public override string Version => "1.0.1";
        public override string Link => "https://github.com/Toxic-Cookie/NeosLowPriority";

        public override void OnEngineInit()
        {
            using (Process p = Process.GetCurrentProcess())
            {
                var oldPriority = p.PriorityClass;
                p.PriorityClass = ProcessPriorityClass.Idle;
                Msg($"Changed process priority from {oldPriority} to {p.PriorityClass}");
            }
        }
    }
}
