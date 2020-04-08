using System;

namespace Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ArticalesDialogBox dialog = new ArticalesDialogBox();
            /*dialog.ArticlesListBox = new ListBox(dialog);
            dialog.TitleTextBox = new TextBox(dialog);
            dialog.SaveButton = new Button(dialog);*/
            dialog.SimulateUserInteraction();

        }
    }
}
