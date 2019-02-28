//-----------------------------------------------------------------------
// <copyright file="CommonBL.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;
    using Models;
    using Models.AGModels;
    using Newtonsoft.Json;
    using Resources;
    using RestSharp;
    using SmartLibrary.Infrastructure;

    /// <summary>
    /// class CommonBL
    /// </summary>
    public class CommonBL
    {
        /// <summary>
        /// Check for constraints
        /// </summary>
        /// <param name="tableId">table ID</param>
        /// <param name="primaryKey">Primary Key</param>
        /// <returns>flag</returns>
        public static bool CheckForForeignKeyReference(int tableId, int primaryKey)
        {
            bool flag = false;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.CheckReferenceOfPrimaryKey(tableId, primaryKey);
                if (ds != null && ds.Tables.Count > 0)
                {
                    for (int i = 0; i < ds.Tables.Count; i++)
                    {
                        DataTable dt = ds.Tables[i];
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            if (dt.Rows[0]["Count"].ToInteger() > 0)
                            {
                                flag = true; // If refrence is used 
                                break;
                            }
                        }
                    }
                }
            }

            return flag;
        }

        /// <summary>
        /// GetListForDropdown
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="pleaseSelectText">pleaseSelectText</param>
        /// <param name="selectedValue">selectedValue</param>
        /// <param name="selectedText">selectedText</param>
        /// <param name="textField">textField</param>
        /// <param name="valueField">valueField</param>
        /// <param name="searchCriteria">searchCriteria</param>
        /// <returns>List</returns>
        public static List<SelectListItem> GetListForDropdown<T>(string pleaseSelectText = "", string selectedValue = "", string selectedText = "", string textField = "Name", string valueField = "ID", T searchCriteria = default(T))
        {
            List<SelectListItem> retList = new List<SelectListItem>();
            if (searchCriteria == null)
            {
                searchCriteria = Activator.CreateInstance<T>();
            }

            if (searchCriteria.GetType().GetProperty("Active") != null && searchCriteria.GetType().GetProperty("Active").GetValue(searchCriteria) == null)
            {
                searchCriteria.GetType().InvokeMember("Active", BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty, Type.DefaultBinder, searchCriteria, new object[] { true });
            }

            List<T> listT;
            using (Services.ServiceContext service = new Services.ServiceContext())
            {
                listT = service.Search<T>((T)searchCriteria).ToList();
            }

            SelectListItem selectListItem;
            if (!string.IsNullOrEmpty(pleaseSelectText))
            {
                selectListItem = new SelectListItem();
                selectListItem.Text = pleaseSelectText;
                selectListItem.Value = string.Empty;
                retList.Add(selectListItem);
            }

            foreach (var item in listT)
            {
                selectListItem = new SelectListItem();
                selectListItem.Text = item.GetType().GetProperty(textField).GetValue(item).String();
                selectListItem.Value = item.GetType().GetProperty(valueField).GetValue(item).String();
                selectListItem.Selected = !string.IsNullOrEmpty(selectedValue) && selectedValue == selectListItem.Value.String();
                retList.Add(selectListItem);
            }

            if (!string.IsNullOrEmpty(selectedValue) && !retList.Any(i => i.Value == selectedValue))
            {
                string inActiveText = string.Empty;
                if (string.IsNullOrEmpty(selectedText))
                {
                    if (searchCriteria.GetType().GetProperty("Active") != null)
                    {
                        searchCriteria.GetType().InvokeMember("Active", BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty, Type.DefaultBinder, searchCriteria, new object[] { false });
                    }

                    if (searchCriteria.GetType().GetProperty("ID") != null)
                    {
                        searchCriteria.GetType().InvokeMember("ID", BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty, Type.DefaultBinder, searchCriteria, new object[] { selectedValue.ToInteger() });
                    }

                    using (Services.ServiceContext service = new Services.ServiceContext())
                    {
                        listT = service.Search<T>((T)searchCriteria).ToList();
                    }

                    if (listT?.Count == 1)
                    {
                        var text = listT[0].GetType().InvokeMember(textField, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, Type.DefaultBinder, listT[0], new object[] { });
                        if (!string.IsNullOrEmpty(text.String()))
                        {
                            inActiveText = text.String() + " (In-Active)";
                        }
                    }
                }
                else
                {
                    inActiveText = selectedText + " (In-Active)";
                }

                selectListItem = new SelectListItem();
                selectListItem.Text = inActiveText;
                selectListItem.Value = selectedValue;
                retList.Add(selectListItem);
            }

            return retList;
        }

        /// <summary>
        /// Get MessageType List
        /// </summary>
        /// <param name="pleaseSelectText">pleaseSelectText</param>
        /// <returns>List</returns>
        public static List<SelectListItem> GetMessageTypeList(string pleaseSelectText = "")
        {
            List<SelectListItem> messageTypeSelectList = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(pleaseSelectText))
            {
                messageTypeSelectList.Add(new SelectListItem() { Text = pleaseSelectText, Value = string.Empty });
            }

            messageTypeSelectList.AddRange(Enum.GetValues(typeof(SystemEnumList.MessageType))
                        .Cast<SystemEnumList.MessageType>()
                        .Where(x => x != SystemEnumList.MessageType.ChatMessage)
                        .Select(x => new SelectListItem { Text = x.GetDescription(), Value = x.GetHashCode().ToString() })
                        .ToList());

            return messageTypeSelectList;
        }

        /// <summary>
        /// Get Borrow Book Status Dropdown List
        /// </summary>
        /// <param name="isAllRequired">All Status Required or not</param>
        /// <returns>List</returns>
        public static List<SelectListItem> GetBorrowBookStatusDropdown(bool isAllRequired = false)
        {
            return Enum.GetValues(typeof(SystemEnumList.BorrowBookStatus))
                        .Cast<SystemEnumList.BorrowBookStatus>()
                        .Where(x => (isAllRequired || x != SystemEnumList.BorrowBookStatus.All) && x != SystemEnumList.BorrowBookStatus.Available && x != SystemEnumList.BorrowBookStatus.Approved)
                        .Select(x => new SelectListItem { Text = x.GetDescription(), Value = x.GetHashCode().ToString() })
                        .OrderBy(x => x.Value)
                        .ToList();
        }

        /// <summary>
        /// Get Space Booking Status Dropdown List
        /// </summary>
        /// <returns>List</returns>
        public static List<SelectListItem> GetSpaceBookingStatusDropdown()
        {
            return Enum.GetValues(typeof(SystemEnumList.SpaceBookingStatus))
                        .Cast<SystemEnumList.SpaceBookingStatus>()
                        .Where(x => x != SystemEnumList.SpaceBookingStatus.All && x != SystemEnumList.SpaceBookingStatus.Available && x != SystemEnumList.SpaceBookingStatus.Confirmed)
                        .Select(x => new SelectListItem { Text = x.GetDescription(), Value = x.GetHashCode().ToString() })
                        .ToList();
        }

        /// <summary>
        /// Get SpentTime in "10 hours ago" format.
        /// </summary>
        /// <param name="date">date</param>
        /// <param name="timeFormat">default time format</param>
        /// <returns>SpentTime in "10 hours ago" format.</returns>
        public static string GetSpentTime(DateTime? date, string timeFormat = "")
        {
            var timeString = string.Empty;
            if (date.HasValue)
            {
                timeFormat = string.IsNullOrEmpty(timeFormat) ? ProjectConfiguration.DateTimeFormat : timeFormat;
                var timeSpan = DateTime.Now.Subtract(date.Value);
                timeString = timeSpan.TotalDays > 1 ? date.Value.ToString(timeFormat)
                           : timeSpan.TotalHours > 1 ? (Math.Round(timeSpan.TotalHours) + " hours ago")
                           : (Math.Ceiling(timeSpan.TotalMinutes) + " minutes ago");
            }

            return timeString;
        }

        #region Active Directory Implementation

        /// <summary>
        /// Get Active Directory Users
        /// </summary>
        /// <param name="model">Login model</param>
        /// <returns>List</returns>
        public static List<ActiveDirectoryUser> GetActiveDirectoryUserList()
        {
            ActiveDirectoryUserApiResponse userResponse = null;
            var client = new RestClient(ProjectConfiguration.ActiveDirectoryUserUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            request.AddParameter("FromWhere", "3", ParameterType.QueryString);
            IRestResponse res = client.Execute(request);
            if (res.StatusCode == HttpStatusCode.OK)
            {
                userResponse = JsonConvert.DeserializeObject<ActiveDirectoryUserApiResponse>(res.Content);
            }

            return userResponse?.Data?.Where(x => x.PCNumber != string.Empty && x.PCNumber != null)?.ToList() ?? new List<ActiveDirectoryUser>();
        }

        /// <summary>
        /// Get User List
        /// </summary>
        /// <param name="pleaseSelectText">pleaseSelectText</param>
        /// <returns>List</returns>
        public static List<SelectListItem> GetActiveDirectoryUserDropDown(string pleaseSelectText = "")
        {
            List<SelectListItem> activeDirectoryUser = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(pleaseSelectText))
            {
                activeDirectoryUser.Add(new SelectListItem() { Text = pleaseSelectText, Value = string.Empty });
            }

            var selectList = GetActiveDirectoryUserList().Select(x => new SelectListItem
            {
                Text = x.Name + " [" + (string.IsNullOrEmpty(x.Email) ? "-" : x.Email) + "]",
                Value = x.PCNumber
            });
            activeDirectoryUser.AddRange(selectList);

            return activeDirectoryUser;
        }

        /// <summary>
        /// Get ActiveDirectoryResponse
        /// </summary>
        /// <param name="model">Login model</param>
        /// <returns>List</returns>
        public ActiveDirectoryLoginResponse ActiveDirectoryResponse(Login model)
        {
            ActiveDirectoryLoginResponse response = null;
            var client = new RestClient(ProjectConfiguration.ActiveDirectoryLoginUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            request.AddParameter("application/json", "{\r\n UserName:\"" + model.Email + "\",\r\n Password:\"" + model.EncryptedPassword + "\",\r\n FromWhere:3\r\n}", ParameterType.RequestBody);
            IRestResponse res = client.Execute(request);
            response = JsonConvert.DeserializeObject<ActiveDirectoryLoginResponse>(res.Content);
            return response;
        }

        /// <summary>
        /// Get Form Authentication Guest Login Response
        /// </summary>
        /// <param name="model">Login model</param>
        /// <returns>List</returns>
        public ActiveDirectoryLoginResponse FormAuthenticationGuestLogin(Login model)
        {
            ActiveDirectoryLoginResponse response = null;
            var client = new RestClient(ProjectConfiguration.FormAunthenticationGuestLoginUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            ////request.AddParameter("UserName", model.Email);
            ////request.AddParameter("Password", EncryptionDecryption.EncryptByTripleDES(model.Password));
            ////request.AddParameter("FromWhere", 3);
            request.AddParameter("application/json", "\r\n{UserName:\"" + model.Email + "\",\r\nPassword:\"" + model.EncryptedPassword + "\",\r\nFromWhere:3}", ParameterType.RequestBody);
            IRestResponse res = client.Execute(request);
            response = JsonConvert.DeserializeObject<ActiveDirectoryLoginResponse>(res.Content);
            return response;
        }

        /// <summary>
        /// Get Form Authentication Guest Login Response
        /// </summary>
        /// <param name="pcNumber">pcNumber</param>
        /// <returns>List</returns>
        public ActiveDirectoryUserDetailsResponse GetADuserDataWithPCNo(string pcNumber)
        {
            ActiveDirectoryUserDetailsResponse response = null;
            var client = new RestClient(ProjectConfiguration.GetADuserDataWithPCNo + "?userName=" + pcNumber + "&FromWhere=3");
            var request = new RestRequest(Method.GET);
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            IRestResponse res = client.Execute(request);
            if (res.StatusCode == HttpStatusCode.OK)
            {
                response = JsonConvert.DeserializeObject<ActiveDirectoryUserDetailsResponse>(res.Content);
            }

            return response;
        }

        /// <summary>
        /// Get ActiveDirectoryRegisterResponse
        /// </summary>
        /// <param name="model">ActiveDirectoryRegister model</param>
        /// <returns>List</returns>
        public ActiveDirectoryRegisterResponse ActiveDirectoryRegisterResponse(ActiveDirectoryRegister model)
        {
            ActiveDirectoryRegisterResponse response = null;
            var client = new RestClient(ProjectConfiguration.ActiveDirectoryRegisterUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            var requestBody = new RegisterAPIModel();
            requestBody.FromWhere = 3;
            requestBody.Email = model.Email;
            requestBody.Password = model.LoginType == SystemEnumList.LoginType.Staff.GetHashCode() ? "Admin@123" : model.EncryptedPassword;
            requestBody.FirstName = model.FirstName;
            requestBody.LastName = model.LastName;
            requestBody.CountryId = string.Empty;
            requestBody.StateId = string.Empty;
            requestBody.LanguageId = SystemEnumList.Language.Arabic.GetHashCode();
            requestBody.IsADUser = model.LoginType == SystemEnumList.LoginType.Staff.GetHashCode();
            request.AddJsonBody(requestBody);
            IRestResponse res = client.Execute(request);
            if (res.StatusCode == HttpStatusCode.OK)
            {
                response = JsonConvert.DeserializeObject<ActiveDirectoryRegisterResponse>(res.Content);
            }

            return response;
        }

        /// <summary>
        /// Get ActiveDirectoryRegisterResponse
        /// </summary>
        /// <param name="model">ActiveDirectoryRegister model</param>
        /// <returns>List</returns>
        public ActiveDirectoryRegisterResponse ActiveDirectoryUpdateResponse(ActiveDirectoryRegister model)
        {
            ActiveDirectoryRegisterResponse response = null;
            var client = new RestClient(ProjectConfiguration.ActiveDirectoryUpdateUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            var requestBody = new RegisterAPIModel();
            requestBody.FromWhere = 3;
            requestBody.UserId = model.UserId;
            requestBody.Email = model.Email;
            requestBody.Password = model.LoginType == SystemEnumList.LoginType.Staff.GetHashCode() ? "Admin@123" : model.EncryptedPassword;
            requestBody.FirstName = model.FirstName;
            requestBody.LastName = model.LastName;
            requestBody.CountryId = string.Empty;
            requestBody.StateId = string.Empty;
            requestBody.LanguageId = model.LanguageId;
            requestBody.IsADUser = model.LoginType == SystemEnumList.LoginType.Staff.GetHashCode();
            request.AddJsonBody(requestBody);
            IRestResponse res = client.Execute(request);
            if (res.StatusCode == HttpStatusCode.OK)
            {
                response = JsonConvert.DeserializeObject<ActiveDirectoryRegisterResponse>(res.Content);
            }

            return response;
        }

        /// <summary>
        /// Get ActiveDirectoryRegisterResponse
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="userId">userId</param>
        /// <returns>List</returns>
        public ActiveDirectoryDeleteResponse ActiveDirectoryDeleteResponse(string email, string userId)
        {
            ActiveDirectoryDeleteResponse response = null;
            var client = new RestClient(ProjectConfiguration.ActiveDirectoryDeleteUserUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            var requestBody = new RegisterAPIModel();
            requestBody.FromWhere = 3;
            requestBody.UserId = userId;
            requestBody.Email = email;
            request.AddJsonBody(requestBody);
            IRestResponse res = client.Execute(request);
            if (res.StatusCode == HttpStatusCode.OK)
            {
                response = JsonConvert.DeserializeObject<ActiveDirectoryDeleteResponse>(res.Content);
            }

            return response;
        }

        /// <summary>
        /// Get ActiveDirectoryRegisterResponse
        /// </summary>
        /// <param name="model">ActiveDirectoryRegister model</param>
        /// <returns>List</returns>
        public ActiveDirectoryRegisterResponse ActiveDirectoryChangePasswordResponse(ActiveDirectoryRegister model)
        {
            ActiveDirectoryRegisterResponse response = null;
            var client = new RestClient(ProjectConfiguration.ActiveDirectoryChangePasswordUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            var requestBody = new RegisterAPIModel();
            requestBody.FromWhere = 3;
            requestBody.Email = model.Email;
            requestBody.CurrentPassword = model.EncryptedPassword;
            requestBody.NewPassword = model.EncryptedNewPassword;
            requestBody.ConfirmPassword = model.EncryptedConfirmPassword;
            request.AddJsonBody(requestBody);
            IRestResponse res = client.Execute(request);
            if (res.StatusCode == HttpStatusCode.OK)
            {
                response = JsonConvert.DeserializeObject<ActiveDirectoryRegisterResponse>(res.Content);
            }

            return response;
        }

        /// <summary>
        /// Get ActiveDirectoryResponse
        /// </summary>
        /// <param name="pcName">PC Name</param>
        /// <returns>List</returns>
        public ActiveDirectoryLoginResponse ActiveDirectoryDirectLogin(string pcName)
        {
            ActiveDirectoryLoginResponse response = null;
            var client = new RestClient(ProjectConfiguration.ActiveDirectoryDirectLogin);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("access", ProjectConfiguration.AccessTokenForActiveDirectoryLogin);
            request.AddParameter("application/json", "{UserName:\"" + pcName + "\",FromWhere:3}", ParameterType.RequestBody);
            IRestResponse res = client.Execute(request);
            response = JsonConvert.DeserializeObject<ActiveDirectoryLoginResponse>(res.Content);
            return response;
        }

        #endregion

        /// <summary>
        /// Login method
        /// </summary>
        /// <param name="model">model</param>
        /// <returns> return login response</returns>
        public Login GetUserLogin(Login model)
        {
            Login respModel = new Login();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.UserLogin(model.Email, model.Password);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        respModel.Userdata = ConvertTo.DataTableIntoList<User>(ds.Tables[0]).ToList().FirstOrDefault();
                    }
                }
            }

            return respModel;
        }

        /// <summary>
        /// Login method
        /// </summary>
        /// <param name="userEmail">Email Id</param>
        /// <returns> return login response</returns>
        public Login GetUserLoginwithEmail(string userEmail)
        {
            Login respModel = new Login();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.UserLoginwithEmail(userEmail);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        respModel.Userdata = ConvertTo.DataTableIntoList<User>(ds.Tables[0]).ToList().FirstOrDefault();
                    }
                }
            }

            return respModel;
        }

        /// <summary>
        /// Login method for customer
        /// </summary>
        /// <param name="model">model</param>
        /// <returns> return login response</returns>
        public Login GetCustomerLogin(Login model)
        {
            Login respModel = new Login();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.CustomerLogin(model.Email, model.Password);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        respModel.Customerdata = ConvertTo.DataTableIntoList<Customer>(ds.Tables[0]).ToList().FirstOrDefault();
                    }
                }
            }

            return respModel;
        }

        /// <summary>
        /// Login method
        /// </summary>
        /// <param name="userEmail">Email Id</param>
        /// <returns> return login response</returns>
        public Login GetCustomerLoginwithEmail(string userEmail)
        {
            Login respModel = new Login();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.CustomerLoginwithEmail(userEmail);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        respModel.Customerdata = ConvertTo.DataTableIntoList<Customer>(ds.Tables[0]).ToList().FirstOrDefault();
                    }
                }
            }

            return respModel;
        }

        /// <summary>
        /// Get page access list
        /// </summary>
        /// <param name="roleId">roleId</param>
        /// <returns> return list of page access</returns>
        public object GetPageAccessBasedOnUserRole(int? roleId)
        {
            List<PageAccess> pageAccessesList = new List<PageAccess>();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetPageAccessBasedOnUserRole(roleId);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        pageAccessesList = ConvertTo.DataTableIntoList<PageAccess>(ds.Tables[0]).ToList();
                    }
                }
            }

            return (object)pageAccessesList;
        }

        /// <summary>
        /// Change User/Customer Password
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="password">password</param>
        /// <param name="spfor">spfor</param>
        /// < returns > true or false</returns>
        public bool ChangePassword(int id, string password, string spfor)
        {
            using (CustomContext service = new CustomContext())
            {
                return service.ChangeUserPassword(id, password, spfor);
            }
        }

        /// <summary>
        /// Delete PageAccess based on role
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Delete PageAccess</returns>
        public int DeletePageAccessBasedOnRole(int id)
        {
            int retVal = 0;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.DeletePageAccessBasedOnUserRole(id);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.ToInteger(ds.Tables[0]);
                    }
                }
            }

            return retVal;
        }

        /// <summary>
        /// Update Page Access based on role save and update
        /// </summary>
        /// <param name="roleId">roleId</param>
        /// <param name="pageAccessList">pageAccessList</param>
        /// <returns>boolean</returns>
        public int UpdatePageAccessBasedOnRole(int roleId, List<PageAccess> pageAccessList)
        {
            int retVal = 0;
            try
            {
                using (CustomContext service = new CustomContext())
                {
                    // adding new page access 
                    foreach (var page in pageAccessList)
                    {
                        if (page.Id > 0)
                        {
                            page.ModifiedBy = ProjectSession.UserId;
                            page.ModifiedDate = DateTime.Now;
                        }
                        else
                        {
                            page.CreatedBy = ProjectSession.UserId;
                            page.CreatedDate = DateTime.Now;
                        }

                        page.RoleId = roleId;
                        service.Save<PageAccess>(page);
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }

            return retVal;
        }

        /// <summary>
        /// Get Book Borrowed Details
        /// </summary>
        /// <param name="bookId">bookId</param>       
        /// <param name="statusId">statusId</param>
        /// <param name="active">active</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">sortExpression</param>
        /// <param name="sortDirection">sortDirection</param>
        /// <param name="searchText">searchText</param>
        /// <returns> Book Borrowed Details</returns>
        public List<BorrowedBook> GetBookBorrowedDetails(int bookId, int? statusId = null, int? active = 1, int? startRowIndex = null, int? endRowIndex = null, string sortExpression = null, string sortDirection = null, string searchText = null)
        {
            List<BorrowedBook> retVal = new List<BorrowedBook>();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetBookBorrowedDetails(bookId, statusId, active, startRowIndex, endRowIndex, sortExpression, sortDirection, searchText);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.DataTableIntoList<BorrowedBook>(ds.Tables[0]).ToList();
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Get Book Details Complete
        /// </summary>
        /// <param name="bookId">bookId</param>           
        /// <param name="customerId">Customer Id</param>
        /// <returns>Book Details</returns>
        public Book GetBookDetailsComplete(int bookId, int? customerId = null)
        {
            Book retVal = new Book();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetBookDetailsComplete(bookId, customerId);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.DataTableIntoList<Book>(ds.Tables[0]).FirstOrDefault();
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Get Book Details Complete
        /// </summary>
        /// <param name="customerId">customerId</param>    
        /// <param name="searchText">searchText</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">Sort Expression</param>
        /// <param name="sortDirection">Sort Direction</param>
        /// <returns>Book Details</returns>
        public List<BorrowedBook> GetBookDetailsOfCustomer(int customerId, string searchText, int? startRowIndex, int? endRowIndex, string sortExpression, string sortDirection)
        {
            List<BorrowedBook> retVal = new List<BorrowedBook>();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetBookDetailsOfCustomer(customerId, searchText, startRowIndex, endRowIndex, sortExpression, sortDirection);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.DataTableIntoList<BorrowedBook>(ds.Tables[0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Get Space Details Complete
        /// </summary>
        /// <param name="customerId">customerId</param>    
        /// <param name="searchText">searchText</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">Sort Expression</param>
        /// <param name="sortDirection">Sort Direction</param>
        /// <returns>Space Details</returns>
        public List<SpaceBooking> GetSpaceDetailsOfCustomer(int customerId, string searchText, int? startRowIndex, int? endRowIndex, string sortExpression, string sortDirection)
        {
            List<SpaceBooking> retVal = new List<SpaceBooking>();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetSpaceDetailsOfCustomer(customerId, searchText, startRowIndex, endRowIndex, sortExpression, sortDirection);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.DataTableIntoList<SpaceBooking>(ds.Tables[0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Get Current Book Status
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="active">active</param>     
        /// <returns>Get Book Status</returns>
        public int GetCurrentBookStatus(int bookId, int? active)
        {
            int retVal = 0;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetCurrentBookStatus(bookId, active);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.ToInteger(ds.Tables[0].Rows[0][0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Accept Cancel Book Borrow Request
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="userId">userId</param>    
        /// <param name="statusId">statusId</param>    
        /// <param name="borrowId">borrowId</param>
        /// <param name="bookperiod">bookperiod</param>  
        /// <returns>return status</returns>
        public int AcceptCancelBookBorrowRequest(int bookId, int userId, int statusId, int borrowId, int bookperiod)
        {
            int retVal = 0;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.AcceptCancelBookBorrowRequest(bookId, userId, statusId, borrowId, bookperiod);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.ToInteger(ds.Tables[0].Rows[0][0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Return Book
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="userId">userId</param>            
        /// <param name="borrowId">borrowId</param>  
        /// <param name="returnNotes">returnNotes</param>  
        /// <param name="returnDate">returnDate</param>  
        /// <returns>return status</returns>
        public int BookReturn(int bookId, int userId, int borrowId, string returnNotes, DateTime returnDate)
        {
            int retVal = 0;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.BookReturn(bookId, userId, borrowId, returnNotes, returnDate);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.ToInteger(ds.Tables[0].Rows[0][0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Check Book Pending Entry
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="customerId">customerId</param>          
        /// <returns>return status</returns>
        public bool CheckBookPendingEntry(int bookId, int customerId)
        {
            bool retVal = false;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.CheckBookPendingEntry(bookId, customerId);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.ToBoolean(ds.Tables[0].Rows[0][0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Get Pending/Approve status
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="customerId">customerId</param>          
        /// <returns>return status</returns>
        public int GetCheckBookBorrowStatus(int bookId, int customerId)
        {
            int retVal = 0;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetCheckBookBorrowStatus(bookId, customerId);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.ToInteger(ds.Tables[0].Rows[0][0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Get book comments
        /// </summary>
        /// <param name="bookId">bookId</param>
        /// <param name="searchText">searchText</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">sortExpression</param>
        /// <param name="sortDirection">sortDirection</param>
        /// <returns> return book comments</returns>
        public List<BookDiscussion> GetBookComments(int bookId, string searchText, int? startRowIndex, int? endRowIndex, string sortExpression, string sortDirection)
        {
            List<BookDiscussion> retVal = new List<BookDiscussion>();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetBookDiscussions(bookId, searchText, startRowIndex, endRowIndex, sortExpression, sortDirection);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.DataTableIntoList<BookDiscussion>(ds.Tables[0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Get Todays Activities
        /// </summary>
        /// <param name="requestType">requestType</param>
        /// <param name="fromDate">fromDate</param>
        /// <param name="toDate">toDate</param>
        /// <param name="active">active</param>
        /// <param name="customerId">customerId</param>
        /// <param name="searchText">searchText</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">Sort Expression</param>
        /// <param name="sortDirection">Sort Direction</param>
        /// <param name="status">status</param>
        /// <returns>Return today's activities</returns>
        public object GetTodaysActivities(string requestType, DateTime? fromDate, DateTime? toDate, int active = 1, int? customerId = null, string searchText = null, int? startRowIndex = null, int? endRowIndex = null, string sortExpression = "", string sortDirection = "", string status = "")
        {
            object retVal = new object();
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetTodaysActivities(requestType, fromDate, toDate, active, customerId, searchText, startRowIndex, endRowIndex, sortExpression, sortDirection, status);
                if (ds?.Tables.Count > 0)
                {
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        // if request type is book details
                        if (requestType == SystemEnumList.RequestTypeTodayActivity.BookDetails.GetDescription())
                        {
                            List<BorrowedBook> finalList = ConvertTo.DataTableIntoList<BorrowedBook>(ds.Tables[0]);
                            retVal = (object)finalList;
                        }

                        // if request type is room bookings
                        if (requestType == SystemEnumList.RequestTypeTodayActivity.RoomBookings.GetDescription())
                        {
                            List<SpaceBooking> finalList = ConvertTo.DataTableIntoList<SpaceBooking>(ds.Tables[0]);
                            retVal = (object)finalList;
                        }
                    }
                    else
                    {
                        // if request type is book details
                        if (requestType == SystemEnumList.RequestTypeTodayActivity.BookDetails.GetDescription())
                        {
                            // returning blank list
                            List<BorrowedBook> finalList = new List<BorrowedBook>();
                            retVal = (object)finalList;
                        }

                        // if request type is room bookings
                        if (requestType == SystemEnumList.RequestTypeTodayActivity.RoomBookings.GetDescription())
                        {
                            // returning blank list
                            List<SpaceBooking> finalList = new List<SpaceBooking>();
                            retVal = (object)finalList;
                        }
                    }
                }

                return retVal;
            }
        }
    }
}
