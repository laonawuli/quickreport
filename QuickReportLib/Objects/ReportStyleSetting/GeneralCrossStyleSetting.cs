using System;
using System.Collections.Generic;
using System.Text;
using QuickReportLib.ReportStyles;

namespace QuickReportLib.Objects.ReportStyleSetting
{
    /// <summary>
    /// һ�㽻�汨����ʽ����ʵ�塣
    /// </summary>
    public class GeneralCrossStyleSetting : BaseStyleSetting
    {
        private string row = string.Empty;
        private string column = string.Empty;
        private string value = string.Empty;
        private string rowText = string.Empty;

        /// <summary>
        /// �С�
        /// </summary>
        public string Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        /// <summary>
        /// �С�
        /// </summary>
        public string Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }

        /// <summary>
        /// ֵ��
        /// </summary>
        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        /// <summary>
        /// �����ơ�
        /// </summary>
        public string RowText
        {
            get
            {
                return rowText;
            }
            set
            {
                rowText = value;
            }
        }
    }
}