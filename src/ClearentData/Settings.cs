using System.Configuration;

namespace ClearentData
{
    public class Settings
    {
        private static string _repoType;
      
        public static string GetRepoType()
        {
            var what = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (string.IsNullOrEmpty(_repoType))
                _repoType = ConfigurationManager.AppSettings["RepositoryType"].ToString();

            return _repoType;
        }
    }
}
