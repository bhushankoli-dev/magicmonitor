using System;
using System.ServiceProcess;
using System.Threading;

namespace MagicMonitor
{
    /// <summary>
    /// Core monitoring service that runs on each server.
    /// Monitors CPU, RAM, Disk, Processes and sends
    /// alerts via relay to master server.
    /// </summary>
    public class MonitorService : ServiceBase
    {
        private Timer _monitorTimer;
        private readonly int _cpuCheckInterval = 40000;    // 40 seconds
        private readonly int _ramCheckInterval = 50000;    // 50 seconds
        private readonly int _heartbeatInterval = 20000;   // 20 seconds
        private readonly int _processCheckInterval = 60000; // 60 seconds

        public MonitorService()
        {
            ServiceName = "MagicMonitorService";
        }

        protected override void OnStart(string[] args)
        {
            // Start all monitoring threads
            StartCPUMonitor();
            StartRAMMonitor();
            StartDiskMonitor();
            StartProcessMonitor();
            StartHeartbeat();
            StartUpdateClient();
        }

        protected override void OnStop()
        {
            _monitorTimer?.Dispose();
        }

        private void StartCPUMonitor()
        {
            // CPU monitoring every 40 seconds
            // Alerts at 80% threshold
            // Implementation in production code
        }

        private void StartRAMMonitor()
        {
            // RAM monitoring every 50 seconds
            // Alerts at 85% threshold
            // Implementation in production code
        }

        private void StartDiskMonitor()
        {
            // Disk monitoring twice daily
            // Critical alert at <5GB free
            // Warning alert at <10GB free
            // Implementation in production code
        }

        private void StartProcessMonitor()
        {
            // Process health check every 60 seconds
            // Auto-restart if critical process stops
            // Checks DoNotStart.flag for manual override
            // Implementation in production code
        }

        private void StartHeartbeat()
        {
            // Heartbeat every 20 seconds
            // Confirms server is operational
            // Implementation in production code
        }

        private void StartUpdateClient()
        {
            // Checks for updates every hour
            // Downloads and installs automatically
            // Implementation in production code
        }
    }
}
