using Microsoft.Dynamics.Framework.UI.Extensibility;

namespace Charts.BarChart
{
    [ControlAddInExport("BarChart")]
    public interface IBarChart
    {
        [ApplicationVisible]
        event ApplicationEventHandler ControlAddInReady;
    }
}
