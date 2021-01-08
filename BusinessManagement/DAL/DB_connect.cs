using FireSharp.Config;
namespace DAL
{
    public class DB_connect
    {
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "o0eMR0noTxqK87VmrKy0nSPtfI6YgdAb7rEeFCbe",
            BasePath = "https://businessmanagementuit-default-rtdb.firebaseio.com/"
        };
    }
}
