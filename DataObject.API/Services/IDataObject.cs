namespace DataObject.API.Services
{
    public interface IDataObject
    {
        public static abstract Task<bool> DoesExists(string remoteFullPath);

        public static abstract Task Upload(string file, string remoteFullPath);

        public static abstract Task Download(string remoteFullPath, string localFullPath = "");

        public static abstract Task<string> Publish(string remoteFullPath, int expirationTime = 90);

        public static abstract Task Remove(string remoteFullPath, bool recursive = false);

    }
}
