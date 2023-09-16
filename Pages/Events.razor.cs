using System.Net;
using Microsoft.JSInterop;
using Phd_Port.Data;
using Phd_Port.Model;

namespace Phd_Port.Pages
{
    public partial class Events
    {
        BookmarkhubContext context1;
        public bool isDataReady = false;
        public int whichPage = 0;

        List<Event> events = new List<Event>();
        List<Event> currentEvents = new List<Event>();
        List<Event> eventsUpcoming = new List<Event>();
        int eventsUpcomingTotal = 0;
        int eventsTotal = 0;
        int eventsPageTotal = 0;
        int currentEventsTotal = 0;
        string RowColor;
        string searchText = "";

        public async Task RefreshFavoriteStates()
        {
            foreach (var ev in events)
            {
                int favoritedCount = context1.EventsFavorites.Where(o => o.Targetid == ev.Id && o.Userid == Datastore.userId).Count();

                if (favoritedCount < 1)
                {
                    ev.FavText = "far";
                }
                else
                {
                    ev.FavText = "fas";
                }
            }
        }

        public async Task RefreshEventsList()
        {
            int listfrom = 10 * whichPage;
            // Get new events
            var all_events = context1.Events.Where(e => e.Dateend >= DateTime.UtcNow);
            events = (List<Event>)(from e in all_events
                                   orderby Datastore.SortByColumn, Datastore.SortOrder
                                   select e).Take(10);

            RefreshFavoriteStates();
            StateHasChanged();
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                context1 = DbFactory.CreateDbContext();
                Datastore.SortByColumn = "datestart";
                Datastore.SortOrder = "DESC";
                if (Datastore.isLoggedin == false)
                {
                    NavigationManager.NavigateTo("/");
                }

                // Get new events
                List<Event> all_events = context1.Events.Where(e => e.Dateend >= DateTime.Now && e.Isdeleted == 0).ToList();
                events = (from e in all_events
                          orderby Datastore.SortByColumn, Datastore.SortOrder
                          select e).ToList();
                // Get the total number of upcoming events
                eventsUpcomingTotal = all_events.Count(e => e.Dateend > DateTime.Now && e.Datestart > DateTime.UtcNow);

                // Get the total number of events
                eventsTotal = all_events.Count(e => e.Dateend >= DateTime.Now);

                currentEventsTotal = all_events.Count(e => e.Dateend >= DateTime.Now && e.Datestart <= DateTime.Now);

                isDataReady = true;
                eventsPageTotal = (int)Math.Floor(eventsTotal / 10.0) + 1;
                RefreshFavoriteStates();

                // Format the table right here
                await JS.InvokeVoidAsync("Format_Table");


                StateHasChanged();
            }
            catch (Exception ex)
            {
                string b = ex.Message;
            }
        }


        public async void call_me()
        {
            await JS.InvokeVoidAsync("Format_Table");
        }
        public void FavPressed(Event ev)
        {
            HttpResponseMessage response;

            if (ev.FavText == "fas")
            {
                EventsFavorite model = context1.EventsFavorites.FirstOrDefault(e => e.Targetid == ev.Id && e.Userid == Datastore.userId);
                if (model != null)
                {
                    context1.EventsFavorites.Remove(model);
                    context1.SaveChanges();
                    ev.FavText = "far";
                }

            }
            else if (ev.FavText == "far")
            {
                try
                {

                    EventsFavorite model = new EventsFavorite() { Targetid = ev.Id, Userid = Datastore.userId };
                    context1.EventsFavorites.Add(model);
                    context1.SaveChanges();
                    response = new HttpResponseMessage(HttpStatusCode.Created);

                }
                catch (Exception)
                {
                    response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                }


                if (response.IsSuccessStatusCode)
                {
                    ev.FavText = "fas";
                }
            }
        }
        private void EditEvent(int id)
        {
            NavigationManager.NavigateTo($"/eventedit/{id}");
        }

        //public async Task DeleteEvent(int id)
        //{
        //    if (Datastore.userName != "admin")
        //    {
        //        return;
        //    }

        //    try
        //    {
        //        using (MySqlCommand command = new MySqlCommand("UPDATE events SET isdeleted = 1 WHERE id = @id", connection))
        //        {
        //            command.Parameters.AddWithValue("@id", id);

        //            if (connection.State != System.Data.ConnectionState.Open)
        //                await connection.OpenAsync();

        //            if (await command.ExecuteNonQueryAsync() > 0)
        //            {
        //                JS.InvokeVoidAsync("alert", "item deleted successfully");
        //                eventsTotal--;
        //            }
        //            else
        //            {
        //                JS.InvokeVoidAsync("alert", "item could not be deleted");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        JS.InvokeVoidAsync("alert", "item could not be deleted (error)");
        //    }
        //}


    }
}


