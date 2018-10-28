using Summer.Common.Utility;
using Summer.CompetitiveTender.Service;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplate;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTemplateNode;
using Summer.CompetitiveTender.Service.ServiceReferenceGpTenderProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Xceed.Words.NET;

namespace Summer.CompetitiveTender.View.InviteTender
{
    public class GenerateDocument
    {
        public string GenerateBidTemplateDocument(gpTemplateWebDO gpt)
        {
            string path = string.Format("{0}\\{1}.docx", AppDirectory.Temp(), gpt.gtName);

            IGpTemplateNodeService gpTemplateNodeService = new GpTemplateNodeService();

            gpTemplateNodeWebDO[] gptns = gpTemplateNodeService.FindListByGtId(gpt.gtId);

            using (DocX document = DocX.Create(path))
            {
                //标题
                document.InsertParagraph("招标模板").FontSize(18d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                //段落
                this.GenerateDocumentContent(gptns, document, 0, 1);

                document.Save();
            }

            return path;
        }

        public string GenerateBidDocument(gpTenderProjectWebDO gptp, gpTemplateWebDO gpt)
        {
            string path = Path.Combine(AppDirectory.Temp_Dir(gptp.gpId), "招标文件.docx");

            IGpTemplateNodeService gpTemplateNodeService = new GpTemplateNodeService();

            gpTemplateNodeWebDO[] gptns = gpTemplateNodeService.FindListByGtId(gpt.gtId);

            using (DocX document = DocX.Create(path))
            {
                //标题
                document.InsertParagraph("《招标文件》").FontSize(18d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                //项目名称
                document.InsertParagraph(string.Format("项目名称：{0}", gptp.gtpName)).FontSize(15d).Bold().SpacingAfter(30d).Alignment = Alignment.left;

                //标段名称
                document.InsertParagraph(string.Format("标段名称：{0}", gptp.gsName)).FontSize(15d).Bold().SpacingAfter(30d).Alignment = Alignment.left;

                //段落
                this.GenerateDocumentContent(gptns, document, 0, 1);

                document.Save();
            }

            return path;
        }

        public string GenerateBidEvalClauseDocument(gpTenderProjectWebDO gptp)
        {
            string path = Path.Combine(AppDirectory.Temp_Dir(gptp.gpId), "评标条款.docx");

            IGpEvalwayItemGtfService gpEvalwayItemGtfService = new GpEvalwayItemGtfService();

            var result = gpEvalwayItemGtfService.FindListByGsIdAndGewigName(gptp.gpId, string.Empty);

            using (DocX document = DocX.Create(path))
            {
                //标题
                document.InsertParagraph("《评分条款》").FontSize(18d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                var t = document.AddTable(result.Count() + 1, 11);
                t.Design = TableDesign.ColorfulList;
                t.Alignment = Alignment.center;

                //标题
                t.Rows[0].Cells[0].Paragraphs[0].Append("编码");
                t.Rows[0].Cells[1].Paragraphs[0].Append("名称");
                t.Rows[0].Cells[2].Paragraphs[0].Append("类型");
                t.Rows[0].Cells[3].Paragraphs[0].Append("最高分");
                t.Rows[0].Cells[4].Paragraphs[0].Append("最低分");
                t.Rows[0].Cells[5].Paragraphs[0].Append("是否需要设置值1");
                t.Rows[0].Cells[6].Paragraphs[0].Append("设置值1的说明");
                t.Rows[0].Cells[7].Paragraphs[0].Append("是否需要设置值2");
                t.Rows[0].Cells[8].Paragraphs[0].Append("设置值2的说明");
                t.Rows[0].Cells[9].Paragraphs[0].Append("算法名称");
                t.Rows[0].Cells[10].Paragraphs[0].Append("备注");

                int indexer = 1;

                foreach (var item in result.OrderBy(x => x.sort))
                {
                    t.Rows[indexer].Cells[0].Paragraphs[0].Append(item.gewigCode);
                    t.Rows[indexer].Cells[1].Paragraphs[0].Append(item.gewigName);
                    t.Rows[indexer].Cells[2].Paragraphs[0].Append(item.gewigType.ToString());
                    t.Rows[indexer].Cells[3].Paragraphs[0].Append(item.maxScore.ToString());
                    t.Rows[indexer].Cells[4].Paragraphs[0].Append(item.minScore.ToString());
                    t.Rows[indexer].Cells[5].Paragraphs[0].Append(item.isNeedFirstPara == 0 ? "不需要" : "需要");
                    t.Rows[indexer].Cells[6].Paragraphs[0].Append(item.firstParaDesc);
                    t.Rows[indexer].Cells[7].Paragraphs[0].Append(item.isNeedSecondPara == 0 ? "不需要" : "需要");
                    t.Rows[indexer].Cells[8].Paragraphs[0].Append(item.secondParaDesc);
                    t.Rows[indexer].Cells[9].Paragraphs[0].Append(item.algoName);
                    t.Rows[indexer].Cells[10].Paragraphs[0].Append(item.remark);

                    indexer++;
                }

                // Insert a new Paragraph into the document.
                var p = document.InsertParagraph("评分条款:");
                p.SpacingAfter(10d);

                // Insert the Table after the Paragraph.
                p.InsertTableAfterSelf(t);

                document.Save();
            }

            return path;
        }

        public string GenerateBidEvalScoringPointDocument(gpTenderProjectWebDO gptp)
        {
            string path = Path.Combine(AppDirectory.Temp_Dir(gptp.gpId), "评分点.docx");

            IGpTenderEvalEleService gpTenderEvalEleService = new GpTenderEvalEleService();

            var result = gpTenderEvalEleService.FindListByGsIdAndGteeName(gptp.gpId, string.Empty);

            using (DocX document = DocX.Create(path))
            {
                //标题
                document.InsertParagraph("《评分点》").FontSize(18d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                var t = document.AddTable(result.Count() + 1, 11);
                t.Design = TableDesign.ColorfulList;
                t.Alignment = Alignment.center;

                //标题
                t.Rows[0].Cells[0].Paragraphs[0].Append("评标因素名称");
                t.Rows[0].Cells[1].Paragraphs[0].Append("评标因素单位");
                t.Rows[0].Cells[2].Paragraphs[0].Append("评标因素数值");
                t.Rows[0].Cells[3].Paragraphs[0].Append("评标因素数值梯度");
                t.Rows[0].Cells[4].Paragraphs[0].Append("基准分数最大值");
                t.Rows[0].Cells[5].Paragraphs[0].Append("基准分数最小值");
                t.Rows[0].Cells[6].Paragraphs[0].Append("基准");
                t.Rows[0].Cells[7].Paragraphs[0].Append("大于基准算法");
                t.Rows[0].Cells[8].Paragraphs[0].Append("大于基准梯度值");
                t.Rows[0].Cells[9].Paragraphs[0].Append("小于基准算法");
                t.Rows[0].Cells[10].Paragraphs[0].Append("小于基准梯度值");

                int indexer = 1;

                foreach (var item in result)
                {
                    t.Rows[indexer].Cells[0].Paragraphs[0].Append(item.gteeName);
                    t.Rows[indexer].Cells[1].Paragraphs[0].Append(item.evalUnit);
                    t.Rows[indexer].Cells[2].Paragraphs[0].Append(item.evalNum.ToString());
                    t.Rows[indexer].Cells[3].Paragraphs[0].Append(item.evalGrads.ToString());
                    t.Rows[indexer].Cells[4].Paragraphs[0].Append(item.maxScore.ToString());
                    t.Rows[indexer].Cells[5].Paragraphs[0].Append(item.minScore.ToString());
                    t.Rows[indexer].Cells[6].Paragraphs[0].Append(item.standard.ToString());
                    t.Rows[indexer].Cells[7].Paragraphs[0].Append(item.greatWay.ToString());
                    t.Rows[indexer].Cells[8].Paragraphs[0].Append(item.greatNum.ToString());
                    t.Rows[indexer].Cells[9].Paragraphs[0].Append(item.littleWay.ToString());
                    t.Rows[indexer].Cells[10].Paragraphs[0].Append(item.littleNum.ToString());

                    indexer++;
                }

                // Insert a new Paragraph into the document.
                var p = document.InsertParagraph("评分点:");
                p.SpacingAfter(10d);

                // Insert the Table after the Paragraph.
                p.InsertTableAfterSelf(t);

                document.Save();
            }

            return path;
        }

        public string GenerateBidEvalFactorDocument(gpTenderProjectWebDO gptp)
        {
            string path = Path.Combine(AppDirectory.Temp_Dir(gptp.gpId), "评分因素.docx");

            IGpBidFileOrgService gpBidFileOrgService = new GpBidFileOrgService();

            var result = gpBidFileOrgService.FindListByProjectIdAndSectionId(gptp.gtpId, gptp.gpId);

            using (DocX document = DocX.Create(path))
            {
                //标题
                document.InsertParagraph("《评分因素》").FontSize(18d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                var t = document.AddTable(result.Count() + 1, 2);
                t.Design = TableDesign.ColorfulList;
                t.Alignment = Alignment.center;

                //标题
                t.Rows[0].Cells[0].Paragraphs[0].Append("名称");
                t.Rows[0].Cells[1].Paragraphs[0].Append("是否必须");

                int indexer = 1;

                foreach (var item in result.OrderBy(x => x.sort))
                {
                    t.Rows[indexer].Cells[0].Paragraphs[0].Append(item.bbfoName);
                    t.Rows[indexer].Cells[1].Paragraphs[0].Append(item.isMust == 0 ? "否" : "是");

                    indexer++;
                }

                // Insert a new Paragraph into the document.
                var p = document.InsertParagraph("评分因素:");
                p.SpacingAfter(10d);

                // Insert the Table after the Paragraph.
                p.InsertTableAfterSelf(t);

                document.Save();
            }

            return path;
        }

        public string GenerateBidQuestionDocument(gpTenderProjectWebDO gptp)
        {
            string path = Path.Combine(AppDirectory.Temp_Dir(gptp.gpId), "问题澄清.docx");

            IGpTfOperationService gpTfOperationService = new GpTfOperationService();

            //澄清
            var result1 = gpTfOperationService.FindQuestions(gptp.gtpId, gptp.gpId, string.Empty, 1);

            //修改
            var result2 = gpTfOperationService.FindQuestions(gptp.gtpId, gptp.gpId, string.Empty, 2);

            if (result1.Count() == 0 && result2.Count() == 0)
            {
                return string.Empty;
            }

            using (DocX document = DocX.Create(path))
            {
                //标题
                document.InsertParagraph("《问题澄清》").FontSize(18d).Bold().SpacingAfter(50d).Alignment = Alignment.center;

                //澄清
                var t1 = document.AddTable(result1.Count() + 1, 3);
                t1.Design = TableDesign.ColorfulList;
                t1.Alignment = Alignment.center;

                //标题
                t1.Rows[0].Cells[0].Paragraphs[0].Append("标题");
                t1.Rows[0].Cells[1].Paragraphs[0].Append("内容");
                t1.Rows[0].Cells[2].Paragraphs[0].Append("创建时间");

                int indexer = 1;

                foreach (var item in result1)
                {
                    t1.Rows[indexer].Cells[0].Paragraphs[0].Append(item.gtoTitle);
                    t1.Rows[indexer].Cells[1].Paragraphs[0].Append(item.gtoContent);
                    t1.Rows[indexer].Cells[2].Paragraphs[0].Append(item.optTime.ToLongDateString());

                    indexer++;
                }

                //修改
                var t2 = document.AddTable(result2.Count() + 1, 3);
                t2.Design = TableDesign.ColorfulList;
                t2.Alignment = Alignment.center;

                //标题
                t2.Rows[0].Cells[0].Paragraphs[0].Append("标题");
                t2.Rows[0].Cells[1].Paragraphs[0].Append("内容");
                t2.Rows[0].Cells[2].Paragraphs[0].Append("创建时间");

                indexer = 1;

                foreach (var item in result2)
                {
                    t2.Rows[indexer].Cells[0].Paragraphs[0].Append(item.gtoTitle);
                    t2.Rows[indexer].Cells[1].Paragraphs[0].Append(item.gtoContent);
                    t2.Rows[indexer].Cells[2].Paragraphs[0].Append(item.optTime.ToLongDateString());

                    indexer++;
                }

                // Insert a new Paragraph into the document.
                var p1 = document.InsertParagraph("澄清:");
                p1.SpacingAfter(10d);

                // Insert the Table after the Paragraph.
                p1.InsertTableAfterSelf(t1);

                // Insert a new Paragraph into the document.
                var p2 = document.InsertParagraph("修改:");
                p2.SpacingAfter(10d);

                // Insert the Table after the Paragraph.
                p2.InsertTableAfterSelf(t2);

                document.Save();
            }

            return path;
        }

        private void GenerateDocumentContent(gpTemplateNodeWebDO[] gptns, DocX document, long parentId, int level)
        {
            foreach (var item in gptns.Where(x => x.gtnPid == parentId).OrderBy(x => x.sort))
            {
                //段落
                var p = document.InsertParagraph();

                p.Append(item.gtnName)
                .Font(new Xceed.Words.NET.Font("Arial"))
                .FontSize(25 / (level + (level - 1) * 0.1))
                .Color(Color.Black)
                .Bold()
                .KeepWithNextParagraph();

                if (level == 1)
                {
                    p.Heading(HeadingType.Heading1);
                    document.InsertSection();
                }
                else if (level == 2)
                {
                    p.Heading(HeadingType.Heading2);
                }
                else if (level == 3)
                {
                    p.Heading(HeadingType.Heading3);
                }

                this.GenerateDocumentContent(gptns, document, item.gtnId, level + 1);
            }
        }
    }
}
