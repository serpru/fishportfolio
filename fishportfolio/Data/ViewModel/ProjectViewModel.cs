using MudBlazor;

namespace fishportfolio.Data.ViewModel
{
    public class ProjectViewModel
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
        public string Href { get; set; }
        public Color Color { get; set; }
        public bool IsDone { get; set; }



        public ProjectViewModel()
        {
            Date = new DateTime(2022, 11, 2);
            Title = "Default title";
            Description = "Default description";
            ImageLink = "images/placeholder-image.jpg";
            Href = "/";
            Color = Color.Secondary;
            IsDone = true;
        }

        public ProjectViewModel(DateTime date, string title, string description, string imageLink, string href, Color color, bool isDone)
        {
            Date = date;
            Title = title;
            Description = description;
            ImageLink = imageLink;
            Href = href;
            Color = color;
            IsDone = isDone;
        }
    }
}
