# Enterprise Infrastructure Monitoring System

## About This Project

Built a **production-grade, self-healing infrastructure monitoring system** that monitors 20+ critical Windows servers across multiple AWS accounts with zero manual intervention.
 
## Key Highlights

- **Zero-Touch Updates:** Automated 3-tier update pipeline deploys to 20+ servers in 2-3 hours
- **Real-Time Alerting:** Sub-30 second alert latency from detection to notification
- **Self-Healing:** Auto-restart failed processes, auto-expand storage, auto-scale databases
- **Complete Visibility:** CPU, RAM, disk, processes, patches tracked 24/7/365
- **Scalable Architecture:** Master-Relay-Monitor design scales across AWS accounts

## Tech Stack

- **Backend:** C# .NET 6.0, Windows Services
- **Infrastructure:** AWS (EC2, RDS, VPC), On-Premises hybrid
- **Automation:** Windows Task Scheduler, PowerShell scripting
- **Monitoring:** Custom agent with 40-second polling intervals
- **Alerting:** SMTP integration, HTML email templates
- **Reporting:** Automated Excel generation, daily/monthly summaries

## Architecture
Master Server (Central Control)
↓
Relay Servers (AWS Account Aggregation)
↓
Monitor Services (Edge - 20+ Servers)


## Impact & Metrics

-  **40-60% reduction** in unplanned downtime
-  **70% auto-remediation** rate (issues fixed without human intervention)
-  **100% prevention** of storage-related outages
-  **<30 seconds** average alert response time
-  **99%+ uptime** across monitored infrastructure

## Key Features

**Real-Time Monitoring:**
- CPU (40s), RAM (50s), Disk (2x daily), Process (60s), Heartbeat (20s)

**Intelligent Automation:**
- Auto-restart failed processes
- Auto-expand RDS storage (daily 6:30 AM)
- Auto-deploy updates via scheduled tasks
- Alert suppression to prevent fatigue

**Compliance & Audit:**
- Complete audit trail with 90-day log retention
- Weekly patch compliance tracking
- Daily/monthly automated reports
- RBI audit-ready documentation

**Self-Updating System:**
- UAC bypass using NT AUTHORITY\SYSTEM
- Protected configuration (never overwritten)
- Staged rollout (Master → Relay → Monitor)
- Automatic rollback capability

## Technical Challenges Solved

1. **UAC Bypass for Automation:** Scheduled tasks with SYSTEM privileges
2. **Configuration Preservation:** File exclusion during updates
3. **Network Efficiency:** Relay-level caching reduces bandwidth 20x
4. **Multi-Account Isolation:** VPC peering with security boundaries
5. **Zero-Downtime Updates:** Staggered deployment over 2-3 hours

##  What Makes It Special

- **Production Battle-Tested:** Running in banking environment with strict compliance
- **Fully Automated:** From deployment to updates to remediation
- **Scalable Design:** Proven for 20+ servers, designed for 100+
- **Minimal Overhead:** <5% CPU, ~150MB RAM per server
- **Enterprise Features:** Multi-account, hybrid cloud, self-healing

## Skills Demonstrated

`C#` `.NET 6` `Windows Services` `AWS` `EC2` `RDS` `VPC` `PowerShell` `Automation` `System Architecture` `Distributed Systems` `DevOps` `Monitoring` `Alerting` `High Availability` `Disaster Recovery` `Security` `Compliance`

---

*Building reliable, self-healing infrastructure at scale* 
