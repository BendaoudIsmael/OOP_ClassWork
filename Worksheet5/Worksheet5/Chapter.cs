using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet5
{
    class Chapter
    {
        List<Page> pages = new List<Page>();
        string title;
        int chapterNumber;

        public string Title { get => title; set => title = value; }
        public int ChaptherNumber { get => chapterNumber; set => chaptherNumber = value; }
        internal List<Page> Pages { get => pages; set => pages = value; }

        public Chapter(string title, int chapterNumber)
        {
            this.title = title;
            this.chapterNumber = chapterNumber;
        }

        public void AddPage()
        {
            /*We have a compostion relationship between chapter and page since
             * the page instance is created in the chapter instance and without
             * the chapter instance, the page instance cannout be accessed.
             * therefore, if the chapter instance is deleted, the page instance is
             * deleted with it.
             */
            Page newPage = new Page(pages.Count + 1);
            pages.Add(newPage);

            //pages.Add(new Page(pages.Count + 1 ));
        }
    }
}
