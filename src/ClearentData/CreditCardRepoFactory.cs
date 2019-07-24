using System;

namespace ClearentData
{
    public class CreditCardRepoFactory
    {
        public static ICreditCardRepo GetRepository()
        {
            string repoType = Settings.GetRepoType();

            switch (repoType.ToUpper())
            {
                case "TEST":
                    return new CreditCardTestRepo();
                    
                default:
                    throw new Exception("Could not find valid RepositoryType configuration value");
            }
        }
    }
}
