using FireSharp.Config;
using FireSharp.Interfaces;
namespace DAL
{
    public static class DB_connect
    {
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Z5SMsT1X1xcb3du5OrKnA2YaGYzkUuQsgq55riWO",
            BasePath = "https://bmproject-e9619-default-rtdb.firebaseio.com/"
        };
        public static IFirebaseClient client = new FireSharp.FirebaseClient(config);
    }
}
