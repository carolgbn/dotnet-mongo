namespace dotnet_mongo_api.Data.Collections
{
    internal class GeoJson2DGeographicCoordinates
    {
        private double longitude;
        private double latitude;

        public GeoJson2DGeographicCoordinates(double longitude, double latitude)
        {
            this.longitude = longitude;
            this.latitude = latitude;
        }
    }
}