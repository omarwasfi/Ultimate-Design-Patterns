using System.Collections.Generic;

namespace Undo_Mekanizem___MY_SOLVE
{
    public class Editor
    {
        private string content;

        private List<string> recentContents;

        public Editor()
        {
            recentContents = new List<string>();
        }

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
            this.recentContents.Add(content);
        }

        public void undo()
        {
            if (recentContents.Count > 1)
            {
                this.recentContents.RemoveAt(recentContents.Count - 1);
                this.content = this.recentContents[recentContents.Count - 1];
            }
            else
            {
                this.recentContents = new List<string>();
                this.content = "";
            }
        }
    }
}