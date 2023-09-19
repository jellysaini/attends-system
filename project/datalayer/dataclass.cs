using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace datalayer
{
    //****************class for user **********************
    public class User_dataclass:ClsCon
    {
        //create private variable
        private Int32 _UserId;
        private string _UserFirstName;
        private string _UserLastName;
        private string _UserEmailAddress;
        private string _UserPassword;
        private Int32  _UserMobile;
        private DateTime _UserDOB;
        private Int32 _UserSalary;
        private string _UserAddress;
        private Int32 _UserDesignation;
        private Int32 _UserStatus;
        private String _UserNewPassword;
        //create property
        protected Int32 UserId
        {
            get{return _UserId;}
        }
        protected string UserFirstName
        {
            get { return _UserFirstName; }
        }
        protected string UserLastName
        {
            get { return _UserLastName; }
        }
        protected string UserEmailAddress
        {
            get { return _UserEmailAddress; }
        }
        protected string UserPassword
        {
            get { return _UserPassword; }
        }
        protected Int32 UserMobile
        {
            get { return _UserMobile; }
        }
        protected DateTime UserDOB
        {
            get { return _UserDOB; }
        }
        protected Int32 UserSalary
        {
            get { return _UserSalary; }
        }
        protected string UserAddress
        {
            get { return _UserAddress; }
        }
        protected Int32 UserDesignation
        {
            get { return _UserDesignation; }
        }
        protected Int32 UserStatus
        {
            get { return _UserStatus; }
        }
        protected String UserNewPassword
        {
            get{return _UserNewPassword;}
        }
        public User_dataclass()//default constructor
        { }
        //create a parameter constructor for User_insert
        public User_dataclass(string UserFirstName, string UserLastName, string UserEmailAddress, string UserPassword, Int32 UserMobile, DateTime UserDOB, string UserAddress, Int32 UserDesignation, Int32 UserStatus)
        {
            //pass value to private variables//
            
            _UserFirstName = UserFirstName;
            _UserLastName = UserLastName;
            _UserEmailAddress = UserEmailAddress;
            _UserPassword = UserPassword;
            _UserMobile = UserMobile;
            _UserDOB = UserDOB;
            
            _UserAddress = UserAddress;
            _UserDesignation = UserDesignation;
            _UserStatus = UserStatus;
        }
        //parameter constructor for Login_Check
        public User_dataclass(String UserEmailAddress, String UserPassword)
        {
            //pass value to private variables//
            _UserEmailAddress = UserEmailAddress;
            _UserPassword = UserPassword;
          
        }
        //parameter  constructor for change password
        public User_dataclass(String UserOldPasword, String UserNewPassword, Int32 UserId)
        {
            _UserPassword = UserOldPasword;
            _UserNewPassword = UserNewPassword;
            _UserId = UserId;
        }
        //create a parameter constructor
        public User_dataclass(Int32 UserId, String UserFirstName, String UserLastName, String UserEmailAddress, Int32 UserMobile, DateTime UserDOB, Int32 UserDesignation, String UserAddress)
        {
            _UserId = UserId;
            _UserFirstName = UserFirstName;
            _UserLastName = UserLastName;
            _UserEmailAddress = UserEmailAddress;
            _UserMobile = UserMobile;
            _UserDOB = UserDOB;
            _UserDesignation = UserDesignation;
            _UserAddress=UserAddress;
        }
        //*****************************Insert New User***********************//
        protected void User_Insert()
        {
            //SqlConnection con = get_connection();
            if (con.State ==ConnectionState.Closed)//check connection is it open or close
            {
                con.Open(); //open the connection
            }
            SqlCommand cmd = new SqlCommand("Insert_User", con);//create the object of sqlcommand ans pass store procedure and connection
            cmd.CommandType = CommandType.StoredProcedure;
            //pass parameters//
            cmd.Parameters.Add("@UserFirstName", SqlDbType.VarChar, 50).Value = UserFirstName;
            cmd.Parameters.Add("@UserLastName", SqlDbType.VarChar, 50).Value = UserLastName;
            cmd.Parameters.Add("@UserEmailAddress", SqlDbType.VarChar, 50).Value = UserEmailAddress;
            cmd.Parameters.Add("@UserPassword", SqlDbType.VarChar, 50).Value = UserPassword;
            cmd.Parameters.Add("@UserMobile", SqlDbType.Int).Value = UserMobile;
            cmd.Parameters.Add("@UserDOB", SqlDbType.DateTime).Value = UserDOB;
            cmd.Parameters.Add("@UserAddress", SqlDbType.VarChar, 300).Value = UserAddress;
            cmd.Parameters.Add("@UserDesignation", SqlDbType.Int).Value = UserDesignation;
            cmd.Parameters.Add("@UserStatus", SqlDbType.Int).Value = UserStatus;
            try
            {
                cmd.ExecuteNonQuery(); //execute the command and return the no of records//
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose(); //dispose the command
                con.Close(); //close the connection
            }
        }
        //*****************************Login Checking **********************//
        protected Int32  Login_Check(out Int32 UserDesignation,out String UserFirstName)
        {
            if (con.State == ConnectionState.Closed)//check connection  
            {
                con.Open();//open the connection    
            }
            SqlCommand cmd = new SqlCommand("Login_Check", con);//pass store procedure and connection object to the sqlcommand object
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserEmailAddress", SqlDbType.VarChar, 50).Value = UserEmailAddress;//pass parameter
            cmd.Parameters.Add("@UserPassword", SqlDbType.VarChar, 50).Value = UserPassword;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Direction = ParameterDirection.Output;//this is the output parameter
            cmd.Parameters.Add("@UserFirstName", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;//output parameter
            cmd.Parameters.Add("@UserDesignation", SqlDbType.Int).Direction = ParameterDirection.Output;//output parameter
            try
            {
                cmd.ExecuteNonQuery();//execute the command
                UserDesignation = Convert.ToInt32(cmd.Parameters["@UserDesignation"].Value);//pass the value to the output parameter
                UserFirstName = Convert.ToString(cmd.Parameters["@UserFirstName"].Value);//pass the value to output parameter
                Int32 a = Convert.ToInt32(cmd.Parameters["@UserId"].Value);//this is the return type value 
                return a;//return the value to business layer
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

        }
        //******************************Change Password**************************//
        protected Int32 Change_Password()
        {
            if (con.State ==ConnectionState.Closed)//check the connection
            {
                con.Open();//open the connection
            }
            SqlCommand cmd = new SqlCommand("Change_Password", con);//pass store procedure and connection object to sqlcomand 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserOldPassword", SqlDbType.VarChar, 50).Value = UserPassword;//pass parameter
            cmd.Parameters.Add("@UserNewPassword", SqlDbType.VarChar, 50).Value = UserNewPassword;//pass parameter
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;//pass parameter
            SqlParameter p1 = new SqlParameter("@ret", SqlDbType.Int);//create sql parameter which get some value and return it
            p1.Direction = ParameterDirection.ReturnValue;// define the type of the parameter
            try
            {
                cmd.Parameters.Add(p1);//add parameter
                cmd.ExecuteNonQuery();//execute the query   
                Int32 a = Convert.ToInt32(cmd.Parameters["@ret"].Value);//pass parameter value to the variable
                return a;//return the value 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //*********************Disply all user name for salary**************************// 
        protected DataTable Disply_AllUserName()
        {
            if (con.State == ConnectionState.Closed)//check the connection
            {
                con.Open();//open the connection
            }
            SqlCommand cmd = new SqlCommand("Display_All_UserName", con);//pass the store procedure and connection object to the sqlcommand object
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);//sqldatareader execute the query and read the the record from table
                DataTable dt = new DataTable();//create the object of data table
                dt.Load(dr);// load the sqldatareader value into datatable object
                DataRow myrow = dt.NewRow();//create a new row which is datatable object type
                myrow[0] = 0;// enter the first value in the row
                myrow[1] = "Please Select User";//enter the second value in the row
                dt.Rows.InsertAt(myrow, 0);//insert this row at 0th position in datatable 
                return dt;// return the datatable
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

        }
        //**********************Display the User Designation****************//
        protected DataTable Disply_UserDesignation()
        {
            if (con.State == ConnectionState.Closed)//check the connection
            {
                con.Open();//opeb the connection
            }
            SqlCommand cmd = new SqlCommand("Display_User_Designation", con);//pass store procedure and connection onject to the sqlcommand object
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);//create sqldatareader object which is execute the query and read the record frok the table
                DataTable dt = new DataTable();//create the object of the datatable
                dt.Load(dr);//load data reader record into datatable object
                DataRow myrow = dt.NewRow();//create a new row which is datatable object tyep
                myrow[0] = 0;//insert  some value at first column in the row
                myrow[1] = "Select Designation";//insert some value to the second column in the row
                dt.Rows.InsertAt(myrow, 0);//insert this row at the 0th position in the datatable object
                return dt;//return the datatable object
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

        }
        //***************************Display All User Detail ************************//
        protected DataTable Display_UserDetail()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Display_User", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

        }
        //**********************************Find User Detail for Update*****************/
        protected DataTable Find_UserDetail(Int32 UserId)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Find_User_Detail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //**********************************Update User Detail****************************//
        protected void Update_UserDetail()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Update_User_Detail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
            cmd.Parameters.Add("@UserFirstName", SqlDbType.VarChar, 50).Value = UserFirstName;
            cmd.Parameters.Add("@UserLastName", SqlDbType.VarChar, 50).Value = UserLastName;
            cmd.Parameters.Add("@UserEmailAddress", SqlDbType.VarChar, 50).Value = UserEmailAddress;
            cmd.Parameters.Add("@UserMobile", SqlDbType.Int).Value = UserMobile;
            cmd.Parameters.Add("@UserDOB", SqlDbType.DateTime).Value = UserDOB;
            cmd.Parameters.Add("@UserDesignation", SqlDbType.Int).Value = UserDesignation;
            cmd.Parameters.Add("@UserAddress", SqlDbType.VarChar, 300).Value = UserAddress;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //*******************************Display All User name in overtime page under user***********************//
        protected DataTable Display_UserName()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Display_UserName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
   }
    public class Salary_Detail_dataclass : ClsCon
    {
        //create the private variable
        private Int32 _SalaryId;
        private Int32 _UserId;
        private Int32 _Basic;
        private Int32 _HRA;
        private Int32 _TA;
        private Int32 _DA;
        private Int32 _DailyRate;
        private Int32 _DailyOvertimeRate;
        private Int32 _DailyReductionRate;
        private Int32 _TotalSalary;
        //create property for every variable
        protected Int32 SalaryId
        {
            get { return _SalaryId; }
        }
        protected Int32 UserId
        {
            get { return _UserId; }
        }
        protected Int32 Basic
        {
            get { return _Basic; }
        }
        protected Int32 HRA
        {
            get { return _HRA; }
        }
        protected Int32 TA
        {
            get { return _TA; }
        }
        protected Int32 DA
        {
            get { return _DA; }
        }
        protected Int32 DailyRate
        {
            get { return _DailyRate; }
        }
        protected Int32 DailyOvertimeRate
        {
            get { return _DailyOvertimeRate; }
        }
        protected Int32 DailyReductionRate
        {
            get { return _DailyReductionRate; }
        }
        protected Int32 ToatalSalary
        {
            get { return _TotalSalary; }
        }
        //create a default constructor
        public Salary_Detail_dataclass()
        { }
        // create parameter constructor
        public Salary_Detail_dataclass(Int32 UserId, Int32 Basic, Int32 HRA, Int32 TA, Int32 DA, Int32 DailyRate, Int32 DailyOvertimeRate, Int32 DailyReductionRate, Int32 TotalSalary)
        {
            _UserId = UserId;
            _Basic = Basic;
            _HRA = HRA;
            _TA = TA;
            _DA = DA;
            _DailyRate = DailyRate;
            _DailyOvertimeRate = DailyOvertimeRate;
            _DailyReductionRate = DailyReductionRate;
            _TotalSalary = TotalSalary;

        }
        
        //*******************Insert_SalaryDetail***************************//
        protected void SalaryDeatil_Insert()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Insert_Salary_Detail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
            cmd.Parameters.Add("@Basic", SqlDbType.Int).Value = Basic;
            cmd.Parameters.Add("@HRA", SqlDbType.Int).Value = HRA;
            cmd.Parameters.Add("@TA", SqlDbType.Int).Value = TA;
            cmd.Parameters.Add("@DA", SqlDbType.Int).Value = DA;
            cmd.Parameters.Add("@DailyRate", SqlDbType.Int).Value = DailyRate;
            cmd.Parameters.Add("@DailyOvertimeRate", SqlDbType.Int).Value = DailyOvertimeRate;
            cmd.Parameters.Add("@DailyReductionRate", SqlDbType.Int).Value = DailyReductionRate;
            cmd.Parameters.Add("@TotalSalary", SqlDbType.Int).Value = ToatalSalary;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //***********************Display Salary Detail*************************//
        protected DataTable Display_SalaryDetail()
        {
            if (con.State ==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Display_salary_detail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //********************************Find the Saray Detail******************//
        protected DataTable Find_SalaryDetail(Int32 SalaryId)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Find_Salary_Detail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SalaryId", SqlDbType.Int).Value = SalaryId;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //***************************Update the Salary Detail**********************//
        protected void Update_SalaryDetail()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Update_Salary_Detail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SalaryId", SqlDbType.Int).Value = UserId;
            cmd.Parameters.Add("Basic", SqlDbType.Int).Value = Basic;
            cmd.Parameters.Add("@HRA", SqlDbType.Int).Value = HRA;
            cmd.Parameters.Add("@TA", SqlDbType.Int).Value = TA;
            cmd.Parameters.Add("@DA", SqlDbType.Int).Value = DA;
            cmd.Parameters.Add("@DailyRate", SqlDbType.Int).Value = DailyRate;
            cmd.Parameters.Add("@DailyOvertimeRate", SqlDbType.Int).Value = DailyOvertimeRate;
            cmd.Parameters.Add("@DailyReductionRate", SqlDbType.Int).Value = DailyReductionRate;
            cmd.Parameters.Add("TotalSalary", SqlDbType.Int).Value = ToatalSalary;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

            
    }
    public class UserAttends_dataclass : ClsCon
    {
        //create private variable//
        private Int32 _Id;
        private Int32 _UserId;
        private DateTime _LoginDateTime;
        private DateTime _LogoutDateTime;
        private String _DailyTotalHours;
        private Char _AttendsRegister;
        private Int32 _BitField;
        //create the property //
        protected Int32 Id
        {
            get { return _Id;}
        }
        protected Int32 UserId
        {
            get { return _UserId; }
        }
        protected DateTime LoginDateTime
        {
            get { return _LoginDateTime; }
        }
        protected DateTime LogoutDateTime
        {
            get { return _LogoutDateTime; }
        }
        protected String  DailyTotalHours
        {
            get { return _DailyTotalHours; }
        }
        protected Char AttendsRegiste
        {
            get { return _AttendsRegister; }
        }
        protected Int32 BitField
        {
            get { return _BitField; }
        }
        //create the default constructor
        public UserAttends_dataclass()
        { }
        //create a parameter constructor
        public UserAttends_dataclass(Int32 UserId, DateTime LoginDateTime,Char AttendsRegister,Int32 BitField)
        {
            _UserId = UserId;
            _LoginDateTime = LoginDateTime;
            _AttendsRegister = AttendsRegister;
            _BitField = BitField;
        }
        //create a parameter constructor
        public UserAttends_dataclass(Int32 UserId,DateTime LoginDateTime, DateTime LogoutDateTime, String DailyTotalHours)
        {
            _UserId = UserId;
            _LoginDateTime = LoginDateTime;
            _LogoutDateTime = LogoutDateTime;
            _DailyTotalHours = DailyTotalHours;
        }
        //*****************************Insert LoginDateTime**************************//
        protected void Insert_UserAttends()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Insert_Attends", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
            cmd.Parameters.Add("@LoginDateTime", SqlDbType.DateTime).Value = LoginDateTime;
            cmd.Parameters.Add("@AttendsRegister", SqlDbType.Char, 1).Value = AttendsRegiste;
            cmd.Parameters.Add("@BitField", SqlDbType.Int).Value = BitField;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
           
        }
        protected void Update_UserAttends()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Update_Attends", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
            cmd.Parameters.Add("@LoginDateTime", SqlDbType.DateTime).Value = LoginDateTime;
            cmd.Parameters.Add("@LogoutDateTime", SqlDbType.DateTime).Value = LogoutDateTime;
            cmd.Parameters.Add("@DailyTotalHours", SqlDbType.VarChar,50).Value = DailyTotalHours;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        protected DateTime Get_UserLoginDateTime(Int32 UserId)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Get_LoginDate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                DateTime lgn = Convert.ToDateTime(dt.Rows[0]["LogindateTime"].ToString());
                return lgn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

    }
    public class ApplyLeave_dataclass : ClsCon
    {
        //create private variable
        private Int32 _Id;
        private String _UserName;
        private Int32 _UserId;
        private Int32 _Designation;
        private DateTime _LeaveFrom;
        private DateTime _LeaveTo;
        private String _NoOfDay;
        private String _Reason;
        private Int32 _IsConfirm;
        private DateTime _ApplyDate;
        //create property for every variable
        protected Int32 Id
        {
            get { return _Id; }
        }
        protected String UserName
        {
            get { return _UserName; }
        }
        protected Int32 UserId
        {
            get { return _UserId; }
        }
        protected Int32 Designation
        {
            get { return _Designation; }
        }
        protected DateTime LeaveFrom
        {
            get { return _LeaveFrom; }
        }
        protected DateTime LeaveTo
        {
            get { return _LeaveTo; }
        }
        protected String NoOfDay
        {
            get { return _NoOfDay; }
        }
        protected String Reason
        {
            get { return _Reason; }
        }
        protected Int32 IsConfirm
        {
            get { return _IsConfirm; }
        }
        protected DateTime ApplyDate
        {
            get { return _ApplyDate; }
        }
        //default constructor
        public ApplyLeave_dataclass()
        { }
        //parameters constructor
        public ApplyLeave_dataclass(String UserName, Int32 UserId, Int32 Designation, DateTime LeaveFrom, DateTime LeaveTo, String NoOfDay, String Reason, Int32 IsConfirm, DateTime ApplyDate)
        {
            _UserName = UserName;
            _UserId = UserId;
            _Designation = Designation;
            _LeaveFrom = LeaveFrom;
            _LeaveTo = LeaveTo;
            _NoOfDay = NoOfDay;
            _Reason = Reason;
            _IsConfirm = IsConfirm;
            _ApplyDate = ApplyDate;

        }
        //**********************************function for apply leave********************************//
        public void ApplyLeave_Insert()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Apply_Leave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = UserName;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
            cmd.Parameters.Add("@Designation", SqlDbType.Int).Value = Designation;
            cmd.Parameters.Add("@LeaveFrom", SqlDbType.DateTime).Value = LeaveFrom;
            cmd.Parameters.Add("@LeaveTo", SqlDbType.DateTime).Value = LeaveTo;
            cmd.Parameters.Add("@NoOfDay", SqlDbType.VarChar,50).Value = NoOfDay;
            cmd.Parameters.Add("@Reason", SqlDbType.VarChar, 300).Value = Reason;
            cmd.Parameters.Add("@IsConfirm", SqlDbType.Int).Value = IsConfirm;
            cmd.Parameters.Add("@ApplyDate", SqlDbType.DateTime).Value = ApplyDate;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();

            }

        }
        //**********************************function for check the leave request********************//
        public DataTable Check_LeaveRequest()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Check_LeaveRequest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //********************************function for confirm leave*******************//
        public void ConfirmLeave(Int32 Id)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Confrim_Leave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //********************************function for cancel leave**********************//
        public void CancelLeave(Int32 Id)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Cancel_Leave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //*********************************function for check leave respones ***********/
        public DataTable Check_LeaveResponse(Int32 UserId)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Check_LeaveResponse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
            try
            {
                SqlDataReader dr =cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        //********************************function for delete the leave request******************/
        public void Delete_LeaveRequest(Int32 Id)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Delete_LeaveRequest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

    }
}
