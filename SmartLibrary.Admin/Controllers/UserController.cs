// <copyright file="UserController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using Infrastructure;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using Resources;
    using SmartLibrary.Admin.Pages;
    using SmartLibrary.Models;
    using SmartLibrary.Services;

    /// <summary>
    /// UserController
    /// </summary>
    public class UserController : BaseController
    {
        private UserDataBL userDataBL;
        private CommonBL commonBL;
        private MasterDataBL masterBL;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// UserController
        /// </summary>
        public UserController()
        {
            if (this.userDataBL == null)
            {
                this.userDataBL = new UserDataBL();
                this.commonBL = new CommonBL();
                this.masterBL = new MasterDataBL();
            }
        }

        #region User

        /// <summary>
        /// User this instance.
        /// </summary>
        /// <returns>List of User</returns>
        [ActionName(Actions.Index)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Users)]
        public ActionResult Index()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            return this.View(Views.Index);
        }

        /// <summary>
        ///  list of Users with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">searchdata</param>
        /// <returns>List of Users</returns>
        [HttpPost]
        [ActionName(Actions.Index)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Users)]
        public JsonResult User([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "")
        {
            List<User> usrerList = new List<User>();

            User model = new User()
            {
                Email = searchdata,
                FirstName = searchdata,
                LastName = searchdata,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data,
            };

            usrerList = this.userDataBL.GetUsersList(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (usrerList != null && usrerList.Count > 0)
            {
                totalRecord = usrerList.FirstOrDefault().TotalRecords;
                filteredRecord = usrerList.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, usrerList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Manages the User.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual User View</returns>
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Users)]
        [ActionName(Actions.AddEditUser)]
        public ActionResult ManageUser(int id = 0)
        {
            User model = new User();
            model.Id = id;
            if (id > 0)
            {
                model = this.userDataBL.GetUsersList(model).FirstOrDefault();
            }
            else
            {
                model.Active = true;
            }

            return this.PartialView(PartialViews.AddEditUsers, model);
        }

        /// <summary>
        /// Manages the User.
        /// </summary>
        /// <param name="user">The User.</param>
        /// <returns>Save User</returns>
        [ActionName(Actions.AddEditUser)]
        [HttpPost]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Users)]
        public JsonResult ManageUser(User user)
        {
            try
            {
                if (user.LoginType == SystemEnumList.LoginType.Guest.GetHashCode())
                {
                    this.ModelState.Remove(nameof(user.PCNumber));
                }

                if (this.ModelState.IsValid)
                {
                    if (user.Id > 0)
                    {
                        if (user.LoginType == SystemEnumList.LoginType.Guest.GetHashCode())
                        {
                            ActiveDirectoryRegister update = new ActiveDirectoryRegister()
                            {
                                UserId = user.AGUserId,
                                Email = user.Email,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                LanguageId = user?.Language ?? SystemEnumList.Language.Arabic.GetHashCode()
                            };
                            var response = this.commonBL.ActiveDirectoryUpdateResponse(update);
                            if (response == null || response.Status != SystemEnumList.ApiStatus.Success.GetDescription())
                            {
                                return this.Json(new { resultData = response.StatusCode, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = response.Message, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.DenyGet });
                            }
                        }

                        user.ModifiedBy = ProjectSession.UserId;
                        user.ModifiedDate = DateTime.Now;
                    }
                    else
                    {
                        if (user.LoginType == SystemEnumList.LoginType.Guest.GetHashCode())
                        {
                            ActiveDirectoryRegister register = new ActiveDirectoryRegister()
                            {
                                Email = user.Email,
                                Password = user.Password,
                                EncryptedPassword = user.EncryptedPassword,
                                FirstName = user.FirstName,
                                LastName = user.LastName
                            };
                            var response = this.commonBL.ActiveDirectoryRegisterResponse(register);
                            if (response == null || response.Status != SystemEnumList.ApiStatus.Success.GetDescription())
                            {
                                return this.Json(new { resultData = response.StatusCode, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = response.Message, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.DenyGet });
                            }

                            user.AGUserId = response.Data.UserId;
                            user.Password = string.Empty; ////As we are not allowed to store password in our DB
                        }

                        user.CreatedBy = ProjectSession.UserId;
                        user.CreatedDate = DateTime.Now;
                    }

                    int status = this.userDataBL.SaveUser(user);
                    string message = string.Empty;
                    if (status > -1)
                    {
                        if (user.Id > 0)
                        {
                            message = Messages.UpdateMessage.SetArguments(General.User);
                        }
                        else
                        {
                            message = Messages.SaveMessage.SetArguments(General.User);
                        }
                    }
                    else
                    {
                        if (status == -2)
                        {
                            message = Messages.DuplicateMessage.SetArguments(General.User);
                        }
                        else
                        {
                            message = Messages.ErrorMessage.SetArguments(General.User);
                        }

                        return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = message, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.DenyGet });
                    }

                    return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = message, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.DenyGet });
                }
                else
                {
                    string errorMsg = string.Empty;
                    foreach (ModelState modelState in this.ViewData.ModelState.Values)
                    {
                        foreach (ModelError error in modelState.Errors)
                        {
                            if (!string.IsNullOrEmpty(errorMsg))
                            {
                                errorMsg = errorMsg + " , ";
                            }

                            errorMsg = errorMsg + error.ErrorMessage;
                        }
                    }

                    return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.DenyGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.DenyGet });
            }
        }

        /// <summary>
        /// Deletes the User.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Delete Individual</returns>
        [ActionName(Actions.DeleteUser)]
        [HttpPost]
        [PageAccessAttribute(PermissionName = Constants.ACTION_DELETE, ActionName = Actions.Users)]
        public ActionResult DeleteUser(int id = 0)
        {
            try
            {
                var user = this.userDataBL.SelectUser(id);
                if (user.LoginType == SystemEnumList.LoginType.Guest.GetHashCode())
                {
                var adResponse = this.commonBL.ActiveDirectoryDeleteResponse(user.Email, user.AGUserId);
                if (adResponse == null || adResponse.Status != SystemEnumList.ApiStatus.Success.GetDescription() || adResponse.Data.IsDeleted == false)
                {
                    return this.Json(new { success = false, resultData = adResponse.StatusCode, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = adResponse.Message, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                }

                int status = this.userDataBL.DeleteUser(id);
                if (status == 0)
                {
                    return this.Json(new { success = true, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.DeleteMessage.SetArguments(General.User), title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return this.Json(new { success = false, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.DeleteErrorMessage.SetArguments(General.User), title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// ChangeStatus
        /// </summary>
        /// <param name="status">The Status</param>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual User View</returns>
        [HttpPost]
        [ActionName(Actions.ChangeUserStatus)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Users)]
        public JsonResult ChangeUserStatus(bool status, int id = 0)
        {
            User model = new User();
            model.Id = id;
            if (id > 0)
            {
                model = this.userDataBL.GetUsersList(model).FirstOrDefault();
            }

            model.Active = status;
            model.ModifiedBy = ProjectSession.UserId;
            model.ModifiedDate = DateTime.Now;

            int result = this.userDataBL.SaveUser(model);
            if (result > -1)
            {
                return this.Json(new { success = true });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.User) });
            }
        }
        #endregion

        #region Role

        /// <summary>
        /// Role this instance.
        /// </summary>
        /// <returns>List of Roles</returns>
        [ActionName(Actions.Role)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Role)]
        public ActionResult Role()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            return this.View(Views.Role);
        }

        /// <summary>
        ///  list of Roles with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">search</param>
        /// <returns>List of Roles</returns>
        [HttpPost]
        [ActionName(Actions.Role)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Role)]
        public JsonResult Role([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "")
        {
            List<Role> roleList = new List<Role>();

            Role model = new Role()
            {
                Name = searchdata,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data,
                PageAccesses = searchdata
            };

            roleList = this.userDataBL.GetRoleList(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (roleList != null && roleList.Count > 0)
            {
                totalRecord = roleList.FirstOrDefault().TotalRecords;
                filteredRecord = roleList.FirstOrDefault().TotalRecords;
                foreach (var role in roleList)
                {
                    role.IdEncrypted = EncryptionDecryption.EncryptByTripleDES(role.Id.ToString());
                }
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, roleList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Manages the Role.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Role View</returns>
        [HttpGet]
        [ActionName(Actions.AddEditRole)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Role)]
        public ActionResult AddEditRole(string id)
        {
            Role model = new Role();
            model.Id = 0;

            if (!string.IsNullOrEmpty(id))
            {
                string decryptedVal = EncryptionDecryption.DecryptByTripleDES(id);
                if (decryptedVal != string.Empty)
                {
                    model.Id = decryptedVal.ToInteger();
                }
                else
                {
                    return this.RedirectToAction(Actions.Role, Controllers.User);
                }
            }

            if (model.Id > 0)
            {
                model = this.userDataBL.GetRoleList(model).FirstOrDefault();
            }
            else
            {
                model.Active = true;
            }

            List<PageAccess> dbPageAccessList = new List<PageAccess>();
            dbPageAccessList = (List<PageAccess>)this.commonBL.GetPageAccessBasedOnUserRole(model.Id);
            List<Page> pageList = this.masterBL.GetPageList(new Page() { Active = SystemEnumList.ActiveStatus.Active.GetHashCode().ToBoolean() });
            var pageAccessList = new List<PageAccess>();
            foreach (var page in pageList)
            {
                PageAccess pageAccess = new PageAccess();
                PageAccess pageAccessdb = dbPageAccessList?.Where(x => x.PageId == page.Id).FirstOrDefault();
                if (pageAccessdb != null)
                {
                    pageAccess = pageAccessdb;
                    pageAccess.PageName = page.Name;
                }
                else
                {
                    pageAccess.PageName = page.Name;
                    pageAccess.RoleId = model.Id;
                    pageAccess.PageId = page.Id;
                    pageAccess.CreatedBy = ProjectSession.UserId;
                    pageAccess.CreatedDate = DateTime.Now;
                    pageAccess.IsView = false;
                    pageAccess.IsAddUpdate = false;
                    pageAccess.IsDelete = false;
                }

                pageAccessList.Add(pageAccess);
            }

            model.PageAccessList = pageAccessList;

            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            return this.View(model);
        }

        /// <summary>
        /// Manages the Role.
        /// </summary>
        /// <param name="role">The Role.</param>
        /// <returns>Save role</returns>
        [ActionName(Actions.AddEditRole)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Role)]
        [HttpPost]
        public JsonResult AddEditRole(Role role)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    int status = this.userDataBL.SaveRole(role);
                    string message = string.Empty;
                    if (status > 0)
                    {
                        // as role is save now saving page access
                        int pageAccessStatus = this.commonBL.UpdatePageAccessBasedOnRole(status, role.PageAccessList);

                        if (role.Id > 0)
                        {
                            message = Messages.UpdateMessage.SetArguments(General.Role);
                        }
                        else
                        {
                            message = Messages.SaveMessage.SetArguments(General.Role);
                        }
                    }
                    else
                    {
                        if (status == -2)
                        {
                            message = Messages.DuplicateMessage.SetArguments(General.Role);
                        }
                        else
                        {
                            message = Messages.ErrorMessage.SetArguments(General.Role);
                        }

                        this.AddToastMessage(Infrastructure.SystemEnumList.Title.Role.GetDescription(), message, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return this.Json(new { status = SystemEnumList.MessageBoxType.Error.GetDescription(), message = message, title = Infrastructure.SystemEnumList.Title.Role.GetDescription(), JsonRequestBehavior.AllowGet });
                    }

                    this.AddToastMessage(Infrastructure.SystemEnumList.Title.Role.GetDescription(), message, Infrastructure.SystemEnumList.MessageBoxType.Success);
                    return this.Json(new { status = SystemEnumList.MessageBoxType.Success.GetDescription(), message = message, title = Infrastructure.SystemEnumList.Title.Role.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    string errorMsg = string.Empty;
                    foreach (ModelState modelState in this.ViewData.ModelState.Values)
                    {
                        foreach (ModelError error in modelState.Errors)
                        {
                            if (!string.IsNullOrEmpty(errorMsg))
                            {
                                errorMsg = errorMsg + " , ";
                            }

                            errorMsg = errorMsg + error.ErrorMessage;
                        }
                    }

                    return this.Json(new { status = SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg, title = Infrastructure.SystemEnumList.Title.Role.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { status = SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message, title = Infrastructure.SystemEnumList.Title.Role.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// Deletes the Role.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Delete Role</returns>
        [ActionName(Actions.DeleteRole)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_DELETE, ActionName = Actions.Role)]
        [HttpPost]
        public JsonResult DeleteRole(int id = 0)
        {
            try
            {
                // delete page access before deleting role.
                int pageaccessStatus = this.commonBL.DeletePageAccessBasedOnRole(id);
                if (pageaccessStatus == 0)
                {
                    int status = this.userDataBL.DeleteRole(id);
                    if (status == 0)
                    {
                        return this.Json(new { success = true, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.DeleteMessage.SetArguments(General.Role), title = Infrastructure.SystemEnumList.Title.Role.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else
                    {
                        return this.Json(new { success = false, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.DeleteErrorMessage.SetArguments(General.Role), title = Infrastructure.SystemEnumList.Title.Role.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                }
                else
                {
                    return this.Json(new { success = false, resultData = pageaccessStatus, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.DeleteErrorMessage.SetArguments(General.PageAcess), title = Infrastructure.SystemEnumList.Title.Role.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.Role.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// ChangeStatus
        /// </summary>
        /// <param name="status">The Status</param>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Role</returns>
        [HttpPost]
        [ActionName(Actions.ChangeRoleStatus)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Role)]
        public JsonResult ChangeRoleStatus(bool status, int id = 0)
        {
            Role model = new Role();
            model.Id = id;
            if (id > 0)
            {
                model = this.userDataBL.GetRoleList(model).FirstOrDefault();
            }

            model.Active = status;
            int result = this.userDataBL.SaveRole(model);
            if (result > -1)
            {
                return this.Json(new { success = true });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.Role) });
            }
        }

        #endregion

        /// <summary>
        /// Change Password Page.
        /// </summary>
        /// <returns>View Change Password.</returns>
        [ActionName(Actions.ChangePassword)]
        public ActionResult ChangePassword()
        {
            if (!string.IsNullOrEmpty(ConvertTo.String(ProjectSession.UserId)))
            {
                int userId = ProjectSession.UserId.ToInteger();
                using (Services.ServiceContext changePasswordService = new Services.ServiceContext(true))
                {
                    var userModel = changePasswordService.Search(new SmartLibrary.Models.User()
                    {
                        Id = userId
                    }).FirstOrDefault();

                    if (userModel != null && userModel.Id > 0)
                    {
                        SmartLibrary.Models.ChangePassword changePassword = new SmartLibrary.Models.ChangePassword();
                        changePassword.Id = userModel.Id;
                        return this.View(Views.ChangePassword, changePassword);
                    }
                }
            }

            return this.View(Views.ChangePassword);
        }

        /// <summary>
        /// Change Password Page.
        /// </summary>
        /// <param name="changePassword">change Password model.</param>
        /// <returns>View Change Password.</returns>
        [ActionName(Actions.ChangePassword)]
        [HttpPost]
        public ActionResult ChangePassword(SmartLibrary.Models.ChangePassword changePassword)
        {
            using (Services.ServiceContext changePasswordService = new Services.ServiceContext(true))
            {
                if (changePassword == null || ConvertTo.ToInteger(changePassword.Id) <= 0)
                {
                    this.ViewBag.ChangePasswordMessage = SmartLibrary.Resources.Account.UserNotExist;
                    return this.View(Views.ChangePassword, changePassword);
                }

                var userModel = changePasswordService.Search(new SmartLibrary.Models.User()
                {
                    Id = changePassword.Id,
                }).FirstOrDefault();

                if (userModel != null && userModel.Id > 0)
                {
                    ////if (ProjectConfiguration.IsActiveDirectory)
                    ////{
                    ////    ActiveDirectoryRegister activeDirectoryChangePassword = new ActiveDirectoryRegister()
                    ////    {
                    ////        Email = userModel.Email,
                    ////        Password = changePassword.CurrentPassword,
                    ////        NewPassword = changePassword.NewPassword,
                    ////        ConfirmPassword = changePassword.ConfirmPassword
                    ////    };

                    ////    var changePasswordResponse = this.commonBL.ActiveDirectoryChangePasswordResponse(activeDirectoryChangePassword);

                    ////    if (changePasswordResponse == null || changePasswordResponse.Status != SystemEnumList.ApiStatus.Success.GetDescription())
                    ////    {
                    ////        this.AddToastMessage(Resources.General.Error, changePasswordResponse?.Message ?? Messages.ErrorMessage.SetArguments(General.Member), Infrastructure.SystemEnumList.MessageBoxType.Error);
                    ////        return this.View(Views.ChangePassword, changePassword);                            
                    ////    }
                    ////}

                    if (userModel.Password == Infrastructure.EncryptionDecryption.EncryptByTripleDES(changePassword.CurrentPassword))
                    {
                        if (changePassword.NewPassword == changePassword.ConfirmPassword)
                        {
                            userModel.Password = Infrastructure.EncryptionDecryption.EncryptByTripleDES(changePassword.NewPassword);
                            bool response = this.commonBL.ChangePassword(userModel.Id, userModel.Password, Infrastructure.SystemEnumList.ChangePasswordFor.User.GetDescription());
                            if (response)
                            {
                                this.AddToastMessage(Resources.General.Success, Account.PasswordChangedSuccessfully, Infrastructure.SystemEnumList.MessageBoxType.Success);
                                return new RedirectResult(this.Url.Action(Views.BookGrid, Controllers.Book));
                            }
                            else
                            {
                                this.AddToastMessage(Resources.General.Error, Messages.ChangePasswordError, Infrastructure.SystemEnumList.MessageBoxType.Error);
                                return this.View(Views.ChangePassword, changePassword);
                            }
                        }
                        else
                        {
                            this.AddToastMessage(Resources.General.Error, Account.NewPasswordAndConfirmPasswordNotMatch, SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.ChangePassword, changePassword);
                        }
                    }
                    else
                    {
                        this.AddToastMessage(Resources.General.Error, Account.CurrentPasswordNotMatch, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return this.View(Views.ChangePassword, changePassword);
                    }
                }
                else
                {
                    this.AddToastMessage(Resources.General.Error, Account.UserNotExist, Infrastructure.SystemEnumList.MessageBoxType.Error);
                    return this.View(Views.ChangePassword, changePassword);
                }
            }
        }

        /// <summary>
        /// View the UserProfile.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>View User Profile.</returns>
        [ActionName(Actions.UserProfile)]
        public ActionResult UserProfile(int id = 0)
        {
            User model = new User();
            id = ProjectSession.UserId.ToInteger();
            model.Id = id;
            if (id > 0)
            {
                model = this.userDataBL.GetUsersList(model).FirstOrDefault();
            }

            return this.View(Views.UserProfile, model);
        }

        /// <summary>
        /// Manages the UserProfile.
        /// </summary>
        /// <param name="user">The User.</param>
        /// <param name="action">The Action.</param>
        /// <returns>Save User profile.</returns>
        [ActionName(Actions.UserProfile)]
        [HttpPost]
        public ActionResult UserProfile(User user, string action)
        {
            try
            {
                int userId = ProjectSession.UserId.ToInteger();
                var userProfile = this.userDataBL.SelectUser(userId);
                if (ProjectConfiguration.IsActiveDirectory && user.LoginType == SystemEnumList.LoginType.Guest.GetHashCode())
                {
                    ActiveDirectoryRegister activeDirectoryUpdate = new ActiveDirectoryRegister()
                    {
                        UserId = userProfile.AGUserId,
                        Email = userProfile.Email,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        LanguageId = user?.Language ?? SystemEnumList.Language.Arabic.GetHashCode()
                    };

                    var updateResponse = this.commonBL.ActiveDirectoryUpdateResponse(activeDirectoryUpdate);
                    if (updateResponse == null || updateResponse.Status != SystemEnumList.ApiStatus.Success.GetDescription())
                    {
                        this.AddToastMessage(Account.MyProfile, updateResponse?.Message ?? Messages.ErrorMessage.SetArguments(General.Member), Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return new RedirectResult(this.Url.Action(Views.UserProfile, Controllers.User));
                    }
                }

                userProfile.ModifiedBy = userId;
                userProfile.ModifiedDate = DateTime.Now;
                userProfile.Email = user.Email;
                userProfile.FirstName = user.FirstName;
                userProfile.LastName = user.LastName;
                userProfile.Language = user.Language;

                int status = this.userDataBL.SaveUser(userProfile);
                string message = string.Empty;
                var messagebox = Infrastructure.SystemEnumList.MessageBoxType.Success;
                if (status > 0)
                {
                    ProjectSession.AdminPortalLanguageId = user.Language.ToInteger();
                    CultureInfo cultureInfo = new CultureInfo(SmartLibrary.Admin.Classes.General.GetCultureName(ProjectSession.AdminPortalLanguageId), true);
                    System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
                    message = Messages.UpdateMessage.SetArguments(Resources.General.User);
                }
                else
                {
                    if (status == -2)
                    {
                        message = Messages.DuplicateMessage.SetArguments(Resources.General.User);
                        messagebox = Infrastructure.SystemEnumList.MessageBoxType.Error;
                    }
                    else
                    {
                        message = Messages.ErrorMessage.SetArguments(Resources.General.User);
                        messagebox = Infrastructure.SystemEnumList.MessageBoxType.Error;
                    }
                }

                this.AddToastMessage(Account.MyProfile, message, messagebox);
                return new RedirectResult(this.Url.Action(Views.UserProfile, Controllers.User));
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.User.GetDescription(), JsonRequestBehavior.DenyGet });
            }
        }
    }
}