using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace ConsoleApp
{
    public class MsdnMagazine
    {
        /// <summary>
        /// 
        /// </summary>
        public string Publisher { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int IssueNum { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public List<Chapter> Chapters { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchKey"></param>
        /// <returns></returns>
        public int GetChapterPageCount(string searchKey)
        {
            var startPage = -1;

            try
            {
                var chapters = this.Chapters.Where(x => x.Name.Contains(searchKey)).OrderBy(x => x.StartPage);

                if (chapters.Any() == true)
                {
                    //only return the first matched chapter's start page
                    startPage = chapters.First().StartPage;
                }

            }
            catch (Exception ex)
            {
                Debug.Fail(ex.Message + "[" + ex.StackTrace +"]");
            }

            return startPage;
        }
    }




    /// <summary>
    /// 
    /// </summary>
    public class Chapter
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int StartPage { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int EndPage { get; set; }
    }
}
