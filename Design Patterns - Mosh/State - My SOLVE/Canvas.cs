namespace State___My_SOLVE
{
    public class Canvas
    {
        public Tool SelectedTool { get; set; }

        public void MouseDown()
        {
            SelectedTool.MouseDownBehave();
        }

        public void MouseUp()
        {
            SelectedTool.DrawBehave();
        }

    }
}