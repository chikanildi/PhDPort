namespace Phd_Port.Model
{
    public class EventModel
    {

        public int id;
        public string Title;
        public string EventType { get; set; }
        public List<string> EventTypes { get; set; } = new List<string>
        {
            "Conference",
            "Podcast",
            "Colloqium",
            "Lecture series",
            "Research Seminar",
            "Roundtable discussion",
            "Seminar",
            "Summer School",
            "Webinar", "Workshop"
            // Add more event types as needed
        };
        public string Organizer { get; set; }
        public string Location;
        public string Mode;
        public string Fee;
        public string Description;
        public string FavText = "far";
        public string EventUrl;
        public int IsDeleted;
        public string EventUrlFormatted
        {
            get
            {
                if (EventUrl.Contains("http"))
                {
                    return EventUrl;
                }
                return "https://" + EventUrl;
            }
        }

        public DateTime StartDate;
        public DateTime EndDate;
        public string PostedBy;
        public DateTime SubmitDate;


    }
}
