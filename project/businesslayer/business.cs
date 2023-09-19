using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using datalayer;

namespace businesslayer
{
    public class User_business : User_dataclass
    {
        public User_business()
        { }
        public User_business(string UserFirstName, string UserLastName, string UserEmailAddress, string UserPassword, Int32 UserMobile, DateTime UserDOB, string UserAddress, Int32 UserDesignation, Int32 UserStatus)
            : base(UserFirstName, UserLastName, UserEmailAddress, UserPassword, UserMobile, UserDOB, UserAddress, UserDesignation, UserStatus)
        { }
        public User_business(string UserEmailAddress, string UserPassword)
            : base(UserEmailAddress,UserPassword)
        { }
        public User_business(string UserOldPassword,string UserNewPassword,Int32 UserId)
            :base(UserOldPassword,UserNewPassword,UserId)
        {}
        public User_business(Int32 UserId, String UserFirstName, String UserLastName, String UserEmailAddress, Int32 UserMobile, DateTime UserDOB, Int32 UserDesignation, String UserAddress)
            : base(UserId, UserFirstName, UserLastName, UserEmailAddress, UserMobile, UserDOB, UserDesignation,UserAddress)
        {
        }
        public void Insert_User()
        {
            User_Insert();
        }
        public Int32 User_Login(out int UserDec,out String UsrName)
        {
            
            Int32 a = Login_Check(out UserDec,out UsrName);
            return a;
        }
        public Int32 Change_UserPassword()
        {
            Int32 ret = Change_Password();
            return ret;
        }
        public DataTable Display_All_User_Name()
        {
            DataTable dt = new DataTable();
            dt = Disply_AllUserName();
            return dt;
        }
        public DataTable Display_User_Designation()
        {
            DataTable dt = new DataTable();
            dt = Disply_UserDesignation();
            return dt;
        }
        public DataTable Display_User_Detail()
        {
            DataTable dt = new DataTable();
            dt = Display_UserDetail();
            return dt;
        }
        public DataTable Find_User_Detail(Int32 UserId)
        {
            DataTable dt = new DataTable();
            dt = Find_UserDetail(UserId);
            return dt;
        }
        public void Update_User_Detail()
        {
            Update_UserDetail();
        }
        public DataTable Display_User_Name()
        {
            DataTable dt = new DataTable();
            dt = Display_UserName();
            return dt;
        }

    }
    public class Salary_Detail_business : Salary_Detail_dataclass
    {
        public Salary_Detail_business()
        { }
        public Salary_Detail_business(Int32 UserId, Int32 Basic, Int32 HRA, Int32 TA, Int32 DA, Int32 DailyRate, Int32 DailyOvertimeRate, Int32 DailyReductionRate, Int32 TotalSalary)
            : base(UserId,Basic,HRA,TA,DA,DailyRate,DailyOvertimeRate,DailyReductionRate,TotalSalary)
        { }
      
        public void Insert_Salary_Detail()
        {
            SalaryDeatil_Insert();
        }
        public DataTable Display_salary_Detail()
        {
            DataTable dt = new DataTable();
            dt = Display_SalaryDetail();
            return dt;
        }
        public DataTable Find_Salary_Detail(Int32 SalaryId)
        {
            DataTable dt = new DataTable();
            dt = Find_SalaryDetail(SalaryId);
            return dt;
        }
        public void Update_Salary_Detail()
        {
            Update_SalaryDetail();
        }
    }
    public class User_Attends_business : UserAttends_dataclass
    {
        public User_Attends_business()
        { }
        public User_Attends_business(Int32 UserId, DateTime LoginDateTime,Char AttendsRegister,Int32 BitField)
            : base(UserId,LoginDateTime,AttendsRegister,BitField)
        { }
        public User_Attends_business(Int32 UserId, DateTime LoginDateTime, DateTime LogoutDateTime, String DailyTotalHours)
            : base(UserId,LoginDateTime,LogoutDateTime,DailyTotalHours)
        { }
        public void Insert_User_Allends()
        {
            Insert_UserAttends();
        }
        public void Update_User_Attends()
        {
            Update_UserAttends();
        }
        public DateTime Get_LoginDate(Int32 UserId)
        {
            DateTime dt = Get_UserLoginDateTime(UserId);
            return dt;
        }
    }

    public class Leave_business : ApplyLeave_dataclass
    {
        public Leave_business()
        { }
        public Leave_business(String UserName, Int32 UserId, Int32 Designation, DateTime LeaveFrom, DateTime LeaveTo, String NoOfDay, String Reason, Int32 IsConfirm, DateTime ApplyDate)
               :base(UserName,UserId,Designation,LeaveFrom,LeaveTo,NoOfDay, Reason, IsConfirm, ApplyDate)
        { }
        public void Insert_Apply_Leave()
        {
            ApplyLeave_Insert();
        }
        public DataTable  Check_Leave_Request()
        {
            DataTable dt = new DataTable();
            dt = Check_LeaveRequest();
            return dt;
        }
        public void Confirm_Leave(Int32 Id)
        {
            ConfirmLeave(Id);
        }
        public void Cancel_Leave(Int32 Id)
        {
            CancelLeave(Id);
        }
        public DataTable Check_Leave_Respones(Int32 UserId)
        {
            DataTable dt = new DataTable();
            dt = Check_LeaveResponse(UserId);
            return dt;
        }
        public void Delete_Leave_Request(Int32 Id)
        {
            Delete_LeaveRequest(Id);
        }
    }
}

