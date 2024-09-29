using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace ZomatoLikeApplication
{
    public class JsonHandler
    {
        public static void ParseJson(string jsonString)
        {
            var reviews = JsonConvert.DeserializeObject<ReviewList>(jsonString);

            foreach (var review in reviews.Reviews)
            {
                Console.WriteLine($"Review for {review.Restaurant}: {review.ReviewText}, Rating: {review.Rating}");
            }
        }

    }
    public class Review
    {
        public string Restaurant { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
    }

    public class ReviewList
    {
        public List<Review> Reviews { get; set; }
    }

}
