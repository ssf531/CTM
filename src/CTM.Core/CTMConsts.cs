using CTM.Debugging;

namespace CTM
{
    public class CTMConsts
    {
        public const string LocalizationSourceName = "CTM";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "492b117f45f945d5a13c910c70b0d3ad";
    }
}
