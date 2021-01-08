using FireSharp.Config;
using FireSharp.Interfaces;
namespace DAL
{
    public static class DB_connect
    {
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "o0eMR0noTxqK87VmrKy0nSPtfI6YgdAb7rEeFCbe",
            BasePath = "https://businessmanagementuit-default-rtdb.firebaseio.com/"
        };
        public static IFirebaseClient client = new FireSharp.FirebaseClient(config);
    }
}
