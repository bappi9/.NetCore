using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreWithSqlServerConnection
{
    public partial class ERP_HRContext : DbContext
    {
        public ERP_HRContext()
        {
        }

        public ERP_HRContext(DbContextOptions<ERP_HRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<TableGeneral> TableGeneral { get; set; }
        public virtual DbSet<TableWages> TableWages { get; set; }
        public virtual DbSet<TblAefpsamount> TblAefpsamount { get; set; }
        public virtual DbSet<TblAfblremoteAttendancePermission> TblAfblremoteAttendancePermission { get; set; }
        public virtual DbSet<TblAgemployeeprogress> TblAgemployeeprogress { get; set; }
        public virtual DbSet<TblAjmlAttendance> TblAjmlAttendance { get; set; }
        public virtual DbSet<TblAjmlDropDown> TblAjmlDropDown { get; set; }
        public virtual DbSet<TblAjmlOvertime> TblAjmlOvertime { get; set; }
        public virtual DbSet<TblAjmlPairmachine> TblAjmlPairmachine { get; set; }
        public virtual DbSet<TblAjmlPairmachineRate> TblAjmlPairmachineRate { get; set; }
        public virtual DbSet<TblAjmlPayrollGrade> TblAjmlPayrollGrade { get; set; }
        public virtual DbSet<TblAjmlPayrollprocess> TblAjmlPayrollprocess { get; set; }
        public virtual DbSet<TblAjmlPunishment> TblAjmlPunishment { get; set; }
        public virtual DbSet<TblAjmlTrialCard> TblAjmlTrialCard { get; set; }
        public virtual DbSet<TblAllowance> TblAllowance { get; set; }
        public virtual DbSet<TblAllowanceDetails> TblAllowanceDetails { get; set; }
        public virtual DbSet<TblAllowanceType> TblAllowanceType { get; set; }
        public virtual DbSet<TblApplicationType> TblApplicationType { get; set; }
        public virtual DbSet<TblAppsTask> TblAppsTask { get; set; }
        public virtual DbSet<TblAppsTaskDetalis> TblAppsTaskDetalis { get; set; }
        public virtual DbSet<TblAttendanceDailySummary> TblAttendanceDailySummary { get; set; }
        public virtual DbSet<TblAttendanceProcessed> TblAttendanceProcessed { get; set; }
        public virtual DbSet<TblAttendancePunishment> TblAttendancePunishment { get; set; }
        public virtual DbSet<TblAttendanceRemoteConfig> TblAttendanceRemoteConfig { get; set; }
        public virtual DbSet<TblAttendanceUnprocessed> TblAttendanceUnprocessed { get; set; }
        public virtual DbSet<TblAuditExcellReport> TblAuditExcellReport { get; set; }
        public virtual DbSet<TblBenifitBonus> TblBenifitBonus { get; set; }
        public virtual DbSet<TblBenifitBonus1> TblBenifitBonus1 { get; set; }
        public virtual DbSet<TblBenifitBonusGenerationHistory> TblBenifitBonusGenerationHistory { get; set; }
        public virtual DbSet<TblBenifitBonusSetup> TblBenifitBonusSetup { get; set; }
        public virtual DbSet<TblBenifitEntry> TblBenifitEntry { get; set; }
        public virtual DbSet<TblBreak> TblBreak { get; set; }
        public virtual DbSet<TblBreakExtra> TblBreakExtra { get; set; }
        public virtual DbSet<TblBreakLateCount> TblBreakLateCount { get; set; }
        public virtual DbSet<TblBreakMoneytaryPunishment> TblBreakMoneytaryPunishment { get; set; }
        public virtual DbSet<TblCafeteria> TblCafeteria { get; set; }
        public virtual DbSet<TblCafeteriaDetails> TblCafeteriaDetails { get; set; }
        public virtual DbSet<TblCafeteriaRate> TblCafeteriaRate { get; set; }
        public virtual DbSet<TblCasualSalary> TblCasualSalary { get; set; }
        public virtual DbSet<TblCasualSalaryForDti> TblCasualSalaryForDti { get; set; }
        public virtual DbSet<TblConfidential> TblConfidential { get; set; }
        public virtual DbSet<TblCourier> TblCourier { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblDocDispatch> TblDocDispatch { get; set; }
        public virtual DbSet<TblDocName> TblDocName { get; set; }
        public virtual DbSet<TblDutyCatagory> TblDutyCatagory { get; set; }
        public virtual DbSet<TblEmpElinfo> TblEmpElinfo { get; set; }
        public virtual DbSet<TblEmpOverTime> TblEmpOverTime { get; set; }
        public virtual DbSet<TblEmpPlel> TblEmpPlel { get; set; }
        public virtual DbSet<TblEmpTada> TblEmpTada { get; set; }
        public virtual DbSet<TblEmpTransferPromotion> TblEmpTransferPromotion { get; set; }
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }
        public virtual DbSet<TblEmployeeAttendance> TblEmployeeAttendance { get; set; }
        public virtual DbSet<TblEmployeeAttendanceFloor> TblEmployeeAttendanceFloor { get; set; }
        public virtual DbSet<TblEmployeeAttendanceRemoteConfig> TblEmployeeAttendanceRemoteConfig { get; set; }
        public virtual DbSet<TblEmployeeElinformation> TblEmployeeElinformation { get; set; }
        public virtual DbSet<TblEmployeeGroup> TblEmployeeGroup { get; set; }
        public virtual DbSet<TblEmployeeGroupPermissionAttendance> TblEmployeeGroupPermissionAttendance { get; set; }
        public virtual DbSet<TblEmployeeGroupPermissionBreak> TblEmployeeGroupPermissionBreak { get; set; }
        public virtual DbSet<TblEmployeeGroupPermissionHolidays> TblEmployeeGroupPermissionHolidays { get; set; }
        public virtual DbSet<TblEmployeeGroupPermissionLeave> TblEmployeeGroupPermissionLeave { get; set; }
        public virtual DbSet<TblEmployeeGroupPermissionSalary> TblEmployeeGroupPermissionSalary { get; set; }
        public virtual DbSet<TblEmployeeHolidays> TblEmployeeHolidays { get; set; }
        public virtual DbSet<TblEmployeeInfoDetail> TblEmployeeInfoDetail { get; set; }
        public virtual DbSet<TblEmployeeJobStation> TblEmployeeJobStation { get; set; }
        public virtual DbSet<TblEmployeeJobStationReg> TblEmployeeJobStationReg { get; set; }
        public virtual DbSet<TblEmployeeOffDay> TblEmployeeOffDay { get; set; }
        public virtual DbSet<TblEmployeeOfficeHour> TblEmployeeOfficeHour { get; set; }
        public virtual DbSet<TblEmployeeOfficeHourChange> TblEmployeeOfficeHourChange { get; set; }
        public virtual DbSet<TblEmployeeOvertime> TblEmployeeOvertime { get; set; }
        public virtual DbSet<TblEmployeeOvertimePayment> TblEmployeeOvertimePayment { get; set; }
        public virtual DbSet<TblEmployeePerformBehavior> TblEmployeePerformBehavior { get; set; }
        public virtual DbSet<TblEmployeePerformJobDes> TblEmployeePerformJobDes { get; set; }
        public virtual DbSet<TblEmployeePerformJobDesMarks> TblEmployeePerformJobDesMarks { get; set; }
        public virtual DbSet<TblEmployeePerformanceGrades> TblEmployeePerformanceGrades { get; set; }
        public virtual DbSet<TblEmployeePerformanceGrading> TblEmployeePerformanceGrading { get; set; }
        public virtual DbSet<TblEmployeePerformanceGradingDetalis> TblEmployeePerformanceGradingDetalis { get; set; }
        public virtual DbSet<TblEmployeePerformanceGradingType> TblEmployeePerformanceGradingType { get; set; }
        public virtual DbSet<TblEmployeeProfileEmpOfficialInfoGroup> TblEmployeeProfileEmpOfficialInfoGroup { get; set; }
        public virtual DbSet<TblEmployeeProfileTransferPromotion> TblEmployeeProfileTransferPromotion { get; set; }
        public virtual DbSet<TblEmployeePunishment> TblEmployeePunishment { get; set; }
        public virtual DbSet<TblEmployeeReward> TblEmployeeReward { get; set; }
        public virtual DbSet<TblEmployeeSalary> TblEmployeeSalary { get; set; }
        public virtual DbSet<TblEmployeeSwap> TblEmployeeSwap { get; set; }
        public virtual DbSet<TblEmployeeTeamBuild> TblEmployeeTeamBuild { get; set; }
        public virtual DbSet<TblEmployeeTeamShift> TblEmployeeTeamShift { get; set; }
        public virtual DbSet<TblEmployeeTeamShiftAssigned> TblEmployeeTeamShiftAssigned { get; set; }
        public virtual DbSet<TblEmployeeTeamShiftRoster> TblEmployeeTeamShiftRoster { get; set; }
        public virtual DbSet<TblEmployeeTeamShiftRosterManagementRoles> TblEmployeeTeamShiftRosterManagementRoles { get; set; }
        public virtual DbSet<TblEmployeeTeamShiftRosterScheduleConfig> TblEmployeeTeamShiftRosterScheduleConfig { get; set; }
        public virtual DbSet<TblEmployeeTeamShiftSequence> TblEmployeeTeamShiftSequence { get; set; }
        public virtual DbSet<TblFloorName> TblFloorName { get; set; }
        public virtual DbSet<TblGlobalValue> TblGlobalValue { get; set; }
        public virtual DbSet<TblHeaderMessage> TblHeaderMessage { get; set; }
        public virtual DbSet<TblHrdataHistory> TblHrdataHistory { get; set; }
        public virtual DbSet<TblInternalApproval> TblInternalApproval { get; set; }
        public virtual DbSet<TblInternalApprovalCc> TblInternalApprovalCc { get; set; }
        public virtual DbSet<TblInternalApprovalDetalis> TblInternalApprovalDetalis { get; set; }
        public virtual DbSet<TblLeaveApplication> TblLeaveApplication { get; set; }
        public virtual DbSet<TblLeaveBalance> TblLeaveBalance { get; set; }
        public virtual DbSet<TblLeaveTypeSetup> TblLeaveTypeSetup { get; set; }
        public virtual DbSet<TblLetterIssue> TblLetterIssue { get; set; }
        public virtual DbSet<TblLetterTypeConfigaration> TblLetterTypeConfigaration { get; set; }
        public virtual DbSet<TblLoanApplicationM> TblLoanApplicationM { get; set; }
        public virtual DbSet<TblLoanApplicationOld> TblLoanApplicationOld { get; set; }
        public virtual DbSet<TblLoginInfoSalesProject> TblLoginInfoSalesProject { get; set; }
        public virtual DbSet<TblMailPriorityType> TblMailPriorityType { get; set; }
        public virtual DbSet<TblMailRecipientType> TblMailRecipientType { get; set; }
        public virtual DbSet<TblMailTypeInfo> TblMailTypeInfo { get; set; }
        public virtual DbSet<TblMeetinMinutesPersonAttenName> TblMeetinMinutesPersonAttenName { get; set; }
        public virtual DbSet<TblMeetingAgenda> TblMeetingAgenda { get; set; }
        public virtual DbSet<TblMeetingMinutes> TblMeetingMinutes { get; set; }
        public virtual DbSet<TblMeetingMinutesNextSchedule> TblMeetingMinutesNextSchedule { get; set; }
        public virtual DbSet<TblMeetingRoomAttendance> TblMeetingRoomAttendance { get; set; }
        public virtual DbSet<TblMettingMinutesDecissions> TblMettingMinutesDecissions { get; set; }
        public virtual DbSet<TblMonth> TblMonth { get; set; }
        public virtual DbSet<TblMonthlySalaryGenerate> TblMonthlySalaryGenerate { get; set; }
        public virtual DbSet<TblMonthlySalaryGenerateTest> TblMonthlySalaryGenerateTest { get; set; }
        public virtual DbSet<TblMonthlySalaryGeneratetest1> TblMonthlySalaryGeneratetest1 { get; set; }
        public virtual DbSet<TblOfficialMovement> TblOfficialMovement { get; set; }
        public virtual DbSet<TblPayrollProcesse> TblPayrollProcesse { get; set; }
        public virtual DbSet<TblPfInvestmentMaturity> TblPfInvestmentMaturity { get; set; }
        public virtual DbSet<TblPfRelease> TblPfRelease { get; set; }
        public virtual DbSet<TblPfbankAccountConfiguration> TblPfbankAccountConfiguration { get; set; }
        public virtual DbSet<TblPfbankAccountStatement> TblPfbankAccountStatement { get; set; }
        public virtual DbSet<TblPfbankBook> TblPfbankBook { get; set; }
        public virtual DbSet<TblPfinvestment> TblPfinvestment { get; set; }
        public virtual DbSet<TblPfinvestmentType> TblPfinvestmentType { get; set; }
        public virtual DbSet<TblPfrecieveBankStatement> TblPfrecieveBankStatement { get; set; }
        public virtual DbSet<TblPolicyDocType> TblPolicyDocType { get; set; }
        public virtual DbSet<TblPrevilegeLeave> TblPrevilegeLeave { get; set; }
        public virtual DbSet<TblPunchMechineConfig> TblPunchMechineConfig { get; set; }
        public virtual DbSet<TblPunchMechineRawData> TblPunchMechineRawData { get; set; }
        public virtual DbSet<TblReligion> TblReligion { get; set; }
        public virtual DbSet<TblRoster> TblRoster { get; set; }
        public virtual DbSet<TblRosterScheduleConfig> TblRosterScheduleConfig { get; set; }
        public virtual DbSet<TblSalaryAdvice> TblSalaryAdvice { get; set; }
        public virtual DbSet<TblSalaryGenerateStation> TblSalaryGenerateStation { get; set; }
        public virtual DbSet<TblSalaryWithAccHead> TblSalaryWithAccHead { get; set; }
        public virtual DbSet<TblShift> TblShift { get; set; }
        public virtual DbSet<TblUnit> TblUnit { get; set; }
        public virtual DbSet<TblUnitAddress> TblUnitAddress { get; set; }
        public virtual DbSet<TblUnitAddressType> TblUnitAddressType { get; set; }
        public virtual DbSet<TblUnitByUser> TblUnitByUser { get; set; }
        public virtual DbSet<TblUserAdProfile> TblUserAdProfile { get; set; }
        public virtual DbSet<TblUserDesignation> TblUserDesignation { get; set; }
        public virtual DbSet<TblUserInfo> TblUserInfo { get; set; }
        public virtual DbSet<TblUserJobType> TblUserJobType { get; set; }
        public virtual DbSet<TblWorkPlan> TblWorkPlan { get; set; }
        public virtual DbSet<TblWorkPlanDoc> TblWorkPlanDoc { get; set; }
        public virtual DbSet<TblofficialMovementType> TblofficialMovementType { get; set; }

        // Unable to generate entity type for table 'dbo.tblEmployeeProfileReward'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileRewardCategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileSkill'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileSkillType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileSpouseInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblBreakPunishmentLetterConfig'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPiceRate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileTraining'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPiceRateSalaryGenerate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblProductionDailySummary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblCashSalary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblProvidentFund'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeSalaryHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPunchMachineConfig'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeSelection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPunchMachineDateInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeSeparate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblChangeDayOff'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeTaxAmount'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblChangeDeg'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeTaxProvition'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblChangeDegEmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblChangeSalary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblLeaveProcessed'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblResult'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblConferenceRoomList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblConferenceRoomSheduleInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblConferenceRoomSheduleInfoDetaills'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblRosterManagementRoles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblConfidentialEducation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblConfidentialGrading'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblConfidentialLaguage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblConfidentialPerformance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblConfidentialTraining'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDay'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSeparationDocPath'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployerSalaryAccount'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDispatchFiles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2_FP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMenuListOfFoodCorner'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblShiftByEmployee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2_FP_2015-02-19'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTADABill'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2_FP_2015-03-01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAJMLBonusHoursStorage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTAXDeductionType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmpSalaryStop'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2_FP_AJML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAJMLBonusHoursStorage1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTempEmpBasicInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmpSeparateType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2_FP_AJMLNew'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTempLeave'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmpSeparation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDocumentsArchiveInternal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2_FP_AMFL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDocumentType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2_FP_ATML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblELRemainingFromArchive_HR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDTICasualSalary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_2_FP_HO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblCoinDistribution'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDTICasualSalaryGenerate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDTICasualSalaryUpdate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_21'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSalaryView'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblGLCodeByEmployee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_22'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblGLCodeName'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblGlobalDocType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_3_Salary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblGlobalDocUpload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblUnitOwnershipType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblGlobalDocView'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmpInsuranceInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_4_ERP_Permission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblUnitPfConfiguration'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblGlobalSubDocType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_5'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblUnitRequest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_6'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblUnitTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_7'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblGLRecordRoom'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temtest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblLoanScheduleM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_Loan'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_TAX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblHRDocUpload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeFestivalBonus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblHRPeriod'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeGratuityProvition'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl25Employee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblHRPolicyUpload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl6To12'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblWorkCenterInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblACLSalaryDec15'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAGEmployeeGradingDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAjmlDismissal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Temporary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblJobstationVsCOAHead'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAGEmployeeprogressDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAJML'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblLoanType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSalaryView1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeListForCafeteria'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblLeaveHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblLeaveNotAllowedMonth'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeInsurancePermission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAjmlEmployee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeJobStationOperator'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblLoanCustomizeInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblLoanSchedule_Old'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeTaxTreasuryDeposite'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAjmlSubDepartment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAjmlTemporary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMailUserPermision'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMarketingEmployee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAllowanceOnetime'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblRemoteUrl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMaualAttendance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblRemoteUrlDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblReward'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAppPermission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAppsNews'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMobileInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMobileOperator'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileAddress'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMobileType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileAddressType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMobileUserType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployee2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileAsset'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPunchMachineAH'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblMobileUseType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileAsssetType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileBenifitAllowance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileContact'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileContactType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblInsuranceType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileDocuments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileEducation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileEducationBoard'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileEducationDegree'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblRewardType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileEducationInstitution'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAttendenceManual'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileEducationSubject'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblOtherDeductionAmount'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileEmpInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditExcellReport1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileEmpOfficialInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPayrollProcesseForPiceRate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeTemporary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileEmpOfficialInfoJobType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileExperience'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileExperienceIndustry'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileFamilyInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileLanguage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileLanguageProficiencyLevel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblBenifitDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileLanguageType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblBenifitType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileNomineeInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPFInvestmentDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileProfessionalDegree'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfilePunishment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblBreakDuration'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfilePunishmentType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblEmployeeProfileReference'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=devesql;Initial Catalog=ERP_HR;User ID=sqlrw;Password=RWsql@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("Table_1");

                entity.Property(e => e.IntId)
                    .HasColumnName("intID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StrCardNumber)
                    .HasColumnName("strCardNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrCode)
                    .HasColumnName("strCode")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableGeneral>(entity =>
            {
                entity.HasKey(e => e.IntEmpId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Table_General");

                entity.HasIndex(e => e.IntEmployeeJobStationId)
                    .HasName("Mar_2_2018_11_06_12_097PM");

                entity.Property(e => e.IntEmpId)
                    .HasColumnName("intEmpID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DteJoining)
                    .HasColumnName("dteJoining")
                    .HasColumnType("date");

                entity.Property(e => e.IntAbsent).HasColumnName("intAbsent");

                entity.Property(e => e.IntBankId).HasColumnName("intBankID");

                entity.Property(e => e.IntBl).HasColumnName("intBL");

                entity.Property(e => e.IntBranchId).HasColumnName("intBranchID");

                entity.Property(e => e.IntCl).HasColumnName("intCL");

                entity.Property(e => e.IntDistrictId).HasColumnName("intDistrictID");

                entity.Property(e => e.IntEl).HasColumnName("intEL");

                entity.Property(e => e.IntEmployeeJobStationId).HasColumnName("intEmployeeJobStationId");

                entity.Property(e => e.IntHoliday).HasColumnName("intHoliday");

                entity.Property(e => e.IntLate).HasColumnName("intLate");

                entity.Property(e => e.IntLwp).HasColumnName("intLWP");

                entity.Property(e => e.IntMl).HasColumnName("intML");

                entity.Property(e => e.IntNightCount).HasColumnName("intNightCount");

                entity.Property(e => e.IntNightDuty).HasColumnName("intNightDuty");

                entity.Property(e => e.IntOffday).HasColumnName("intOffday");

                entity.Property(e => e.IntPl).HasColumnName("intPL");

                entity.Property(e => e.IntPresent).HasColumnName("intPresent");

                entity.Property(e => e.IntSl).HasColumnName("intSL");

                entity.Property(e => e.IntUnit).HasColumnName("intUnit");

                entity.Property(e => e.MonAbsentPunishmentAmount)
                    .HasColumnName("monAbsentPunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonAllowance)
                    .HasColumnName("monAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonAttendanceBenifit)
                    .HasColumnName("monAttendanceBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonBasicAmount)
                    .HasColumnName("monBasicAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonDayoffBenifit)
                    .HasColumnName("monDayoffBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDofferBenifit)
                    .HasColumnName("monDofferBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDormataryBenifit)
                    .HasColumnName("monDormataryBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDueAefps)
                    .HasColumnName("monDueAEFPS")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAmount)
                    .HasColumnName("monHouseRentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLatePunishmentAmount)
                    .HasColumnName("monLatePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLeavePunishmentAmount)
                    .HasColumnName("monLeavePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLieuBenifit)
                    .HasColumnName("monLieuBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoanAmount)
                    .HasColumnName("monLoanAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLodingBenifit)
                    .HasColumnName("monLodingBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonMedicalAllowanceAmount)
                    .HasColumnName("monMedicalAllowanceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMobileAllowance)
                    .HasColumnName("monMobileAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightAllowance)
                    .HasColumnName("monNightAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightBenifit)
                    .HasColumnName("monNightBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNontabBenifit)
                    .HasColumnName("monNontabBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtamount)
                    .HasColumnName("monOTAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherAmount)
                    .HasColumnName("monOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPerHourSalary)
                    .HasColumnName("monPerHourSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfamount)
                    .HasColumnName("monPFAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPlamount)
                    .HasColumnName("monPLAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishment)
                    .HasColumnName("monPunishment")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalaryAllowancePayInCash)
                    .HasColumnName("monSalaryAllowancePayInCash")
                    .HasColumnType("money");

                entity.Property(e => e.MonScottBenifit)
                    .HasColumnName("monScottBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonTadaamount)
                    .HasColumnName("monTADAAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxAmount)
                    .HasColumnName("monTaxAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalDeduction)
                    .HasColumnName("monTotalDeduction")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalOthour)
                    .HasColumnName("monTotalOTHour")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalPayableSalary)
                    .HasColumnName("monTotalPayableSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalSalary)
                    .HasColumnName("monTotalSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportAmount)
                    .HasColumnName("monTransportAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionFee)
                    .HasColumnName("monUnionFee")
                    .HasColumnType("money");

                entity.Property(e => e.StrAreaName)
                    .IsRequired()
                    .HasColumnName("strAreaName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankAccountNo)
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankName)
                    .HasColumnName("strBankName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBranchName)
                    .HasColumnName("strBranchName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDepartment)
                    .IsRequired()
                    .HasColumnName("strDepartment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .IsRequired()
                    .HasColumnName("strDesignation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDistrictName)
                    .HasColumnName("strDistrictName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGroupName)
                    .IsRequired()
                    .HasColumnName("strGroupName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobStationName)
                    .IsRequired()
                    .HasColumnName("strJobStationName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .IsRequired()
                    .HasColumnName("strJobType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .IsRequired()
                    .HasColumnName("strName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRegionName)
                    .IsRequired()
                    .HasColumnName("strRegionName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRoutingNo)
                    .HasColumnName("strRoutingNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTeritoryName)
                    .IsRequired()
                    .HasColumnName("strTeritoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrUnit)
                    .IsRequired()
                    .HasColumnName("strUnit")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableWages>(entity =>
            {
                entity.HasKey(e => e.IntEmpId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Table_Wages");

                entity.HasIndex(e => new { e.IntEmpId, e.StrName, e.StrDepartment, e.StrJobType, e.StrDesignation, e.DteJoining, e.IntTotalHours, e.IntPresent, e.IntAbsent, e.IntOffday, e.IntHoliday, e.IntLate, e.MonSalary, e.MonLatePunishmentAmount, e.MonTotalSalary, e.MonTotalOthour, e.MonPerHourSalary, e.MonOtamount, e.MonPunishment, e.MonTotalPayableSalary, e.StrJobStationName, e.StrUnit, e.StrBankName, e.StrBranchName, e.StrBankAccountNo, e.IntEmployeeJobStationId })
                    .HasName("Mar_2_2018_11_06_09_073PM");

                entity.Property(e => e.IntEmpId)
                    .HasColumnName("intEmpID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DteJoining)
                    .HasColumnName("dteJoining")
                    .HasColumnType("date");

                entity.Property(e => e.IntAbsent).HasColumnName("intAbsent");

                entity.Property(e => e.IntBankId).HasColumnName("intBankID");

                entity.Property(e => e.IntBranchId).HasColumnName("intBranchID");

                entity.Property(e => e.IntDistrictId).HasColumnName("intDistrictID");

                entity.Property(e => e.IntEmployeeJobStationId).HasColumnName("intEmployeeJobStationId");

                entity.Property(e => e.IntHoliday).HasColumnName("intHoliday");

                entity.Property(e => e.IntLate).HasColumnName("intLate");

                entity.Property(e => e.IntNightCount).HasColumnName("intNightCount");

                entity.Property(e => e.IntNightDuty).HasColumnName("intNightDuty");

                entity.Property(e => e.IntOffday).HasColumnName("intOffday");

                entity.Property(e => e.IntPresent).HasColumnName("intPresent");

                entity.Property(e => e.IntTotalHours).HasColumnName("intTotalHours");

                entity.Property(e => e.IntUnit).HasColumnName("intUnit");

                entity.Property(e => e.MonAllowance)
                    .HasColumnName("monAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonAttendanceBenifit)
                    .HasColumnName("monAttendanceBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDayoffBenifit)
                    .HasColumnName("monDayoffBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDofferBenifit)
                    .HasColumnName("monDofferBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDormataryBenifit)
                    .HasColumnName("monDormataryBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDueAefps)
                    .HasColumnName("monDueAEFPS")
                    .HasColumnType("money");

                entity.Property(e => e.MonLatePunishmentAmount)
                    .HasColumnName("monLatePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLieuBenifit)
                    .HasColumnName("monLieuBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLodingBenifit)
                    .HasColumnName("monLodingBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightBenifit)
                    .HasColumnName("monNightBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightDutyAmount)
                    .HasColumnName("monNightDutyAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonNontabBenifit)
                    .HasColumnName("monNontabBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtamount)
                    .HasColumnName("monOTAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPerHourSalary)
                    .HasColumnName("monPerHourSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishment)
                    .HasColumnName("monPunishment")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonScottBenifit)
                    .HasColumnName("monScottBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonTadaamount)
                    .HasColumnName("monTADAAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalOthour)
                    .HasColumnName("monTotalOTHour")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalPayableSalary)
                    .HasColumnName("monTotalPayableSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalSalary)
                    .HasColumnName("monTotalSalary")
                    .HasColumnType("money");

                entity.Property(e => e.StrAreaName)
                    .IsRequired()
                    .HasColumnName("strAreaName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankAccountNo)
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankName)
                    .HasColumnName("strBankName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBranchName)
                    .HasColumnName("strBranchName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDepartment)
                    .IsRequired()
                    .HasColumnName("strDepartment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .IsRequired()
                    .HasColumnName("strDesignation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDistrictName)
                    .HasColumnName("strDistrictName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobStationName)
                    .IsRequired()
                    .HasColumnName("strJobStationName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .IsRequired()
                    .HasColumnName("strJobType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .IsRequired()
                    .HasColumnName("strName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRegionName)
                    .IsRequired()
                    .HasColumnName("strRegionName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRoutingNo)
                    .HasColumnName("strRoutingNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTeritoryName)
                    .IsRequired()
                    .HasColumnName("strTeritoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrUnit)
                    .IsRequired()
                    .HasColumnName("strUnit")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAefpsamount>(entity =>
            {
                entity.HasKey(e => e.Intid);

                entity.ToTable("tblAEFPSAmount");

                entity.Property(e => e.Intid).HasColumnName("intid");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntWh).HasColumnName("intWH");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TblAfblremoteAttendancePermission>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblAFBLRemoteAttendancePermission");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblAgemployeeprogress>(entity =>
            {
                entity.HasKey(e => e.IntRow);

                entity.ToTable("tblAGEmployeeprogress");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteApproved)
                    .HasColumnName("dteApproved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtePromotionConfirmation)
                    .HasColumnName("dtePromotionConfirmation")
                    .HasColumnType("date");

                entity.Property(e => e.DteProposed)
                    .HasColumnName("dteProposed")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntAction).HasColumnName("intAction");

                entity.Property(e => e.IntApproved).HasColumnName("intApproved");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntProposed).HasColumnName("intProposed");

                entity.Property(e => e.NumApprovedGross)
                    .HasColumnName("numApprovedGross")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumApprovedIncrementPercentage)
                    .HasColumnName("numApprovedIncrementPercentage")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumApprovededIncrementTaka)
                    .HasColumnName("numApprovededIncrementTaka")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumPerformance)
                    .HasColumnName("numPerformance")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumProposedGross)
                    .HasColumnName("numProposedGross")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumProposedIncrementPercentage)
                    .HasColumnName("numProposedIncrementPercentage")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumProposedIncrementTaka)
                    .HasColumnName("numProposedIncrementTaka")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StrAcrCode)
                    .HasColumnName("strAcrCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrApprovedPromotion)
                    .HasColumnName("strApprovedPromotion")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.StrDptHdRemarks)
                    .HasColumnName("strDptHdRemarks")
                    .HasMaxLength(555)
                    .IsUnicode(false);

                entity.Property(e => e.StrOverallPerformance)
                    .HasColumnName("strOverallPerformance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPerformanceGrade)
                    .HasColumnName("strPerformanceGrade")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StrProposedPromotion)
                    .HasColumnName("strProposedPromotion")
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAjmlAttendance>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblAjmlAttendance");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.D1)
                    .HasColumnName("D_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D10)
                    .HasColumnName("D_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D11)
                    .HasColumnName("D_11")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D12)
                    .HasColumnName("D_12")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D13)
                    .HasColumnName("D_13")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D14)
                    .HasColumnName("D_14")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D15)
                    .HasColumnName("D_15")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D16)
                    .HasColumnName("D_16")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D17)
                    .HasColumnName("D_17")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D18)
                    .HasColumnName("D_18")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D19)
                    .HasColumnName("D_19")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D2)
                    .HasColumnName("D_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D20)
                    .HasColumnName("D_20")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D21)
                    .HasColumnName("D_21")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D22)
                    .HasColumnName("D_22")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D23)
                    .HasColumnName("D_23")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D24)
                    .HasColumnName("D_24")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D25)
                    .HasColumnName("D_25")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D26)
                    .HasColumnName("D_26")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D27)
                    .HasColumnName("D_27")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D28)
                    .HasColumnName("D_28")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D29)
                    .HasColumnName("D_29")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D3)
                    .HasColumnName("D_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D30)
                    .HasColumnName("D_30")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D31)
                    .HasColumnName("D_31")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.D4)
                    .HasColumnName("D_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D5)
                    .HasColumnName("D_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D6)
                    .HasColumnName("D_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D7)
                    .HasColumnName("D_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D8)
                    .HasColumnName("D_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.D9)
                    .HasColumnName("D_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.MillNo)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Pshift)
                    .HasColumnName("PShift")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rshift)
                    .HasColumnName("RShift")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .HasMaxLength(750)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAjmlDropDown>(entity =>
            {
                entity.HasKey(e => e.IntRow);

                entity.ToTable("tblAjmlDropDown");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntActionby).HasColumnName("intActionby");

                entity.Property(e => e.StrDetails)
                    .HasColumnName("strDetails")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrShort)
                    .HasColumnName("strShort")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrType)
                    .HasColumnName("strType")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAjmlOvertime>(entity =>
            {
                entity.HasKey(e => e.IntRow)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblAjmlOvertime");

                entity.HasIndex(e => new { e.DteEffective, e.IntEnroll })
                    .HasName("Dec_11_2017_11_33_38_870AM");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteEffective)
                    .HasColumnName("dteEffective")
                    .HasColumnType("date");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntHour).HasColumnName("intHour");

                entity.Property(e => e.IntPunishBy).HasColumnName("intPunishBy");
            });

            modelBuilder.Entity<TblAjmlPairmachine>(entity =>
            {
                entity.HasKey(e => e.IntRow)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblAjmlPairmachine");

                entity.HasIndex(e => new { e.IntEnroll, e.IntStation, e.DteFrom, e.DteTo })
                    .HasName("Jan_5_2018_11_00_16_877PM");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteFrom)
                    .HasColumnName("dteFrom")
                    .HasColumnType("date");

                entity.Property(e => e.DteTo)
                    .HasColumnName("dteTo")
                    .HasColumnType("date");

                entity.Property(e => e.IntActionby).HasColumnName("intActionby");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntHour).HasColumnName("intHour");

                entity.Property(e => e.IntStation).HasColumnName("intStation");

                entity.Property(e => e.IsSeniorSupervisor).HasColumnName("isSeniorSupervisor");

                entity.Property(e => e.IsSupervisor).HasColumnName("isSupervisor");

                entity.Property(e => e.IsWorker).HasColumnName("isWorker");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumHrate)
                    .HasColumnName("numHRate")
                    .HasColumnType("numeric(18, 3)");
            });

            modelBuilder.Entity<TblAjmlPairmachineRate>(entity =>
            {
                entity.HasKey(e => e.IntRow);

                entity.ToTable("tblAjmlPairmachineRate");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteFrom)
                    .HasColumnName("dteFrom")
                    .HasColumnType("date");

                entity.Property(e => e.DteTo)
                    .HasColumnName("dteTo")
                    .HasColumnType("date");

                entity.Property(e => e.IntActionby).HasColumnName("intActionby");

                entity.Property(e => e.IntDay).HasColumnName("intDay");

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.NumHrate)
                    .HasColumnName("numHRate")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.NumRate)
                    .HasColumnName("numRate")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.StrType)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAjmlPayrollGrade>(entity =>
            {
                entity.HasKey(e => e.IntRow);

                entity.ToTable("tblAjmlPayrollGrade");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteFrom)
                    .HasColumnName("dteFrom")
                    .HasColumnType("date");

                entity.Property(e => e.DteTo)
                    .HasColumnName("dteTo")
                    .HasColumnType("date");

                entity.Property(e => e.IntActionby).HasColumnName("intActionby");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StrType)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAjmlPayrollprocess>(entity =>
            {
                entity.HasKey(e => e.IntRow)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblAjmlPayrollprocess");

                entity.HasIndex(e => new { e.Enroll, e.DteGeneration })
                    .HasName("<Ajml-01>");

                entity.HasIndex(e => new { e.Enroll, e.Gender, e.IntWhour, e.Point, e.DteGeneration })
                    .HasName("Jun_12_2018_3_49_13_183AM");

                entity.HasIndex(e => new { e.Section, e.IntWhour, e.IntMlhour, e.IntClhour, e.IntElhour, e.IntOthour, e.NumSubWages, e.IntAmlh, e.IntAclh, e.IntAelh, e.NumAwages, e.NumSubBenifit, e.NumTrnsport, e.NumSubDeduction, e.Point, e.DteGeneration })
                    .HasName("Dec_11_2017_1_49_23_580PM");

                entity.HasIndex(e => new { e.IntWeekno, e.NumJoraH, e.Enroll, e.PhotoUrl, e.Employee, e.Code, e.Station, e.Department, e.Designation, e.Jobtype, e.Doj, e.Pshift, e.Grade, e.Gross, e.Basics, e.Sph, e.IntWhour, e.IntMlhour, e.IntClhour, e.IntElhour, e.IntOthour, e.NumWages, e.NumLvwages, e.NumOtamount, e.NumSubWages, e.IntAmlh, e.IntAclh, e.IntAelh, e.IntNhour, e.NumNallw, e.NumAttBns, e.NumJoraBns, e.NumSplAllw, e.NumSubBenifit, e.NumTrnsport, e.UnionFee, e.Pf, e.Punishment, e.NumSubDeduction, e.Netpayable, e.Gender, e.Point, e.Rshift, e.SectionId, e.DepartmentId, e.DteGeneration })
                    .HasName("Dec_11_2017_7_07_21_500AM");

                entity.HasIndex(e => new { e.Enroll, e.Employee, e.Code, e.Station, e.Section, e.Department, e.Designation, e.Jobtype, e.Gender, e.Doj, e.Pshift, e.Cshift, e.Grade, e.Gross, e.Basics, e.Sph, e.IntWday, e.IntPresent, e.IntAbsent, e.IntMl, e.IntCl, e.IntEl, e.IntPhour, e.IntWhour, e.IntMlhour, e.IntClhour, e.IntElhour, e.IntOthour, e.IntThour, e.NumWages, e.NumLvwages, e.NumOtamount, e.NumSubWages, e.IntAmlh, e.IntAclh, e.IntAelh, e.NumAwages, e.IntNhour, e.IntNphour, e.NumNallw, e.NumAttBns, e.NumJoraBns, e.NumSplAllw, e.NumSubBenifit, e.Transport, e.NumTrnsport, e.UnionFee, e.Pf, e.Punishment, e.NumSubDeduction, e.Netpayable, e.DteGeneration })
                    .HasName("Dec_11_2017_3_17_45_893PM");

                entity.HasIndex(e => new { e.Enroll, e.Employee, e.Code, e.Station, e.Section, e.Department, e.Designation, e.Jobtype, e.Gender, e.Doj, e.Pshift, e.Cshift, e.Grade, e.Gross, e.Basics, e.Sph, e.IntWday, e.IntPresent, e.IntAbsent, e.IntMl, e.IntCl, e.IntEl, e.IntPhour, e.IntWhour, e.IntMlhour, e.IntClhour, e.IntElhour, e.IntOthour, e.IntThour, e.NumWages, e.NumLvwages, e.NumOtamount, e.NumSubWages, e.IntAmlh, e.IntAclh, e.IntAelh, e.NumAwages, e.IntNhour, e.IntNphour, e.NumNallw, e.NumAttBns, e.NumJoraBns, e.NumSplAllw, e.NumSubBenifit, e.Transport, e.NumTrnsport, e.UnionFee, e.Pf, e.Punishment, e.NumSubDeduction, e.Netpayable, e.DteAction, e.DteGeneration })
                    .HasName("Dec_11_2017_4_57_08_300PM");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.Basics).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cshift)
                    .HasColumnName("CShift")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Doj).HasColumnType("date");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteGeneration)
                    .HasColumnName("dteGeneration")
                    .HasColumnType("date");

                entity.Property(e => e.Employee)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gross).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IntAbsent).HasColumnName("intAbsent");

                entity.Property(e => e.IntAclh).HasColumnName("intACLH");

                entity.Property(e => e.IntAelh).HasColumnName("intAELH");

                entity.Property(e => e.IntAmlh).HasColumnName("intAMLH");

                entity.Property(e => e.IntCl).HasColumnName("intCL");

                entity.Property(e => e.IntClhour).HasColumnName("intCLhour");

                entity.Property(e => e.IntEl).HasColumnName("intEL");

                entity.Property(e => e.IntElhour).HasColumnName("intELhour");

                entity.Property(e => e.IntMl).HasColumnName("intML");

                entity.Property(e => e.IntMlhour).HasColumnName("intMLhour");

                entity.Property(e => e.IntNhour).HasColumnName("intNHour");

                entity.Property(e => e.IntNphour).HasColumnName("intNPHour");

                entity.Property(e => e.IntOthour).HasColumnName("intOThour");

                entity.Property(e => e.IntPhour).HasColumnName("intPhour");

                entity.Property(e => e.IntPresent).HasColumnName("intPresent");

                entity.Property(e => e.IntThour).HasColumnName("intThour");

                entity.Property(e => e.IntWday).HasColumnName("intWDay");

                entity.Property(e => e.IntWeekno).HasColumnName("intWeekno");

                entity.Property(e => e.IntWhour).HasColumnName("intWhour");

                entity.Property(e => e.IsTransport).HasColumnName("isTransport");

                entity.Property(e => e.IsWorker).HasColumnName("isWorker");

                entity.Property(e => e.Jobtype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Netpayable).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumAttBns)
                    .HasColumnName("numAttBns")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumAwages)
                    .HasColumnName("numAWages")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumJoraBns)
                    .HasColumnName("numJoraBns")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumJoraH)
                    .HasColumnName("numJoraH")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumLvwages)
                    .HasColumnName("numLVWages")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumNallw)
                    .HasColumnName("numNAllw")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumOtamount)
                    .HasColumnName("numOTAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumSplAllw)
                    .HasColumnName("numSplAllw")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumSubBenifit)
                    .HasColumnName("numSubBenifit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumSubDeduction)
                    .HasColumnName("numSubDeduction")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumSubWages)
                    .HasColumnName("numSubWages")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumTrnsport)
                    .HasColumnName("numTrnsport")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumWages)
                    .HasColumnName("numWages")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pshift)
                    .HasColumnName("PShift")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Punishment).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rshift).HasColumnName("RShift");

                entity.Property(e => e.Section)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sph)
                    .HasColumnName("SPH")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Station)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnionFee).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TblAjmlPunishment>(entity =>
            {
                entity.HasKey(e => e.IntRow);

                entity.ToTable("tblAjmlPunishment");

                entity.HasIndex(e => new { e.IntRow, e.IntEnroll, e.MonAmount, e.IntHour, e.MonSpecial, e.StrDn, e.DteEffective })
                    .HasName("Feb_2_2018_11_00_04_737PM");

                entity.HasIndex(e => new { e.IntRow, e.MonAmount, e.IntHour, e.MonSpecial, e.StrDn, e.IntEnroll, e.DteEffective })
                    .HasName("Dec_11_2017_4_56_29_750PM");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteEffective)
                    .HasColumnName("dteEffective")
                    .HasColumnType("date");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntHour).HasColumnName("intHour");

                entity.Property(e => e.IntPunishBy).HasColumnName("intPunishBy");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MonSpecial)
                    .HasColumnName("monSpecial")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StrDn)
                    .HasColumnName("strDN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StrReason)
                    .HasColumnName("strReason")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAjmlTrialCard>(entity =>
            {
                entity.HasKey(e => e.IntTrialId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblAjmlTrialCard");

                entity.HasIndex(e => e.StrCardNo)
                    .HasName("Dec_11_2017_3_28_12_793PM");

                entity.HasIndex(e => new { e.StrCardNo, e.IntEnroll })
                    .HasName("Dec_11_2017_10_51_40_367AM");

                entity.HasIndex(e => new { e.IntEnroll, e.StrSection, e.IntShift })
                    .HasName("Dec_11_2017_11_10_18_377AM");

                entity.HasIndex(e => new { e.IntEnroll, e.StrSection, e.IntSection, e.IntShiftRunning })
                    .HasName("<Ajml-01>");

                entity.HasIndex(e => new { e.StrTransport, e.IntShift, e.DteIssue, e.DteJoin, e.IsActive, e.IsConfirm, e.IntTrialId, e.IntEnroll, e.StrEmployee, e.StrCardNo, e.StrGuardian, e.StrAge, e.StrAddress, e.StrGender, e.StrSection, e.IntStation })
                    .HasName("Jun_12_2018_3_50_17_430AM");

                entity.Property(e => e.IntTrialId).HasColumnName("intTrialId");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteIssue)
                    .HasColumnName("dteIssue")
                    .HasColumnType("date");

                entity.Property(e => e.DteJoin)
                    .HasColumnName("dteJoin")
                    .HasColumnType("date");

                entity.Property(e => e.IntActionby).HasColumnName("intActionby");

                entity.Property(e => e.IntDepartment).HasColumnName("intDepartment");

                entity.Property(e => e.IntDesignation).HasColumnName("intDesignation");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntGrade).HasColumnName("intGrade");

                entity.Property(e => e.IntSection).HasColumnName("intSection");

                entity.Property(e => e.IntShift).HasColumnName("intShift");

                entity.Property(e => e.IntShiftRunning).HasColumnName("intShiftRunning");

                entity.Property(e => e.IntStation).HasColumnName("intStation");

                entity.Property(e => e.IntTransport).HasColumnName("intTransport");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsConfirm).HasColumnName("isConfirm");

                entity.Property(e => e.IsIdCprint).HasColumnName("isIdCPrint");

                entity.Property(e => e.StrAddress)
                    .HasColumnName("strAddress")
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.StrAge)
                    .HasColumnName("strAge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrCardNo)
                    .HasColumnName("strCardNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployee)
                    .HasColumnName("strEmployee")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrFit)
                    .HasColumnName("strFit")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrGender)
                    .HasColumnName("strGender")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StrGrade)
                    .HasColumnName("strGrade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrGuardian)
                    .HasColumnName("strGuardian")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrPhoto)
                    .HasColumnName("strPhoto")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrSection)
                    .HasColumnName("strSection")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StrTransport)
                    .HasColumnName("strTransport")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAllowance>(entity =>
            {
                entity.HasKey(e => e.IntAllowanceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblAllowance");

                entity.HasIndex(e => e.IntEmployeeId)
                    .HasName("Jun_12_2018_3_50_03_090AM");

                entity.HasIndex(e => new { e.IntAllowanceTypeId, e.IntAllowanceId, e.IntMonthId, e.IntYear, e.IntEmployeeId })
                    .HasName("Dec_11_2017_11_45_58_167AM");

                entity.HasIndex(e => new { e.IntAllowanceTypeId, e.IntEmployeeId, e.IntMonthId, e.IntYear, e.YsnActive })
                    .HasName("<Index-03, sysname,>");

                entity.Property(e => e.IntAllowanceId).HasColumnName("intAllowanceId");

                entity.Property(e => e.IntAllowanceTypeId).HasColumnName("intAllowanceTypeId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntLoginId).HasColumnName("intLoginId");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthId");

                entity.Property(e => e.IntYear).HasColumnName("intYear");

                entity.Property(e => e.StrReason)
                    .HasColumnName("strReason")
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblAllowanceDetails>(entity =>
            {
                entity.HasKey(e => e.IntAllowanceDetailsId);

                entity.ToTable("tblAllowanceDetails");

                entity.HasIndex(e => new { e.MonAmount, e.IntAllowanceId })
                    .HasName("Dec_11_2017_11_45_56_647AM");

                entity.Property(e => e.IntAllowanceDetailsId).HasColumnName("intAllowanceDetailsId");

                entity.Property(e => e.IntAllowanceId).HasColumnName("intAllowanceId");

                entity.Property(e => e.IntProductId).HasColumnName("intProductId");

                entity.Property(e => e.IntQuantity).HasColumnName("intQuantity");

                entity.Property(e => e.IntUnitMessarmentId).HasColumnName("intUnitMessarmentId");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblAllowanceType>(entity =>
            {
                entity.HasKey(e => e.IntAllowanceTypeId);

                entity.ToTable("tblAllowanceType");

                entity.Property(e => e.IntAllowanceTypeId).HasColumnName("intAllowanceTypeId");

                entity.Property(e => e.StrAllowance)
                    .HasColumnName("strAllowance")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCategory)
                    .HasColumnName("strCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrShortName)
                    .HasColumnName("strShortName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YsnAmount).HasColumnName("ysnAmount");

                entity.Property(e => e.YsnProduct).HasColumnName("ysnProduct");
            });

            modelBuilder.Entity<TblApplicationType>(entity =>
            {
                entity.HasKey(e => e.IntAppTypeId);

                entity.ToTable("tblApplicationType");

                entity.Property(e => e.IntAppTypeId).HasColumnName("intAppTypeId");

                entity.Property(e => e.StrAppTypeName)
                    .HasColumnName("strAppTypeName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblAppsTask>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblAppsTask");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DteInsert)
                    .HasColumnName("dteInsert")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntAsignBy).HasColumnName("intAsignBy");

                entity.Property(e => e.IntToEnroll).HasColumnName("intToEnroll");

                entity.Property(e => e.StrBody)
                    .HasColumnName("strBody")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrSubject)
                    .HasColumnName("strSubject")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrToEmailAddress)
                    .HasColumnName("strToEmailAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");

                entity.Property(e => e.YsnComplete).HasColumnName("ysnComplete");
            });

            modelBuilder.Entity<TblAppsTaskDetalis>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblAppsTaskDetalis");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.IntCcEnroll).HasColumnName("intCcEnroll");

                entity.Property(e => e.IntReffTask).HasColumnName("intReffTask");

                entity.Property(e => e.StrCcEmailAddress)
                    .HasColumnName("strCcEmailAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblAttendanceDailySummary>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .HasName("PK__tblAtten__BB4A5F70417387F5");

                entity.ToTable("tblAttendanceDailySummary");

                entity.HasIndex(e => new { e.IntMonthId, e.IntYear, e.IntEmployeeId, e.YsnEarlyLeave })
                    .HasName("Mar_2_2018_11_00_28_563PM");

                entity.HasIndex(e => new { e.IntDayId, e.IntMonthId, e.IntYear, e.IntEmployeeId, e.YsnPresent })
                    .HasName("May_11_2018_05_58_14_080AM");

                entity.HasIndex(e => new { e.IntAutoId, e.IntEmployeeId, e.YsnSwap, e.IntMonthId, e.IntYear, e.YsnLate })
                    .HasName("<SmryIndex-01>");

                entity.HasIndex(e => new { e.YsnEarlyLeave, e.IntPunchCount, e.IntDayId, e.IntMonthId, e.IntYear, e.IntEmployeeId })
                    .HasName("<Index-01, sysname,>");

                entity.HasIndex(e => new { e.IntDayId, e.YsnPresent, e.YsnAbsent, e.YsnLeave, e.YsnMovement, e.YsnHoliday, e.YsnOffday, e.YsnLate, e.IntMonthId, e.IntYear, e.IntEmployeeId })
                    .HasName("Dec_11_2017_7_04_14_360AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.YsnPresent, e.YsnLeave, e.YsnMovement, e.YsnHoliday, e.YsnOffday, e.IntMonthId, e.IntYear, e.YsnAbsent, e.IntDayId, e.IntPunchCount })
                    .HasName("June_06_2018_18_620AM");

                entity.HasIndex(e => new { e.IntAutoId, e.IntEmployeeId, e.YsnPresent, e.YsnLeave, e.YsnMovement, e.YsnHoliday, e.YsnOffday, e.YsnLate, e.TimeLateHour, e.YsnEarlyLeave, e.TimeEarlyLeaveHour, e.TimeAttendanceHour, e.TimeExtraHour, e.TimeShiftOverTime, e.YsnSwap, e.IntPunchCount, e.IntMonthId, e.IntYear, e.YsnAbsent, e.IntDayId })
                    .HasName("<HolidayIndex, sysname,>");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntDayId).HasColumnName("intDayId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthId");

                entity.Property(e => e.IntPunchCount).HasColumnName("intPunchCount");

                entity.Property(e => e.IntYear).HasColumnName("intYear");

                entity.Property(e => e.TimeAttendanceHour).HasColumnName("timeAttendanceHour");

                entity.Property(e => e.TimeEarlyLeaveHour).HasColumnName("timeEarlyLeaveHour");

                entity.Property(e => e.TimeExtraHour).HasColumnName("timeExtraHour");

                entity.Property(e => e.TimeLateHour).HasColumnName("timeLateHour");

                entity.Property(e => e.TimeShiftOverTime).HasColumnName("timeShiftOverTime");

                entity.Property(e => e.YsnAbsent).HasColumnName("ysnAbsent");

                entity.Property(e => e.YsnEarlyLeave).HasColumnName("ysnEarlyLeave");

                entity.Property(e => e.YsnHoliday).HasColumnName("ysnHoliday");

                entity.Property(e => e.YsnLate).HasColumnName("ysnLate");

                entity.Property(e => e.YsnLeave).HasColumnName("ysnLeave");

                entity.Property(e => e.YsnMovement).HasColumnName("ysnMovement");

                entity.Property(e => e.YsnOffday).HasColumnName("ysnOffday");

                entity.Property(e => e.YsnPresent).HasColumnName("ysnPresent");

                entity.Property(e => e.YsnSwap).HasColumnName("ysnSwap");
            });

            modelBuilder.Entity<TblAttendanceProcessed>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("tblAttendanceProcessed");

                entity.HasIndex(e => new { e.Enroll, e.Unit, e.Station, e.NightPresent, e.NightAbsent, e.IsEligibleForSalary })
                    .HasName("<Index-01, sysname,>");

                entity.HasIndex(e => new { e.Enroll, e.Presents, e.LeaveWithPay, e.Lwp, e.Movement, e.Holiday, e.OffDay, e.IsEligibleForSalary })
                    .HasName("<Index-02, sysname,>");

                entity.HasIndex(e => new { e.Presents, e.LeaveWithPay, e.Lwp, e.Movement, e.Holiday, e.OffDay, e.Enroll, e.IsEligibleForSalary })
                    .HasName("<Index-03, sysname,>");

                entity.Property(e => e.AbsentAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Accommodation).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BasicAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BasicPer).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Bl).HasColumnName("BL");

                entity.Property(e => e.CafeteriaBill).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CanteenBill).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.Coin).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DailySalary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Deduction).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DishBill).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.ElectricBill).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ErpTaxAmount)
                    .HasColumnName("erpTaxAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Gross).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GymBill).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HourlySalary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HouseRentAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HouseRentPer).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IntTotalDay).HasColumnName("intTotalDay");

                entity.Property(e => e.IsEligibleForSalary).HasColumnName("isEligibleForSalary");

                entity.Property(e => e.LateAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.Lwpamount)
                    .HasColumnName("LWPAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MealRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MedicalAllowanceAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MedicalAllowancePer).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.OtherAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OtherDeduction).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Paytype)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pfamount)
                    .HasColumnName("PFAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Pfper)
                    .HasColumnName("PFPer")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Pl).HasColumnName("PL");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.TotalDeduction).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalPayable).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransportAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransportBill).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransportPer).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TblAttendancePunishment>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblAttendancePunishment");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeID");

                entity.Property(e => e.IntNoLateCountDay).HasColumnName("intNoLateCountDay");

                entity.Property(e => e.IntNoOfPunishDay).HasColumnName("intNoOfPunishDay");
            });

            modelBuilder.Entity<TblAttendanceRemoteConfig>(entity =>
            {
                entity.HasKey(e => e.IntSheetCode);

                entity.ToTable("tblAttendanceRemoteConfig");

                entity.Property(e => e.IntSheetCode).HasColumnName("intSheetCode");

                entity.Property(e => e.DteLastUpdate)
                    .HasColumnName("dteLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntDay).HasColumnName("intDay");

                entity.Property(e => e.IntEmpJobStationId).HasColumnName("intEmpJobStationId");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblAttendanceUnprocessed>(entity =>
            {
                entity.HasKey(e => e.IntRow);

                entity.ToTable("tblAttendanceUnprocessed");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.IntDay).HasColumnName("intDay");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntPunchCount).HasColumnName("intPunchCount");

                entity.Property(e => e.IntStation).HasColumnName("intStation");

                entity.Property(e => e.TmAttendanceHour)
                    .HasColumnName("tmAttendanceHour")
                    .HasColumnType("time(0)");

                entity.Property(e => e.YsnAbsent).HasColumnName("ysnAbsent");

                entity.Property(e => e.YsnHoliday).HasColumnName("ysnHoliday");

                entity.Property(e => e.YsnLate).HasColumnName("ysnLate");

                entity.Property(e => e.YsnLeave).HasColumnName("ysnLeave");

                entity.Property(e => e.YsnMovement).HasColumnName("ysnMovement");

                entity.Property(e => e.YsnOffday).HasColumnName("ysnOffday");

                entity.Property(e => e.YsnPresent).HasColumnName("ysnPresent");
            });

            modelBuilder.Entity<TblAuditExcellReport>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("pk_tblAuditExcellReport");

                entity.ToTable("tblAuditExcellReport");

                entity.HasIndex(e => e.DteGenerate)
                    .HasName("Mar_2_2018_11_04_56_710PM");

                entity.HasIndex(e => e.IntEmpId)
                    .HasName("May_4_2018_11_00_06_933PM");

                entity.Property(e => e.DteGenerate)
                    .HasColumnName("dteGenerate")
                    .HasColumnType("date");

                entity.Property(e => e.DteJoining)
                    .HasColumnName("dteJoining")
                    .HasColumnType("date");

                entity.Property(e => e.IntAbsent).HasColumnName("intAbsent");

                entity.Property(e => e.IntBl).HasColumnName("intBL");

                entity.Property(e => e.IntCl).HasColumnName("intCL");

                entity.Property(e => e.IntCntNight).HasColumnName("intCntNight");

                entity.Property(e => e.IntEl).HasColumnName("intEL");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.IntHoliday).HasColumnName("intHoliday");

                entity.Property(e => e.IntJobStation).HasColumnName("intJobStation");

                entity.Property(e => e.IntLate).HasColumnName("intLate");

                entity.Property(e => e.IntLeave).HasColumnName("intLeave");

                entity.Property(e => e.IntLwp).HasColumnName("intLWP");

                entity.Property(e => e.IntMl).HasColumnName("intML");

                entity.Property(e => e.IntOffday).HasColumnName("intOffday");

                entity.Property(e => e.IntPl).HasColumnName("intPL");

                entity.Property(e => e.IntPresent).HasColumnName("intPresent");

                entity.Property(e => e.IntRamadan).HasColumnName("intRamadan");

                entity.Property(e => e.IntSl).HasColumnName("intSL");

                entity.Property(e => e.IntTotalHours).HasColumnName("intTotalHours");

                entity.Property(e => e.IntTotalMeal).HasColumnName("intTotalMeal");

                entity.Property(e => e.IntUnit).HasColumnName("intUnit");

                entity.Property(e => e.IntWorkingDays).HasColumnName("intWorkingDays");

                entity.Property(e => e.MonAbsentPunishmentAmount)
                    .HasColumnName("monAbsentPunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonAccommodation)
                    .HasColumnName("monAccommodation")
                    .HasColumnType("money");

                entity.Property(e => e.MonAttendanceBenifit)
                    .HasColumnName("monAttendanceBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonBasicAmount)
                    .HasColumnName("monBasicAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonCafeteriaBill)
                    .HasColumnName("monCafeteriaBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCanteenBill)
                    .HasColumnName("monCanteenBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCarMotorcycleLoan)
                    .HasColumnName("monCarMotorcycleLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonCoin)
                    .HasColumnName("monCoin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MonDayoffBenifit)
                    .HasColumnName("monDayoffBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDishBill)
                    .HasColumnName("monDishBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonDofferBenifit)
                    .HasColumnName("monDofferBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDormataryBenifit)
                    .HasColumnName("monDormataryBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonElectricBill)
                    .HasColumnName("monElectricBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonFlatInstallment)
                    .HasColumnName("monFlatInstallment")
                    .HasColumnType("money");

                entity.Property(e => e.MonGymBill)
                    .HasColumnName("monGymBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonHajjLoan)
                    .HasColumnName("monHajjLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHeatBenifit)
                    .HasColumnName("monHeatBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonHomeLoan)
                    .HasColumnName("monHomeLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAmount)
                    .HasColumnName("monHouseRentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoindatePenalty)
                    .HasColumnName("monJoindatePenalty")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoraBenifit)
                    .HasColumnName("monJoraBenifit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MonLatePunishmentAmount)
                    .HasColumnName("monLatePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLeavePunishmentAmount)
                    .HasColumnName("monLeavePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLieuBenifit)
                    .HasColumnName("monLieuBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoanAmount)
                    .HasColumnName("monLoanAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLodingBenifit)
                    .HasColumnName("monLodingBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonMedicalAllowanceAmount)
                    .HasColumnName("monMedicalAllowanceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightBenifit)
                    .HasColumnName("monNightBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNontabBenifit)
                    .HasColumnName("monNontabBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherAmount)
                    .HasColumnName("monOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherDeductionAmount)
                    .HasColumnName("monOtherDeductionAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfamount)
                    .HasColumnName("monPFAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishment)
                    .HasColumnName("monPunishment")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishmentSchedule)
                    .HasColumnName("monPunishmentSchedule")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonScottBenifit)
                    .HasColumnName("monScottBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonSecurityDeposit)
                    .HasColumnName("monSecurityDeposit")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxAmount)
                    .HasColumnName("monTaxAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalDeduction)
                    .HasColumnName("monTotalDeduction")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalPayableSalary)
                    .HasColumnName("monTotalPayableSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportAmount)
                    .HasColumnName("monTransportAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportBill)
                    .HasColumnName("monTransportBill")
                    .HasColumnType("money");

                entity.Property(e => e.NumMealRate)
                    .HasColumnName("numMealRate")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StrArea)
                    .HasColumnName("strArea")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrDepartment)
                    .HasColumnName("strDepartment")
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .HasColumnName("strDesignation")
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .HasColumnName("strJobType")
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .IsUnicode(false);

                entity.Property(e => e.StrPaymentType)
                    .HasColumnName("strPaymentType")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StrRegion)
                    .HasColumnName("strRegion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrStationType)
                    .HasColumnName("strStationType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrTeritory)
                    .HasColumnName("strTeritory")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBenifitBonus>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblBenifit_Bonus");

                entity.HasIndex(e => new { e.MonBonusAmount, e.IntBonusId, e.IntEmployeeId, e.IntMonthId, e.IntYearId })
                    .HasName("Dec_12_2017_10_04_19_270AM");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntBonusId).HasColumnName("intBonusId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthId");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.IntYearId).HasColumnName("intYearId");

                entity.Property(e => e.MonBonusAmount)
                    .HasColumnName("monBonusAmount")
                    .HasColumnType("money");

                entity.Property(e => e.YsnPaid).HasColumnName("ysnPaid");
            });

            modelBuilder.Entity<TblBenifitBonus1>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblBenifit_Bonus1");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.AreaBonus).HasColumnType("money");

                entity.Property(e => e.IntBonusId).HasColumnName("intBonusId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthId");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.IntYearId).HasColumnName("intYearId");

                entity.Property(e => e.MonBonusAmount)
                    .HasColumnName("monBonusAmount")
                    .HasColumnType("money");

                entity.Property(e => e.PreBonus).HasColumnType("money");

                entity.Property(e => e.YsnPaid).HasColumnName("ysnPaid");
            });

            modelBuilder.Entity<TblBenifitBonusGenerationHistory>(entity =>
            {
                entity.HasKey(e => e.IntBonusHistoryId);

                entity.ToTable("tblBenifit_BonusGenerationHistory");

                entity.Property(e => e.IntBonusHistoryId).HasColumnName("intBonusHistoryId");

                entity.Property(e => e.DteEffectedDate)
                    .HasColumnName("dteEffectedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteGenerationDate)
                    .HasColumnName("dteGenerationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntBonusId).HasColumnName("intBonusID");

                entity.Property(e => e.IntGeneratedBy).HasColumnName("intGeneratedBy");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthId");

                entity.Property(e => e.IntYearId).HasColumnName("intYearId");
            });

            modelBuilder.Entity<TblBenifitBonusSetup>(entity =>
            {
                entity.HasKey(e => e.IntBonusId);

                entity.ToTable("tblBenifit_BonusSetup");

                entity.Property(e => e.IntBonusId).HasColumnName("intBonusId");

                entity.Property(e => e.IntMinimumServiceMonthFullBonus).HasColumnName("intMinimumServiceMonth_FullBonus");

                entity.Property(e => e.IntMinimumServiceMonthShortBonus).HasColumnName("intMinimumServiceMonth_ShortBonus");

                entity.Property(e => e.IntNumberOfMonthToBePaidAtAtimeFullBonus).HasColumnName("intNumberOfMonthToBePaidAtATime_FullBonus");

                entity.Property(e => e.IntNumberOfMonthToBePaidAtAtimeShortBonus).HasColumnName("intNumberOfMonthToBePaidAtATime_ShortBonus");

                entity.Property(e => e.IntReligionId).HasColumnName("intReligionID");

                entity.Property(e => e.StrBonusDescription)
                    .HasColumnName("strBonusDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBonusName)
                    .HasColumnName("strBonusName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBenifitEntry>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .HasName("PK_tblBenifitsEntry");

                entity.ToTable("tblBenifitEntry");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteInsertDate)
                    .HasColumnName("dteInsertDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntJobStation).HasColumnName("intJobStation");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblBreak>(entity =>
            {
                entity.HasKey(e => e.IntBreakId);

                entity.ToTable("tblBreak");

                entity.Property(e => e.IntBreakId).HasColumnName("intBreakID");

                entity.Property(e => e.IntJobSatationId).HasColumnName("intJobSatationID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrBreakName)
                    .HasColumnName("strBreakName")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TimeBreakEnd).HasColumnName("timeBreakEnd");

                entity.Property(e => e.TimeBreakStart).HasColumnName("timeBreakStart");

                entity.Property(e => e.YsnFixed).HasColumnName("ysnFixed");

                entity.Property(e => e.YsnPunishmentAllowed).HasColumnName("ysnPunishmentAllowed");

                entity.Property(e => e.YsnRewordAllowed).HasColumnName("ysnRewordAllowed");
            });

            modelBuilder.Entity<TblBreakExtra>(entity =>
            {
                entity.HasKey(e => e.IntAutoIncId);

                entity.ToTable("tblBreakExtra");

                entity.Property(e => e.IntAutoIncId).HasColumnName("intAutoIncId");

                entity.Property(e => e.DteExBrkDate)
                    .HasColumnName("dteExBrkDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationId");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrReason)
                    .HasColumnName("strReason")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeExBrkEnd).HasColumnName("timeExBrkEnd");

                entity.Property(e => e.TimeExBrkStart).HasColumnName("timeExBrkStart");
            });

            modelBuilder.Entity<TblBreakLateCount>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblBreakLateCount");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntBreakId).HasColumnName("intBreakId");

                entity.Property(e => e.IntDayId).HasColumnName("intDayId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthId");

                entity.Property(e => e.IntYear).HasColumnName("intYear");

                entity.Property(e => e.TimeBreakLate).HasColumnName("timeBreakLate");

                entity.Property(e => e.YsnBreakLate).HasColumnName("ysnBreakLate");

                entity.Property(e => e.YsnExBreak).HasColumnName("ysnExBreak");
            });

            modelBuilder.Entity<TblBreakMoneytaryPunishment>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblBreakMoneytaryPunishment");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.IntBreakId).HasColumnName("intBreakID");

                entity.Property(e => e.IntDutycatagory).HasColumnName("intDutycatagory");

                entity.Property(e => e.NumDaysForApplicable).HasColumnName("numDaysForApplicable");

                entity.Property(e => e.NumDaysForDeduction).HasColumnName("numDaysForDeduction");

                entity.Property(e => e.NumHoursForApplicable).HasColumnName("numHoursForApplicable");

                entity.Property(e => e.NumHoursForDeduction).HasColumnName("numHoursForDeduction");

                entity.Property(e => e.YsnHourly).HasColumnName("ysnHourly");

                entity.Property(e => e.YsnLetterIssueEnable).HasColumnName("ysnLetterIssueEnable");
            });

            modelBuilder.Entity<TblCafeteria>(entity =>
            {
                entity.HasKey(e => e.IntRow);

                entity.ToTable("tblCafeteria");

                entity.HasIndex(e => new { e.IntGroup, e.IntEnroll })
                    .HasName("Feb_2_2018_11_03_26_113PM");

                entity.HasIndex(e => new { e.IntMealOption, e.StrNarration, e.IntActionBy, e.DteAction, e.IntRow, e.IntEnroll, e.IntGroup, e.IntType })
                    .HasName("May_4_2018_11_00_12_007PM");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntGroup).HasColumnName("intGroup");

                entity.Property(e => e.IntMealOption).HasColumnName("intMealOption");

                entity.Property(e => e.IntType).HasColumnName("intType");

                entity.Property(e => e.StrNarration)
                    .HasColumnName("strNarration")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCafeteriaDetails>(entity =>
            {
                entity.HasKey(e => e.IntRow)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblCafeteriaDetails");

                entity.HasIndex(e => new { e.IntEnroll, e.DteMeal, e.IntCountMeal })
                    .HasName("Jun_12_2018_3_49_08_833AM");

                entity.HasIndex(e => new { e.IntCountMeal, e.StrNarration, e.IntEnroll, e.DteMeal })
                    .HasName("Jan_5_2018_11_00_48_640PM");

                entity.HasIndex(e => new { e.DteMeal, e.IntCountMeal, e.StrNarration, e.IntEnroll, e.IntSpendMeal })
                    .HasName("Feb_2_2018_11_00_29_623PM");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteMeal)
                    .HasColumnName("dteMeal")
                    .HasColumnType("date");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntCountMeal).HasColumnName("intCountMeal");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntMealFor).HasColumnName("intMealFor");

                entity.Property(e => e.IntSpendMeal).HasColumnName("intSpendMeal");

                entity.Property(e => e.IsOwnGuest).HasColumnName("isOwnGuest");

                entity.Property(e => e.IsPayable).HasColumnName("isPayable");

                entity.Property(e => e.StrNarration)
                    .HasColumnName("strNarration")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.YsnMenualEntry).HasColumnName("ysnMenualEntry");
            });

            modelBuilder.Entity<TblCafeteriaRate>(entity =>
            {
                entity.HasKey(e => e.IntRow);

                entity.ToTable("tblCafeteriaRate");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteFrom)
                    .HasColumnName("dteFrom")
                    .HasColumnType("date");

                entity.Property(e => e.DteTo)
                    .HasColumnName("dteTo")
                    .HasColumnType("date");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StrGroup)
                    .HasColumnName("strGroup")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrNarration)
                    .HasColumnName("strNarration")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCasualSalary>(entity =>
            {
                entity.HasKey(e => new { e.IntEmpId, e.DteDate, e.IntProductId });

                entity.ToTable("tblCasualSalary");

                entity.HasIndex(e => new { e.IntEmpId, e.DteDate, e.IntWorkCount, e.IntProductId, e.IntUnitId })
                    .HasName("Jun_12_2018_3_49_10_620AM");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("date");

                entity.Property(e => e.IntProductId).HasColumnName("intProductID");

                entity.Property(e => e.IntId)
                    .HasColumnName("intID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntWorkCount).HasColumnName("intWorkCount");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblCasualSalaryForDti>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblCasualSalaryForDTI");

                entity.Property(e => e.IntId)
                    .HasColumnName("intID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntDeptId).HasColumnName("intDeptID");

                entity.Property(e => e.IntDesigId).HasColumnName("intDesigID");

                entity.Property(e => e.IntEmplId).HasColumnName("intEmplID");

                entity.Property(e => e.IntGroupId).HasColumnName("intGroupID");

                entity.Property(e => e.IntJobType).HasColumnName("intJobType");

                entity.Property(e => e.IntNightDuty).HasColumnName("intNightDuty");

                entity.Property(e => e.IntTotalAbsent).HasColumnName("intTotalAbsent");

                entity.Property(e => e.IntTotalPresent).HasColumnName("intTotalPresent");

                entity.Property(e => e.IntWorkingDays).HasColumnName("intWorkingDays");

                entity.Property(e => e.MonNetPayableSalary)
                    .HasColumnName("monNetPayableSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonOthour)
                    .HasColumnName("monOTHour")
                    .HasColumnType("money");

                entity.Property(e => e.MonPerHourSalary)
                    .HasColumnName("monPerHourSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalDutyHour)
                    .HasColumnName("monTotalDutyHour")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalHour)
                    .HasColumnName("monTotalHour")
                    .HasColumnType("money");

                entity.Property(e => e.StrBankAccountNo)
                    .IsRequired()
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankName)
                    .IsRequired()
                    .HasColumnName("strBankName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrBranchName)
                    .IsRequired()
                    .HasColumnName("strBranchName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrDeptName)
                    .IsRequired()
                    .HasColumnName("strDeptName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesigName)
                    .IsRequired()
                    .HasColumnName("strDesigName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrDistrict)
                    .IsRequired()
                    .HasColumnName("strDistrict")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeCode)
                    .IsRequired()
                    .HasColumnName("strEmployeeCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeName)
                    .IsRequired()
                    .HasColumnName("strEmployeeName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGroupName)
                    .IsRequired()
                    .HasColumnName("strGroupName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .IsRequired()
                    .HasColumnName("strJobType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrRoutingNo)
                    .IsRequired()
                    .HasColumnName("strRoutingNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblConfidential>(entity =>
            {
                entity.HasKey(e => e.IntConfidentialId);

                entity.ToTable("tblConfidential");

                entity.Property(e => e.IntConfidentialId).HasColumnName("intConfidentialId");

                entity.Property(e => e.DteLastUpdate)
                    .HasColumnName("dteLastUpdate")
                    .HasColumnType("date");

                entity.Property(e => e.DteSubmitted)
                    .HasColumnName("dteSubmitted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteViewedByDeptHead)
                    .HasColumnName("dteViewedByDeptHead")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteViewedByHr)
                    .HasColumnName("dteViewedByHR")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteViewedByMd)
                    .HasColumnName("dteViewedByMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntExpOtherCompany).HasColumnName("intExpOtherCompany");

                entity.Property(e => e.StrCommentOfDept)
                    .HasColumnName("strCommentOfDept")
                    .IsUnicode(false);

                entity.Property(e => e.StrCommentOfHr)
                    .HasColumnName("strCommentOfHR")
                    .IsUnicode(false);

                entity.Property(e => e.StrCommentOfMd)
                    .HasColumnName("strCommentOfMD")
                    .IsUnicode(false);

                entity.Property(e => e.StrComments)
                    .HasColumnName("strComments")
                    .IsUnicode(false);

                entity.Property(e => e.StrDeptheadSignUrl)
                    .HasColumnName("strDeptheadSignUrl")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmpSignUrl)
                    .HasColumnName("strEmpSignUrl")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrHrsignUrl)
                    .HasColumnName("strHRSignUrl")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrLongTerm)
                    .HasColumnName("strLongTerm")
                    .IsUnicode(false);

                entity.Property(e => e.StrMdsignUrl)
                    .HasColumnName("strMDSignUrl")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrPerformanceLevel)
                    .HasColumnName("strPerformanceLevel")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrPotential)
                    .HasColumnName("strPotential")
                    .IsUnicode(false);

                entity.Property(e => e.StrPreferenceTowork)
                    .HasColumnName("strPreferenceTowork")
                    .IsUnicode(false);

                entity.Property(e => e.StrSelfDevelopment)
                    .HasColumnName("strSelfDevelopment")
                    .IsUnicode(false);

                entity.Property(e => e.StrShortTerm)
                    .HasColumnName("strShortTerm")
                    .IsUnicode(false);

                entity.Property(e => e.StrTaskTarget)
                    .HasColumnName("strTaskTarget")
                    .IsUnicode(false);

                entity.Property(e => e.YsnRelocate).HasColumnName("ysnRelocate");

                entity.Property(e => e.YsnViewedByDeptHead).HasColumnName("ysnViewedByDeptHead");

                entity.Property(e => e.YsnViewedByHr).HasColumnName("ysnViewedByHR");

                entity.Property(e => e.YsnViewedByMd).HasColumnName("ysnViewedByMD");
            });

            modelBuilder.Entity<TblCourier>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblCourier");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.StrCourier)
                    .IsRequired()
                    .HasColumnName("strCourier")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.IntDepartmentId);

                entity.ToTable("tblDepartment");

                entity.Property(e => e.IntDepartmentId).HasColumnName("intDepartmentID");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntLastActionBy).HasColumnName("intLastActionBy");

                entity.Property(e => e.IntSection).HasColumnName("intSection");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrDepatrment)
                    .IsRequired()
                    .HasColumnName("strDepatrment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblDocDispatch>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblDocDispatch");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntDeliveryThruId).HasColumnName("intDeliveryThruID");

                entity.Property(e => e.IntDocNameId).HasColumnName("intDocNameID");

                entity.Property(e => e.StrDeliveryType)
                    .IsRequired()
                    .HasColumnName("strDeliveryType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocType)
                    .IsRequired()
                    .HasColumnName("strDocType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrFcompany)
                    .HasColumnName("strFCompany")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrFcompanyAdd)
                    .HasColumnName("strFCompanyAdd")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrFcompanyPhone)
                    .HasColumnName("strFCompanyPhone")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrFemail)
                    .HasColumnName("strFEmail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrFmobile)
                    .HasColumnName("strFMobile")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrFname)
                    .HasColumnName("strFName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTcompany)
                    .HasColumnName("strTCompany")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTcompanyAdd)
                    .HasColumnName("strTCompanyAdd")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTcompanyPhone)
                    .HasColumnName("strTCompanyPhone")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTemail)
                    .HasColumnName("strTEmail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTmobile)
                    .HasColumnName("strTMobile")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTname)
                    .HasColumnName("strTName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTrakingNo)
                    .HasColumnName("strTrakingNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");

                entity.Property(e => e.YsnMailSend).HasColumnName("ysnMailSend");

                entity.Property(e => e.YsnReceive).HasColumnName("ysnReceive");
            });

            modelBuilder.Entity<TblDocName>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblDocName");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.StrDocName)
                    .IsRequired()
                    .HasColumnName("strDocName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblDutyCatagory>(entity =>
            {
                entity.HasKey(e => e.IntDutyCatId);

                entity.ToTable("tblDutyCatagory");

                entity.Property(e => e.IntDutyCatId).HasColumnName("intDutyCatID");

                entity.Property(e => e.StrDutyCatagory)
                    .HasColumnName("strDutyCatagory")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnShiffting).HasColumnName("ysnShiffting");
            });

            modelBuilder.Entity<TblEmpElinfo>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblEmpELInfo");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.IntAvailableEl)
                    .HasColumnName("intAvailableEL")
                    .HasComputedColumnSql("([intELDays]-[intTakenELDays])");

                entity.Property(e => e.IntEldays).HasColumnName("intELDays");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntTakenEldays).HasColumnName("intTakenELDays");

                entity.Property(e => e.IntYear).HasColumnName("intYear");

                entity.Property(e => e.MonBasic)
                    .HasColumnName("monBasic")
                    .HasColumnType("money");

                entity.Property(e => e.MonElamount)
                    .HasColumnName("monELAmount")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(([intELDays]-[intTakenELDays])*[monBasic])");

                entity.Property(e => e.MonGross)
                    .HasColumnName("monGross")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblEmpOverTime>(entity =>
            {
                entity.HasKey(e => new { e.IntEmpId, e.DteDate });

                entity.ToTable("tblEmpOverTime");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteEndTime).HasColumnName("dteEndTime");

                entity.Property(e => e.DteInsertTime)
                    .HasColumnName("dteInsertTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteStartTime).HasColumnName("dteStartTime");

                entity.Property(e => e.DteUpdateDate)
                    .HasColumnName("dteUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntId)
                    .HasColumnName("intID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntJobStation).HasColumnName("intJobStation");

                entity.Property(e => e.IntOtType).HasColumnName("intOtType");

                entity.Property(e => e.IntOtcount).HasColumnName("intOTCount");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntUpdateBy).HasColumnName("intUpdateBy");

                entity.Property(e => e.IntVersion).HasColumnName("intVersion");

                entity.Property(e => e.MonHour)
                    .HasColumnName("monHour")
                    .HasColumnType("money");

                entity.Property(e => e.StrInsertIp)
                    .IsRequired()
                    .HasColumnName("strInsertIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPurpose)
                    .IsRequired()
                    .HasColumnName("strPurpose")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TmDuration).HasColumnName("tmDuration");
            });

            modelBuilder.Entity<TblEmpPlel>(entity =>
            {
                entity.HasKey(e => new { e.IntEnroll, e.IntYear })
                    .HasName("PK_tblEmpPFEL");

                entity.ToTable("tblEmpPLEL");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntYear).HasColumnName("intYear");

                entity.Property(e => e.DteLeaveTakenDate)
                    .HasColumnName("dteLeaveTakenDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteTakenDate)
                    .HasColumnName("dteTakenDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntId)
                    .HasColumnName("intID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.MonPlelammount)
                    .HasColumnName("monPLELAmmount")
                    .HasColumnType("money");

                entity.Property(e => e.YsnPleltaken).HasColumnName("ysnPLELTaken");
            });

            modelBuilder.Entity<TblEmpTada>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmpTADA");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteAdviceDate)
                    .HasColumnName("dteAdviceDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteInsertTime)
                    .HasColumnName("dteInsertTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.MonAdviceAmount)
                    .HasColumnName("monAdviceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.StrInsertIp)
                    .IsRequired()
                    .HasColumnName("strInsertIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmpTransferPromotion>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmpTransferPromotion");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DteFromDate)
                    .HasColumnName("dteFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteInsertDate)
                    .HasColumnName("dteInsertDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteToDate)
                    .HasColumnName("dteToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntDepartment).HasColumnName("intDepartment");

                entity.Property(e => e.IntDesignation).HasColumnName("intDesignation");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.IntFggroupId).HasColumnName("intFGGroupID");

                entity.Property(e => e.IntGeoId).HasColumnName("intGeoID");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntJobstation).HasColumnName("intJobstation");

                entity.Property(e => e.IntLevelId).HasColumnName("intLevelID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(500);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.IntEmployeeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployee");

                entity.HasIndex(e => e.StrMobileImeno)
                    .HasName("Jun_12_2018_3_50_05_240AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.IntPresentShiftId })
                    .HasName("<EmpIndex-01>");

                entity.HasIndex(e => new { e.IntSuperviserId, e.YsnActive })
                    .HasName("Dec_11_2017_10_52_24_407AM");

                entity.HasIndex(e => new { e.StrEmployeeCode, e.YsnActive })
                    .HasName("Dec_11_2017_10_50_21_687AM");

                entity.HasIndex(e => new { e.StrSortName, e.YsnActive })
                    .HasName("Dec_11_2017_11_01_24_527AM");

                entity.HasIndex(e => new { e.StrOfficeEmail, e.IntDepartmentId, e.YsnActive })
                    .HasName("Dec_11_2017_11_00_07_890AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeCode, e.StrEmployeeName, e.IntJobTypeId, e.IntSuperviserId })
                    .HasName("Dec_11_2017_11_04_16_967AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeName, e.IntDepartmentId, e.IntUnitId, e.IntJobStationId })
                    .HasName("Dec_11_2017_11_14_25_583AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeName, e.IntJobStationId, e.IntDesignationId, e.IntSuperviserId })
                    .HasName("IX_Feb 11_05_48_00_PM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeName, e.IntJobStationId, e.IntDesignationId, e.IntUnitId })
                    .HasName("Dec_11_2017_11_45_59_823AM");

                entity.HasIndex(e => new { e.IntGroupId, e.IntJobStationId, e.IntJobTypeId, e.IntDayOffId, e.IntEmployeeId })
                    .HasName("Feb_02_2018_02_50_00_PM");

                entity.HasIndex(e => new { e.StrEmployeeCode, e.StrOfficeEmail, e.YsnActive, e.StrEmployeeName, e.IntEmployeeId })
                    .HasName("Feb_2_2018_05_36_00_PM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeCode, e.StrEmployeeName, e.IntDesignationId, e.IntJobStationId, e.YsnActive })
                    .HasName("Dec_11_2017_11_05_17_257AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeCode, e.StrEmployeeName, e.IntDesignationId, e.StrOfficeEmail, e.IntUnitId, e.YsnActive })
                    .HasName("May_4_2018_11_00_21_403PM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeName, e.IntBankId, e.IntDistrictId, e.IntBranchId, e.IntWorkCenterId, e.IntJobStationId, e.YsnActive })
                    .HasName("Dec_11_2017_7_07_07_973AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.IntJobStationId, e.StrOfficeEmail, e.IntBankId, e.IntDistrictId, e.IntBranchId, e.IntWorkCenterId, e.IntJobTypeId, e.YsnActive })
                    .HasName("Dec_11_2017_7_07_36_860AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeName, e.IntJobStationId, e.IntDesignationId, e.IntDepartmentId, e.IntGroupId, e.IntUnitId, e.YsnActive, e.StrPaymentType })
                    .HasName("Dec_11_2017_11_09_34_067AM");

                entity.HasIndex(e => new { e.MonSalary, e.IntBankId, e.IntBranchId, e.IntWorkCenterId, e.IntEmployeeId, e.IntUnitId, e.YsnActive, e.YsnSalaryHold, e.IntJobStationId, e.DteJoiningDate, e.StrPaymentType })
                    .HasName("<Index-03, sysname,>");

                entity.HasIndex(e => new { e.IntBankId, e.IntBranchId, e.IntWorkCenterId, e.IntEmployeeId, e.StrEmployeeName, e.IntUnitId, e.IntJobStationId, e.IntJobTypeId, e.IntDesignationId, e.IntDepartmentId, e.DteJoiningDate, e.YsnActive, e.IntGroupId })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.IntEmployeeId, e.StrEmployeeCode, e.StrEmployeeName, e.IntGroupId, e.IntUnitId, e.MonBasic, e.IntJobTypeId, e.IntDesignationId, e.IntDepartmentId, e.MonSalary, e.IntBankId, e.IntDistrictId, e.IntBranchId, e.IntWorkCenterId, e.IntJobStationId, e.YsnActive, e.YsnSalaryHold })
                    .HasName("Dec_11_2017_4_58_15_610PM");

                entity.HasIndex(e => new { e.IntJobStationId, e.IntJobTypeId, e.IntDesignationId, e.IntDepartmentId, e.IntDutyCatagoryId, e.IntPresentShiftId, e.IntDayOffId, e.StrEmployeePunchCardCode, e.StrContactPeriod, e.IntSuperviserId, e.DteJoiningDate, e.DteAppointmentDate, e.StrResponsibility, e.StrBloodGroup, e.StrOfficeEmail, e.StrBankAccountNo, e.MonSalary, e.StrNationalId, e.StrGender, e.IntSoftwareLoginUserId, e.YsnActive, e.StrBankName, e.TimeOfficeHour, e.MonBasic, e.YsnSalaryHold, e.StrPermanentAddress, e.StrPresentAddress, e.StrContactNo1, e.StrContactNo2, e.StrEmpImageUrl, e.StrEmployeeCodePrevious, e.StrPaymentType, e.IntReligionId, e.IntDepot, e.IntBankId, e.IntDistrictId, e.IntBranchId, e.StrFirstName, e.StrMiddleName, e.StrLastName, e.StrAlias, e.StrOrganisationUnit, e.StrManager, e.StrCountry, e.StrCity, e.StrMailBox, e.StrPassword, e.StrIpphone, e.IntWorkCenterId, e.DteBirth, e.StrGlcode, e.DteConfirmation, e.DteResign, e.StrFloorAccess, e.IntEmployeeId, e.StrEmployeeCode, e.IntAppTypeId, e.StrEmployeeName, e.StrSortName, e.IntGroupId, e.IntUnitId })
                    .HasName("<HolidayIndex1, sysname,>");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.DteAppointmentDate)
                    .HasColumnName("dteAppointmentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteBirth)
                    .HasColumnName("dteBirth")
                    .HasColumnType("date");

                entity.Property(e => e.DteConfirmation)
                    .HasColumnName("dteConfirmation")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteJoiningDate)
                    .HasColumnName("dteJoiningDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteResign)
                    .HasColumnName("dteResign")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntAppTypeId).HasColumnName("intAppTypeId");

                entity.Property(e => e.IntBankId).HasColumnName("intBankId");

                entity.Property(e => e.IntBranchId).HasColumnName("intBranchId");

                entity.Property(e => e.IntDayOffId).HasColumnName("intDayOffId");

                entity.Property(e => e.IntDepartmentId).HasColumnName("intDepartmentID");

                entity.Property(e => e.IntDepot).HasColumnName("intDepot");

                entity.Property(e => e.IntDesignationId).HasColumnName("intDesignationID");

                entity.Property(e => e.IntDistrictId).HasColumnName("intDistrictId");

                entity.Property(e => e.IntDutyCatagoryId).HasColumnName("intDutyCatagoryID");

                entity.Property(e => e.IntGroupId).HasColumnName("intGroupID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeId");

                entity.Property(e => e.IntPersonalUseFuelRateType).HasColumnName("intPersonalUseFuelRateType");

                entity.Property(e => e.IntPresentShiftId).HasColumnName("intPresentShiftID");

                entity.Property(e => e.IntReligionId).HasColumnName("intReligionID");

                entity.Property(e => e.IntSoftwareLoginUserId).HasColumnName("intSoftwareLoginUserID");

                entity.Property(e => e.IntSuperviserId).HasColumnName("intSuperviserId");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntUseVheicleId).HasColumnName("intUseVheicleId");

                entity.Property(e => e.IntWorkCenterId).HasColumnName("intWorkCenterID");

                entity.Property(e => e.MonBasic)
                    .HasColumnName("monBasic")
                    .HasColumnType("money");

                entity.Property(e => e.MonPersonalMilageRate)
                    .HasColumnName("monPersonalMilageRate")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.StrAge)
                    .HasColumnName("strAge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrAlias)
                    .HasColumnName("strAlias")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrArchiveMailbox)
                    .HasColumnName("strArchiveMailbox")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankAccountNo)
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankName)
                    .HasColumnName("strBankName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrBloodGroup)
                    .HasColumnName("strBloodGroup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrBranchName)
                    .HasColumnName("strBranchName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrCity)
                    .HasColumnName("strCity")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrContactNo1)
                    .HasColumnName("strContactNo1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrContactNo2)
                    .HasColumnName("strContactNo2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrContactPeriod)
                    .HasColumnName("strContactPeriod")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrCountry)
                    .HasColumnName("strCountry")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink1)
                    .HasColumnName("strDocumentLink1")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink2)
                    .HasColumnName("strDocumentLink2")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink3)
                    .HasColumnName("strDocumentLink3")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink4)
                    .HasColumnName("strDocumentLink4")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink5)
                    .HasColumnName("strDocumentLink5")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink6)
                    .HasColumnName("strDocumentLink6")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink7)
                    .HasColumnName("strDocumentLink7")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink8)
                    .HasColumnName("strDocumentLink8")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentLink9)
                    .HasColumnName("strDocumentLink9")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDocumentType)
                    .HasColumnName("strDocumentType")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmergencyPersonRelation)
                    .HasColumnName("strEmergencyPersonRelation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmergencyPhoneNo)
                    .HasColumnName("strEmergencyPhoneNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmpImageUrl)
                    .HasColumnName("strEmpImageUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeCode)
                    .HasColumnName("strEmployeeCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeCodePrevious)
                    .HasColumnName("strEmployeeCodePrevious")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeName)
                    .HasColumnName("strEmployeeName")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeePunchCardCode)
                    .HasColumnName("strEmployeePunchCardCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrFirstName)
                    .HasColumnName("strFirstName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrFloorAccess)
                    .HasColumnName("strFloorAccess")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.StrGender)
                    .HasColumnName("strGender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrGlcode)
                    .HasColumnName("strGLCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrGovtEmployeeAddress)
                    .HasColumnName("strGovtEmployeeAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrGovtEmployeeDepartment)
                    .HasColumnName("strGovtEmployeeDepartment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrGovtEmployeeDesignation)
                    .HasColumnName("strGovtEmployeeDesignation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrGovtEmployeeName)
                    .HasColumnName("strGovtEmployeeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrGovtEmployeePhoneNo)
                    .HasColumnName("strGovtEmployeePhoneNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrGovtEmployeeRelation)
                    .HasColumnName("strGovtEmployeeRelation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrInstitute)
                    .HasColumnName("strInstitute")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrIpphone)
                    .HasColumnName("strIPPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrLastDegree)
                    .HasColumnName("strLastDegree")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrLastName)
                    .HasColumnName("strLastName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrLocalGuardianAddress)
                    .HasColumnName("strLocalGuardianAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrLocalGuardianName)
                    .HasColumnName("strLocalGuardianName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrLocalGuardianPhoneNo)
                    .HasColumnName("strLocalGuardianPhoneNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrLocalGuardianRelation)
                    .HasColumnName("strLocalGuardianRelation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrMailBox)
                    .HasColumnName("strMailBox")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrManager)
                    .HasColumnName("strManager")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrMiddleName)
                    .HasColumnName("strMiddleName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrMobileImeno)
                    .HasColumnName("strMobileIMENo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrNationalId)
                    .HasColumnName("strNationalId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrOfficeEmail)
                    .HasColumnName("strOfficeEmail")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrOrganisationUnit)
                    .HasColumnName("strOrganisationUnit")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrPassword)
                    .HasColumnName("strPassword")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrPaymentType)
                    .HasColumnName("strPaymentType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPermanentAddress)
                    .HasColumnName("strPermanentAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrPresentAddress)
                    .HasColumnName("strPresentAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrResponsibility)
                    .HasColumnName("strResponsibility")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrSalaryUnit)
                    .HasColumnName("strSalaryUnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrSortName)
                    .HasColumnName("strSortName")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StrSubjectName)
                    .HasColumnName("strSubjectName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrTinno)
                    .HasColumnName("strTINno")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOfficeHour).HasColumnName("timeOfficeHour");

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");

                entity.Property(e => e.YsnNewCardInstallation).HasColumnName("ysnNewCardInstallation");

                entity.Property(e => e.YsnSalaryHold).HasColumnName("ysnSalaryHold");
            });

            modelBuilder.Entity<TblEmployeeAttendance>(entity =>
            {
                entity.HasKey(e => e.IntAutoIncrement)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployeeAttendance");

                entity.HasIndex(e => e.IntMrsl)
                    .HasName("Jun_12_2018_3_50_19_627AM");

                entity.HasIndex(e => e.IntUserId)
                    .HasName("<AttIndex-01>");

                entity.HasIndex(e => new { e.DteAttendanceTime, e.IntEmployeeId, e.DteAttendanceDate })
                    .HasName("<Index-02, sysname,>");

                entity.HasIndex(e => new { e.IntEmployeeId, e.IntJobStationId, e.DteAttendanceDate })
                    .HasName("Jun_12_2018_3_48_30_430AM");

                entity.Property(e => e.IntAutoIncrement).HasColumnName("intAutoIncrement");

                entity.Property(e => e.DteAttendanceDate)
                    .HasColumnName("dteAttendanceDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteAttendanceTime).HasColumnName("dteAttendanceTime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntMrsl).HasColumnName("intMRSL");

                entity.Property(e => e.IntUserId).HasColumnName("intUserID");

                entity.Property(e => e.StrEmployeeBarcode)
                    .HasColumnName("strEmployeeBarcode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrRemark)
                    .HasColumnName("strRemark")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserIp)
                    .HasColumnName("strUserIP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeHoursEarlyLeave).HasColumnName("timeHoursEarlyLeave");

                entity.Property(e => e.TimeHoursLate).HasColumnName("timeHoursLate");

                entity.Property(e => e.YsnEaryLeave).HasColumnName("ysnEaryLeave");

                entity.Property(e => e.YsnLate).HasColumnName("ysnLate");

                entity.Property(e => e.YsnProcess).HasColumnName("ysnProcess");
            });

            modelBuilder.Entity<TblEmployeeAttendanceFloor>(entity =>
            {
                entity.HasKey(e => e.IntRow)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployeeAttendanceFloor");

                entity.Property(e => e.IntRow).HasColumnName("intRow");

                entity.Property(e => e.DteAttendanceDate)
                    .HasColumnName("dteAttendanceDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteAttendanceTime).HasColumnName("dteAttendanceTime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntMrsl).HasColumnName("intMRSL");

                entity.Property(e => e.IntUserId).HasColumnName("intUserID");

                entity.Property(e => e.StrRemark)
                    .HasColumnName("strRemark")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserIp)
                    .HasColumnName("strUserIP")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployeeAttendanceRemoteConfig>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeAttendanceRemoteConfig");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteAttDate)
                    .HasColumnName("dteAttDate")
                    .HasColumnType("date");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationId");

                entity.Property(e => e.TimeAttendance).HasColumnName("timeAttendance");
            });

            modelBuilder.Entity<TblEmployeeElinformation>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployeeELInformation");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteJoiningDate)
                    .HasColumnName("dteJoiningDate")
                    .HasColumnType("date");

                entity.Property(e => e.IntElamountYear2005).HasColumnName("intELAmountYear2005");

                entity.Property(e => e.IntElamountYear2006).HasColumnName("intELAmountYear2006");

                entity.Property(e => e.IntElamountYear2007).HasColumnName("intELAmountYear2007");

                entity.Property(e => e.IntElamountYear2008).HasColumnName("intELAmountYear2008");

                entity.Property(e => e.IntElamountYear2009).HasColumnName("intELAmountYear2009");

                entity.Property(e => e.IntElamountYear2010).HasColumnName("intELAmountYear2010");

                entity.Property(e => e.IntElamountYear2011).HasColumnName("intELAmountYear2011");

                entity.Property(e => e.IntElamountYear2012).HasColumnName("intELAmountYear2012");

                entity.Property(e => e.IntElamountYear2013).HasColumnName("intELAmountYear2013");

                entity.Property(e => e.IntElamountYear2014).HasColumnName("intELAmountYear2014");

                entity.Property(e => e.IntElremainingYear2005).HasColumnName("intELRemainingYear2005");

                entity.Property(e => e.IntElremainingYear2006).HasColumnName("intELRemainingYear2006");

                entity.Property(e => e.IntElremainingYear2007).HasColumnName("intELRemainingYear2007");

                entity.Property(e => e.IntElremainingYear2008).HasColumnName("intELRemainingYear2008");

                entity.Property(e => e.IntElremainingYear2009).HasColumnName("intELRemainingYear2009");

                entity.Property(e => e.IntElremainingYear2010).HasColumnName("intELRemainingYear2010");

                entity.Property(e => e.IntElremainingYear2011).HasColumnName("intELRemainingYear2011");

                entity.Property(e => e.IntElremainingYear2012).HasColumnName("intELRemainingYear2012");

                entity.Property(e => e.IntElremainingYear2013).HasColumnName("intELRemainingYear2013");

                entity.Property(e => e.IntElremainingYear2014).HasColumnName("intELRemainingYear2014");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntStationId).HasColumnName("intStationId");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrDepartment)
                    .HasColumnName("strDepartment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .HasColumnName("strDesignation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeName)
                    .HasColumnName("strEmployeeName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGroupName)
                    .HasColumnName("strGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .HasColumnName("strJobType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeeGroup>(entity =>
            {
                entity.HasKey(e => e.IntGroupId);

                entity.ToTable("tblEmployeeGroup");

                entity.Property(e => e.IntGroupId).HasColumnName("intGroupID");

                entity.Property(e => e.StrGroupName)
                    .HasColumnName("strGroupName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.YsnMangenentGroup).HasColumnName("ysnMangenentGroup");
            });

            modelBuilder.Entity<TblEmployeeGroupPermissionAttendance>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeGroupPermissionAttendance");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntGracePreodinMinute).HasColumnName("intGracePreodinMinute");

                entity.Property(e => e.IntGroupId).HasColumnName("intGroupID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeId");

                entity.Property(e => e.YsnFlexibleAttendance).HasColumnName("ysnFlexibleAttendance");

                entity.Property(e => e.YsnOverTimeHourly).HasColumnName("ysnOverTimeHourly");

                entity.Property(e => e.YsnOvertimeAllowed).HasColumnName("ysnOvertimeAllowed");
            });

            modelBuilder.Entity<TblEmployeeGroupPermissionBreak>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeGroupPermissionBreak");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntBreakId).HasColumnName("intBreakID");

                entity.Property(e => e.IntGroupId).HasColumnName("intGroupID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeId");

                entity.Property(e => e.IntShiftId).HasColumnName("intShiftID");

                entity.Property(e => e.TimeBreakDuration).HasColumnName("timeBreakDuration");
            });

            modelBuilder.Entity<TblEmployeeGroupPermissionHolidays>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeGroupPermissionHolidays");

                entity.HasIndex(e => new { e.DteFromDate, e.DteToDate, e.IntJobStationId, e.IntReligionId })
                    .HasName("Dec_11_2017_11_46_03_770AM");

                entity.HasIndex(e => new { e.IntGroupId, e.IntJobTypeId, e.IntJobStationId, e.DteFromDate, e.DteToDate })
                    .HasName("Dec_11_2017_11_17_56_580AM");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteFromDate)
                    .HasColumnName("dteFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtePermitedDate)
                    .HasColumnName("dtePermitedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteToDate)
                    .HasColumnName("dteToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntGroupId).HasColumnName("intGroupID");

                entity.Property(e => e.IntHolidayId).HasColumnName("intHolidayID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeId");

                entity.Property(e => e.IntReligionId).HasColumnName("intReligionId");
            });

            modelBuilder.Entity<TblEmployeeGroupPermissionLeave>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeGroupPermissionLeave");

                entity.HasIndex(e => new { e.IntLeaveTypeId, e.IntGroupId, e.IntJobStationId, e.IntJobTypeId })
                    .HasName("Dec_11_2017_10_50_43_363AM");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntGroupId).HasColumnName("intGroupID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeId");

                entity.Property(e => e.IntLeaveTypeId).HasColumnName("intLeaveTypeID");

                entity.Property(e => e.IntNumberOfLeave).HasColumnName("intNumberOfLeave");
            });

            modelBuilder.Entity<TblEmployeeGroupPermissionSalary>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeGroupPermissionSalary");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntGroupId).HasColumnName("intGroupID");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeId");

                entity.Property(e => e.NumBasicPercentance)
                    .HasColumnName("numBasicPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumHouseRentPercentance)
                    .HasColumnName("numHouseRentPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumMedicalAllowancePercentance)
                    .HasColumnName("numMedicalAllowancePercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumPfpercentance)
                    .HasColumnName("numPFPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumTaxPercentance)
                    .HasColumnName("numTaxPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumTransportPercentance)
                    .HasColumnName("numTransportPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YsnHourly).HasColumnName("ysnHourly");
            });

            modelBuilder.Entity<TblEmployeeHolidays>(entity =>
            {
                entity.HasKey(e => e.IntHolidayId);

                entity.ToTable("tblEmployeeHolidays");

                entity.Property(e => e.IntHolidayId).HasColumnName("intHolidayID");

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrHolidayName)
                    .HasColumnName("strHolidayName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeeInfoDetail>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeInfoDetail");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntPresentRoadNo)
                    .HasColumnName("intPresentRoadNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrFatherName)
                    .HasColumnName("strFatherName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrMotherName)
                    .HasColumnName("strMotherName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrPermanentDistrict)
                    .HasColumnName("strPermanentDistrict")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrPermanentPoliceStation)
                    .HasColumnName("strPermanentPoliceStation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrPermanentPostOffice)
                    .HasColumnName("strPermanentPostOffice")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrPermanentVillage)
                    .HasColumnName("strPermanentVillage")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrPresentDistrict)
                    .HasColumnName("strPresentDistrict")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrPresentHouseNo)
                    .HasColumnName("strPresentHouseNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrPresentPoliceStation)
                    .HasColumnName("strPresentPoliceStation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrPresentPostOffice)
                    .HasColumnName("strPresentPostOffice")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrSpouseName)
                    .HasColumnName("strSpouseName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployeeJobStation>(entity =>
            {
                entity.HasKey(e => e.IntEmployeeJobStationId);

                entity.ToTable("tblEmployeeJobStation");

                entity.HasIndex(e => e.IntAreaId)
                    .HasName("Dec_11_2017_4_57_02_730PM");

                entity.HasIndex(e => new { e.IntEmployeeJobStationId, e.StrStatus })
                    .HasName("May_4_2018_11_00_10_300PM");

                entity.HasIndex(e => new { e.StrStationAddress, e.IntEmployeeJobStationId })
                    .HasName("Dec_11_2017_10_50_19_903AM");

                entity.HasIndex(e => new { e.YsnActive, e.IntTeritory })
                    .HasName("Dec_12_2017_10_03_50_870AM");

                entity.HasIndex(e => new { e.IntEmployeeJobStationId, e.StrJobStationName, e.IntUnitId })
                    .HasName("Dec_11_2017_10_56_16_053AM");

                entity.HasIndex(e => new { e.IntEmployeeJobStationId, e.YsnActive, e.StrStatus })
                    .HasName("Dec_11_2017_10_59_13_593AM");

                entity.HasIndex(e => new { e.YsnActive, e.IntPrincipalDepot, e.IntEmployeeJobStationId })
                    .HasName("Dec_11_2017_3_19_57_867PM");

                entity.HasIndex(e => new { e.IntAreaId, e.YsnActive, e.IntUnitId, e.StrJobStationName })
                    .HasName("Dec_11_2017_4_59_29_977PM");

                entity.HasIndex(e => new { e.IntEmployeeJobStationId, e.StrJobStationName, e.IntSequence, e.YsnActive, e.IntRegionId })
                    .HasName("Feb_2_2018_11_00_06_067PM");

                entity.HasIndex(e => new { e.IntEmployeeJobStationId, e.StrJobStationName, e.YsnActive, e.IntUnitId, e.IntTeritory, e.IntStationType })
                    .HasName("Dec_11_2017_10_53_14_640AM");

                entity.HasIndex(e => new { e.IntEmployeeJobStationId, e.StrJobStationName, e.YsnActive, e.IntUnitId, e.StrStatus, e.IntStationType })
                    .HasName("Mar_2_2018_11_04_26_677PM");

                entity.HasIndex(e => new { e.StrJobStationName, e.StrStationAddress, e.YsnRoster, e.StrStatus, e.IntRegionId, e.IntAreaId, e.IntTeritory, e.IntStationType, e.IntTravelAndConveyId, e.IntEmployeeJobStationId })
                    .HasName("Feb_12_2018_05_30_00_PM");

                entity.Property(e => e.IntEmployeeJobStationId).HasColumnName("intEmployeeJobStationId");

                entity.Property(e => e.IntAreaId).HasColumnName("intAreaId");

                entity.Property(e => e.IntPrincipalDepot).HasColumnName("intPrincipalDepot");

                entity.Property(e => e.IntRegionId).HasColumnName("intRegionId");

                entity.Property(e => e.IntSequence).HasColumnName("intSequence");

                entity.Property(e => e.IntStationType).HasColumnName("intStationType");

                entity.Property(e => e.IntTeritory).HasColumnName("intTeritory");

                entity.Property(e => e.IntTravelAndConveyId).HasColumnName("intTravelAndConveyID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrJobStationName)
                    .HasColumnName("strJobStationName")
                    .HasMaxLength(250);

                entity.Property(e => e.StrRegion)
                    .HasColumnName("strRegion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrStationAddress)
                    .HasColumnName("strStationAddress")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.StrStatus)
                    .HasColumnName("strStatus")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");

                entity.Property(e => e.YsnDirect).HasColumnName("ysnDirect");

                entity.Property(e => e.YsnRoster).HasColumnName("ysnRoster");
            });

            modelBuilder.Entity<TblEmployeeJobStationReg>(entity =>
            {
                entity.HasKey(e => e.IntStationId);

                entity.ToTable("tblEmployeeJobStationReg");

                entity.Property(e => e.IntStationId).HasColumnName("intStationId");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrJobStationName)
                    .HasColumnName("strJobStationName")
                    .HasMaxLength(250);

                entity.Property(e => e.StrLongitudeX)
                    .HasColumnName("strLongitudeX")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrStationAddress)
                    .HasColumnName("strStationAddress")
                    .IsUnicode(false);

                entity.Property(e => e.StrlatitudeY)
                    .HasColumnName("strlatitudeY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeeOffDay>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeOffDay");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntDayOffId).HasColumnName("intDayOffId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeeOfficeHour>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeOfficeHour");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.StrReason).HasColumnName("strReason");

                entity.Property(e => e.TmDuty).HasColumnName("tmDuty");

                entity.Property(e => e.TmEnd).HasColumnName("tmEnd");

                entity.Property(e => e.TmLastPunch).HasColumnName("tmLastPunch");

                entity.Property(e => e.TmStart).HasColumnName("tmStart");
            });

            modelBuilder.Entity<TblEmployeeOfficeHourChange>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeOfficeHourChange");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteChange)
                    .HasColumnName("dteChange")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteFrom)
                    .HasColumnName("dteFrom")
                    .HasColumnType("date");

                entity.Property(e => e.DteTo)
                    .HasColumnName("dteTo")
                    .HasColumnType("date");

                entity.Property(e => e.IntChangeBy).HasColumnName("intChangeBy");

                entity.Property(e => e.IntEmpjobStationId).HasColumnName("intEmpjobStationId");

                entity.Property(e => e.IntShiftId).HasColumnName("intShiftId");

                entity.Property(e => e.StrReason)
                    .HasColumnName("strReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeEnd).HasColumnName("timeEnd");

                entity.Property(e => e.TimeStart).HasColumnName("timeStart");

                entity.Property(e => e.TmLastPunch).HasColumnName("tmLastPunch");
            });

            modelBuilder.Entity<TblEmployeeOvertime>(entity =>
            {
                entity.HasKey(e => e.IntAutoIncId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployeeOvertime");

                entity.Property(e => e.IntAutoIncId).HasColumnName("intAutoIncId");

                entity.Property(e => e.DteAssignDate)
                    .HasColumnName("dteAssignDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntOverTimeshiftId).HasColumnName("intOverTimeshiftId");

                entity.Property(e => e.IntPresentShiftId).HasColumnName("intPresentShiftId");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblEmployeeOvertimePayment>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeOvertimePayment");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteLastPaymentDate)
                    .HasColumnName("dteLastPaymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.MonBalance)
                    .HasColumnName("monBalance")
                    .HasColumnType("money");

                entity.Property(e => e.MonPayment)
                    .HasColumnName("monPayment")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotal)
                    .HasColumnName("monTotal")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblEmployeePerformBehavior>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblEmployeePerformBehavior");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.StrBehavior)
                    .HasColumnName("strBehavior")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeePerformJobDes>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeePerformJobDes");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DecWeight)
                    .HasColumnName("decWeight")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeePerformJobDesMarks>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeePerformJobDesMarks");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DecMarks)
                    .HasColumnName("decMarks")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteInsertDate)
                    .HasColumnName("dteInsertDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntReffJdc).HasColumnName("intReffJDC");

                entity.Property(e => e.IntType).HasColumnName("intType");

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeePerformanceGrades>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblEmployeePerformanceGrades");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.IntGradeUpper).HasColumnName("intGradeUpper");

                entity.Property(e => e.IntGradelower).HasColumnName("intGradelower");

                entity.Property(e => e.StrGrade)
                    .HasColumnName("strGrade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeePerformanceGrading>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployeePerformanceGrading");

                entity.HasIndex(e => new { e.DecGradeNumber, e.DteGradeFor, e.StrGrade, e.IntEnroll, e.IntTypeId })
                    .HasName("Feb_2_2018_11_00_28_270PM");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DecGradeNumber)
                    .HasColumnName("decGradeNumber")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DteGradeFor)
                    .HasColumnName("dteGradeFor")
                    .HasColumnType("date");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntGradeId).HasColumnName("intGradeID");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntInsertDate)
                    .HasColumnName("intInsertDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntTypeId).HasColumnName("intTypeID");

                entity.Property(e => e.StrGrade)
                    .HasColumnName("strGrade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeePerformanceGradingDetalis>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeePerformanceGradingDetalis");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DecExaminedMarks)
                    .HasColumnName("decExaminedMarks")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DecMarks)
                    .HasColumnName("decMarks")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteExmineDate)
                    .HasColumnName("dteExmineDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEnrollment).HasColumnName("intEnrollment");

                entity.Property(e => e.IntExaminedBy).HasColumnName("intExaminedBy");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntJobstation).HasColumnName("intJobstation");

                entity.Property(e => e.IntUnit).HasColumnName("intUnit");

                entity.Property(e => e.StrDescrption)
                    .HasColumnName("strDescrption")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployeePerformanceGradingType>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblEmployeePerformanceGradingType");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeeProfileEmpOfficialInfoGroup>(entity =>
            {
                entity.HasKey(e => e.IntFggroupId);

                entity.ToTable("tblEmployeeProfileEmpOfficialInfoGroup");

                entity.Property(e => e.IntFggroupId).HasColumnName("intFGGroupID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrEmpGroupName)
                    .HasColumnName("strEmpGroupName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployeeProfileTransferPromotion>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeProfileTransferPromotion");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DteFromDate)
                    .HasColumnName("dteFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DteToDate)
                    .HasColumnName("dteToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntDepartment).HasColumnName("intDepartment");

                entity.Property(e => e.IntDesignation).HasColumnName("intDesignation");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.IntFggroupId).HasColumnName("intFGGroupID");

                entity.Property(e => e.IntGeoId).HasColumnName("intGeoID");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntJobstation).HasColumnName("intJobstation");

                entity.Property(e => e.IntLevelId).HasColumnName("intLevelID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(500);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblEmployeePunishment>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployeePunishment");

                entity.HasIndex(e => new { e.IntAutoId, e.DteEffective, e.MonAmount, e.StrReason, e.IntEnroll })
                    .HasName("Feb_2_2018_11_05_50_963PM");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteEffective)
                    .HasColumnName("dteEffective")
                    .HasColumnType("date");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntPunishBy).HasColumnName("intPunishBy");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");

                entity.Property(e => e.StrPunishment)
                    .HasColumnName("strPunishment")
                    .IsUnicode(false);

                entity.Property(e => e.StrReason)
                    .HasColumnName("strReason")
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<TblEmployeeReward>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployeeReward");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteEffective)
                    .HasColumnName("dteEffective")
                    .HasColumnType("date");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntRewardBy).HasColumnName("intRewardBy");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");

                entity.Property(e => e.StrReason)
                    .HasColumnName("strReason")
                    .IsUnicode(false);

                entity.Property(e => e.StrReward)
                    .HasColumnName("strReward")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployeeSalary>(entity =>
            {
                entity.HasKey(e => e.IntEmpSalaryId);

                entity.ToTable("tblEmployeeSalary");

                entity.HasIndex(e => new { e.NumPfpercentance, e.IntEmployeeId })
                    .HasName("Dec_11_2017_10_50_37_717AM");

                entity.Property(e => e.IntEmpSalaryId).HasColumnName("intEmpSalaryID");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.MonBasicAmount)
                    .HasColumnName("monBasicAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAmount)
                    .HasColumnName("monHouseRentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMedicalAllowanceAmount)
                    .HasColumnName("monMedicalAllowanceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherAmount)
                    .HasColumnName("monOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfamount)
                    .HasColumnName("monPFAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxAmount)
                    .HasColumnName("monTaxAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxableAmount)
                    .HasColumnName("monTaxableAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalSalary)
                    .HasColumnName("monTotalSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportAmount)
                    .HasColumnName("monTransportAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NumBasicPercentance)
                    .HasColumnName("numBasicPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumHouseRentPercentance)
                    .HasColumnName("numHouseRentPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumMedicalAllowancePercentance)
                    .HasColumnName("numMedicalAllowancePercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumPfpercentance)
                    .HasColumnName("numPFPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumTaxPercentance)
                    .HasColumnName("numTaxPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumTransportPercentance)
                    .HasColumnName("numTransportPercentance")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblEmployeeSwap>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeSwap");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeIdDuty).HasColumnName("intEmployeeIdDuty");

                entity.Property(e => e.IntEmployeeIdOff).HasColumnName("intEmployeeIdOff");

                entity.Property(e => e.StrReason)
                    .HasColumnName("strReason")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployeeTeamBuild>(entity =>
            {
                entity.HasKey(e => e.IntTeamId);

                entity.ToTable("tblEmployeeTeamBuild");

                entity.HasIndex(e => new { e.IntTeamId, e.StrTeamName, e.IntJobStationId })
                    .HasName("May_4_2018_11_00_01_130PM");

                entity.HasIndex(e => new { e.IntTeamId, e.IntUnitId, e.IntJobStationId, e.YsnActive })
                    .HasName("Apr_6_2018_11_00_02_550PM");

                entity.Property(e => e.IntTeamId).HasColumnName("intTeamId");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrTeamName)
                    .HasColumnName("strTeamName")
                    .HasMaxLength(500);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblEmployeeTeamShift>(entity =>
            {
                entity.HasKey(e => e.IntShiftId);

                entity.ToTable("tblEmployeeTeamShift");

                entity.HasIndex(e => new { e.IntShiftId, e.IntSequenceId })
                    .HasName("<SftIndex-01>");

                entity.HasIndex(e => new { e.IntShiftId, e.StrShiftName, e.IntTeamId })
                    .HasName("Apr_6_2018_11_00_00_750PM");

                entity.Property(e => e.IntShiftId).HasColumnName("intShiftId");

                entity.Property(e => e.IntSequenceId).HasColumnName("intSequenceId");

                entity.Property(e => e.IntTeamId).HasColumnName("intTeamId");

                entity.Property(e => e.StrShiftName)
                    .HasColumnName("strShiftName")
                    .HasMaxLength(500);

                entity.Property(e => e.TmDuty).HasColumnName("tmDuty");

                entity.Property(e => e.TmLastPunch).HasColumnName("tmLastPunch");

                entity.Property(e => e.TmShiftEnd).HasColumnName("tmShiftEnd");

                entity.Property(e => e.TmShiftStart).HasColumnName("tmShiftStart");

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");

                entity.Property(e => e.YsnNight).HasColumnName("ysnNight");

                entity.Property(e => e.YsnRoster).HasColumnName("ysnRoster");
            });

            modelBuilder.Entity<TblEmployeeTeamShiftAssigned>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeTeamShiftAssigned");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntShiftId).HasColumnName("intShiftId");

                entity.Property(e => e.IntStationtId).HasColumnName("intStationtId");

                entity.Property(e => e.IntTeamId).HasColumnName("intTeamId");
            });

            modelBuilder.Entity<TblEmployeeTeamShiftRoster>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblEmployeeTeamShiftRoster");

                entity.HasIndex(e => new { e.IntEmployeeId, e.DteRosterDutyDate })
                    .HasName("Dec_11_2017_7_12_27_323AM");

                entity.HasIndex(e => new { e.IntPresentShiftId, e.IntJobStationId, e.DteRosterDutyDate, e.IntEmployeeId })
                    .HasName("Dec_11_2017_7_07_43_473AM");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteInsertDate)
                    .HasColumnName("dteInsertDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DteRosterDutyDate)
                    .HasColumnName("dteRosterDutyDate")
                    .HasColumnType("date");

                entity.Property(e => e.IntAssetId).HasColumnName("intAssetId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationId");

                entity.Property(e => e.IntPresentShiftId).HasColumnName("intPresentShiftId");

                entity.Property(e => e.IntShiftSequenceNo).HasColumnName("intShiftSequenceNo");

                entity.Property(e => e.YsnActive)
                    .HasColumnName("ysnActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.YsnConsecutive).HasColumnName("ysnConsecutive");

                entity.Property(e => e.YsnOverTime).HasColumnName("ysnOverTime");

                entity.Property(e => e.YsnRegular).HasColumnName("ysnRegular");
            });

            modelBuilder.Entity<TblEmployeeTeamShiftRosterManagementRoles>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeTeamShiftRosterManagementRoles");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntNextShiftId).HasColumnName("intNextShiftID");

                entity.Property(e => e.IntPresentShiftId).HasColumnName("intPresentShiftID");
            });

            modelBuilder.Entity<TblEmployeeTeamShiftRosterScheduleConfig>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblEmployeeTeamShiftRosterScheduleConfig");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteLastChangeDate)
                    .HasColumnName("dteLastChangeDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteNextChangeDate)
                    .HasColumnName("dteNextChangeDate")
                    .HasColumnType("date");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationId");

                entity.Property(e => e.IntNoOfDaysChange).HasColumnName("intNoOfDaysChange");

                entity.Property(e => e.IntTeamId).HasColumnName("intTeamId");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");
            });

            modelBuilder.Entity<TblEmployeeTeamShiftSequence>(entity =>
            {
                entity.HasKey(e => e.IntSequenceId);

                entity.ToTable("tblEmployeeTeamShiftSequence");

                entity.Property(e => e.IntSequenceId).HasColumnName("intSequenceId");

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(500);

                entity.Property(e => e.StrSequenceName)
                    .HasColumnName("strSequenceName")
                    .HasMaxLength(500);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblFloorName>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblFloorName");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblGlobalValue>(entity =>
            {
                entity.HasKey(e => e.StrKey);

                entity.ToTable("tblGlobalValue");

                entity.Property(e => e.StrKey)
                    .HasColumnName("strKey")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.StrValue)
                    .IsRequired()
                    .HasColumnName("strValue")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHeaderMessage>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblHeaderMessage");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.DteEndDate)
                    .HasColumnName("dteEndDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteInsertionTime)
                    .HasColumnName("dteInsertionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteModificationTime)
                    .HasColumnName("dteModificationTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteStartDate)
                    .HasColumnName("dteStartDate")
                    .HasColumnType("date");

                entity.Property(e => e.IntInsertedBy).HasColumnName("intInsertedBy");

                entity.Property(e => e.IntModifiedBy).HasColumnName("intModifiedBy");

                entity.Property(e => e.StrMessage)
                    .IsRequired()
                    .HasColumnName("strMessage")
                    .HasMaxLength(500);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblHrdataHistory>(entity =>
            {
                entity.HasKey(e => e.IntHistoryId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblHRDataHistory");

                entity.Property(e => e.IntHistoryId).HasColumnName("intHistoryID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntUserId).HasColumnName("intUserID");

                entity.Property(e => e.StrAction)
                    .HasColumnName("strAction")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .IsUnicode(false);

                entity.Property(e => e.StrTblName)
                    .HasColumnName("strTblName")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInternalApproval>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblInternalApproval");

                entity.HasIndex(e => e.IntInssertBy)
                    .HasName("Jan_5_2018_11_00_38_950PM");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteClose)
                    .HasColumnName("dteClose")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntDept).HasColumnName("intDept");

                entity.Property(e => e.IntInssertBy).HasColumnName("intInssertBy");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.MonTotalBill)
                    .HasColumnName("monTotalBill")
                    .HasColumnType("money");

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .IsUnicode(false);

                entity.Property(e => e.StrFtpFilePath)
                    .HasColumnName("strFtpFilePath")
                    .IsUnicode(false);

                entity.Property(e => e.StrSubJect)
                    .HasColumnName("strSubJect")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.YsnApprove).HasColumnName("ysnApprove");
            });

            modelBuilder.Entity<TblInternalApprovalCc>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblInternalApprovalCC");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntReffId).HasColumnName("IntReffID");
            });

            modelBuilder.Entity<TblInternalApprovalDetalis>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblInternalApprovalDetalis");

                entity.HasIndex(e => e.IntRefInternalApp)
                    .HasName("Dec_11_2017_3_17_44_623PM");

                entity.HasIndex(e => new { e.IntToEmp, e.Ysnactive, e.YsnView })
                    .HasName("Dec_11_2017_11_01_43_037AM");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntRefInternalApp).HasColumnName("intRefInternalApp");

                entity.Property(e => e.IntToEmp).HasColumnName("intToEmp");

                entity.Property(e => e.IntUnitId).HasColumnName("IntUnitID");

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .IsUnicode(false);

                entity.Property(e => e.StrFtpFilePath)
                    .HasColumnName("strFtpFilePath")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.YsnApprove).HasColumnName("ysnApprove");
            });

            modelBuilder.Entity<TblLeaveApplication>(entity =>
            {
                entity.HasKey(e => e.IntApplicationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblLeaveApplication");

                entity.HasIndex(e => e.IntEmployeeId)
                    .HasName("Dec_11_2017_10_50_46_120AM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.DateApprovedFromDate, e.DateApprovedToDate, e.YsnApproved })
                    .HasName("Jun_12_2018_3_50_09_187AM");

                entity.HasIndex(e => new { e.IntApplicationId, e.IntEmployeeId, e.DateApprovedFromDate, e.DateApprovedToDate, e.YsnApproved })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.IntLeaveTypeId, e.IntEmployeeId, e.DateApprovedFromDate, e.DateApprovedToDate, e.YsnApproved })
                    .HasName("<Index-01, sysname,>");

                entity.HasIndex(e => new { e.IntApplicationId, e.DateApplicationDate, e.DateAppliedFromDate, e.DateAppliedToDate, e.StrLeaveReason, e.StrAddressDuetoLeave, e.StrphoneDuetoLeave, e.SrtApprovedStatus, e.IntEmployeeId, e.IntLeaveTypeId })
                    .HasName("Feb_11_2018_03_15__00AM");

                entity.Property(e => e.IntApplicationId).HasColumnName("intApplicationId");

                entity.Property(e => e.DateApplicationDate)
                    .HasColumnName("dateApplicationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateAppliedFromDate)
                    .HasColumnName("dateAppliedFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateAppliedToDate)
                    .HasColumnName("dateAppliedToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateApprovedDate)
                    .HasColumnName("dateApprovedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateApprovedFromDate)
                    .HasColumnName("dateApprovedFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateApprovedToDate)
                    .HasColumnName("dateApprovedToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntApprovedBy).HasColumnName("intApprovedBy");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntLeaveTypeId).HasColumnName("intLeaveTypeID");

                entity.Property(e => e.IntPayStatus).HasColumnName("intPayStatus");

                entity.Property(e => e.IsPaid).HasColumnName("isPaid");

                entity.Property(e => e.SrtApprovedStatus)
                    .HasColumnName("srtApprovedStatus")
                    .HasMaxLength(5);

                entity.Property(e => e.StrAddressDuetoLeave)
                    .HasColumnName("strAddressDuetoLeave")
                    .HasMaxLength(150);

                entity.Property(e => e.StrLeaveReason)
                    .HasColumnName("strLeaveReason")
                    .HasMaxLength(250);

                entity.Property(e => e.StrphoneDuetoLeave)
                    .HasColumnName("strphoneDuetoLeave")
                    .HasMaxLength(150);

                entity.Property(e => e.TmEnd).HasColumnName("tmEnd");

                entity.Property(e => e.TmStart).HasColumnName("tmStart");

                entity.Property(e => e.YsnApproved).HasColumnName("ysnApproved");

                entity.Property(e => e.YsnHalfDayLeave).HasColumnName("ysnHalfDayLeave");

                entity.Property(e => e.YsnRejected).HasColumnName("ysnRejected");
            });

            modelBuilder.Entity<TblLeaveBalance>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblLeaveBalance");

                entity.HasIndex(e => e.IntEmployeeId)
                    .HasName("Mar_2_2018_11_06_15_040PM");

                entity.HasIndex(e => new { e.IntRemainingDays, e.IntLeaveTypeId, e.IntEmployeeId })
                    .HasName("Jan_5_2018_11_04_05_323PM");

                entity.HasIndex(e => new { e.IntBalanceDays, e.IntEmployeeId, e.IntLeaveTakenDays, e.IntAutoId, e.IntLeaveTypeId, e.IntRemainingDays })
                    .HasName("<Index-01, sysname,>");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntBalanceDays).HasColumnName("intBalanceDays");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntLeaveTakenDays).HasColumnName("intLeaveTakenDays");

                entity.Property(e => e.IntLeaveTypeId).HasColumnName("intLeaveTypeId");

                entity.Property(e => e.IntRemainingDays).HasColumnName("intRemainingDays");

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLeaveTypeSetup>(entity =>
            {
                entity.HasKey(e => e.IntLeaveTypeId);

                entity.ToTable("tblLeaveTypeSetup");

                entity.Property(e => e.IntLeaveTypeId).HasColumnName("intLeaveTypeID");

                entity.Property(e => e.IntCompanyPloicy).HasColumnName("intCompanyPloicy");

                entity.Property(e => e.IntMaxApplicationAtAMonth).HasColumnName("intMaxApplication_At_a_month");

                entity.Property(e => e.IntMaximumAllowedAtATime).HasColumnName("intMaximumAllowedAt_A_Time");

                entity.Property(e => e.StrApplicableFor)
                    .HasColumnName("strApplicableFor")
                    .HasMaxLength(10);

                entity.Property(e => e.StrLeaveType)
                    .HasColumnName("strLeaveType")
                    .HasMaxLength(150);

                entity.Property(e => e.YsnBalanceCheck).HasColumnName("ysnBalanceCheck");

                entity.Property(e => e.YsnHalfDayAllowed).HasColumnName("ysnHalfDayAllowed");

                entity.Property(e => e.YsnHaveMonthRestriction).HasColumnName("ysnHaveMonthRestriction");

                entity.Property(e => e.YsnOnlyOneTime).HasColumnName("ysnOnlyOneTime");
            });

            modelBuilder.Entity<TblLetterIssue>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblLetterIssue");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DteIssueDate)
                    .HasColumnName("dteIssueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtePrintDate)
                    .HasColumnName("dtePrintDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntLetterId).HasColumnName("intLetterId");
            });

            modelBuilder.Entity<TblLetterTypeConfigaration>(entity =>
            {
                entity.HasKey(e => e.IntLetterId)
                    .HasName("PK_tblHrLetter");

                entity.ToTable("tblLetterTypeConfigaration");

                entity.Property(e => e.IntLetterId).HasColumnName("intLetterId");

                entity.Property(e => e.StrCcto).HasColumnName("strCCTo");

                entity.Property(e => e.StrLetterName)
                    .HasColumnName("strLetterName")
                    .HasMaxLength(200);

                entity.Property(e => e.StrLetterSubject)
                    .HasColumnName("strLetterSubject")
                    .HasMaxLength(200);

                entity.Property(e => e.StrSigningAuthority)
                    .HasColumnName("strSigningAuthority")
                    .HasMaxLength(150);

                entity.Property(e => e.StrSigningAuthorityDesignation)
                    .HasColumnName("strSigningAuthorityDesignation")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblLoanApplicationM>(entity =>
            {
                entity.HasKey(e => e.IntLoanApplicationId);

                entity.ToTable("tblLoanApplicationM");

                entity.HasIndex(e => new { e.IntEmployeeId, e.YsnEnable })
                    .HasName("Apr_6_2018_11_00_07_123PM");

                entity.HasIndex(e => new { e.IntLoanApplicationId, e.IntEmployeeId, e.IntLoanTypeId, e.IntLoanAmount, e.IntNumberOfInstallment, e.DteApplicationDate, e.YsnApprove, e.YsnEnable })
                    .HasName("May_4_2018_11_00_13_630PM");

                entity.Property(e => e.IntLoanApplicationId).HasColumnName("intLoanApplicationId");

                entity.Property(e => e.DteApplicationDate)
                    .HasColumnName("dteApplicationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteApproveDate)
                    .HasColumnName("dteApproveDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteEffectiveDate)
                    .HasColumnName("dteEffectiveDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteRejectDate)
                    .HasColumnName("dteRejectDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntApproveBy).HasColumnName("intApproveBy");

                entity.Property(e => e.IntApproveLoanAmount).HasColumnName("intApproveLoanAmount");

                entity.Property(e => e.IntApproveNumberOfInstallment).HasColumnName("intApproveNumberOfInstallment");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntLoanAmount).HasColumnName("intLoanAmount");

                entity.Property(e => e.IntLoanTypeId).HasColumnName("intLoanTypeId");

                entity.Property(e => e.IntNumberOfInstallment).HasColumnName("intNumberOfInstallment");

                entity.Property(e => e.IntRejectBy).HasColumnName("intRejectBy");

                entity.Property(e => e.YsnApprove).HasColumnName("ysnApprove");

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");

                entity.Property(e => e.YsnLoanStatus).HasColumnName("ysnLoanStatus");
            });

            modelBuilder.Entity<TblLoanApplicationOld>(entity =>
            {
                entity.HasKey(e => e.IntLoanApplicationId)
                    .HasName("PK_tblLoanApplication");

                entity.ToTable("tblLoanApplication_Old");

                entity.HasIndex(e => new { e.IntEmployeeId, e.YsnLoanStatus })
                    .HasName("Dec_11_2017_11_33_56_933AM");

                entity.HasIndex(e => new { e.IntLoanApplicationId, e.IntEmployeeId, e.IntLoanAmount, e.IntNumberOfInstallment, e.DteApplicationDate, e.DteEffectiveDate, e.YsnApprove })
                    .HasName("Jan_5_2018_11_00_57_013PM");

                entity.HasIndex(e => new { e.IntLoanApplicationId, e.IntEmployeeId, e.IntLoanAmount, e.IntNumberOfInstallment, e.DteApplicationDate, e.IntApproveBy, e.IntApproveLoanAmount, e.IntApproveNumberOfInstallment, e.DteApproveDate, e.YsnLoanStatus, e.DteEffectiveDate, e.YsnApprove })
                    .HasName("Mar_2_2018_11_05_09_713PM");

                entity.Property(e => e.IntLoanApplicationId).HasColumnName("intLoanApplicationId");

                entity.Property(e => e.DteApplicationDate)
                    .HasColumnName("dteApplicationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteApproveDate)
                    .HasColumnName("dteApproveDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteEffectiveDate)
                    .HasColumnName("dteEffectiveDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntApproveBy).HasColumnName("intApproveBy");

                entity.Property(e => e.IntApproveLoanAmount).HasColumnName("intApproveLoanAmount");

                entity.Property(e => e.IntApproveNumberOfInstallment).HasColumnName("intApproveNumberOfInstallment");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntLoanAmount).HasColumnName("intLoanAmount");

                entity.Property(e => e.IntNumberOfInstallment).HasColumnName("intNumberOfInstallment");

                entity.Property(e => e.YsnApprove).HasColumnName("ysnApprove");

                entity.Property(e => e.YsnLoanStatus).HasColumnName("ysnLoanStatus");
            });

            modelBuilder.Entity<TblLoginInfoSalesProject>(entity =>
            {
                entity.HasKey(e => e.Intid);

                entity.ToTable("tblLoginInfoSalesProject");

                entity.Property(e => e.Intid).HasColumnName("intid");

                entity.Property(e => e.Dtedatetime)
                    .HasColumnName("dtedatetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.StrDevice)
                    .HasColumnName("strDevice")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrDeviceName)
                    .HasColumnName("strDeviceName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrIpaddress)
                    .HasColumnName("strIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrMacAddress)
                    .HasColumnName("strMacAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrRemarks)
                    .HasColumnName("strRemarks")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserEmail)
                    .HasColumnName("strUserEmail")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.StrUsertype)
                    .HasColumnName("strUsertype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMailPriorityType>(entity =>
            {
                entity.HasKey(e => e.IntPtiorityId);

                entity.ToTable("tblMailPriorityType");

                entity.Property(e => e.IntPtiorityId).HasColumnName("intPtiorityID");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntLastActionBy).HasColumnName("intLastActionBy");

                entity.Property(e => e.StrPriority)
                    .HasColumnName("strPriority")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblMailRecipientType>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblMailRecipientType");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntLastActionBy).HasColumnName("intLastActionBy");

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrRecipientTpe)
                    .HasColumnName("strRecipientTpe")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblMailTypeInfo>(entity =>
            {
                entity.HasKey(e => e.IntMailTypeId);

                entity.ToTable("tblMailTypeInfo");

                entity.Property(e => e.IntMailTypeId).HasColumnName("intMailTypeID");

                entity.Property(e => e.DteLastActionDate)
                    .HasColumnName("dteLastActionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntLastActionBy).HasColumnName("intLastActionBy");

                entity.Property(e => e.IntMailPriorityTypeId).HasColumnName("intMailPriorityTypeID");

                entity.Property(e => e.StrDescription).HasColumnName("strDescription");

                entity.Property(e => e.StrFromAddress)
                    .HasColumnName("strFromAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrFromPass)
                    .HasColumnName("strFromPass")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrMailTypeName)
                    .HasColumnName("strMailTypeName")
                    .HasMaxLength(10);

                entity.Property(e => e.StrMailTypeShortName)
                    .HasColumnName("strMailTypeShortName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnDaily).HasColumnName("ysnDaily");

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");

                entity.Property(e => e.YsnMonthLy).HasColumnName("ysnMonthLy");

                entity.Property(e => e.YsnWeekly).HasColumnName("ysnWeekly");
            });

            modelBuilder.Entity<TblMeetinMinutesPersonAttenName>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblMeetinMinutesPersonAttenName");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.IntEnroll).HasColumnName("intEnroll");

                entity.Property(e => e.IntIdReffTblMeeting).HasColumnName("intIdReffTblMeeting");

                entity.Property(e => e.IntInsertby).HasColumnName("intInsertby");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrDesignation)
                    .HasColumnName("strDesignation")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrPersonAttendName)
                    .HasColumnName("strPersonAttendName")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMeetingAgenda>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblMeetingAgenda");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.IntIdReffTblMeeting).HasColumnName("intIdReffTblMeeting");

                entity.Property(e => e.IntInsertby).HasColumnName("intInsertby");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrAgenda)
                    .HasColumnName("strAgenda")
                    .IsUnicode(false);

                entity.Property(e => e.StrPresenter)
                    .HasColumnName("strPresenter")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrTimeAlloted)
                    .HasColumnName("strTimeAlloted")
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMeetingMinutes>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblMeetingMinutes");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteMeetEndTime)
                    .HasColumnName("dteMeetEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteMeetStrtTime)
                    .HasColumnName("dteMeetStrtTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dtetime)
                    .HasColumnName("dtetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntInsertby).HasColumnName("intInsertby");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrCalledby)
                    .HasColumnName("strCalledby")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrLocation)
                    .HasColumnName("strLocation")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrMeetInfo)
                    .HasColumnName("strMeetInfo")
                    .IsUnicode(false);

                entity.Property(e => e.StrMeetTitle)
                    .HasColumnName("strMeetTitle")
                    .IsUnicode(false);

                entity.Property(e => e.StrObjective)
                    .HasColumnName("strObjective")
                    .IsUnicode(false);

                entity.Property(e => e.StrReffNo)
                    .HasColumnName("strReffNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMeetingMinutesNextSchedule>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblMeetingMinutesNextSchedule");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteTime)
                    .HasColumnName("dteTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntIdReffTblMeeting).HasColumnName("intIdReffTblMeeting");

                entity.Property(e => e.IntInsertby).HasColumnName("intInsertby");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrAgenda)
                    .HasColumnName("strAgenda")
                    .IsUnicode(false);

                entity.Property(e => e.StrParticipants)
                    .HasColumnName("strParticipants")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.YesnActive).HasColumnName("yesnActive");
            });

            modelBuilder.Entity<TblMeetingRoomAttendance>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblMeetingRoomAttendance");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteAtenDate)
                    .HasColumnName("dteAtenDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteEndTime).HasColumnName("dteEndTime");

                entity.Property(e => e.DteStartTime).HasColumnName("dteStartTime");

                entity.Property(e => e.IntConfScheduleId).HasColumnName("intConfScheduleId");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntLocationId).HasColumnName("intLocationId");

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblMettingMinutesDecissions>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblMettingMinutesDecissions");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.IntIdReffTblMeeting).HasColumnName("intIdReffTblMeeting");

                entity.Property(e => e.IntInsertby).HasColumnName("intInsertby");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.StrDecissions)
                    .HasColumnName("strDecissions")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMonth>(entity =>
            {
                entity.HasKey(e => e.IntMonthId);

                entity.ToTable("tblMonth");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthId");

                entity.Property(e => e.StrMonthName)
                    .HasColumnName("strMonthName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMonthlySalaryGenerate>(entity =>
            {
                entity.HasKey(e => new { e.IntEmpId, e.IntYearId, e.IntMonthId });

                entity.ToTable("tblMonthlySalaryGenerate");

                entity.HasIndex(e => new { e.IntUnitId, e.IntEmpId, e.StrName, e.StrStatus, e.IntMonthId, e.IntYearId, e.MonSalaryAllowancePayInCash })
                    .HasName("<Index-01, sysname,>");

                entity.HasIndex(e => new { e.IntUnitId, e.StrGlcode, e.StrCcname, e.IntNetPayableSalaryCoa, e.StrStatus, e.IntMonthId, e.IntYearId })
                    .HasName("Mar_2_2018_11_05_02_087PM");

                entity.HasIndex(e => new { e.StrDesignation, e.StrStatus, e.IntUnitId, e.MonSalary, e.MonTaxAmount, e.MonLoanAmount, e.MonCoinAmount, e.StrUnit, e.IntMonthId, e.IntYearId, e.MonNetPayableSalary })
                    .HasName("Dec_11_2017_3_19_52_117PM");

                entity.HasIndex(e => new { e.MonPfemployeeContribution, e.MonPfemployerContribution, e.MonGratuity, e.MonLoan, e.IntEmpId, e.StrName, e.StrGroupName, e.StrJobType, e.StrDepartment, e.StrDesignation, e.DteJoining, e.StrServiceLength, e.StrOfficeEmail, e.StrContactNo, e.DteBirth, e.StrDob, e.StrRegionName, e.StrAreaName, e.StrTeritoryName, e.StrJobStationName, e.StrUnit, e.IntUnitId, e.StrBankName, e.StrBankBranchName, e.StrDistrict, e.StrRoutingNumber, e.StrBankAccountNo, e.IntPresent, e.IntAbsent, e.IntOffday, e.IntHoliday, e.IntCl, e.IntSl, e.IntEl, e.IntMl, e.IntPl, e.IntBl, e.IntLwp, e.IntLate, e.IntNightDuty, e.MonTotalOthour, e.MonPerHourSalary, e.MonBasicAmount, e.MonHouseRentAmount, e.MonMedicalAllowanceAmount, e.MonTransportAmount, e.MonOtherAmount, e.MonGrossSalary, e.MonJoindatePenalty, e.MonSalary, e.MonPfamount, e.MonTaxAmount, e.MonLoanAmount, e.MonCoinAmount, e.MonAbsentPunishmentAmount, e.MonLeavePunishmentAmount, e.MonLatePunishmentAmount, e.MonPunishment, e.MonDueAefps, e.MonUnionFee, e.MonElectricBill, e.MonDishBill, e.MonTransportBill, e.MonCafeteriaBill, e.MonGymBill, e.MonCanteenBill, e.MonAccommodation, e.MonNightAllowance, e.MonAttendanceBenefit, e.MonNontabBenefit, e.MonNightBenefit, e.MonDayoffBenefit, e.MonDofferBenefit, e.MonDormataryBenefit, e.MonScottBenefit, e.MonLieuBenefit, e.MonHeatBenefit, e.MonDriverAllowance, e.MonMotorCycleAllowance, e.MonConveyanceAllowance, e.MonHouseRentAllowance, e.MonUnionDonationAllowance, e.MonSpecialSalaryAllowance, e.MonMobileAllowance, e.MonOtamount, e.MonPlamount, e.MonTadaamount, e.StrStatus, e.IntMonthId, e.IntYearId, e.MonNetPayableSalary })
                    .HasName("Dec_11_2017_4_57_16_090PM");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.IntYearId).HasColumnName("intYearID");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthID");

                entity.Property(e => e.DteBirth)
                    .HasColumnName("dteBirth")
                    .HasColumnType("date");

                entity.Property(e => e.DteJoining)
                    .HasColumnName("dteJoining")
                    .HasColumnType("date");

                entity.Property(e => e.IntAbsent).HasColumnName("intAbsent");

                entity.Property(e => e.IntAbsentPunishmentCoa).HasColumnName("intAbsentPunishmentCOA");

                entity.Property(e => e.IntAccommodationCrCoa).HasColumnName("intAccommodationCrCOA");

                entity.Property(e => e.IntAccommodationDrCoa).HasColumnName("intAccommodationDrCOA");

                entity.Property(e => e.IntAefpscrCoa).HasColumnName("intAEFPSCrCOA");

                entity.Property(e => e.IntAefpsdrCoa).HasColumnName("intAEFPSDrCOA");

                entity.Property(e => e.IntAttendanceBenefitCoa).HasColumnName("intAttendanceBenefitCOA");

                entity.Property(e => e.IntBl).HasColumnName("intBL");

                entity.Property(e => e.IntCafeteriaCoa).HasColumnName("intCafeteriaCOA");

                entity.Property(e => e.IntCanteenCoa).HasColumnName("intCanteenCOA");

                entity.Property(e => e.IntCl).HasColumnName("intCL");

                entity.Property(e => e.IntCoinCoa).HasColumnName("intCoinCOA");

                entity.Property(e => e.IntConveyanceAllowanceCoa).HasColumnName("intConveyanceAllowanceCOA");

                entity.Property(e => e.IntDayoffBenefitCoa).HasColumnName("intDayoffBenefitCOA");

                entity.Property(e => e.IntDishBillCoa).HasColumnName("intDishBillCOA");

                entity.Property(e => e.IntDofferBenefitCoa).HasColumnName("intDofferBenefitCOA");

                entity.Property(e => e.IntDormataryBenefitCoa).HasColumnName("intDormataryBenefitCOA");

                entity.Property(e => e.IntDriverAllowanceCoa).HasColumnName("intDriverAllowanceCOA");

                entity.Property(e => e.IntEl).HasColumnName("intEL");

                entity.Property(e => e.IntElectricBillCoa).HasColumnName("intElectricBillCOA");

                entity.Property(e => e.IntEmployeeJobStationId).HasColumnName("intEmployeeJobStationId");

                entity.Property(e => e.IntFlatInstallmentCr).HasColumnName("intFlatInstallmentCr");

                entity.Property(e => e.IntFlatInstallmentDr).HasColumnName("intFlatInstallmentDr");

                entity.Property(e => e.IntGymCoa).HasColumnName("intGymCOA");

                entity.Property(e => e.IntHeatBenefitCoa).HasColumnName("intHeatBenefitCOA");

                entity.Property(e => e.IntHoliday).HasColumnName("intHoliday");

                entity.Property(e => e.IntHouseRentAllowanceCoa).HasColumnName("intHouseRentAllowanceCOA");

                entity.Property(e => e.IntJoraBenifitCoa).HasColumnName("intJoraBenifitCOA");

                entity.Property(e => e.IntLate).HasColumnName("intLate");

                entity.Property(e => e.IntLatePunishmentCoa).HasColumnName("intLatePunishmentCOA");

                entity.Property(e => e.IntLeavePunishmentCoa).HasColumnName("intLeavePunishmentCOA");

                entity.Property(e => e.IntLieuBenefitCoa).HasColumnName("intLieuBenefitCOA");

                entity.Property(e => e.IntLoanCrCoa).HasColumnName("intLoanCrCOA");

                entity.Property(e => e.IntLoanDrCoa).HasColumnName("intLoanDrCOA");

                entity.Property(e => e.IntLwp).HasColumnName("intLWP");

                entity.Property(e => e.IntMl).HasColumnName("intML");

                entity.Property(e => e.IntMobileAllowanceCoa).HasColumnName("intMobileAllowanceCOA");

                entity.Property(e => e.IntMotorCycleAllowanceCoa).HasColumnName("intMotorCycleAllowanceCOA");

                entity.Property(e => e.IntNetPayableSalaryCoa).HasColumnName("intNetPayableSalaryCOA");

                entity.Property(e => e.IntNightAllowanceCoa).HasColumnName("intNightAllowanceCOA");

                entity.Property(e => e.IntNightBenefitCoa).HasColumnName("intNightBenefitCOA");

                entity.Property(e => e.IntNightDuty).HasColumnName("intNightDuty");

                entity.Property(e => e.IntNontabBenefitCoa).HasColumnName("intNontabBenefitCOA");

                entity.Property(e => e.IntOffday).HasColumnName("intOffday");

                entity.Property(e => e.IntOtamountCoa).HasColumnName("intOTAmountCOA");

                entity.Property(e => e.IntPfcompanyCrCoa).HasColumnName("intPFCompanyCrCOA");

                entity.Property(e => e.IntPfcompanyDrCoa).HasColumnName("intPFCompanyDrCOA");

                entity.Property(e => e.IntPfempCrCoa).HasColumnName("intPFEmpCrCOA");

                entity.Property(e => e.IntPfempDrCoa).HasColumnName("intPFEmpDrCOA");

                entity.Property(e => e.IntPl).HasColumnName("intPL");

                entity.Property(e => e.IntPlamountCoa).HasColumnName("intPLAmountCOA");

                entity.Property(e => e.IntPresent).HasColumnName("intPresent");

                entity.Property(e => e.IntPunishmentCrCoa).HasColumnName("intPunishmentCrCOA");

                entity.Property(e => e.IntPunishmentDrCoa).HasColumnName("intPunishmentDrCOA");

                entity.Property(e => e.IntSalaryCoa).HasColumnName("intSalaryCOA");

                entity.Property(e => e.IntScottBenefitCoa).HasColumnName("intScottBenefitCOA");

                entity.Property(e => e.IntSl).HasColumnName("intSL");

                entity.Property(e => e.IntSpecialSalaryAllowanceCoa).HasColumnName("intSpecialSalaryAllowanceCOA");

                entity.Property(e => e.IntTadaamountCoa).HasColumnName("intTADAAmountCOA");

                entity.Property(e => e.IntTaxCrCoa).HasColumnName("intTaxCrCOA");

                entity.Property(e => e.IntTaxDrCoa).HasColumnName("intTaxDrCOA");

                entity.Property(e => e.IntTotalHours).HasColumnName("intTotalHours");

                entity.Property(e => e.IntTransportCoa).HasColumnName("intTransportCOA");

                entity.Property(e => e.IntUnionDonationAllowanceCoa).HasColumnName("intUnionDonationAllowanceCOA");

                entity.Property(e => e.IntUnionFeeCrCoa).HasColumnName("intUnionFeeCrCOA");

                entity.Property(e => e.IntUnionFeeDrCoa).HasColumnName("intUnionFeeDrCOA");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntWorkingDays).HasColumnName("intWorkingDays");

                entity.Property(e => e.MonAbsentPunishmentAmount)
                    .HasColumnName("monAbsentPunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonAccommodation)
                    .HasColumnName("monAccommodation")
                    .HasColumnType("money");

                entity.Property(e => e.MonAttendanceBenefit)
                    .HasColumnName("monAttendanceBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonBasicAmount)
                    .HasColumnName("monBasicAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonCafeteriaBill)
                    .HasColumnName("monCafeteriaBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCanteenBill)
                    .HasColumnName("monCanteenBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCarMotorcycleLoan)
                    .HasColumnName("monCarMotorcycleLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonCoinAmount)
                    .HasColumnName("monCoinAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonConveyanceAllowance)
                    .HasColumnName("monConveyanceAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonDayoffBenefit)
                    .HasColumnName("monDayoffBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDishBill)
                    .HasColumnName("monDishBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonDofferBenefit)
                    .HasColumnName("monDofferBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDormataryBenefit)
                    .HasColumnName("monDormataryBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDriverAllowance)
                    .HasColumnName("monDriverAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonDueAefps)
                    .HasColumnName("monDueAEFPS")
                    .HasColumnType("money");

                entity.Property(e => e.MonElectricBill)
                    .HasColumnName("monElectricBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonFlatInstallment)
                    .HasColumnName("monFlatInstallment")
                    .HasColumnType("money");

                entity.Property(e => e.MonGratuity)
                    .HasColumnName("monGratuity")
                    .HasColumnType("money");

                entity.Property(e => e.MonGrossSalary)
                    .HasColumnName("monGrossSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonGymBill)
                    .HasColumnName("monGymBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonHajjLoan)
                    .HasColumnName("monHajjLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHeatBenefit)
                    .HasColumnName("monHeatBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonHomeLoan)
                    .HasColumnName("monHomeLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAllowance)
                    .HasColumnName("monHouseRentAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAmount)
                    .HasColumnName("monHouseRentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoindatePenalty)
                    .HasColumnName("monJoindatePenalty")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoraBenifit)
                    .HasColumnName("monJoraBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLatePunishmentAmount)
                    .HasColumnName("monLatePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLeavePunishmentAmount)
                    .HasColumnName("monLeavePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLieuBenefit)
                    .HasColumnName("monLieuBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoan)
                    .HasColumnName("monLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoanAmount)
                    .HasColumnName("monLoanAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMedicalAllowanceAmount)
                    .HasColumnName("monMedicalAllowanceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMobileAllowance)
                    .HasColumnName("monMobileAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonMotorCycleAllowance)
                    .HasColumnName("monMotorCycleAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNetPayableSalary)
                    .HasColumnName("monNetPayableSalary")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(([monSalary]-(((((((((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monHajjLoan])+[monHomeLoan])+[monCarMotorcycleLoan])+[monPunishmentSchedule])+[monSecurityDeposit])+[monFlatInstallment])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+(((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])+isnull([monJoraBenifit],(0))))");

                entity.Property(e => e.MonNightAllowance)
                    .HasColumnName("monNightAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightBenefit)
                    .HasColumnName("monNightBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNontabBenefit)
                    .HasColumnName("monNontabBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtamount)
                    .HasColumnName("monOTAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherAmount)
                    .HasColumnName("monOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPerHourSalary)
                    .HasColumnName("monPerHourSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfamount)
                    .HasColumnName("monPFAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfemployeeContribution)
                    .HasColumnName("monPFEmployeeContribution")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfemployerContribution)
                    .HasColumnName("monPFEmployerContribution")
                    .HasColumnType("money");

                entity.Property(e => e.MonPlamount)
                    .HasColumnName("monPLAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishment)
                    .HasColumnName("monPunishment")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishmentSchedule)
                    .HasColumnName("monPunishmentSchedule")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalaryAllowancePayInCash)
                    .HasColumnName("monSalaryAllowancePayInCash")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(case when [monSalaryPayInBankFix]=(0) then (0) else (([monSalary]-(((((((((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monHajjLoan])+[monHomeLoan])+[monCarMotorcycleLoan])+[monPunishmentSchedule])+[monSecurityDeposit])+[monFlatInstallment])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+(((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])+isnull([monJoraBenifit],(0))))-[monSalaryPayInBankFix] end)");

                entity.Property(e => e.MonSalaryPayInBank)
                    .HasColumnName("monSalaryPayInBank")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(case when [monSalaryPayInBankFix]=(0) then ([monSalary]-(((((((((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monHajjLoan])+[monHomeLoan])+[monCarMotorcycleLoan])+[monPunishmentSchedule])+[monSecurityDeposit])+[monFlatInstallment])+[monCoinAmount])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+(((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])+isnull([monJoraBenifit],(0))) else [monSalaryPayInBankFix] end)");

                entity.Property(e => e.MonSalaryPayInBankFix)
                    .HasColumnName("monSalaryPayInBankFix")
                    .HasColumnType("money");

                entity.Property(e => e.MonScottBenefit)
                    .HasColumnName("monScottBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonSecurityDeposit)
                    .HasColumnName("monSecurityDeposit")
                    .HasColumnType("money");

                entity.Property(e => e.MonServiceBenefits)
                    .HasColumnName("monServiceBenefits")
                    .HasColumnType("money")
                    .HasComputedColumnSql("((([monPFEmployeeContribution]+[monPFEmployerContribution])+[monGratuity])-[monLoan])");

                entity.Property(e => e.MonSpecialSalaryAllowance)
                    .HasColumnName("monSpecialSalaryAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonTadaamount)
                    .HasColumnName("monTADAAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxAmount)
                    .HasColumnName("monTaxAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalAllowance)
                    .HasColumnName("monTotalAllowance")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])+isnull([monJoraBenifit],(0)))");

                entity.Property(e => e.MonTotalDeduction)
                    .HasColumnName("monTotalDeduction")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(((((((((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monHajjLoan])+[monHomeLoan])+[monCarMotorcycleLoan])+[monPunishmentSchedule])+[monSecurityDeposit])+[monFlatInstallment])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill])");

                entity.Property(e => e.MonTotalOthour)
                    .HasColumnName("monTotalOTHour")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportAmount)
                    .HasColumnName("monTransportAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportBill)
                    .HasColumnName("monTransportBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionDonationAllowance)
                    .HasColumnName("monUnionDonationAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionFee)
                    .HasColumnName("monUnionFee")
                    .HasColumnType("money");

                entity.Property(e => e.StrAreaName)
                    .HasColumnName("strAreaName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankAccountNo)
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankBranchName)
                    .HasColumnName("strBankBranchName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankName)
                    .HasColumnName("strBankName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcgroupName)
                    .HasColumnName("strCCGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcname)
                    .HasColumnName("strCCName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcpname)
                    .HasColumnName("strCCPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcppname)
                    .HasColumnName("strCCPPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcspname)
                    .HasColumnName("strCCSPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcsspname)
                    .HasColumnName("strCCSSPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrContactNo)
                    .HasColumnName("strContactNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDepartment)
                    .HasColumnName("strDepartment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .HasColumnName("strDesignation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDistrict)
                    .HasColumnName("strDistrict")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDob)
                    .HasColumnName("strDOB")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeCode)
                    .HasColumnName("strEmployeeCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGlcode)
                    .HasColumnName("strGLCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGroupName)
                    .HasColumnName("strGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobStationName)
                    .HasColumnName("strJobStationName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .HasColumnName("strJobType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrOfficeEmail)
                    .HasColumnName("strOfficeEmail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRegionName)
                    .HasColumnName("strRegionName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRoutingNumber)
                    .HasColumnName("strRoutingNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrServiceLength)
                    .HasColumnName("strServiceLength")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrStatus)
                    .HasColumnName("strStatus")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTeritoryName)
                    .HasColumnName("strTeritoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrUnit)
                    .HasColumnName("strUnit")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMonthlySalaryGenerateTest>(entity =>
            {
                entity.HasKey(e => new { e.IntEmpId, e.IntYearId, e.IntMonthId });

                entity.ToTable("tblMonthlySalaryGenerateTest");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.IntYearId).HasColumnName("intYearID");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthID");

                entity.Property(e => e.DteBirth)
                    .HasColumnName("dteBirth")
                    .HasColumnType("date");

                entity.Property(e => e.DteJoining)
                    .HasColumnName("dteJoining")
                    .HasColumnType("date");

                entity.Property(e => e.IntAbsent).HasColumnName("intAbsent");

                entity.Property(e => e.IntAbsentPunishmentCoa).HasColumnName("intAbsentPunishmentCOA");

                entity.Property(e => e.IntAccommodationCrCoa).HasColumnName("intAccommodationCrCOA");

                entity.Property(e => e.IntAccommodationDrCoa).HasColumnName("intAccommodationDrCOA");

                entity.Property(e => e.IntAefpscrCoa).HasColumnName("intAEFPSCrCOA");

                entity.Property(e => e.IntAefpsdrCoa).HasColumnName("intAEFPSDrCOA");

                entity.Property(e => e.IntAttendanceBenefitCoa).HasColumnName("intAttendanceBenefitCOA");

                entity.Property(e => e.IntBl).HasColumnName("intBL");

                entity.Property(e => e.IntCafeteriaCoa).HasColumnName("intCafeteriaCOA");

                entity.Property(e => e.IntCanteenCoa).HasColumnName("intCanteenCOA");

                entity.Property(e => e.IntCl).HasColumnName("intCL");

                entity.Property(e => e.IntCoinCoa).HasColumnName("intCoinCOA");

                entity.Property(e => e.IntConveyanceAllowanceCoa).HasColumnName("intConveyanceAllowanceCOA");

                entity.Property(e => e.IntDayoffBenefitCoa).HasColumnName("intDayoffBenefitCOA");

                entity.Property(e => e.IntDishBillCoa).HasColumnName("intDishBillCOA");

                entity.Property(e => e.IntDofferBenefitCoa).HasColumnName("intDofferBenefitCOA");

                entity.Property(e => e.IntDormataryBenefitCoa).HasColumnName("intDormataryBenefitCOA");

                entity.Property(e => e.IntDriverAllowanceCoa).HasColumnName("intDriverAllowanceCOA");

                entity.Property(e => e.IntEl).HasColumnName("intEL");

                entity.Property(e => e.IntElectricBillCoa).HasColumnName("intElectricBillCOA");

                entity.Property(e => e.IntEmployeeJobStationId).HasColumnName("intEmployeeJobStationId");

                entity.Property(e => e.IntFlatInstallmentCr).HasColumnName("intFlatInstallmentCr");

                entity.Property(e => e.IntFlatInstallmentDr).HasColumnName("intFlatInstallmentDr");

                entity.Property(e => e.IntGymCoa).HasColumnName("intGymCOA");

                entity.Property(e => e.IntHeatBenefitCoa).HasColumnName("intHeatBenefitCOA");

                entity.Property(e => e.IntHoliday).HasColumnName("intHoliday");

                entity.Property(e => e.IntHouseRentAllowanceCoa).HasColumnName("intHouseRentAllowanceCOA");

                entity.Property(e => e.IntJoraBenifitCoa).HasColumnName("intJoraBenifitCOA");

                entity.Property(e => e.IntLate).HasColumnName("intLate");

                entity.Property(e => e.IntLatePunishmentCoa).HasColumnName("intLatePunishmentCOA");

                entity.Property(e => e.IntLeavePunishmentCoa).HasColumnName("intLeavePunishmentCOA");

                entity.Property(e => e.IntLieuBenefitCoa).HasColumnName("intLieuBenefitCOA");

                entity.Property(e => e.IntLoanCrCoa).HasColumnName("intLoanCrCOA");

                entity.Property(e => e.IntLoanDrCoa).HasColumnName("intLoanDrCOA");

                entity.Property(e => e.IntLwp).HasColumnName("intLWP");

                entity.Property(e => e.IntMl).HasColumnName("intML");

                entity.Property(e => e.IntMobileAllowanceCoa).HasColumnName("intMobileAllowanceCOA");

                entity.Property(e => e.IntMotorCycleAllowanceCoa).HasColumnName("intMotorCycleAllowanceCOA");

                entity.Property(e => e.IntNetPayableSalaryCoa).HasColumnName("intNetPayableSalaryCOA");

                entity.Property(e => e.IntNightAllowanceCoa).HasColumnName("intNightAllowanceCOA");

                entity.Property(e => e.IntNightBenefitCoa).HasColumnName("intNightBenefitCOA");

                entity.Property(e => e.IntNightDuty).HasColumnName("intNightDuty");

                entity.Property(e => e.IntNontabBenefitCoa).HasColumnName("intNontabBenefitCOA");

                entity.Property(e => e.IntOffday).HasColumnName("intOffday");

                entity.Property(e => e.IntOtamountCoa).HasColumnName("intOTAmountCOA");

                entity.Property(e => e.IntPfcompanyCrCoa).HasColumnName("intPFCompanyCrCOA");

                entity.Property(e => e.IntPfcompanyDrCoa).HasColumnName("intPFCompanyDrCOA");

                entity.Property(e => e.IntPfempCrCoa).HasColumnName("intPFEmpCrCOA");

                entity.Property(e => e.IntPfempDrCoa).HasColumnName("intPFEmpDrCOA");

                entity.Property(e => e.IntPl).HasColumnName("intPL");

                entity.Property(e => e.IntPlamountCoa).HasColumnName("intPLAmountCOA");

                entity.Property(e => e.IntPresent).HasColumnName("intPresent");

                entity.Property(e => e.IntPunishmentCrCoa).HasColumnName("intPunishmentCrCOA");

                entity.Property(e => e.IntPunishmentDrCoa).HasColumnName("intPunishmentDrCOA");

                entity.Property(e => e.IntSalaryCoa).HasColumnName("intSalaryCOA");

                entity.Property(e => e.IntScottBenefitCoa).HasColumnName("intScottBenefitCOA");

                entity.Property(e => e.IntSl).HasColumnName("intSL");

                entity.Property(e => e.IntSpecialSalaryAllowanceCoa).HasColumnName("intSpecialSalaryAllowanceCOA");

                entity.Property(e => e.IntTadaamountCoa).HasColumnName("intTADAAmountCOA");

                entity.Property(e => e.IntTaxCrCoa).HasColumnName("intTaxCrCOA");

                entity.Property(e => e.IntTaxDrCoa).HasColumnName("intTaxDrCOA");

                entity.Property(e => e.IntTotalHours).HasColumnName("intTotalHours");

                entity.Property(e => e.IntTransportCoa).HasColumnName("intTransportCOA");

                entity.Property(e => e.IntUnionDonationAllowanceCoa).HasColumnName("intUnionDonationAllowanceCOA");

                entity.Property(e => e.IntUnionFeeCrCoa).HasColumnName("intUnionFeeCrCOA");

                entity.Property(e => e.IntUnionFeeDrCoa).HasColumnName("intUnionFeeDrCOA");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntWorkingDays).HasColumnName("intWorkingDays");

                entity.Property(e => e.MonAbsentPunishmentAmount)
                    .HasColumnName("monAbsentPunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonAccommodation)
                    .HasColumnName("monAccommodation")
                    .HasColumnType("money");

                entity.Property(e => e.MonAttendanceBenefit)
                    .HasColumnName("monAttendanceBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonBasicAmount)
                    .HasColumnName("monBasicAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonCafeteriaBill)
                    .HasColumnName("monCafeteriaBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCanteenBill)
                    .HasColumnName("monCanteenBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCarMotorcycleLoan)
                    .HasColumnName("monCarMotorcycleLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonCoinAmount)
                    .HasColumnName("monCoinAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonConveyanceAllowance)
                    .HasColumnName("monConveyanceAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonDayoffBenefit)
                    .HasColumnName("monDayoffBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDishBill)
                    .HasColumnName("monDishBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonDofferBenefit)
                    .HasColumnName("monDofferBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDormataryBenefit)
                    .HasColumnName("monDormataryBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDriverAllowance)
                    .HasColumnName("monDriverAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonDueAefps)
                    .HasColumnName("monDueAEFPS")
                    .HasColumnType("money");

                entity.Property(e => e.MonElectricBill)
                    .HasColumnName("monElectricBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonFlatInstallment)
                    .HasColumnName("monFlatInstallment")
                    .HasColumnType("money");

                entity.Property(e => e.MonGratuity)
                    .HasColumnName("monGratuity")
                    .HasColumnType("money");

                entity.Property(e => e.MonGrossSalary)
                    .HasColumnName("monGrossSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonGymBill)
                    .HasColumnName("monGymBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonHajjLoan)
                    .HasColumnName("monHajjLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHeatBenefit)
                    .HasColumnName("monHeatBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonHomeLoan)
                    .HasColumnName("monHomeLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAllowance)
                    .HasColumnName("monHouseRentAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAmount)
                    .HasColumnName("monHouseRentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoindatePenalty)
                    .HasColumnName("monJoindatePenalty")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoraBenifit)
                    .HasColumnName("monJoraBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLatePunishmentAmount)
                    .HasColumnName("monLatePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLeavePunishmentAmount)
                    .HasColumnName("monLeavePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLieuBenefit)
                    .HasColumnName("monLieuBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoan)
                    .HasColumnName("monLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoanAmount)
                    .HasColumnName("monLoanAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMedicalAllowanceAmount)
                    .HasColumnName("monMedicalAllowanceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMobileAllowance)
                    .HasColumnName("monMobileAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonMotorCycleAllowance)
                    .HasColumnName("monMotorCycleAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNetPayableSalary)
                    .HasColumnName("monNetPayableSalary")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(([monSalary]-(((((((((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monHajjLoan])+[monHomeLoan])+[monCarMotorcycleLoan])+[monPunishmentSchedule])+[monSecurityDeposit])+[monFlatInstallment])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+(((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])+isnull([monJoraBenifit],(0))))");

                entity.Property(e => e.MonNightAllowance)
                    .HasColumnName("monNightAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightBenefit)
                    .HasColumnName("monNightBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNontabBenefit)
                    .HasColumnName("monNontabBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtamount)
                    .HasColumnName("monOTAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherAmount)
                    .HasColumnName("monOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPerHourSalary)
                    .HasColumnName("monPerHourSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfamount)
                    .HasColumnName("monPFAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfemployeeContribution)
                    .HasColumnName("monPFEmployeeContribution")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfemployerContribution)
                    .HasColumnName("monPFEmployerContribution")
                    .HasColumnType("money");

                entity.Property(e => e.MonPlamount)
                    .HasColumnName("monPLAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishment)
                    .HasColumnName("monPunishment")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishmentSchedule)
                    .HasColumnName("monPunishmentSchedule")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalaryAllowancePayInCash)
                    .HasColumnName("monSalaryAllowancePayInCash")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(case when [monSalaryPayInBankFix]=(0) then (0) else (([monSalary]-(((((((((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monHajjLoan])+[monHomeLoan])+[monCarMotorcycleLoan])+[monPunishmentSchedule])+[monSecurityDeposit])+[monFlatInstallment])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+(((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])+isnull([monJoraBenifit],(0))))-[monSalaryPayInBankFix] end)");

                entity.Property(e => e.MonSalaryPayInBank)
                    .HasColumnName("monSalaryPayInBank")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(case when [monSalaryPayInBankFix]=(0) then ([monSalary]-(((((((((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monHajjLoan])+[monHomeLoan])+[monCarMotorcycleLoan])+[monPunishmentSchedule])+[monSecurityDeposit])+[monFlatInstallment])+[monCoinAmount])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+(((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])+isnull([monJoraBenifit],(0))) else [monSalaryPayInBankFix] end)");

                entity.Property(e => e.MonSalaryPayInBankFix)
                    .HasColumnName("monSalaryPayInBankFix")
                    .HasColumnType("money");

                entity.Property(e => e.MonScottBenefit)
                    .HasColumnName("monScottBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonSecurityDeposit)
                    .HasColumnName("monSecurityDeposit")
                    .HasColumnType("money");

                entity.Property(e => e.MonServiceBenefits)
                    .HasColumnName("monServiceBenefits")
                    .HasColumnType("money")
                    .HasComputedColumnSql("((([monPFEmployeeContribution]+[monPFEmployerContribution])+[monGratuity])-[monLoan])");

                entity.Property(e => e.MonSpecialSalaryAllowance)
                    .HasColumnName("monSpecialSalaryAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonTadaamount)
                    .HasColumnName("monTADAAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxAmount)
                    .HasColumnName("monTaxAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalAllowance)
                    .HasColumnName("monTotalAllowance")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])+isnull([monJoraBenifit],(0)))");

                entity.Property(e => e.MonTotalDeduction)
                    .HasColumnName("monTotalDeduction")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(((((((((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monHajjLoan])+[monHomeLoan])+[monCarMotorcycleLoan])+[monPunishmentSchedule])+[monSecurityDeposit])+[monFlatInstallment])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill])");

                entity.Property(e => e.MonTotalOthour)
                    .HasColumnName("monTotalOTHour")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportAmount)
                    .HasColumnName("monTransportAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportBill)
                    .HasColumnName("monTransportBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionDonationAllowance)
                    .HasColumnName("monUnionDonationAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionFee)
                    .HasColumnName("monUnionFee")
                    .HasColumnType("money");

                entity.Property(e => e.StrAreaName)
                    .HasColumnName("strAreaName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankAccountNo)
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankBranchName)
                    .HasColumnName("strBankBranchName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankName)
                    .HasColumnName("strBankName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcgroupName)
                    .HasColumnName("strCCGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcname)
                    .HasColumnName("strCCName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcpname)
                    .HasColumnName("strCCPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcppname)
                    .HasColumnName("strCCPPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcspname)
                    .HasColumnName("strCCSPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcsspname)
                    .HasColumnName("strCCSSPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrContactNo)
                    .HasColumnName("strContactNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDepartment)
                    .HasColumnName("strDepartment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .HasColumnName("strDesignation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDistrict)
                    .HasColumnName("strDistrict")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDob)
                    .HasColumnName("strDOB")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeCode)
                    .HasColumnName("strEmployeeCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGlcode)
                    .HasColumnName("strGLCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGroupName)
                    .HasColumnName("strGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobStationName)
                    .HasColumnName("strJobStationName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .HasColumnName("strJobType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrOfficeEmail)
                    .HasColumnName("strOfficeEmail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRegionName)
                    .HasColumnName("strRegionName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRoutingNumber)
                    .HasColumnName("strRoutingNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrServiceLength)
                    .HasColumnName("strServiceLength")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrStatus)
                    .HasColumnName("strStatus")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTeritoryName)
                    .HasColumnName("strTeritoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrUnit)
                    .HasColumnName("strUnit")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMonthlySalaryGeneratetest1>(entity =>
            {
                entity.HasKey(e => new { e.IntEmpId, e.IntYearId, e.IntMonthId })
                    .HasName("PK_tblMonthlySalaryGenerateTest1");

                entity.ToTable("tblMonthlySalaryGeneratetest1");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.IntYearId).HasColumnName("intYearID");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthID");

                entity.Property(e => e.DteBirth)
                    .HasColumnName("dteBirth")
                    .HasColumnType("date");

                entity.Property(e => e.DteJoining)
                    .HasColumnName("dteJoining")
                    .HasColumnType("date");

                entity.Property(e => e.IntAbsent).HasColumnName("intAbsent");

                entity.Property(e => e.IntAbsentPunishmentCoa).HasColumnName("intAbsentPunishmentCOA");

                entity.Property(e => e.IntAccommodationCrCoa).HasColumnName("intAccommodationCrCOA");

                entity.Property(e => e.IntAccommodationDrCoa).HasColumnName("intAccommodationDrCOA");

                entity.Property(e => e.IntAefpscrCoa).HasColumnName("intAEFPSCrCOA");

                entity.Property(e => e.IntAefpsdrCoa).HasColumnName("intAEFPSDrCOA");

                entity.Property(e => e.IntAttendanceBenefitCoa).HasColumnName("intAttendanceBenefitCOA");

                entity.Property(e => e.IntBl).HasColumnName("intBL");

                entity.Property(e => e.IntCafeteriaCoa).HasColumnName("intCafeteriaCOA");

                entity.Property(e => e.IntCanteenCoa).HasColumnName("intCanteenCOA");

                entity.Property(e => e.IntCl).HasColumnName("intCL");

                entity.Property(e => e.IntCoinCoa).HasColumnName("intCoinCOA");

                entity.Property(e => e.IntConveyanceAllowanceCoa).HasColumnName("intConveyanceAllowanceCOA");

                entity.Property(e => e.IntDayoffBenefitCoa).HasColumnName("intDayoffBenefitCOA");

                entity.Property(e => e.IntDishBillCoa).HasColumnName("intDishBillCOA");

                entity.Property(e => e.IntDofferBenefitCoa).HasColumnName("intDofferBenefitCOA");

                entity.Property(e => e.IntDormataryBenefitCoa).HasColumnName("intDormataryBenefitCOA");

                entity.Property(e => e.IntDriverAllowanceCoa).HasColumnName("intDriverAllowanceCOA");

                entity.Property(e => e.IntEl).HasColumnName("intEL");

                entity.Property(e => e.IntElectricBillCoa).HasColumnName("intElectricBillCOA");

                entity.Property(e => e.IntEmployeeJobStationId).HasColumnName("intEmployeeJobStationId");

                entity.Property(e => e.IntGymCoa).HasColumnName("intGymCOA");

                entity.Property(e => e.IntHeatBenefitCoa).HasColumnName("intHeatBenefitCOA");

                entity.Property(e => e.IntHoliday).HasColumnName("intHoliday");

                entity.Property(e => e.IntHouseRentAllowanceCoa).HasColumnName("intHouseRentAllowanceCOA");

                entity.Property(e => e.IntLate).HasColumnName("intLate");

                entity.Property(e => e.IntLatePunishmentCoa).HasColumnName("intLatePunishmentCOA");

                entity.Property(e => e.IntLeavePunishmentCoa).HasColumnName("intLeavePunishmentCOA");

                entity.Property(e => e.IntLieuBenefitCoa).HasColumnName("intLieuBenefitCOA");

                entity.Property(e => e.IntLoanCrCoa).HasColumnName("intLoanCrCOA");

                entity.Property(e => e.IntLoanDrCoa).HasColumnName("intLoanDrCOA");

                entity.Property(e => e.IntLwp).HasColumnName("intLWP");

                entity.Property(e => e.IntMl).HasColumnName("intML");

                entity.Property(e => e.IntMobileAllowanceCoa).HasColumnName("intMobileAllowanceCOA");

                entity.Property(e => e.IntMotorCycleAllowanceCoa).HasColumnName("intMotorCycleAllowanceCOA");

                entity.Property(e => e.IntNetPayableSalaryCoa).HasColumnName("intNetPayableSalaryCOA");

                entity.Property(e => e.IntNightAllowanceCoa).HasColumnName("intNightAllowanceCOA");

                entity.Property(e => e.IntNightBenefitCoa).HasColumnName("intNightBenefitCOA");

                entity.Property(e => e.IntNightDuty).HasColumnName("intNightDuty");

                entity.Property(e => e.IntNontabBenefitCoa).HasColumnName("intNontabBenefitCOA");

                entity.Property(e => e.IntOffday).HasColumnName("intOffday");

                entity.Property(e => e.IntOtamountCoa).HasColumnName("intOTAmountCOA");

                entity.Property(e => e.IntPfcompanyCrCoa).HasColumnName("intPFCompanyCrCOA");

                entity.Property(e => e.IntPfcompanyDrCoa).HasColumnName("intPFCompanyDrCOA");

                entity.Property(e => e.IntPfempCrCoa).HasColumnName("intPFEmpCrCOA");

                entity.Property(e => e.IntPfempDrCoa).HasColumnName("intPFEmpDrCOA");

                entity.Property(e => e.IntPl).HasColumnName("intPL");

                entity.Property(e => e.IntPlamountCoa).HasColumnName("intPLAmountCOA");

                entity.Property(e => e.IntPresent).HasColumnName("intPresent");

                entity.Property(e => e.IntPunishmentCrCoa).HasColumnName("intPunishmentCrCOA");

                entity.Property(e => e.IntPunishmentDrCoa).HasColumnName("intPunishmentDrCOA");

                entity.Property(e => e.IntSalaryCoa).HasColumnName("intSalaryCOA");

                entity.Property(e => e.IntScottBenefitCoa).HasColumnName("intScottBenefitCOA");

                entity.Property(e => e.IntSl).HasColumnName("intSL");

                entity.Property(e => e.IntSpecialSalaryAllowanceCoa).HasColumnName("intSpecialSalaryAllowanceCOA");

                entity.Property(e => e.IntTadaamountCoa).HasColumnName("intTADAAmountCOA");

                entity.Property(e => e.IntTaxCrCoa).HasColumnName("intTaxCrCOA");

                entity.Property(e => e.IntTaxDrCoa).HasColumnName("intTaxDrCOA");

                entity.Property(e => e.IntTotalHours).HasColumnName("intTotalHours");

                entity.Property(e => e.IntTransportCoa).HasColumnName("intTransportCOA");

                entity.Property(e => e.IntUnionDonationAllowanceCoa).HasColumnName("intUnionDonationAllowanceCOA");

                entity.Property(e => e.IntUnionFeeCrCoa).HasColumnName("intUnionFeeCrCOA");

                entity.Property(e => e.IntUnionFeeDrCoa).HasColumnName("intUnionFeeDrCOA");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntWorkingDays).HasColumnName("intWorkingDays");

                entity.Property(e => e.MonAbsentPunishmentAmount)
                    .HasColumnName("monAbsentPunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonAccommodation)
                    .HasColumnName("monAccommodation")
                    .HasColumnType("money");

                entity.Property(e => e.MonAttendanceBenefit)
                    .HasColumnName("monAttendanceBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonBasicAmount)
                    .HasColumnName("monBasicAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonCafeteriaBill)
                    .HasColumnName("monCafeteriaBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCanteenBill)
                    .HasColumnName("monCanteenBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCoinAmount)
                    .HasColumnName("monCoinAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonConveyanceAllowance)
                    .HasColumnName("monConveyanceAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonDayoffBenefit)
                    .HasColumnName("monDayoffBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDishBill)
                    .HasColumnName("monDishBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonDofferBenefit)
                    .HasColumnName("monDofferBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDormataryBenefit)
                    .HasColumnName("monDormataryBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDriverAllowance)
                    .HasColumnName("monDriverAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonDueAefps)
                    .HasColumnName("monDueAEFPS")
                    .HasColumnType("money");

                entity.Property(e => e.MonElectricBill)
                    .HasColumnName("monElectricBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonGratuity)
                    .HasColumnName("monGratuity")
                    .HasColumnType("money");

                entity.Property(e => e.MonGrossSalary)
                    .HasColumnName("monGrossSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonGymBill)
                    .HasColumnName("monGymBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonHeatBenefit)
                    .HasColumnName("monHeatBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAllowance)
                    .HasColumnName("monHouseRentAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAmount)
                    .HasColumnName("monHouseRentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoindatePenalty)
                    .HasColumnName("monJoindatePenalty")
                    .HasColumnType("money");

                entity.Property(e => e.MonLatePunishmentAmount)
                    .HasColumnName("monLatePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLeavePunishmentAmount)
                    .HasColumnName("monLeavePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLieuBenefit)
                    .HasColumnName("monLieuBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoan)
                    .HasColumnName("monLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoanAmount)
                    .HasColumnName("monLoanAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMedicalAllowanceAmount)
                    .HasColumnName("monMedicalAllowanceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMobileAllowance)
                    .HasColumnName("monMobileAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonMotorCycleAllowance)
                    .HasColumnName("monMotorCycleAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNetPayableSalary)
                    .HasColumnName("monNetPayableSalary")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(([monSalary]-(((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit]))");

                entity.Property(e => e.MonNightAllowance)
                    .HasColumnName("monNightAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightBenefit)
                    .HasColumnName("monNightBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNontabBenefit)
                    .HasColumnName("monNontabBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtamount)
                    .HasColumnName("monOTAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherAmount)
                    .HasColumnName("monOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPerHourSalary)
                    .HasColumnName("monPerHourSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfamount)
                    .HasColumnName("monPFAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfemployeeContribution)
                    .HasColumnName("monPFEmployeeContribution")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfemployerContribution)
                    .HasColumnName("monPFEmployerContribution")
                    .HasColumnType("money");

                entity.Property(e => e.MonPlamount)
                    .HasColumnName("monPLAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishment)
                    .HasColumnName("monPunishment")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalaryAllowancePayInCash)
                    .HasColumnName("monSalaryAllowancePayInCash")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(case when [monSalaryPayInBankFix]=(0) then (0) else (([monSalary]-(((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit]))-[monSalaryPayInBankFix] end)");

                entity.Property(e => e.MonSalaryPayInBank)
                    .HasColumnName("monSalaryPayInBank")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(case when [monSalaryPayInBankFix]=(0) then ([monSalary]-(((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill]))+((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit]) else [monSalaryPayInBankFix] end)");

                entity.Property(e => e.MonSalaryPayInBankFix)
                    .HasColumnName("monSalaryPayInBankFix")
                    .HasColumnType("money");

                entity.Property(e => e.MonScottBenefit)
                    .HasColumnName("monScottBenefit")
                    .HasColumnType("money");

                entity.Property(e => e.MonServiceBenefits)
                    .HasColumnName("monServiceBenefits")
                    .HasColumnType("money")
                    .HasComputedColumnSql("((([monPFEmployeeContribution]+[monPFEmployerContribution])+[monGratuity])-[monLoan])");

                entity.Property(e => e.MonSpecialSalaryAllowance)
                    .HasColumnName("monSpecialSalaryAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonTadaamount)
                    .HasColumnName("monTADAAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxAmount)
                    .HasColumnName("monTaxAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalAllowance)
                    .HasColumnName("monTotalAllowance")
                    .HasColumnType("money")
                    .HasComputedColumnSql("((((((((((((((((((([monNightAllowance]+[monAttendanceBenefit])+[monNontabBenefit])+[monNightBenefit])+[monDayoffBenefit])+[monDofferBenefit])+[monDormataryBenefit])+[monScottBenefit])+[monLieuBenefit])+[monDriverAllowance])+[monMotorCycleAllowance])+[monConveyanceAllowance])+[monHouseRentAllowance])+[monUnionDonationAllowance])+[monSpecialSalaryAllowance])+[monMobileAllowance])+[monOTAmount])+[monPLAmount])+[monTADAAmount])+[monHeatBenefit])");

                entity.Property(e => e.MonTotalDeduction)
                    .HasColumnName("monTotalDeduction")
                    .HasColumnType("money")
                    .HasComputedColumnSql("(((((((((((((((([monPFAmount]+[monTaxAmount])+[monLoanAmount])+[monCoinAmount])+[monAbsentPunishmentAmount])+[monLeavePunishmentAmount])+[monLatePunishmentAmount])+[monPunishment])+[monDueAEFPS])+[monUnionFee])+[monElectricBill])+[monDishBill])+[monTransportBill])+[monCafeteriaBill])+[monGymBill])+[monAccommodation])+[monCanteenBill])");

                entity.Property(e => e.MonTotalOthour)
                    .HasColumnName("monTotalOTHour")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportAmount)
                    .HasColumnName("monTransportAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportBill)
                    .HasColumnName("monTransportBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionDonationAllowance)
                    .HasColumnName("monUnionDonationAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionFee)
                    .HasColumnName("monUnionFee")
                    .HasColumnType("money");

                entity.Property(e => e.StrAreaName)
                    .HasColumnName("strAreaName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankAccountNo)
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankBranchName)
                    .HasColumnName("strBankBranchName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankName)
                    .HasColumnName("strBankName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcgroupName)
                    .HasColumnName("strCCGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcname)
                    .HasColumnName("strCCName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcpname)
                    .HasColumnName("strCCPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcppname)
                    .HasColumnName("strCCPPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcspname)
                    .HasColumnName("strCCSPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcsspname)
                    .HasColumnName("strCCSSPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrContactNo)
                    .HasColumnName("strContactNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDepartment)
                    .HasColumnName("strDepartment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .HasColumnName("strDesignation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDistrict)
                    .HasColumnName("strDistrict")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDob)
                    .HasColumnName("strDOB")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeCode)
                    .HasColumnName("strEmployeeCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGlcode)
                    .HasColumnName("strGLCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGroupName)
                    .HasColumnName("strGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobStationName)
                    .HasColumnName("strJobStationName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .HasColumnName("strJobType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrOfficeEmail)
                    .HasColumnName("strOfficeEmail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRegionName)
                    .HasColumnName("strRegionName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRoutingNumber)
                    .HasColumnName("strRoutingNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrServiceLength)
                    .HasColumnName("strServiceLength")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrStatus)
                    .HasColumnName("strStatus")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTeritoryName)
                    .HasColumnName("strTeritoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrUnit)
                    .HasColumnName("strUnit")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOfficialMovement>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblOfficialMovement");

                entity.HasIndex(e => new { e.IntId, e.DteStartTime, e.DteEndTime, e.StrAddress, e.IntDistrictId, e.StrReason, e.DteAppliedTime, e.YsnApproved, e.YsnRejected, e.IntEmpId, e.IntMoveTypeId })
                    .HasName("Dec_12_2017_10_03_46_970AM");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.DteAppliedTime)
                    .HasColumnName("dteAppliedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteApprovedDate)
                    .HasColumnName("dteApprovedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteEndTime)
                    .HasColumnName("dteEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteStartTime)
                    .HasColumnName("dteStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntArrovedBy).HasColumnName("intArrovedBy");

                entity.Property(e => e.IntCountryId).HasColumnName("intCountryID");

                entity.Property(e => e.IntDistrictId).HasColumnName("intDistrictID");

                entity.Property(e => e.IntEmpId).HasColumnName("intEmpID");

                entity.Property(e => e.IntMoveTypeId).HasColumnName("intMoveTypeID");

                entity.Property(e => e.StrAddress)
                    .HasColumnName("strAddress")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.StrReason)
                    .HasColumnName("strReason")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.TmEnd).HasColumnName("tmEnd");

                entity.Property(e => e.TmStart).HasColumnName("tmStart");

                entity.Property(e => e.YsnApproved).HasColumnName("ysnApproved");

                entity.Property(e => e.YsnRejected).HasColumnName("ysnRejected");
            });

            modelBuilder.Entity<TblPayrollProcesse>(entity =>
            {
                entity.HasKey(e => e.IntPayrollProcessId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPayrollProcesse");

                entity.HasIndex(e => new { e.IntEmployeeId, e.DtePayrollGenerationDate, e.IntUnitId, e.MonPfamount })
                    .HasName("Mar_2_2018_11_04_53_213PM");

                entity.HasIndex(e => new { e.DtePayrollGenerationDate, e.MonTaxAmount, e.MonAbsentPunishmentAmount, e.MonLeavePunishmentAmount, e.MonLoanAmount, e.MonLatePunishmentAmount, e.MonOtherDeductionAmount, e.MonGrossSalary, e.MonDeduction, e.IntEmployeeId })
                    .HasName("Dec_11_2017_10_51_37_190AM");

                entity.Property(e => e.IntPayrollProcessId).HasColumnName("intPayrollProcessId");

                entity.Property(e => e.DtePayrollGenerationDate)
                    .HasColumnName("dtePayrollGenerationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntCntNight).HasColumnName("intCntNight");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntJobstation).HasColumnName("intJobstation");

                entity.Property(e => e.IntLateCount).HasColumnName("intLateCount");

                entity.Property(e => e.IntNumberAbsent).HasColumnName("intNumberAbsent");

                entity.Property(e => e.IntNumberOfLeaveWithoutPay).HasColumnName("intNumberOfLeaveWithoutPay");

                entity.Property(e => e.IntRamadan).HasColumnName("intRamadan");

                entity.Property(e => e.IntTotalMeal).HasColumnName("intTotalMeal");

                entity.Property(e => e.IntTotalWorkingDays).HasColumnName("intTotalWorkingDays");

                entity.Property(e => e.IntTotalWorkingHours).HasColumnName("intTotalWorkingHours");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.MonAbsentPunishmentAmount)
                    .HasColumnName("monAbsentPunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonAccommodation)
                    .HasColumnName("monAccommodation")
                    .HasColumnType("money");

                entity.Property(e => e.MonAttendanceBenifit)
                    .HasColumnName("monAttendanceBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonBasicAmount)
                    .HasColumnName("monBasicAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonBreackAmount)
                    .HasColumnName("monBreackAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonCafeteriaBill)
                    .HasColumnName("monCafeteriaBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCanteenBill)
                    .HasColumnName("monCanteenBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCarMotorcycleLoan)
                    .HasColumnName("monCarMotorcycleLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonCoin)
                    .HasColumnName("monCoin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MonDayoffBenifit)
                    .HasColumnName("monDayoffBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDeduction)
                    .HasColumnName("monDeduction")
                    .HasColumnType("money");

                entity.Property(e => e.MonDishBill)
                    .HasColumnName("monDishBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonDofferBenifit)
                    .HasColumnName("monDofferBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDormataryBenifit)
                    .HasColumnName("monDormataryBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonElectricBill)
                    .HasColumnName("monElectricBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonFlatInstallment)
                    .HasColumnName("monFlatInstallment")
                    .HasColumnType("money");

                entity.Property(e => e.MonGrossSalary)
                    .HasColumnName("monGrossSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonGymBill)
                    .HasColumnName("monGymBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonHajjLoan)
                    .HasColumnName("monHajjLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHeatBenifit)
                    .HasColumnName("monHeatBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonHomeLoan)
                    .HasColumnName("monHomeLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAmount)
                    .HasColumnName("monHouseRentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoraBenifit)
                    .HasColumnName("monJoraBenifit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MonLatePunishmentAmount)
                    .HasColumnName("monLatePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLeavePunishmentAmount)
                    .HasColumnName("monLeavePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLieuBenifit)
                    .HasColumnName("monLieuBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoanAmount)
                    .HasColumnName("monLoanAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLodingBenifit)
                    .HasColumnName("monLodingBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonMedicalAllowanceAmount)
                    .HasColumnName("monMedicalAllowanceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightBenifit)
                    .HasColumnName("monNightBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNontabBenifit)
                    .HasColumnName("monNontabBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherAmount)
                    .HasColumnName("monOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherDeductionAmount)
                    .HasColumnName("monOtherDeductionAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfamount)
                    .HasColumnName("monPFAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishmentSchedule)
                    .HasColumnName("monPunishmentSchedule")
                    .HasColumnType("money");

                entity.Property(e => e.MonScottBenifit)
                    .HasColumnName("monScottBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonSecurityDeposit)
                    .HasColumnName("monSecurityDeposit")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxAmount)
                    .HasColumnName("monTaxAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalPayableSalary)
                    .HasColumnName("monTotalPayableSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportAmount)
                    .HasColumnName("monTransportAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportBill)
                    .HasColumnName("monTransportBill")
                    .HasColumnType("money");

                entity.Property(e => e.NumBasicPercentance)
                    .HasColumnName("numBasicPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumHouseRentPercentance)
                    .HasColumnName("numHouseRentPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumMealRate)
                    .HasColumnName("numMealRate")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumMedicalAllowancePercentance)
                    .HasColumnName("numMedicalAllowancePercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumPfpercentance)
                    .HasColumnName("numPFPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumTaxPercentance)
                    .HasColumnName("numTaxPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumTransportPercentance)
                    .HasColumnName("numTransportPercentance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StrArea)
                    .HasColumnName("strArea")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrRegion)
                    .HasColumnName("strRegion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrTeritory)
                    .HasColumnName("strTeritory")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.YsnSubmittedToBank).HasColumnName("ysnSubmittedToBank");
            });

            modelBuilder.Entity<TblPfInvestmentMaturity>(entity =>
            {
                entity.HasKey(e => e.IntInvestmentMaturityId);

                entity.ToTable("tblPfInvestmentMaturity");

                entity.Property(e => e.IntInvestmentMaturityId).HasColumnName("intInvestmentMaturityId");

                entity.Property(e => e.DteMaturedDate)
                    .HasColumnName("dteMaturedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntInvestmentId).HasColumnName("intInvestmentID");

                entity.Property(e => e.MonProfit)
                    .HasColumnName("monProfit")
                    .HasColumnType("money");

                entity.Property(e => e.NumActualDuration)
                    .HasColumnName("numActualDuration")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumMaturedInterest)
                    .HasColumnName("numMaturedInterest")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumMaturedInterestShouldBe)
                    .HasColumnName("numMaturedInterestShouldBe")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblPfRelease>(entity =>
            {
                entity.HasKey(e => e.IntPfReleaseId);

                entity.ToTable("tblPfRelease");

                entity.Property(e => e.IntPfReleaseId).HasColumnName("intPfReleaseId");

                entity.Property(e => e.DteReleaseDate)
                    .HasColumnName("dteReleaseDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntPaidBy).HasColumnName("intPaidBy");

                entity.Property(e => e.MonProfitAmount)
                    .HasColumnName("monProfitAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalReleaseAmount)
                    .HasColumnName("monTotalReleaseAmount")
                    .HasColumnType("money");

                entity.Property(e => e.StrPfReleaseVoucharCode)
                    .HasColumnName("strPfReleaseVoucharCode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.YsnCheckReleased).HasColumnName("ysnCheckReleased");
            });

            modelBuilder.Entity<TblPfbankAccountConfiguration>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .HasName("PK_tblPF_BankAccountConfiguration");

                entity.ToTable("tblPFBankAccountConfiguration");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.IntBankAccountNo).HasColumnName("intBankAccountNo");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");

                entity.Property(e => e.YsnInvestmentAccount).HasColumnName("ysnInvestmentAccount");

                entity.Property(e => e.YsnPfaccount).HasColumnName("ysnPFAccount");
            });

            modelBuilder.Entity<TblPfbankAccountStatement>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .HasName("PK_tblPF_BankAccountStatement");

                entity.ToTable("tblPFBankAccountStatement");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteAutoReconciled)
                    .HasColumnName("dteAutoReconciled")
                    .HasColumnType("date");

                entity.Property(e => e.DteCompleteDate)
                    .HasColumnName("dteCompleteDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteInsertionTime)
                    .HasColumnName("dteInsertionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntAccountId).HasColumnName("intAccountID");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonRunningBalance)
                    .HasColumnName("monRunningBalance")
                    .HasColumnType("money");

                entity.Property(e => e.StrChequeNo)
                    .HasColumnName("strChequeNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrDescription)
                    .IsRequired()
                    .HasColumnName("strDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrParticulars)
                    .IsRequired()
                    .HasColumnName("strParticulars")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.YsnCompleted).HasColumnName("ysnCompleted");

                entity.Property(e => e.YsnVoucherInserted).HasColumnName("ysnVoucherInserted");
            });

            modelBuilder.Entity<TblPfbankBook>(entity =>
            {
                entity.HasKey(e => e.IntPfBankBookId)
                    .HasName("PK_tblPF_BankBook");

                entity.ToTable("tblPFBankBook");

                entity.Property(e => e.IntPfBankBookId).HasColumnName("intPF_BankBookId");

                entity.Property(e => e.DteInsertDate)
                    .HasColumnName("dteInsertDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntAccountNo).HasColumnName("intAccountNo");

                entity.Property(e => e.IntPfRecieveId).HasColumnName("intPF_RecieveID");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");

                entity.Property(e => e.StrRecieveCode)
                    .HasColumnName("strRecieveCode")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPfinvestment>(entity =>
            {
                entity.HasKey(e => e.IntInvestmentId);

                entity.ToTable("tblPFInvestment");

                entity.Property(e => e.IntInvestmentId).HasColumnName("intInvestmentID");

                entity.Property(e => e.DteClosingDate)
                    .HasColumnName("dteClosingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteDateEffectedFrom)
                    .HasColumnName("dteDateEffectedFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntBankAccountNo).HasColumnName("intBankAccountNo");

                entity.Property(e => e.IntBankId).HasColumnName("intBankId");

                entity.Property(e => e.IntBranchId).HasColumnName("intBranchId");

                entity.Property(e => e.IntInvestmentTypeId).HasColumnName("intInvestmentTypeID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.MonInvestmentAmount)
                    .HasColumnName("monInvestmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonProfit)
                    .HasColumnName("monProfit")
                    .HasColumnType("money");

                entity.Property(e => e.NumInterestRate)
                    .HasColumnName("numInterestRate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumInvestmentDuration)
                    .HasColumnName("numInvestmentDuration")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YsnMatured).HasColumnName("ysnMatured");
            });

            modelBuilder.Entity<TblPfinvestmentType>(entity =>
            {
                entity.HasKey(e => e.IntInvestmentTypeId)
                    .HasName("PK_tblPF_InvestmentType");

                entity.ToTable("tblPFInvestmentType");

                entity.Property(e => e.IntInvestmentTypeId).HasColumnName("intInvestmentTypeID");

                entity.Property(e => e.StrInvestmentType)
                    .HasColumnName("strInvestmentType")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StrTypeDescription)
                    .HasColumnName("strTypeDescription")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblPfrecieveBankStatement>(entity =>
            {
                entity.HasKey(e => e.IntPfRecieveId)
                    .HasName("PK_tblPF_RecieveBankStatement");

                entity.ToTable("tblPFRecieveBankStatement");

                entity.Property(e => e.IntPfRecieveId).HasColumnName("intPF_RecieveID");

                entity.Property(e => e.DteRecieveDate)
                    .HasColumnName("dteRecieveDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntAccountNo).HasColumnName("intAccountNo");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");

                entity.Property(e => e.StrCheckNo)
                    .HasColumnName("strCheckNo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StrPerticulars)
                    .HasColumnName("strPerticulars")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrRecieveCode)
                    .HasColumnName("strRecieveCode")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StrVoucharCode)
                    .HasColumnName("strVoucharCode")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPolicyDocType>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblPolicyDocType");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrType)
                    .HasColumnName("strType")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblPrevilegeLeave>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblPrevilegeLeave");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteHrstartingYear)
                    .HasColumnName("dteHRStartingYear")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntPrevilegeDays).HasColumnName("intPrevilegeDays");

                entity.Property(e => e.MonPrevilegeMoney)
                    .HasColumnName("monPrevilegeMoney")
                    .HasColumnType("money");

                entity.Property(e => e.YsnLeaveTaken).HasColumnName("ysnLeaveTaken");
            });

            modelBuilder.Entity<TblPunchMechineConfig>(entity =>
            {
                entity.HasKey(e => e.IntPunchId);

                entity.ToTable("tblPunchMechineConfig");

                entity.Property(e => e.IntPunchId).HasColumnName("intPunchID");

                entity.Property(e => e.IntRouteId).HasColumnName("intRouteID");

                entity.Property(e => e.StrAddress)
                    .HasColumnName("strAddress")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrMachineStatus)
                    .HasColumnName("strMachineStatus")
                    .IsUnicode(false);

                entity.Property(e => e.StrMechineNumber)
                    .HasColumnName("strMechineNumber")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrPunchMechineIp)
                    .HasColumnName("strPunchMechineIP")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrRouteName)
                    .HasColumnName("strRouteName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUnit)
                    .HasColumnName("strUnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YsnBoth).HasColumnName("ysnBoth");

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");

                entity.Property(e => e.YsnIn).HasColumnName("ysnIn");

                entity.Property(e => e.YsnOk).HasColumnName("ysnOk");

                entity.Property(e => e.YsnOut).HasColumnName("ysnOut");
            });

            modelBuilder.Entity<TblPunchMechineRawData>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPunchMechineRawData");

                entity.HasIndex(e => e.IntId)
                    .HasName("ClusteredIndex-20180224-200558")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.DteDate, e.DteTime, e.StrVer, e.YsnIo, e.StrWorkCode, e.StrFormMechineIp, e.IntId, e.DteEntryDatetime, e.IntPunchUserId })
                    .HasName("Jun_12_2018_3_49_16_227AM");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteEntryDatetime)
                    .HasColumnName("dteEntryDatetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteTime).HasColumnName("dteTime");

                entity.Property(e => e.IntPunchUserId).HasColumnName("intPunchUserID");

                entity.Property(e => e.StrFormMechineIp)
                    .HasColumnName("strFormMechineIP")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrVer)
                    .HasColumnName("strVer")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StrWorkCode)
                    .HasColumnName("strWorkCode")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.YsnIo).HasColumnName("ysnIO");
            });

            modelBuilder.Entity<TblReligion>(entity =>
            {
                entity.HasKey(e => e.IntReligionId);

                entity.ToTable("tblReligion");

                entity.Property(e => e.IntReligionId).HasColumnName("intReligionID");

                entity.Property(e => e.StrReligionName)
                    .HasColumnName("strReligionName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblRoster>(entity =>
            {
                entity.HasKey(e => e.IntAutoId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblRoster");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteRosterDutyDate)
                    .HasColumnName("dteRosterDutyDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteShiftEnd).HasColumnName("dteShiftEnd");

                entity.Property(e => e.DteShiftStart).HasColumnName("dteShiftStart");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationId");

                entity.Property(e => e.IntPresentShiftId).HasColumnName("intPresentShiftId");

                entity.Property(e => e.IntShiftSequenceNo).HasColumnName("intShiftSequenceNo");

                entity.Property(e => e.YsnConsecutive).HasColumnName("ysnConsecutive");

                entity.Property(e => e.YsnOverTime).HasColumnName("ysnOverTime");

                entity.Property(e => e.YsnRegular).HasColumnName("ysnRegular");
            });

            modelBuilder.Entity<TblRosterScheduleConfig>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblRosterScheduleConfig");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoId");

                entity.Property(e => e.DteLastChangeDate)
                    .HasColumnName("dteLastChangeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteNextChangeDate)
                    .HasColumnName("dteNextChangeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationId");

                entity.Property(e => e.IntNoOfDaysChange).HasColumnName("intNoOfDaysChange");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");
            });

            modelBuilder.Entity<TblSalaryAdvice>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblSalaryAdvice");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.IntBankAccId).HasColumnName("intBankAccID");

                entity.Property(e => e.IntBankId).HasColumnName("intBankID");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntYearId).HasColumnName("intYearID");

                entity.Property(e => e.MonAmount)
                    .HasColumnName("monAmount")
                    .HasColumnType("money");

                entity.Property(e => e.StrAdviceCode)
                    .IsRequired()
                    .HasColumnName("strAdviceCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrBpcode)
                    .IsRequired()
                    .HasColumnName("strBPCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrJvcode)
                    .HasColumnName("strJVCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrStatus)
                    .HasColumnName("strStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSalaryGenerateStation>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblSalaryGenerateStation");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.IntStationId).HasColumnName("intStationID");
            });

            modelBuilder.Entity<TblSalaryWithAccHead>(entity =>
            {
                entity.HasKey(e => e.IntEmpId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblSalaryWithAccHead");

                entity.Property(e => e.IntEmpId)
                    .HasColumnName("intEmpID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DteBirth)
                    .HasColumnName("dteBirth")
                    .HasColumnType("date");

                entity.Property(e => e.DteJoining)
                    .HasColumnName("dteJoining")
                    .HasColumnType("date");

                entity.Property(e => e.IntAbsent).HasColumnName("intAbsent");

                entity.Property(e => e.IntAbsentPunishmentCoa).HasColumnName("intAbsentPunishmentCOA");

                entity.Property(e => e.IntAccommodationCrCoa).HasColumnName("intAccommodationCrCOA");

                entity.Property(e => e.IntAccommodationDrCoa).HasColumnName("intAccommodationDrCOA");

                entity.Property(e => e.IntAefpscrCoa).HasColumnName("intAEFPSCrCOA");

                entity.Property(e => e.IntAefpsdrCoa).HasColumnName("intAEFPSDrCOA");

                entity.Property(e => e.IntAttendanceBenefitCoa).HasColumnName("intAttendanceBenefitCOA");

                entity.Property(e => e.IntBl).HasColumnName("intBL");

                entity.Property(e => e.IntCafeteriaCoa).HasColumnName("intCafeteriaCOA");

                entity.Property(e => e.IntCanteenCoa).HasColumnName("intCanteenCOA");

                entity.Property(e => e.IntCl).HasColumnName("intCL");

                entity.Property(e => e.IntCoinCoa).HasColumnName("intCoinCOA");

                entity.Property(e => e.IntConveyanceAllowanceCoa).HasColumnName("intConveyanceAllowanceCOA");

                entity.Property(e => e.IntDayoffBenefitCoa).HasColumnName("intDayoffBenefitCOA");

                entity.Property(e => e.IntDishBillCoa).HasColumnName("intDishBillCOA");

                entity.Property(e => e.IntDofferBenefitCoa).HasColumnName("intDofferBenefitCOA");

                entity.Property(e => e.IntDormataryBenefitCoa).HasColumnName("intDormataryBenefitCOA");

                entity.Property(e => e.IntDriverAllowanceCoa).HasColumnName("intDriverAllowanceCOA");

                entity.Property(e => e.IntEl).HasColumnName("intEL");

                entity.Property(e => e.IntElectricBillCoa).HasColumnName("intElectricBillCOA");

                entity.Property(e => e.IntEmployeeJobStationId).HasColumnName("intEmployeeJobStationId");

                entity.Property(e => e.IntFlatInstallmentCr).HasColumnName("intFlatInstallmentCr");

                entity.Property(e => e.IntFlatInstallmentDr).HasColumnName("intFlatInstallmentDr");

                entity.Property(e => e.IntGymCoa).HasColumnName("intGymCOA");

                entity.Property(e => e.IntHeatBenefitCoa).HasColumnName("intHeatBenefitCOA");

                entity.Property(e => e.IntHoliday).HasColumnName("intHoliday");

                entity.Property(e => e.IntHouseRentAllowanceCoa).HasColumnName("intHouseRentAllowanceCOA");

                entity.Property(e => e.IntJobStation).HasColumnName("intJobStation");

                entity.Property(e => e.IntJoraBenifitCoa).HasColumnName("intJoraBenifitCOA");

                entity.Property(e => e.IntLate).HasColumnName("intLate");

                entity.Property(e => e.IntLatePunishmentCoa).HasColumnName("intLatePunishmentCOA");

                entity.Property(e => e.IntLeavePunishmentCoa).HasColumnName("intLeavePunishmentCOA");

                entity.Property(e => e.IntLieuBenefitCoa).HasColumnName("intLieuBenefitCOA");

                entity.Property(e => e.IntLoanCrCoa).HasColumnName("intLoanCrCOA");

                entity.Property(e => e.IntLoanDrCoa).HasColumnName("intLoanDrCOA");

                entity.Property(e => e.IntLwp).HasColumnName("intLWP");

                entity.Property(e => e.IntMl).HasColumnName("intML");

                entity.Property(e => e.IntMobileAllowanceCoa).HasColumnName("intMobileAllowanceCOA");

                entity.Property(e => e.IntMonthId).HasColumnName("intMonthID");

                entity.Property(e => e.IntMotorCycleAllowanceCoa).HasColumnName("intMotorCycleAllowanceCOA");

                entity.Property(e => e.IntNetPayableSalaryCoa).HasColumnName("intNetPayableSalaryCOA");

                entity.Property(e => e.IntNightAllowanceCoa).HasColumnName("intNightAllowanceCOA");

                entity.Property(e => e.IntNightBenefitCoa).HasColumnName("intNightBenefitCOA");

                entity.Property(e => e.IntNightDuty).HasColumnName("intNightDuty");

                entity.Property(e => e.IntNontabBenefitCoa).HasColumnName("intNontabBenefitCOA");

                entity.Property(e => e.IntOffday).HasColumnName("intOffday");

                entity.Property(e => e.IntOtamountCoa).HasColumnName("intOTAmountCOA");

                entity.Property(e => e.IntPfcompanyCrCoa).HasColumnName("intPFCompanyCrCOA");

                entity.Property(e => e.IntPfcompanyDrCoa).HasColumnName("intPFCompanyDrCOA");

                entity.Property(e => e.IntPfempCrCoa).HasColumnName("intPFEmpCrCOA");

                entity.Property(e => e.IntPfempDrCoa).HasColumnName("intPFEmpDrCOA");

                entity.Property(e => e.IntPl).HasColumnName("intPL");

                entity.Property(e => e.IntPlamountCoa).HasColumnName("intPLAmountCOA");

                entity.Property(e => e.IntPresent).HasColumnName("intPresent");

                entity.Property(e => e.IntPunishmentCrCoa).HasColumnName("intPunishmentCrCOA");

                entity.Property(e => e.IntPunishmentDrCoa).HasColumnName("intPunishmentDrCOA");

                entity.Property(e => e.IntSalaryCoa).HasColumnName("intSalaryCOA");

                entity.Property(e => e.IntScottBenefitCoa).HasColumnName("intScottBenefitCOA");

                entity.Property(e => e.IntSl).HasColumnName("intSL");

                entity.Property(e => e.IntSpecialSalaryAllowanceCoa).HasColumnName("intSpecialSalaryAllowanceCOA");

                entity.Property(e => e.IntTadaamountCoa).HasColumnName("intTADAAmountCOA");

                entity.Property(e => e.IntTaxCrCoa).HasColumnName("intTaxCrCOA");

                entity.Property(e => e.IntTaxDrCoa).HasColumnName("intTaxDrCOA");

                entity.Property(e => e.IntTotalHours).HasColumnName("intTotalHours");

                entity.Property(e => e.IntTransportCoa).HasColumnName("intTransportCOA");

                entity.Property(e => e.IntUnionDonationAllowanceCoa).HasColumnName("intUnionDonationAllowanceCOA");

                entity.Property(e => e.IntUnionFeeCrCoa).HasColumnName("intUnionFeeCrCOA");

                entity.Property(e => e.IntUnionFeeDrCoa).HasColumnName("intUnionFeeDrCOA");

                entity.Property(e => e.IntUnit).HasColumnName("intUnit");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntWorkingDays).HasColumnName("intWorkingDays");

                entity.Property(e => e.IntYearId).HasColumnName("intYearID");

                entity.Property(e => e.MonAbsentPunishmentAmount)
                    .HasColumnName("monAbsentPunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonAccommodation)
                    .HasColumnName("monAccommodation")
                    .HasColumnType("money");

                entity.Property(e => e.MonAttendanceBenifit)
                    .HasColumnName("monAttendanceBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonBasicAmount)
                    .HasColumnName("monBasicAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonCafeteriaBill)
                    .HasColumnName("monCafeteriaBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCanteenBill)
                    .HasColumnName("monCanteenBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonCarMotorcycleLoan)
                    .HasColumnName("monCarMotorcycleLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonCoinAmount)
                    .HasColumnName("monCoinAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonConveyanceAllowance)
                    .HasColumnName("monConveyanceAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonDayoffBenifit)
                    .HasColumnName("monDayoffBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDishBill)
                    .HasColumnName("monDishBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonDofferBenifit)
                    .HasColumnName("monDofferBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDormataryBenifit)
                    .HasColumnName("monDormataryBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonDriverAllowance)
                    .HasColumnName("monDriverAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonDueAefps)
                    .HasColumnName("monDueAEFPS")
                    .HasColumnType("money");

                entity.Property(e => e.MonElectricBill)
                    .HasColumnName("monElectricBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonFlatInstallment)
                    .HasColumnName("monFlatInstallment")
                    .HasColumnType("money");

                entity.Property(e => e.MonGratuity)
                    .HasColumnName("monGratuity")
                    .HasColumnType("money");

                entity.Property(e => e.MonGrossSalary)
                    .HasColumnName("monGrossSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonGymBill)
                    .HasColumnName("monGymBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonHajjLoan)
                    .HasColumnName("monHajjLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHeatBenifit)
                    .HasColumnName("monHeatBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonHomeLoan)
                    .HasColumnName("monHomeLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAllowance)
                    .HasColumnName("monHouseRentAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonHouseRentAmount)
                    .HasColumnName("monHouseRentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoindatePenalty)
                    .HasColumnName("monJoindatePenalty")
                    .HasColumnType("money");

                entity.Property(e => e.MonJoraBenifit)
                    .HasColumnName("monJoraBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLatePunishmentAmount)
                    .HasColumnName("monLatePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLeavePunishmentAmount)
                    .HasColumnName("monLeavePunishmentAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonLieuBenifit)
                    .HasColumnName("monLieuBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoan)
                    .HasColumnName("monLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MonLoanAmount)
                    .HasColumnName("monLoanAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMedicalAllowanceAmount)
                    .HasColumnName("monMedicalAllowanceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonMobileAllowance)
                    .HasColumnName("monMobileAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonMotorCycleAllowance)
                    .HasColumnName("monMotorCycleAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightAllowance)
                    .HasColumnName("monNightAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonNightBenifit)
                    .HasColumnName("monNightBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonNontabBenifit)
                    .HasColumnName("monNontabBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtamount)
                    .HasColumnName("monOTAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonOtherAmount)
                    .HasColumnName("monOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPerHourSalary)
                    .HasColumnName("monPerHourSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfamount)
                    .HasColumnName("monPFAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfemployeeContribution)
                    .HasColumnName("monPFEmployeeContribution")
                    .HasColumnType("money");

                entity.Property(e => e.MonPfemployerContribution)
                    .HasColumnName("monPFEmployerContribution")
                    .HasColumnType("money");

                entity.Property(e => e.MonPlamount)
                    .HasColumnName("monPLAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishment)
                    .HasColumnName("monPunishment")
                    .HasColumnType("money");

                entity.Property(e => e.MonPunishmentSchedule)
                    .HasColumnName("monPunishmentSchedule")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalary)
                    .HasColumnName("monSalary")
                    .HasColumnType("money");

                entity.Property(e => e.MonSalaryAllowancePayInCash)
                    .HasColumnName("monSalaryAllowancePayInCash")
                    .HasColumnType("money");

                entity.Property(e => e.MonScottBenifit)
                    .HasColumnName("monScottBenifit")
                    .HasColumnType("money");

                entity.Property(e => e.MonSecurityDeposit)
                    .HasColumnName("monSecurityDeposit")
                    .HasColumnType("money");

                entity.Property(e => e.MonSpecialSalaryAllowance)
                    .HasColumnName("monSpecialSalaryAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonTadaamount)
                    .HasColumnName("monTADAAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTaxAmount)
                    .HasColumnName("monTaxAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTotalOthour)
                    .HasColumnName("monTotalOTHour")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportAmount)
                    .HasColumnName("monTransportAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MonTransportBill)
                    .HasColumnName("monTransportBill")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionDonationAllowance)
                    .HasColumnName("monUnionDonationAllowance")
                    .HasColumnType("money");

                entity.Property(e => e.MonUnionFee)
                    .HasColumnName("monUnionFee")
                    .HasColumnType("money");

                entity.Property(e => e.StrAreaName)
                    .HasColumnName("strAreaName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankAccountNo)
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankBranchName)
                    .HasColumnName("strBankBranchName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBankName)
                    .HasColumnName("strBankName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcgroupName)
                    .HasColumnName("strCCGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcname)
                    .HasColumnName("strCCName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcpname)
                    .HasColumnName("strCCPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcppname)
                    .HasColumnName("strCCPPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcspname)
                    .HasColumnName("strCCSPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrCcsspname)
                    .HasColumnName("strCCSSPName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrContactNo1)
                    .HasColumnName("strContactNo1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDepartment)
                    .HasColumnName("strDepartment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .HasColumnName("strDesignation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDistrict)
                    .HasColumnName("strDistrict")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrDob)
                    .HasColumnName("strDOB")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmployeeCode)
                    .HasColumnName("strEmployeeCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGlcode)
                    .HasColumnName("strGLCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrGroupName)
                    .HasColumnName("strGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobStationName)
                    .HasColumnName("strJobStationName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .HasColumnName("strJobType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrOfficeEmail)
                    .HasColumnName("strOfficeEmail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRegionName)
                    .HasColumnName("strRegionName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrRoutingNumber)
                    .HasColumnName("strRoutingNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrServiceLength)
                    .HasColumnName("strServiceLength")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrStatus)
                    .HasColumnName("strStatus")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrTeritoryName)
                    .HasColumnName("strTeritoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrUnit)
                    .HasColumnName("strUnit")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShift>(entity =>
            {
                entity.HasKey(e => e.IntShiftId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblShift");

                entity.Property(e => e.IntShiftId).HasColumnName("intShiftID");

                entity.Property(e => e.DteEndTime)
                    .HasColumnName("dteEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteStartTime)
                    .HasColumnName("dteStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.InGracePeriodInMinute).HasColumnName("inGracePeriodInMinute");

                entity.Property(e => e.IntJobStationId).HasColumnName("intJobStationID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntshiftSequenceNo).HasColumnName("intshiftSequenceNo");

                entity.Property(e => e.StrShiftName)
                    .HasColumnName("strShiftName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUnit>(entity =>
            {
                entity.HasKey(e => e.IntUnitId);

                entity.ToTable("tblUnit");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntBankAccId).HasColumnName("intBankAccID");

                entity.Property(e => e.IntIrcrenewYear)
                    .HasColumnName("intIRCRenewYear")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntLastActionBy).HasColumnName("intLastActionBy");

                entity.Property(e => e.IntOwnershipType).HasColumnName("intOwnershipType");

                entity.Property(e => e.IntParentUnit).HasColumnName("intParentUnit");

                entity.Property(e => e.StrAccEmailAddress)
                    .HasColumnName("strAccEmailAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StrBusinessArea)
                    .HasColumnName("strBusinessArea")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrFax)
                    .HasColumnName("strFax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrIrc)
                    .HasColumnName("strIRC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrLoginUser)
                    .HasColumnName("strLoginUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPhone)
                    .HasColumnName("strPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrTin)
                    .HasColumnName("strTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUnit)
                    .IsRequired()
                    .HasColumnName("strUnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrVatregNo)
                    .HasColumnName("strVATRegNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");

                entity.Property(e => e.YsnPfunit).HasColumnName("ysnPFUnit");

                entity.Property(e => e.YsnVatExemption).HasColumnName("ysnVatExemption");
            });

            modelBuilder.Entity<TblUnitAddress>(entity =>
            {
                entity.HasKey(e => new { e.IntUnitId, e.IntAddressTypeId });

                entity.ToTable("tblUnitAddress");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.IntAddressTypeId).HasColumnName("intAddressTypeID");

                entity.Property(e => e.StrAddress)
                    .IsRequired()
                    .HasColumnName("strAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmailAddress)
                    .HasColumnName("strEmailAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrFax)
                    .HasColumnName("strFax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPhoneNo)
                    .HasColumnName("strPhoneNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrWebAddress)
                    .HasColumnName("strWebAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUnitAddressType>(entity =>
            {
                entity.HasKey(e => e.IntAddressTypeId);

                entity.ToTable("tblUnitAddressType");

                entity.Property(e => e.IntAddressTypeId).HasColumnName("intAddressTypeID");

                entity.Property(e => e.StrType)
                    .IsRequired()
                    .HasColumnName("strType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUnitByUser>(entity =>
            {
                entity.HasKey(e => new { e.IntUnitId, e.IntUserId });

                entity.ToTable("tblUnitByUser");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitId");

                entity.Property(e => e.IntUserId).HasColumnName("intUserId");
            });

            modelBuilder.Entity<TblUserAdProfile>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblUserAD_Profile");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.AccountDisabled)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountExpiresEndOfDateTime)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRegion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionAd)
                    .HasColumnName("Description_AD")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Home)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HomeFolderConnectDrive)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HomeFolderConnectTo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HomeFolderLocalPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IpPhone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JpegPhoto).HasColumnType("image");

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogonHours)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LogonOnToLogonWorkstations)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogonScript)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Manager)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Office)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherFaxNumbers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherHomePhonenumbers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherIpPhoneNumbers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherMobileNumbers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPagerNumbers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherTelephoneNumbers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherWebPages)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.POBox)
                    .HasColumnName("P_O_Box")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pager)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordneverExpires)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PreWindows2000LogonName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvince)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StorePasswordUsingReversibleEncryption)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbnailLogo).HasColumnType("image");

                entity.Property(e => e.ThumbnailPhoto).HasColumnType("image");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserCannotChangePassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLogonName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserMustChangePasswordAtNextLogon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WebPage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ZipPostalCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserDesignation>(entity =>
            {
                entity.HasKey(e => e.IntDesignationId);

                entity.ToTable("tblUserDesignation");

                entity.Property(e => e.IntDesignationId).HasColumnName("intDesignationID");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntGcafeteria).HasColumnName("intGCafeteria");

                entity.Property(e => e.IntLastActionBy).HasColumnName("intLastActionBy");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrDesignation)
                    .IsRequired()
                    .HasColumnName("strDesignation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblUserInfo>(entity =>
            {
                entity.HasKey(e => e.IntUserId);

                entity.ToTable("tblUserInfo");

                entity.HasIndex(e => e.IntEmployeeId)
                    .HasName("Apr_6_2018_11_00_08_683PM");

                entity.HasIndex(e => e.StrEmail)
                    .HasName("May_4_2018_11_00_17_813PM");

                entity.HasIndex(e => e.StrUserCode)
                    .HasName("Dec_11_2017_10_50_42_090AM");

                entity.Property(e => e.IntUserId)
                    .HasColumnName("intUserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DteAppointmentDate)
                    .HasColumnName("dteAppointmentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteLeaveEndDate)
                    .HasColumnName("dteLeaveEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteLeaveStartDate)
                    .HasColumnName("dteLeaveStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntContactPeriod).HasColumnName("intContactPeriod");

                entity.Property(e => e.IntDepartmentId).HasColumnName("intDepartmentID");

                entity.Property(e => e.IntDesignationId).HasColumnName("intDesignationID");

                entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeID");

                entity.Property(e => e.IntInLeaveUserId).HasColumnName("intInLeaveUserID");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeID");

                entity.Property(e => e.IntLastActionBy).HasColumnName("intLastActionBy");

                entity.Property(e => e.IntLevel).HasColumnName("intLevel");

                entity.Property(e => e.IntParentUserId).HasColumnName("intParentUserID");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrEmail)
                    .HasColumnName("strEmail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .IsRequired()
                    .HasColumnName("strName")
                    .HasMaxLength(150);

                entity.Property(e => e.StrPerDistrict)
                    .HasColumnName("strPerDistrict")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPerDivission)
                    .HasColumnName("strPerDivission")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPerOther)
                    .HasColumnName("strPerOther")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPerPs)
                    .HasColumnName("strPerPS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPhone1)
                    .HasColumnName("strPhone1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPhone2)
                    .HasColumnName("strPhone2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPreDistrict)
                    .HasColumnName("strPreDistrict")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPreDivission)
                    .HasColumnName("strPreDivission")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPreOther)
                    .HasColumnName("strPreOther")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPrePs)
                    .HasColumnName("strPrePS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrSortName)
                    .IsRequired()
                    .HasColumnName("strSortName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserCode)
                    .HasColumnName("strUserCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblUserJobType>(entity =>
            {
                entity.HasKey(e => e.IntJobTypeId);

                entity.ToTable("tblUserJobType");

                entity.Property(e => e.IntJobTypeId).HasColumnName("intJobTypeID");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntLastActionBy).HasColumnName("intLastActionBy");

                entity.Property(e => e.IntUnitId).HasColumnName("intUnitID");

                entity.Property(e => e.StrDescription)
                    .HasColumnName("strDescription")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobType)
                    .IsRequired()
                    .HasColumnName("strJobType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrJobTypeShort)
                    .HasColumnName("strJobTypeShort")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");
            });

            modelBuilder.Entity<TblWorkPlan>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblWorkPlan");

                entity.Property(e => e.IntAutoId).HasColumnName("intAutoID");

                entity.Property(e => e.DteDate)
                    .HasColumnName("dteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntInsertBy).HasColumnName("intInsertBy");

                entity.Property(e => e.StrFinancialYear)
                    .HasColumnName("strFinancialYear")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StrSubject)
                    .HasColumnName("strSubject")
                    .IsUnicode(false);

                entity.Property(e => e.StrWorkPlanDetalis)
                    .HasColumnName("strWorkPlanDetalis")
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblWorkPlanDoc>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblWorkPlanDoc");

                entity.Property(e => e.IntId).HasColumnName("intID");

                entity.Property(e => e.IntRefWorkPlan).HasColumnName("intRefWorkPlan");

                entity.Property(e => e.StrFtpPath)
                    .HasColumnName("strFtpPath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });

            modelBuilder.Entity<TblofficialMovementType>(entity =>
            {
                entity.HasKey(e => e.IntMoveTypeId)
                    .HasName("PK_tbloffialMovementType");

                entity.ToTable("tblofficialMovementType");

                entity.Property(e => e.IntMoveTypeId).HasColumnName("intMoveTypeID");

                entity.Property(e => e.StrMoveType)
                    .HasColumnName("strMoveType")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.YsnActive).HasColumnName("ysnActive");
            });
        }
    }
}
