using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class ArticalesDialogBox 
    {
        public ListBox ArticlesListBox { get; set; } 
        public TextBox TitleTextBox { get; set; } 
        public Button SaveButton { get; set; }


        public ArticalesDialogBox()
        {
            ArticlesListBox = new ListBox();
            TitleTextBox = new TextBox();
            SaveButton = new Button();
        }

        public void SimulateUserInteraction()
        {
            ArticlesListBox.SetSelection("Article 1");
            TitleTextBox.SetContent("");
            ArticlesListBox.SetSelection("Article 2");
            //SaveButton.SetEnabled(false);
            Console.WriteLine("TextBox: " + TitleTextBox.Content);
            Console.WriteLine("Button: " + SaveButton.IsEnabled);
        }

        
        private void TitleTextBoxChanged()
        {

            Boolean isEmpty = (TitleTextBox.Content== null || TitleTextBox.Content == string.Empty);
            SaveButton.SetEnabled(!isEmpty); 
        }

        private void ArticaleSelected()
        {
            TitleTextBox.SetContent(ArticlesListBox.Selection);
            SaveButton.SetEnabled(true);
        }
    }
}
