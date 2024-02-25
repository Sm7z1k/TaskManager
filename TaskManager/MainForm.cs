using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            
            InitializeComponent();
            Processes.CreateProcessList();
            ProcessGridView.DataSource = Globals.ProTable;
            Processes.RefreshProcessList();
            Processes.UpdateProcessList();
            ProcessGridView.Update();                     
        }

        public static class Globals
        {
            public static string Name { get; set; } = "";
            public static int LoadPercentage { get; set; } = 0;
            public static int CurrentClockSpeed { get; set; } = 0;
            public static int MaxClockSpeed { get; set; } = 0;
            public static int NumberOfCores { get; set; } = 0;
            public static int NumberOfLogicalProcessors { get; set; } = 0;
            public static int L2CacheSize { get; set; } = 0;
            public static int FreePhysicalMemory { get; set; } = 0;
            public static int TotalVisibleMemorySize { get; set; } = 0;
            public static int TotalVirtualMemorySize { get; set; } = 0;
            public static int FreeVirtualMemory { get; set; } = 0;
            public static int NumberOfProcessors { get; set; } = 0;
            public static int ProID { get; set; } = 0;
            public static Series CPUseriesArea { get; set; } = new Series("CPUArea");
            public static Series CPUseriesLine { get; set; } = new Series("CPULine");
            public static Series RAMseriesLine { get; set; } = new Series("RAMLine");
            public static Series RAMseriesArea { get; set; } = new Series("RAMArea");
            public static DataTable ProTable { get; set; } = new DataTable();
            public static DataTable SerTable { get; set; } = new DataTable();
            public static Bitmap Icon { get; set; } = new Bitmap(1, 1);
            public static int[] CPU { get; set; } = Enumerable.Repeat(0, 60).ToArray();
            public static int[] RAM { get; set; } = Enumerable.Repeat(0, 60).ToArray();            
        }
    }
}

