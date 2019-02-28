using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Client;
using SmartLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.SignalRHub
{
    public static class SignalRConnections
    {
        public static Dictionary<string, List<string>> connections = new Dictionary<string, List<string>>();
    }

    public class SendNotification
    {
        public void RefreshNotificationCount(List<string> connections)
        {
            ////var connections = SignalRConnections.connections.Values.SelectMany(x => x).ToList();
            ////var context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            ////context.Clients.Clients(connections).Alert(id);

            var connection = new HubConnection(ProjectConfiguration.SignalRHubProxyUrl);
            IHubProxy myHub = connection.CreateHubProxy("NotificationHub");
            connection.Start().Wait(); // not sure if you need this if you are simply posting to the hub
            myHub.Invoke("RefreshNotificationCount", connections);
            //context.Clients(connectionIds).RefreshOnlineUsers();
        }
    }

    //[Microsoft.AspNet.SignalR.Hubs.HubName("notificationHub")]
    public class NotificationHub : Hub
    {
        /// <summary>
        /// RefreshNotificationCount
        /// </summary>
        public void RefreshNotificationCount(List<string> connections)
        {
            // Call the addNewMessageToPage method to update clients.
            this.Clients.Clients(connections).RefreshNotificationCount();
        }

        public override Task OnConnected()
        {
            if (!string.IsNullOrEmpty(Context.QueryString["uid"]) && !string.IsNullOrEmpty(Context.QueryString["ia"]))
            {
                var connectionId = EncryptionDecryption.DecryptByTripleDES(Context.QueryString["uid"]) + "-" + EncryptionDecryption.DecryptByTripleDES(Context.QueryString["ia"]);
                if (!SignalRConnections.connections.ContainsKey(connectionId))
                {
                    SignalRConnections.connections.Add(connectionId, new List<string>());
                }
                SignalRConnections.connections[connectionId].Add(Context.ConnectionId);
            }
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            if (!string.IsNullOrEmpty(Context.QueryString["uid"]) && !string.IsNullOrEmpty(Context.QueryString["ia"]))
            {
                var connectionId = EncryptionDecryption.DecryptByTripleDES(Context.QueryString["uid"]) + "-" + EncryptionDecryption.DecryptByTripleDES(Context.QueryString["ia"]);
                if (SignalRConnections.connections.ContainsKey(connectionId))
                {
                    var connectionList = SignalRConnections.connections[connectionId];
                    connectionList.RemoveAll(x => x == Context.ConnectionId);
                }
            }
            return base.OnDisconnected(stopCalled);
        }
        ////    public List<string> GetActiveConnectionIds(List<string> connectionIds)
        ////    {
        ////        var heartBeat = GlobalHost.DependencyResolver.Resolve<ITransportHeartbeat>();
        ////        var connections = heartBeat.GetConnections();
        ////        if (connections != null && connectionIds != null)
        ////        {
        ////            var filterdConnectionIds = connections.Where(m => connectionIds.Contains(m.ConnectionId)).Select(m => m.ConnectionId).ToList();
        ////            return filterdConnectionIds;
        ////        }
        ////        return connectionIds;
        ////    }
        ////    public void RefreshOnlineUsers(int userID)
        ////    {
        ////        var users = _UserRepo.GetOnlineFriends(userID);
        ////        RefreshOnlineUsersByConnectionIds(users.SelectMany(m => m.ConnectionID).ToList(), userID);
        ////    }
        ////public void RefreshOnlineUsersByConnectionIds(List<string> connectionIds, int userID = 0)
        ////{
        ////    Clients.Clients(connectionIds).RefreshOnlineUsers();
        ////    if (userID > 0)
        ////    {
        ////        var onlineStatus = _UserRepo.GetUserOnlineStatus(userID);
        ////        if (onlineStatus != null)
        ////        {
        ////            Clients.Clients(connectionIds).RefreshOnlineUserByUserID(userID, onlineStatus.IsOnline, Convert.ToString(onlineStatus.LastUpdationTime));
        ////        }
        ////    }
        ////}
        ////    public void SendRequest(int userID, int loggedInUserID)
        ////    {
        ////        _UserRepo.SendFriendRequest(userID, loggedInUserID);
        ////        SendNotification(loggedInUserID, userID, "FriendRequest");
        ////    }
        ////    public void SendNotification(int fromUserID, int toUserID, string notificationType)
        ////    {
        ////        int notificationID = _UserRepo.SaveUserNotification(notificationType, fromUserID, toUserID);
        ////        var connectionId = _UserRepo.GetUserConnectionID(toUserID);
        ////        if (connectionId != null && connectionId.Count() > 0)
        ////        {
        ////            var userInfo = CommonFunctions.GetUserModel(fromUserID);
        ////            int notificationCounts = _UserRepo.GetUserNotificationCounts(toUserID);
        ////            Clients.Clients(connectionId).ReceiveNotification(notificationType, userInfo, notificationID, notificationCounts);
        ////        }
        ////    }
        ////    public void SendResponseToRequest(int requestorID, string requestResponse, int endUserID)
        ////    {
        ////        var notificationID = _UserRepo.ResponseToFriendRequest(requestorID, requestResponse, endUserID);
        ////        if (notificationID > 0)
        ////        {
        ////            var connectionId = _UserRepo.GetUserConnectionID(endUserID);
        ////            if (connectionId != null && connectionId.Count() > 0)
        ////            {
        ////                Clients.Clients(connectionId).RemoveNotification(notificationID);
        ////            }
        ////        }
        ////        if (requestResponse == "Accepted")
        ////        {
        ////            SendNotification(endUserID, requestorID, "FriendRequestAccepted");
        ////            List<string> connectionIds = _UserRepo.GetUserConnectionID(new int[] { endUserID, requestorID });
        ////            RefreshOnlineUsersByConnectionIds(connectionIds);
        ////        }
        ////    }
        ////    public void RefreshNotificationCounts(int toUserID)
        ////    {
        ////        var connectionId = _UserRepo.GetUserConnectionID(toUserID);
        ////        if (connectionId != null && connectionId.Count() > 0)
        ////        {
        ////            int notificationCounts = _UserRepo.GetUserNotificationCounts(toUserID);
        ////            Clients.Clients(connectionId).RefreshNotificationCounts(notificationCounts);
        ////        }
        ////    }
        ////    public void ChangeNotitficationStatus(string notificationIds, int toUserID)
        ////    {
        ////        if (!string.IsNullOrEmpty(notificationIds))
        ////        {
        ////            string[] arrNotificationIds = notificationIds.Split(',');
        ////            int[] ids = arrNotificationIds.Select(m => Convert.ToInt32(m)).ToArray();
        ////            _UserRepo.ChangeNotificationStatus(ids);
        ////            RefreshNotificationCounts(toUserID);
        ////        }
        ////    }
        ////    public void UnfriendUser(int friendMappingID)
        ////    {
        ////        var friendMapping = _UserRepo.RemoveFriendMapping(friendMappingID);
        ////        if (friendMapping != null)
        ////        {
        ////            List<string> connectionIds = _UserRepo.GetUserConnectionID(new int[] { friendMapping.EndUserID, friendMapping.RequestorUserID });
        ////            RefreshOnlineUsersByConnectionIds(connectionIds);
        ////        }
        ////    }
        ////    public void SendMessage(int fromUserId, int toUserId, string message, string fromUserName, string fromUserProfilePic, string toUserName, string toUserProfilePic)
        ////    {
        ////        ChatMessage objentity = new ChatMessage();
        ////        objentity.CreatedOn = System.DateTime.Now;
        ////        objentity.FromUserID = fromUserId;
        ////        objentity.IsActive = true;
        ////        objentity.Message = message;
        ////        objentity.ViewedOn = System.DateTime.Now;
        ////        objentity.Status = "Sent";
        ////        objentity.ToUserID = toUserId;
        ////        objentity.UpdatedOn = System.DateTime.Now;
        ////        var obj = _MessageRepo.SaveChatMessage(objentity);
        ////        var messageRow = CommonFunctions.GetMessageModel(obj);
        ////        List<string> connectionIds = _UserRepo.GetUserConnectionID(new int[] { fromUserId, toUserId });
        ////        Clients.Clients(connectionIds).AddNewChatMessage(messageRow, fromUserId, toUserId, fromUserName, fromUserProfilePic, toUserName, toUserProfilePic);
        ////    }
        ////    public void SendUserTypingStatus(int toUserID, int fromUserID)
        ////    {
        ////        List<string> connectionIds = _UserRepo.GetUserConnectionID(new int[] { toUserID });
        ////        if (connectionIds.Count > 0)
        ////        {
        ////            Clients.Clients(connectionIds).UserIsTyping(fromUserID);
        ////        }
        ////    }
        ////    public void UpdateMessageStatus(int messageID, int currentUserID, int fromUserID)
        ////    {
        ////        if (messageID > 0)
        ////        {
        ////            _MessageRepo.UpdateMessageStatusByMessageID(messageID);
        ////        }
        ////        else
        ////        {
        ////            _MessageRepo.UpdateMessageStatusByUserID(fromUserID, currentUserID);
        ////        }
        ////        List<string> connectionIds = _UserRepo.GetUserConnectionID(new int[] { currentUserID, fromUserID });
        ////        Clients.Clients(connectionIds).UpdateMessageStatusInChatWindow(messageID, currentUserID, fromUserID);
        ////    }
        ////}
    }
}