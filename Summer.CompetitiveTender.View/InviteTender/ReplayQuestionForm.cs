using log4net;
using MetroFramework;
using Summer.CompetitiveTender.Model;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTfOperation;
using Summer.CompetitiveTender.Service.ServiceReferenceLogin;
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
    public partial class ReplayQuestionForm : FormBase
    {
        #region 字段

        /// <summary>
        /// log
        /// </summary>
        private static ILog log = LogManager.GetLogger(typeof(ReplayQuestionForm));

        /// <summary>
        /// IGpTfOperationService
        /// </summary>
        private IGpTfOperationService gpTfOperationService = new GpTfOperationService();

        /// <summary>
        /// gtoId
        /// </summary>
        private string gtoId;

        #endregion

        #region 事件

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                baseUserWebDO user = Cache.GetInstance().GetValue<baseUserWebDO>("login");

                gpTfOperationWebDO gptfo = gpTfOperationService.FindById(this.gtoId);

                gptfo.gtoContent = this.txtContent.Text.Trim();
                gptfo.gtoAnswerId = user.auID;
                gptfo.gtoAnswerCoId = user.acId;
                gptfo.gtoAnswerTime = DateTime.Now;

                if (gpTfOperationService.ReplayQuestion(gptfo))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroMessageBox.Show(this, "操作失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MetroMessageBox.Show(this, "操作失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 方法

        public ReplayQuestionForm(IGpTfOperationService gpTfOperationService, string gtoId)
        {
            InitializeComponent();

            this.gpTfOperationService = gpTfOperationService;
            this.gtoId = gtoId;
        }

        #endregion
    }
}
