using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public partial class FormFacebook : Form
    {
        private List<string> m_NameOfWhoLikedSelectedPost;
        private int m_LastPostIndexToGet = 0;
        public FormFacebook()
        {
            InitializeComponent();
            fetchUserData();
            m_NameOfWhoLikedSelectedPost = new List<string>();
        }

        private void fetchUserData()
        {
            
            updateProfilePicture();
            updateCoverPicture();
            updateUserName();
            fetchfriends();
            //new Thread(this.updateWall).Start();
            updateWall();
        }

        private void updateWall()
        {
            const int k_zero = 0;

            try
            {
                listBoxWall.DisplayMember = "PostData";
                foreach (PostDataHolder post in LoggedInUser.Instance().GetPostsData(m_LastPostIndexToGet))
                {

                    if (post.PostData != null)
                    {
                        
                        
                        listBoxWall.Items.Add(post);
                    }

                }
                if(this.listBoxWall.Items.Count > k_zero)
                {
                    this.listBoxWall.SelectedIndex = k_zero;
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           
            
        }
      

        private void updateProfilePicture()
        {
            ProfielpictureBox.LoadAsync(LoggedInUser.Instance().GetProfilePicture());
        }


        private void updateCoverPicture()
        {
            CoverpictureBox.LoadAsync(LoggedInUser.Instance().GetCoverPicture());
        }

        private void updateUserName()
        {
            FirsrNamelabel.Text = LoggedInUser.Instance().GetFirstName();
            LastNamelabel.Text = LoggedInUser.Instance().GetLastName();
            
        }

        private void PostextBox_MouseEnter(object sender, EventArgs e)
        {

            string defultStatus = "Whats on your mind ? ";
            if (PostextBox.Text == defultStatus)
            {
                PostextBox.Text = string.Empty;
            }


        }

        

        private void PostButton_Click(object sender, EventArgs e)
        {
            LoggedInUser.Instance().PostStatus(PostextBox.Text);
            PostextBox.Text = string.Empty;
            
        }

        private void fetchfriends()
        {
            string unknowUserPicUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRg7sqvEEQjipFVPNEuizNSE_KhUBY5IgwkOkUNU3of52M47X7F";
            this.FriendpictureBox.LoadAsync(unknowUserPicUrl);
            this.listBoxFriends.Items.Clear();
            const int k_Zero = 0;
            List<string> friendsNameList = LoggedInUser.Instance().GetFreindsNames();
            if (friendsNameList.Count > k_Zero)
            {
                foreach (string friendName in friendsNameList)
                {
                    listBoxFriends.Items.Add(friendName);
                }
            }

            else
            {
                string haveNoFriendError = string.Format("{0} dont have any friends", LoggedInUser.Instance().GetFirstName());
                listBoxFriends.Items.Add(haveNoFriendError);
            }
        }


        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetSelectedFrindPic();
        }

        private void fetSelectedFrindPic()
        {
            string PictureLargeURL;
            string selectedFriend = listBoxFriends.SelectedItem.ToString();
            PictureLargeURL = LoggedInUser.Instance().GetImageUrlBySelectedFriend(selectedFriend);
            if (PictureLargeURL != null)
            {
                FriendpictureBox.LoadAsync(PictureLargeURL);
            }
            else
            {
                FriendpictureBox.Image = FriendpictureBox.ErrorImage;
            }

        }

     
        private void listBoxWall_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            object selectedPost = listBoxWall.SelectedItem;
            PostDataHolder selectedPostData = selectedPost as PostDataHolder;
            listBoxSearchResults.Items.Clear();
            UpdatePostDataBySelectedPost(selectedPostData);
                



        }

        private void UpdatePostDataBySelectedPost(PostDataHolder i_SelectedPostData)
        {
            updatedLikeNumberBySelectedPost(i_SelectedPostData.LikesNumber);
            updatedPictureOfSelectedPost(i_SelectedPostData.PostUrl);
            updatedCommentsOfSelectedPost(i_SelectedPostData.Commnets);
            m_NameOfWhoLikedSelectedPost = i_SelectedPostData.WhoLikedNamesList;
            
        }

        private void updatedCommentsOfSelectedPost(List<string> i_Commnets)
        {
            listBoxPostComments.Items.Clear();
            const int k_Zero = 0;
            if (i_Commnets.Count > k_Zero)
            {
                foreach (string comment in i_Commnets)
                {
                    listBoxPostComments.Items.Add(comment);
                }
            }
            else
            {
                const string k_NoOfCommentMessages = "This Post dont have any comments";
                listBoxPostComments.Items.Add(k_NoOfCommentMessages);
            }
        }

        private void updatedPictureOfSelectedPost(string i_PostUrl)
        {
            const string k_NoPicUrl = "https://i.imgur.com/8EMJr2i.png";
            if (i_PostUrl != null)
            {
                pictureBoxWall.LoadAsync(i_PostUrl);
                
            }
            else
            {
                pictureBoxWall.LoadAsync(k_NoPicUrl);
            }

        }

        private void updatedLikeNumberBySelectedPost(int i_LikesCount)
        {
            labelLikeNumberToPost.Text = Convert.ToString(i_LikesCount);
        }

        private void textBoxSearchLikers_TextChanged(object sender, EventArgs e)
        {
            showToUserSearchOptions(textBoxSearchLikers.Text);
        }

        private void showToUserSearchOptions(string I_UserSearchText)
        {

            if (I_UserSearchText != string.Empty)
            {
                foreach (string name in m_NameOfWhoLikedSelectedPost)
                {
                    if (name.StartsWith(I_UserSearchText) && !listBoxSearchResults.Items.Contains(name))
                    {
                        listBoxSearchResults.Items.Add(name);
                    }
                }
            }

            for (int i = listBoxSearchResults.Items.Count - 1; i >= 0; i--)
            {
                string name = listBoxSearchResults.Items[i] as String;
                if (!name.StartsWith(I_UserSearchText))
                {
                    listBoxSearchResults.Items.RemoveAt(i);
                }
            }
        }

        private void listBoxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFriendPhotoBySearch();
        }

        private void updateFriendPhotoBySearch()
        {
            string friendUrl = LoggedInUser.Instance().GetImageUrlBySelectedFriend(listBoxSearchResults.SelectedItem.ToString());
            if(friendUrl != null)
            {
                FriendpictureBox.LoadAsync(friendUrl);
            }
            else
            {
                const string k_NoPicUrl = "https://i.imgur.com/8EMJr2i.png";
                FriendpictureBox.LoadAsync(k_NoPicUrl);
                MessageBox.Show("This friend don't have permissions in your app");
            }
            
        }

        private void buttonLoadPosta_Click(object sender, EventArgs e)
        {
            loadMorePostToWall();
        }

        private void loadMorePostToWall()
        {
          
            m_LastPostIndexToGet = LoggedInUser.Instance().GetLastPostIndex();
            updateWall();
        }

        private void buttonSaveBlessing_Click(object sender, EventArgs e)
        {
            if(textBoxBlessing.Text != string.Empty)
            {
                saveUserBless();
            }
            else
            {
                MessageBox.Show("Please dont save empty blessing");
            }

        }

        private void saveUserBless()
        {
            try
            {
                bool isFemaleBless = false;
                if (this.checkBoxIsFemaleBlessing.Checked)
                {
                    isFemaleBless = true;
                }

                LoggedInUser.Instance().SaveUserBlessings(isFemaleBless, textBoxBlessing.Text);
                textBoxBlessing.Text = string.Empty;
                MessageBox.Show("Blessing was saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBlessFriends_Click(object sender, EventArgs e)
        {
            greatingYourFriends();
        }

        private void greatingYourFriends()
        {
            try
            {
                const int k_zero = 0;
                List<Dictionary<string, string>> friends = LoggedInUser.Instance().BlessFriendWhoHaveABirthDay();
                if (friends.Count > k_zero)
                {

                    foreach (Dictionary<string, string> friend in friends)
                    {

                        listBoxGreeting.Items.Add(friend.Keys.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
