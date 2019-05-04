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

       
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }
      
       
        public virtual DbSet<TblUnit> TblUnit { get; set; }
      
          

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=test;Initial Catalog=ERP_HR;User ID=test;Password=ttest123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

           
 

            
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
             
        }
    }
}
