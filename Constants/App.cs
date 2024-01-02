namespace ParkEase.Constants
{
    public static class App
    {
        public const String APP_NAME = "Park Ease";

        public const String API_BASE_URL = "https://parkease.fied.tech";

        public const int DEFAULT_PAGINATION_LIMIT = 10;

        public const int DEFAULT_MAX_PAGINATION_LIMIT = 99;

        public static readonly String[] LIST_ROLE = { "admin", "karyawan" };

        public const int DEFAULT_ROLE_IDX = 1;

        public static readonly String[] LIST_STATUS = { "active", "banned" };

        public const int DEFAULT_STATUS_IDX = 0;
    }
}
