using MetroFramework.Forms;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTfOperation;
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
        public ITenderQuestionDetailForm(gpTfOperationWebDO gptfo)
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("招标文件操作id:{0}", gptfo.gtoId));
            sb.AppendLine(string.Format("招标文件操作code:{0}", gptfo.gtoCode));
            sb.AppendLine(string.Format("招标项目id:{0}", gptfo.gtpId));
            sb.AppendLine(string.Format("标段（包）id:{0}", gptfo.gsId));
            sb.AppendLine(string.Format("招标文件id:{0}", gptfo.gtfId));
            sb.AppendLine(string.Format("解答标题 :{0}", gptfo.gtoTitle));
            sb.AppendLine(string.Format("解答类型:{0}", gptfo.gtoType));
            sb.AppendLine(string.Format("解答内容:{0}", gptfo.gtoContent));
            sb.AppendLine(string.Format("解答人id:{0}", gptfo.gtoAnswerId));
            sb.AppendLine(string.Format("解答人企业id:{0}", gptfo.gtoAnswerCoId));
            sb.AppendLine(string.Format("解答时间:{0}", gptfo.gtoAnswerTime));
            sb.AppendLine(string.Format("解答文件id:{0}", gptfo.gtoAnswerFileId));
            sb.AppendLine(string.Format("状态 :{0}", gptfo.state));
            sb.AppendLine(string.Format("备注:{0}", gptfo.remark));
            sb.AppendLine(string.Format("问题提出人id:{0}", gptfo.optId));
            sb.AppendLine(string.Format("问题提出人企业id:{0}", gptfo.optCoId));
            sb.AppendLine(string.Format("问题提出时间:{0}", gptfo.optTime));
            sb.AppendLine(string.Format("批次:{0}", gptfo.gtoBatch));
            sb.AppendLine(string.Format("发布状态:{0}", gptfo.sendState));
            sb.AppendLine(string.Format("发布人id:{0}", gptfo.sendId));
            sb.AppendLine(string.Format("发布企业id:{0}", gptfo.sendCoId));
            sb.AppendLine(string.Format("发布时间:{0}", gptfo.sendTime));

            txtDetail.AppendText(sb.ToString());
        }
    }
}
