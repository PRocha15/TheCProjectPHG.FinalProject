namespace TheCProject.Commons
{
    public static class GuidHelper
    {
        public static string ToHtmlIdentifier(this Guid input)
        {
            return GuidToBase64(input);
        }

        public static Guid FromHtmlIdentifier(this string input)
        {
            return Base64ToGuid(input);
        }

        public static string GuidToBase64(this Guid identifier)
        {
            return Convert.ToBase64String(identifier.ToByteArray()).Replace("/", "-").Replace("+", "_").Replace("=", "");
        }

        public static Guid Base64ToGuid(string base64)
        {
            Guid guid = default(Guid);
            if (string.IsNullOrEmpty(base64) || Guid.TryParse(base64, out guid))
            {
                return guid;
            }

            base64 = base64.Replace("-", "/").Replace("_", "+") + "==";

            try
            {
                guid = new Guid(Convert.FromBase64String(base64));
            }
            catch (Exception ex)
            {
                throw new Exception("Bad Base64 conversion to GUID", ex);
            }

            return guid;
        }
    }
}


