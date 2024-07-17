using Natter.Debugging;

namespace Natter
{
    public class NatterConsts
    {
        public const string LocalizationSourceName = "Natter";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "337becafc83446e8b3423e95a5db802f";
    }
}
