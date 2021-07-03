using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Feedback_System
{
    public class Review
    {

        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Suggestion { get; set; }
        public DateTime SubmittedDate { get; set; }

        public Dictionary<string, string> Criterias { get; set; }
        public List<Review> ReviewList()
        {
            string data = Utility.TxtReader(@"Rating.txt");
            if (data != null)
            {
                List<Review> feedbacklst = JsonConvert.DeserializeObject<List<Review>>(data);
                return feedbacklst;
            }
            return null;
        }

    }
}
