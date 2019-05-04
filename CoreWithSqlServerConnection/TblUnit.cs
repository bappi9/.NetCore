using System;
using System.Collections.Generic;

namespace CoreWithSqlServerConnection
{
    public partial class TblUnit
    {
        public int IntUnitId { get; set; }
        public string StrUnit { get; set; }
        public string StrDescription { get; set; }
        public bool YsnEnable { get; set; }
        public int? IntLastActionBy { get; set; }
        public DateTime? DteLastActionTime { get; set; }
        public bool? YsnPfunit { get; set; }
        public string StrVatregNo { get; set; }
        public string StrTin { get; set; }
        public string StrIrc { get; set; }
        public string StrBusinessArea { get; set; }
        public int? IntParentUnit { get; set; }
        public string StrAccEmailAddress { get; set; }
        public string IntIrcrenewYear { get; set; }
        public string StrPhone { get; set; }
        public string StrFax { get; set; }
        public int? IntOwnershipType { get; set; }
        public int? IntBankAccId { get; set; }
        public bool? YsnVatExemption { get; set; }
        public string StrLoginUser { get; set; }
    }
}
