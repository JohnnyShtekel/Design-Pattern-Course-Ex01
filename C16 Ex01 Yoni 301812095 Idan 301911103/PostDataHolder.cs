using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
   public class PostDataHolder 
    {
        public string PostData { get; set; }
        public string PostUrl { get; set; }
        public int LikesNumber { get; set; }
        public List<string> Commnets { get; set; }
        public List<string> WhoLikedNamesList { get; set; }
        public PostDataHolder( string i_PostData,string i_PostUrl, int i_LikesNumber, List<string> i_Commnets, List<string> i_WhoLikedNamesList)
        {
            PostData = i_PostData;
            PostUrl = i_PostUrl;
            LikesNumber = i_LikesNumber;
            Commnets = i_Commnets;
            WhoLikedNamesList = i_WhoLikedNamesList;
        }

    }
}
