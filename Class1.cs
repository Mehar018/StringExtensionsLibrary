namespace StringExtensionsLibrary
{
    
    
        public static class StringExtensions // Top-level static class
        {
            public static bool StartsWithUpper(this string str)
            {
                if (string.IsNullOrEmpty(str))
                    return false;

                return char.IsUpper(str[0]);
            }
        }
    }




