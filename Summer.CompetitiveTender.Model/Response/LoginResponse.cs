using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.CompetitiveTender.Model.Response
{
    /// <summary>
    /// LoginResponse
    /// </summary>
    public class LoginResponse
    {
        public string applyName { get; set; }
        public DateTime applyTime { get; set; }
        public string bankAcCount { get; set; }
        public string bankName { get; set; }
        public string bankUnionCode { get; set; }
        public string bankUnionName { get; set; }
        public string bcCode { get; set; }
        public string bcId { get; set; }
        public string bcName { get; set; }
        public long bcrId { get; set; }
        public string bcrName { get; set; }
        public string bctId { get; set; }
        public string bctName { get; set; }
        public string bptCode { get; set; }
        public string bptId { get; set; }
        public string bptName { get; set; }
        public string buAccount { get; set; }
        public int buAge { get; set; }
        public string buAuctioneerNum { get; set; }
        public DateTime buBirthday { get; set; }
        public string buCode { get; set; }
        public string buCompanyCode { get; set; }
        public string buCompanyName { get; set; }
        public string buContactAddress { get; set; }
        public string buEduMajor { get; set; }
        public string buEmail { get; set; }
        public string buExpertCode { get; set; }
        public string buFax { get; set; }
        public string buGraduation { get; set; }
        public string buHealthState { get; set; }
        public string buId { get; set; }
        public string buIdCard { get; set; }
        public string buInWork { get; set; }
        public string buMaxEdu { get; set; }
        public string buName { get; set; }
        public string buNation { get; set; }
        public string buNativePlace { get; set; }
        public string buPassword { get; set; }
        public string buPhone { get; set; }
        public string buPhoto { get; set; }
        public string buPosition { get; set; }
        public string buQq { get; set; }
        public string buRealName { get; set; }
        public string buRegistered { get; set; }
        public int buSex { get; set; }
        public int buSource { get; set; }
        public string buTel { get; set; }
        public string buTrail { get; set; }
        public string buTrailName { get; set; }
        public int buTypeState { get; set; }
        public string buWorkAddr { get; set; }
        public DateTime buWorkBeginTime { get; set; }
        public string buWorkExp { get; set; }
        public string buWorkMajor { get; set; }
        public string buWorkTel { get; set; }
        public int buWorkYears { get; set; }
        public string buZipCode { get; set; }
        public string buZoning { get; set; }
        public long budId { get; set; }
        public DateTime buidCardEndDate { get; set; }
        public long bzId { get; set; }
        public int companyState { get; set; }
        public DateTime currTime { get; set; }
        public int delflag { get; set; }
        public int evalState { get; set; }
        public string hebUserType { get; set; }
        public int isChief { get; set; }
        public string newPassword { get; set; }
        public string optId { get; set; }
        public string optName { get; set; }
        public int sort { get; set; }
        public int state { get; set; }
        public string verifyName { get; set; }
        public int verifyState { get; set; }
        public DateTime verifyTime { get; set; }
        public string verifyView { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
