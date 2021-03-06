using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using FarPoint.Win.Spread;
using QuickReportLib.Enums;
using QuickReportLib.Interfaces.ReportSetting.HeaderSetting;

namespace QuickReportLib.Controls.Plus.ReportColumnPropertyEditor.HAlignment
{
    internal partial class ToolStripButtonHAlignmentCenter : ToolStripButtonHAlignmentBase, IReportColumnSettingToolStripItem
    {
        public ToolStripButtonHAlignmentCenter()
        {
            InitializeComponent();
        }

        protected override CellHorizontalAlignment HorizontalAlignment
        {
            get
            {
                return CellHorizontalAlignment.Center;
            }
        }

        public override int SortID
        {
            get
            {
                return 90;
            }
        }
    }
}
