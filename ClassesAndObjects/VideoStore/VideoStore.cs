using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class VideoStore
    {

        private List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>();
        }
        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public void CheckOut(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title != title) continue;
                {
                    if (!video.Available())
                    {
                        Console.WriteLine("Not available!");
                    }
                    else
                    {
                        video.BeingCheckOut();
                    }
                }
                
            }
        }
        public void ReturnVideo(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title != title) continue;
                {
                    if (video.Available())
                    {
                        Console.WriteLine("Can't return, not rented!");
                    }
                    else
                    {
                        video.BeingReturned();
                    }
                    
                }
                
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach (var video in _inventory)
            {
                Console.WriteLine(video.ToString());
            }
        }
    }
}
