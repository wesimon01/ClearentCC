using System.Configuration;

namespace ClearentData
{
    public static class Settings
    {
        private static string _repoType;
         
        public static string GetRepoType()
        {
            // var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // above will tell you where the executing code is looking for configuration

            if (string.IsNullOrEmpty(_repoType))
                _repoType = ConfigurationManager.AppSettings["RepositoryType"].ToString();

            return _repoType;
        }
    }
}
