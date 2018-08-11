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
    public partial class ITenderDetailForm : MetroForm
    {
        public ITenderDetailForm()
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("招标项目id:测试");
            sb.AppendLine("招标项目code:测试");
            sb.AppendLine("项目ID:测试");
            sb.AppendLine("项目编号:测试");
            sb.AppendLine("统一交易标识码:测试");
            sb.AppendLine("招标项目名称:测试");
            sb.AppendLine("招标项目类型ID（树形）:测试");
            sb.AppendLine("招标项目类型代码:测试");
            sb.AppendLine("招标项目类型名称:测试");
            sb.AppendLine("招标项目分类ID（树形）:测试");
            sb.AppendLine("招标项目分类代码:测试");
            sb.AppendLine("招标项目分类名称:测试");
            sb.AppendLine("招标项目所在行政区域id（行政区域表）:测试");
            sb.AppendLine("招标项目所在行政区域代码:测试");
            sb.AppendLine("招标项目所在行政区域名称:测试");
            sb.AppendLine("招标代理机构代码类型（暂固定为97，统一社会信用代码）:测试");
            sb.AppendLine("招标内容与范围及招标方案说明:测试");
            sb.AppendLine("项目业主名称:测试");
            sb.AppendLine("招标人名称:测试");
            sb.AppendLine("招标人类别:测试");
            sb.AppendLine("招标人类别名称:测试");
            sb.AppendLine("招标人代码:测试");
            sb.AppendLine("招标代理机构名称:测试");
            sb.AppendLine("招标代理机构类别:测试");
            sb.AppendLine("招标代理机构类别名称:测试");
            sb.AppendLine("招标代理机构代码（统一社会信用代码）:测试");
            sb.AppendLine("招标代理机构基本信息版本号（企业信息操作时间）:测试");
            sb.AppendLine("招标方式:测试");
            sb.AppendLine("招标方式名称:测试");
            sb.AppendLine("招标组织形式:测试");
            sb.AppendLine("招标项目建立时间:测试");
            sb.AppendLine("监督部门ID:测试");
            sb.AppendLine("监督部门代码类型（暂固定为97，统一社会信用代码）:测试");
            sb.AppendLine("监督部门代码类型名称:测试");
            sb.AppendLine("监督部门代码:测试");
            sb.AppendLine("监督部门名称:测试");
            sb.AppendLine("审核部门代码类型（暂固定为97，统一社会信用代码）:测试");
            sb.AppendLine("审核部门代码:测试");
            sb.AppendLine("审核部门名称:测试");
            sb.AppendLine("信息申报责任人姓名（招标项目信息的审核人）:测试");
            sb.AppendLine("信息申报责任人代码类型（暂固定为97，统一社会信用代码）:测试");
            sb.AppendLine("信息申报责任人代码:测试");
            sb.AppendLine("申报责任人:测试");
            sb.AppendLine("状态:测试");

            txtDetail.AppendText(sb.ToString());
        }
    }
}
