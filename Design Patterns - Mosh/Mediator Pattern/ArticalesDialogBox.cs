using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class ArticalesDialogBox : DialogBox
    {
        public ListBox ArticlesListBox { get; set; } /*= new ListBox(owner: this);*/
        public TextBox TitleTextBox { get; set; } /*= new TextBox(owner: this);*/
        public Button SaveButton { get; set; }/* = new Button(owner: this);*/

        public ArticalesDialogBox()
        {
            ArticlesListBox = new ListBox(this);
            TitleTextBox = new TextBox(this);
            SaveButton = new Button(this);
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

        public override void Changed(UIControl uIControl)
        {
            if (uIControl == ArticlesListBox)
                ArticaleSelected();
            else if (uIControl == TitleTextBox)
                TitleTextBoxChanged();
            

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
