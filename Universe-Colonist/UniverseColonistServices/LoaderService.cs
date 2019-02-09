using System;
using System.IO;
using Game.Configurations;

namespace Game.Services
{
    public class LoaderService
    {
        public Config Config { get; internal set; }

        public LoaderService()
        {
            LoadConfig("\\_Data\\Config.json");
        }

        private void LoadConfig(string path)
        {
            string json = Load(path);
            
        }

        public string Load(string path)
        {
            var fullPath = Path.Combine(Environment.CurrentDirectory, path);
            string json = "";

            try
            {
                json = File.ReadAllText(fullPath);
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw;
            }

            return json;
        }
    }
}
