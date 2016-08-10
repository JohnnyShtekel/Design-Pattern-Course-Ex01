using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public sealed class LoggedInUser
    {
        
        private static volatile LoggedInUser m_Instance = null;
        private static object m_SyncRoot = new Object();
        public User FacebookUser { get; private set; }
        private int m_LastPostIndex;
        private LoginResult m_LoginResult;
      
        public static LoggedInUser Instance()
        {
            if (m_Instance == null)
            {
                lock (m_SyncRoot)
                {
                    if (m_Instance == null)
                    {
                        m_Instance = new LoggedInUser();
                    }
                }
            }
            return m_Instance;
        }

        private LoggedInUser()
        {
            
            FacebookWrapper.FacebookService.s_CollectionLimit = 500;
            m_LoginResult = FacebookService.Login("857311881068409",
            "public_profile",
            "user_education_history",
            "user_birthday",
            "user_actions.video",
            "user_actions.news",
            "user_actions.music",
            "user_actions.fitness",
            "user_actions.books",
            "user_about_me",
            "user_friends",
            "publish_actions",
            "user_events",
            "user_games_activity",
            "user_hometown",
            "user_likes",
            "user_location",
            "user_managed_groups",
            "user_photos",
            "user_posts",
            "user_relationships",
            "user_relationship_details",
            "user_religion_politics",
            "user_tagged_places",
            "user_videos",
            "user_website",
            "user_work_history",
            "read_custom_friendlists",
            "read_page_mailboxes",
            "manage_pages",
            "publish_pages",
            "publish_actions",
            "rsvp_event"
        );
            FacebookUser = m_LoginResult.LoggedInUser;
            

        }

        public  bool IsUserConnected()
        {
            bool isUserConnected = false;
            if (m_Instance.m_LoginResult.AccessToken != null)
            {
                isUserConnected = true;
            }

            return isUserConnected;
        }

        public  void PostStatus(string i_Text)
        {
            if (i_Text != string.Empty)
            {
                FacebookUser.PostStatus(i_Text);
            }
            
        }

        
        public string GetLastName()
        {
            return FacebookUser.LastName;
        }

        public string GetFirstName()
        {
            return FacebookUser.FirstName;
        }

        public string GetCoverPicture()
        {
            return FacebookUser.Cover.SourceURL;
        }

        public string GetProfilePicture()
        {
            return FacebookUser.PictureLargeURL;
        }

        public List<string> GetFreindsNames()
        {
            List<string> FriendNamesList = new List<string>(); 
            foreach (User friend in FacebookUser.Friends)
            {
                FriendNamesList.Add(friend.Name);
            }
            
            return FriendNamesList;
        }


      

       public List<PostDataHolder> GetPostsData(int i_StarIndex)
        {
            try
            {
                const int k_NumberOfPostToReturn = 10;
                List<PostDataHolder> postDataList = new List<PostDataHolder>();
                FacebookObjectCollection<Post> myPosts = FacebookUser.Posts;
                for (int i = i_StarIndex; i < i_StarIndex + k_NumberOfPostToReturn; i++)
                {
                    int likesNumber = myPosts[i].LikedBy.Count;
                    List<string> comments = getCommentsMessages(myPosts[i].Comments);
                    List<string> whoLikedThisPost = getListOfPeopleWhoLikedThisPost(myPosts[i].LikedBy);
                    PostDataHolder post;
                    post = new PostDataHolder(myPosts[i].Message, myPosts[i].PictureURL, likesNumber, comments, whoLikedThisPost);
                    postDataList.Add(post);
                }

                m_LastPostIndex = i_StarIndex + k_NumberOfPostToReturn;
                return postDataList;
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new ApplicationException("You dont have more Posts");
            }
        }

        public int GetLastPostIndex()
        {
            return m_LastPostIndex;
        }

        private List<string> getListOfPeopleWhoLikedThisPost(FacebookObjectCollection<User> i_LikedBy)
        {
            List<string> whoLikedThisPost = new List<string>();
            foreach (User user in i_LikedBy)
            {
                whoLikedThisPost.Add(user.Name);
            }
            return whoLikedThisPost;
        }

        private List<string> getCommentsMessages(FacebookObjectCollection<Comment> comments)
        {
            List<string> CommentsMeassage = new List<string>();
            foreach (Comment comment in comments)
            {
                CommentsMeassage.Add(comment.Message);
            }

            return CommentsMeassage;
        }

        public string GetImageUrlBySelectedFriend(string i_FriendFullName)
        {
            
            string PictureLargeURL = null;
            foreach (User friend in FacebookUser.Friends)
            {
                if (i_FriendFullName == friend.Name)
                {
                    PictureLargeURL = friend.PictureLargeURL;
                }
            }

            return PictureLargeURL;
        }

        public int GetNumberLikesOfSelectedPost(string i_PostText)
        {
            int likesNumbers = 0;
            foreach (Post post in FacebookUser.Posts)
            {
                
                if (post.Message == i_PostText)
                {
                    likesNumbers = post.LikedBy.Count();
                }
            }

            return likesNumbers;
        }

        public void SaveUserBlessings(bool i_IsFemaleBless, string i_Blessing)
        {
            string xmlPath = @"..\..\xml's\MaleBlessings.xml";
            if (i_IsFemaleBless)
            {
                xmlPath = @"..\..\xml's\FemaleBlessings.xml";
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            List<string> blessingList = loadBlessingDb(serializer, xmlPath);
            blessingList.Add(i_Blessing);
            UpdateDb(xmlPath, blessingList, serializer);   
        }

        private void UpdateDb(string i_XmlPath,List<string> i_BlessingList, XmlSerializer i_Serializer)
        {

            using (FileStream stream = new FileStream(i_XmlPath, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                i_Serializer.Serialize(stream, i_BlessingList);
            }
        }

        private List<string> loadBlessingDb(XmlSerializer i_Serializer,string i_Path)
        {
            List<string> dezerializedList;
            using (FileStream stream = File.OpenRead(i_Path))
            {
                dezerializedList = (List<string>)i_Serializer.Deserialize(stream);
            }

            return dezerializedList;
        }

        public List<Dictionary<string, string>> BlessFriendWhoHaveABirthDay()
        {
            List<Dictionary<string, string>> peoplewhoblssedList = new List<Dictionary<string, string>>();
            string maleXmlPath = @"..\..\xml's\MaleBlessings.xml";
            string femaleXmlPath = @"..\..\xml's\FemaleBlessings.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            List<string> femaleBlessingList = loadBlessingDb(serializer, maleXmlPath);
            List<string> maleBlessingList = loadBlessingDb(serializer, maleXmlPath);
            try
            {
                foreach (User friend in FacebookUser.Friends)
                {

                    if (friend.Birthday != null)
                    {
                        List<string> updatedFriendList = new List<string>();
                        if (friend.Gender == User.eGender.female)
                        {
                            updatedFriendList = maleBlessingList;
                        }
                        else
                        {
                            updatedFriendList = maleBlessingList;
                        }


                        if (DateTime.Parse(friend.Birthday) == DateTime.Today)
                        {
                            Dictionary<string, string> returnToClientFriend = new Dictionary<string, string>();
                            Random rnd = new Random();
                            int index = rnd.Next(updatedFriendList.Count);
                            friend.PostStatus(updatedFriendList[index]);
                            returnToClientFriend.Add(friend.Name, updatedFriendList[index]);
                            peoplewhoblssedList.Add(returnToClientFriend);
                        }


                    }

                }
                return peoplewhoblssedList;
            }
           catch(Exception ex)
            {
                throw new ApplicationException("User dont have permmision to post on his wall");
            }

            
        }
    }
     
}
