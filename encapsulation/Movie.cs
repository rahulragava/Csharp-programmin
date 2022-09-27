namespace encapsulation
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {

                if ((value == "u") || (value == "ua"))
                {
                    rating = value;
                }
                else
                {
                    rating = "NA";
                }
            }
        }
    }

}
