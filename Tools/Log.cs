namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;

        private Log(string path)
        {
            _path = path;
        }

        public static Log GetInstance(string path)
        {
            if (_instance == null)
            {
                _instance = new Log(path);
            }

            return _instance;
        }

        public void Save(string msg)
        {
            File.AppendAllText(_path, msg + Environment.NewLine);
        }
    }
}
