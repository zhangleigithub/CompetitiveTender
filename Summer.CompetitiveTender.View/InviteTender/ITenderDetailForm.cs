using MetroFramework.Forms;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
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
    public partial class ITenderDetailForm : FormBase
    {
        public ITenderDetailForm(gpTenderProjectWebDO gptp)
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("招标项目id:{0}", gptp.gtpId));
            sb.AppendLine(string.Format("招标项目code:{0}", gptp.gtpCode));
            sb.AppendLine(string.Format("项目ID:{0}", gptp.gpId));
            sb.AppendLine(string.Format("项目编号:{0}", gptp.gpCode));
            sb.AppendLine(string.Format("统一交易标识码:{0}", gptp.unifiedDealCode));
            sb.AppendLine(string.Format("招标项目名称:{0}", gptp.gtpName));
            sb.AppendLine(string.Format("招标项目类型ID（树形）:{0}", gptp.tdrPrjTypeId));
            sb.AppendLine(string.Format("招标项目类型代码:{0}", gptp.tdrPrjType));
            sb.AppendLine(string.Format("招标项目类型名称:{0}", gptp.tdrPrjName));
            sb.AppendLine(string.Format("招标项目分类ID（树形）:{0}", gptp.tdrPrjClassifyId));
            sb.AppendLine(string.Format("招标项目分类代码:{0}", gptp.tdrPrjClassifyCode));
            sb.AppendLine(string.Format("招标项目分类名称:{0}", gptp.tdrPrjClassifyName));
            sb.AppendLine(string.Format("招标项目所在行政区域id（行政区域表）:{0}", gptp.regionId));
            sb.AppendLine(string.Format("招标项目所在行政区域代码:{0}", gptp.regionCode));
            sb.AppendLine(string.Format("招标项目所在行政区域名称:{0}", gptp.regionName));
            sb.AppendLine(string.Format("招标代理机构代码类型（暂固定为97，统一社会信用代码）:{0}", gptp.tdrAgencyCodeType));
            sb.AppendLine(string.Format("招标内容与范围及招标方案说明:{0}", gptp.content));
            sb.AppendLine(string.Format("项目业主名称:{0}", gptp.ownerName));
            sb.AppendLine(string.Format("招标人名称:{0}", gptp.tenderName));
            sb.AppendLine(string.Format("招标人类别:{0}", gptp.tenderType));
            sb.AppendLine(string.Format("招标人类别名称:{0}", gptp.tenderTypeName));
            sb.AppendLine(string.Format("招标人代码:{0}", gptp.tenderCode));
            sb.AppendLine(string.Format("招标代理机构名称:{0}", gptp.agentName));
            sb.AppendLine(string.Format("招标代理机构类别:{0}", gptp.agentType));
            sb.AppendLine(string.Format("招标代理机构类别名称:{0}", gptp.agentTypeName));
            sb.AppendLine(string.Format("招标代理机构代码（统一社会信用代码）:{0}", gptp.agentCode));
            sb.AppendLine(string.Format("招标代理机构基本信息版本号（企业信息操作时间）:{0}", gptp.agentVersion));
            sb.AppendLine(string.Format("招标方式:{0}", gptp.tenderWay));
            sb.AppendLine(string.Format("招标方式名称:{0}", gptp.tenderWayName));
            sb.AppendLine(string.Format("招标组织形式:{0}", gptp.tenderOrgWay));
            sb.AppendLine(string.Format("招标项目建立时间:{0}", gptp.creatTime));
            sb.AppendLine(string.Format("监督部门ID:{0}", gptp.superviseId));
            sb.AppendLine(string.Format("监督部门代码类型（暂固定为97，统一社会信用代码）:{0}", gptp.superviseCodeType));
            sb.AppendLine(string.Format("监督部门代码类型名称:{0}", gptp.superviseCodeTypeName));
            sb.AppendLine(string.Format("监督部门代码:{0}", gptp.superviseCode));
            sb.AppendLine(string.Format("监督部门名称:{0}", gptp.superviseName));
            sb.AppendLine(string.Format("审核部门代码类型（暂固定为97，统一社会信用代码）:{0}", gptp.verifyCoCodeType));
            sb.AppendLine(string.Format("审核部门代码:{0}", gptp.verifyCoCode));
            sb.AppendLine(string.Format("审核部门名称:{0}", gptp.verifyCoName));
            sb.AppendLine(string.Format("信息申报责任人姓名（招标项目信息的审核人）:{0}", gptp.infoReporterName));
            sb.AppendLine(string.Format("信息申报责任人代码类型（暂固定为97，统一社会信用代码）:{0}", gptp.infoReporterCodeType));
            sb.AppendLine(string.Format("信息申报责任人代码:{0}", gptp.infoReporterCode));
            sb.AppendLine(string.Format("申报责任人:{0}", gptp.applyName));
            sb.AppendLine(string.Format("状态:{0}", gptp.state));

            txtDetail.AppendText(sb.ToString());
        }
    }
}
