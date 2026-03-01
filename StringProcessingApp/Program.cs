using StringProcessingApp.Views;

namespace StringProcessingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Only creates and runs the view
            StringView view = new StringView();
            view.Run();
        }
    }
}
