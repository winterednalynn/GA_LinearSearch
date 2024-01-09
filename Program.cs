using static System.Formats.Asn1.AsnWriter;

namespace GA_LinearSearch
{ //EDNA LYNN LAXA 
  //COMPUTER PROGRAMMING V 
  //ASSIGNMENT: GUIDED ASSIGNMENT 3 : LINEAR SEARCH 
  //JANUARY 7, 2023 
    internal class Program
    {
        // Declare the global arrays
        static string[] storeDirectory;
        static string[] storeCategories;
        static Store[] stores;

        //Global Declared array - MINES 
        static string[] movieCategory;
        static string[] movieName;
        static int[] movieRate;
        static Movies[] theMovie;  

        static void Main(string[] args)
        {
            ednalynnPL();

            //SEARCH BY MOVIE 
            Console.WriteLine("Movie Search");
            Console.WriteLine("Walk to Remember: ");
            Console.WriteLine(SearchMovie(movieName, "Walk to remember").ToString()); //TRUE 
            Console.WriteLine();
            Console.WriteLine("Evil Dead Rising");
            Console.WriteLine(SearchMovie(movieName, "Evil Dead Rising").ToString()) ; // TRUE 
            Console.WriteLine();
            Console.WriteLine("Emoji");
            Console.WriteLine(SearchMovie(movieName, "Emoji").ToString()); // FALSE 

            //SEARCH BY CATEGORIES 
            Console.WriteLine();
            Console.WriteLine("Movie Categories");
            Console.WriteLine("Comedy");
            Console.WriteLine(MovieByCategory(movieCategory,"Comedy").ToString()); //TRUE
            Console.WriteLine();
            Console.WriteLine("Based on a true story");
            Console.WriteLine(MovieByCategory(movieCategory,"Based on a true story").ToString()); // False
            
           
            //SEARCH BY RATING 
            Console.WriteLine();
            Console.WriteLine("A movie with 5 star Rating ");
            Console.WriteLine(FindFirstMovieByRating(5, theMovie).ToString());  
            Console.WriteLine();
            Console.WriteLine("Movie with a 3 star rating ");
            Console.WriteLine(FindFirstMovieByRating(3, theMovie).ToString());

            //INDEX PLACEMENT 
            Console.WriteLine();
            Console.WriteLine("Index Placement In Movie List ");
            Console.WriteLine();
            Console.WriteLine("Napoleon Dynamite is located in: ");
            Console.WriteLine(AllMoviePlacement(movieName,"Napoleon Dynamite"));
            Console.WriteLine();
            Console.WriteLine("Walk to remember is located in: ");
            Console.WriteLine(AllMoviePlacement(movieName, "Walk to remember"));






            //Console.WriteLine("Contains");
            //Console.WriteLine(ContainsStore(storeDirectory, "Aqua Adventures").ToString()); // True
            //Console.WriteLine(ContainsStore(storeDirectory, "Box Lunch").ToString()); // False

            //Console.WriteLine("Store By Index");
            //Console.WriteLine(StoreByCategory(storeCategories, "Entertainment").ToString()); // 1
            //Console.WriteLine(StoreByCategory(storeCategories, "Food").ToString()); // -1

            //Console.WriteLine("All stores of a category");
            //Console.WriteLine(AllStoresOfACategory(storeCategories, "Café & Bakery").Count); // 2
            //Console.WriteLine(AllStoresOfACategory(storeCategories, "Food").Count); // 0

            //Console.WriteLine("All stores on a floor");

            //List<Store> storeResults = AllStoresOnLevel(stores, "A");
            //Console.WriteLine(storeResults.Count); // 4
            //foreach (Store store in storeResults) { Console.WriteLine($"{store.Name} - {store.StoreLocation}"); }
            //Console.WriteLine(AllStoresOnLevel(stores, "E").Count); // 0


        }

        static void ednalynnPL() // MY PRELOAD 
        {
            movieCategory = new string[]
           {
            "Comedy",
            "Thriller",
            "Horror",
            "Crime",
            "Mystery",
            "Action",
            "Science Fiction",
            "Romance",
            "Animation",
            "Musical"
           };

            movieName = new string[]
            {
                "Napoleon Dynamite",
                "Gone Girl",
                "Evil Dead Rising",
                "Sound of Freedom",
                "A simple favor",
                "Plane",
                "Simone",
                "Walk to remember",
                "Spirited away",
                "Rent"


            };

            movieRate = new int[]
            {
                5,
                4,
                3,
                2,
                1
            };

            theMovie = new Movies[]
            {

                new Movies("Napoleon Dynamite", "Comedy", 5 ),
                new Movies("Gone Girl", "Thriller", 4),
                new Movies("Evil Dead Rising", "Horror", 5),
                new Movies("Sound Of Freedom", "Crime", 5),
                new Movies("A simple favor", "Mystery", 3),
                new Movies("Plane", "Action", 4),
                new Movies("Simone", "Science Fiction", 2),
                new Movies("Walk to Remember", "Romance", 5),
                new Movies("Spirited away", "Animation", 5),
                new Movies("Rent", "Musical", 5)
            }; 
        }
        public static bool SearchMovie(string[] movieList, string searchCommand) // SEARCH METHOD FOR MOVIE 
        {
            foreach (string movie in movieList) // USING FOR EACH TO LOOP THORUGH MOVIE LIST 
            {
                if (movie == searchCommand)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool MovieByCategory(string[] movieList, string searchCommand) // SEARCH THROUGH CATEGORIES 
        {
            foreach(string movie in movieList)
            {
                if(movie == searchCommand)
                {
                    return true; 
                }
            }
            return false; 
        }
        public static List<int> AllMoviePlacement(string[] movieList, string searchCommand) //INDEX FINDER 
        {
            List<int> index = new List<int>();
            for (int i = 0; i < movieList.Length; i++)
            {
                if (movieList[i] == searchCommand)
                {
                    Console.WriteLine(i);
                }
            }
            return index;
           
        }

        public static Movies FindFirstMovieByRating(int searchRating, IEnumerable<Movies> movies) // LOCATE A MOVIE OF REQUESTED RATE
        {
            return movies.FirstOrDefault(movie => movie.rate == searchRating);
        }

        

        //**************************SAMPLE CODE***********************************


        public static void ProfessorsExample()
        {
            Preload();

            Console.WriteLine("Contains");
            Console.WriteLine(ContainsStore(storeDirectory, "Aqua Adventures").ToString()); // True
            Console.WriteLine(ContainsStore(storeDirectory, "Box Lunch").ToString()); // False

            Console.WriteLine("Store By Index");
            Console.WriteLine(StoreByCategory(storeCategories, "Entertainment").ToString()); // 1
            Console.WriteLine(StoreByCategory(storeCategories, "Food").ToString()); // -1

            Console.WriteLine("All stores of a category");
            Console.WriteLine(AllStoresOfACategory(storeCategories, "Café & Bakery").Count); // 2
            Console.WriteLine(AllStoresOfACategory(storeCategories, "Food").Count); // 0

            Console.WriteLine("All stores on a floor");
            List<Store> storeResults = AllStoresOnLevel(stores, "A");
            Console.WriteLine(storeResults.Count); // 4
            foreach (Store store in storeResults) { Console.WriteLine($"{store.Name} - {store.StoreLocation}"); }
            Console.WriteLine(AllStoresOnLevel(stores, "E").Count); // 0
        }



        public static bool ContainsStore(string[] storeList, string searchKey)
        {
            foreach (string store in storeList)
            {
                if (store == searchKey)
                {
                    return true;
                }
            }
            return false;
        }

        public static int StoreByCategory(string[] storeList, string searchKey)
        {
            for (int i = 0; i < storeList.Length; i++)
            {
                if (storeList[i] == searchKey)
                {
                    return i;
                }
            }
            return -1; // Return -1 if not found
        }

        public static List<int> AllStoresOfACategory(string[] storeList, string searchKey)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < storeList.Length; i++)
            {
                if (storeCategories[i] == searchKey)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        public static List<Store> AllStoresOnLevel(Store[] storeList, string searchKey)
        {
            List<Store> storesInCategory = new List<Store>();
            foreach (Store store in storeList)
            {
                if (store.StoreLocation[0].ToString() == searchKey)
                {
                    storesInCategory.Add(store);
                }
            }
            return storesInCategory;
        }

        static void Preload()
        {
            storeDirectory = new string[]
            {
            "Aqua Adventures",
            "Pixel Playhouse",
            "Brew & Bean",
            "Vintage Visions",
            "Garden Gateway",
            "Melody Makers",
            "Spice Spectrum",
            "Tech Trends",
            "Cozy Corner",
            "Frosty Delights"
            };

            storeCategories = new string[]
            {
            "Sports & Recreation",      // Aqua Adventures
            "Entertainment",            // Pixel Playhouse
            "Café & Bakery",            // Brew & Bean
            "Clothing & Accessories",   // Vintage Visions
            "Home & Garden",            // Garden Gateway
            "Entertainment",            // Melody Makers
            "Food & Groceries",         // Spice Spectrum
            "Electronics",              // Tech Trends
            "Home & Garden",            // Cozy Corner
            "Café & Bakery"             // Frosty Delights
            };

            stores = new Store[]
            {
            new Store("Aqua Adventures", "Sports & Recreation", "A21"),
            new Store("Pixel Playhouse", "Entertainment", "B7"),
            new Store("Brew & Bean", "Café & Bakery", "C36"),
            new Store("Vintage Visions", "Clothing & Accessories", "A9"),
            new Store("Garden Gateway", "Home & Garden", "B42"),
            new Store("Melody Makers", "Entertainment", "C15"),
            new Store("Spice Spectrum", "Food & Groceries", "A3"),
            new Store("Tech Trends", "Electronics", "B28"),
            new Store("Cozy Corner", "Home & Garden", "C12"),
            new Store("Frosty Delights", "Café & Bakery", "A31")
            };

        } // End Preload




    }
}
