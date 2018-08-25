using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public partial class ITenderQuestionDetailForm : FormBase
    {
        public ITenderQuestionDetailForm()
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("招标文件操作id:测试");
            sb.AppendLine("招标文件操作code:测试");
            sb.AppendLine("招标项目id:测试");
            sb.AppendLine("标段（包）id:测试");
            sb.AppendLine("招标文件id:测试");
            sb.AppendLine("解答标题 :测试");
            sb.AppendLine("解答类型:测试");
            sb.AppendLine("解答内容:测试");
            sb.AppendLine("解答人id:测试");
            sb.AppendLine("解答人企业id:测试");
            sb.AppendLine("解答时间:测试");
            sb.AppendLine("解答文件id:测试");
            sb.AppendLine("状态 :测试");
            sb.AppendLine("备注:测试");
            sb.AppendLine("问题提出人id:测试");
            sb.AppendLine("问题提出人企业id:测试");
            sb.AppendLine("问题提出时间:测试");
            sb.AppendLine("批次:测试");
            sb.AppendLine("发布状态:测试");
            sb.AppendLine("发布人id:测试");
            sb.AppendLine("发布企业id:测试");
            sb.AppendLine("发布时间:测试");

            txtDetail.AppendText(sb.ToString());
        }
    }
}
